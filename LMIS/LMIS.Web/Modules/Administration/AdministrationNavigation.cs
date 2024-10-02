using Serenity.Navigation;
using Administration = LMIS.Administration.Pages;

[assembly: NavigationMenu(2000, "Administration", icon: "fa-wrench")]
//[assembly: NavigationLink(1100, "Administration/Languages", typeof(Administration.LanguagePage), icon: "fa-comments")]
//[assembly: NavigationLink(1200, "Administration/Translations", typeof(Administration.TranslationPage), icon: "fa-comment-o")]
[assembly: NavigationLink(2300, "Administration/Roles", typeof(Administration.RolePage), icon: "fa-lock")]
[assembly: NavigationLink(3400, "Administration/User Management", typeof(Administration.UserPage), icon: "fa-users")]