using Yitter.IdGenerator;

namespace LMIS;

public static class SerialNumberHelper
{
    private static object lockObj;
    static SerialNumberHelper()
    {
        lockObj = new object();
        var options = new IdGeneratorOptions()
        {
            WorkerIdBitLength = 10,
            SeqBitLength = 6,
        };
        YitIdHelper.SetIdGenerator(options);
    }
    public static string GenerateWithYitter()
    {
        lock (lockObj)
        {
            return YitIdHelper.NextId().ToString();
        }
    }
}