using System.ComponentModel;
using System.Reflection;

namespace LMIS;
public static class EnumHelper
{
    /// <summary>
    /// 枚举值=>描述 Dictionary缓存
    /// </summary>
    private static readonly BlockingDictionary<Type, Dictionary<int, string>> ValueDescriptionDictionaryCache = new BlockingDictionary<Type, Dictionary<int, string>>(8);

    /// <summary>
    /// 描述=>枚举 Dictionary缓存
    /// </summary>
    private static readonly BlockingDictionary<Type, Dictionary<string, int>> DescriptionValueDictionaryCache = new BlockingDictionary<Type, Dictionary<string, int>>(8);

    /// <summary>
    /// 获取枚举类型的 枚举值=>描述
    /// </summary>
    /// <param name="enumType"></param>
    /// <returns></returns>
    private static Dictionary<int, string> GetValueDescriptionDictionary(Type enumType)
    {
        var dic = ValueDescriptionDictionaryCache.GetOrAdd(enumType, (key) =>
        {
            var enumValues = Enum.GetValues(enumType);
            var dictionary = new Dictionary<int, string>(enumValues.Length);
            foreach (var item in enumValues)
            {
                var description = item.ToString();
                object[] objArr = item.GetType().GetField(item.ToString() ?? string.Empty)?.GetCustomAttributes(typeof(DescriptionAttribute), true);
                if (objArr != null && objArr.Length > 0)
                {
                    DescriptionAttribute da = objArr[0] as DescriptionAttribute;
                    description = da == null ? description : da.Description;
                }
                dictionary.Add(item.GetHashCode(), description);
            }
            return dictionary;
        });

        return dic;
    }

    /// <summary>
    /// 获取枚举类型的 枚举值=>描述
    /// </summary>
    /// <returns></returns>
    public static Dictionary<int, string> GetValueDescriptionDictionary<T>() =>
        GetValueDescriptionDictionary(typeof(T));

    /// <summary>
    /// 获取枚举类型的 描述=> 枚举值 
    /// </summary>
    /// <param name="enumType">枚举类型</param>
    /// <returns></returns>
    private static Dictionary<string, int> GetDescriptionValueDictionary(Type enumType)
    {
        var dic = DescriptionValueDictionaryCache.GetOrAdd(enumType, (type) =>
        {
            var valueDescriptionDic = GetValueDescriptionDictionary(type);
            var descriptionValueDic = new Dictionary<string, int>(valueDescriptionDic.Count);

            foreach (var (key, value) in valueDescriptionDic)
            {
                descriptionValueDic.Add(value, key);
            }

            return descriptionValueDic;
        });
        return dic;
    }

    /// <summary>
    /// 获取枚举类型的 描述字典 => 枚举值 
    /// </summary>
    /// <returns></returns>
    public static Dictionary<string, int> GetDescriptionValueDictionary<T>() =>
        GetDescriptionValueDictionary(typeof(T));

    ///  <summary>
    /// 根据值，获取枚举描述
    ///  </summary>
    ///  <typeparam name="T">枚举类型</typeparam>
    ///  <param name="value">枚举的值</param>
    ///  <param name="defaultDescription">默认描述</param>
    ///  <returns></returns>
    public static string GetEnumDescriptionByValue<T>(int value, string defaultDescription = null)
    {
        var dic = GetValueDescriptionDictionary(typeof(T));

        return dic.TryGetValue(value, out var description) ? description : defaultDescription;
    }

    ///  <summary>
    /// 根据枚举描述，获取值
    ///  </summary>
    ///  <typeparam name="T">枚举类型</typeparam>
    ///  <param name="description"></param>
    ///  <param name="defaultValue">未获取到返回的默认值</param>
    ///  <returns></returns>
    public static int GetEnumValueByDescription<T>(string description, int defaultValue = 0)
    {
        var dic = GetDescriptionValueDictionary(typeof(T));

        return dic.TryGetValue(description, out var value) ? value : defaultValue;
    }

    /// <summary>
    /// 扩展方法，获得枚举的Description
    /// </summary>
    /// <param name="value">枚举值</param>
    /// <param name="nameInstend">当枚举没有定义DescriptionAttribute,是否用枚举名代替，默认使用</param>
    /// <returns>枚举的Description</returns>
    public static string GetDescription(this Enum value, bool nameInstend = true)
    {
        var type = value.GetType();
        var dic = GetValueDescriptionDictionary(type);

        if (dic.TryGetValue(value.GetHashCode(), out var description))
        {
            return description;
        }
        return nameInstend ? Enum.GetName(type, value) : null;
    }

    /// <summary>
    /// 获取枚举int类型的值
    /// </summary>
    /// <param name="e"></param>
    /// <returns></returns>
    public static int GetEnumIntegerValue(Enum e)
    {
        try
        {
            return Convert.ToInt32(e.ToString("D"));
        }
        catch (Exception)
        {
            // ignored
        }

        return -1;
    }

    /// <summary>
    /// 获取对应程序集的所有Enum Types
    /// </summary>
    /// <param name="assemblyNameStr"></param>
    /// <returns></returns>
    public static Dictionary<string, Type> ResolveAssemblyAllEnumTypes(string assemblyNameStr)
    {
        var assemblyName = new AssemblyName(assemblyNameStr);
        var assembly = Assembly.Load(assemblyName);
        var types = assembly.GetTypes().Where(type => type.IsEnum).ToList();
        var dic = new Dictionary<string, Type>(types.Count);
        foreach (var type in types)
        {
            dic.Add(type.Name, type);
        }
        return dic;
    }
}

