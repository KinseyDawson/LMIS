using Serenity.Navigation;
using MyPages = LMIS.ReaderManage.Pages;


[assembly: NavigationMenu(5000, "ReaderManage", icon: "fa-exchange")]
[assembly: NavigationLink(5100, "ReaderManage/CardLevels", typeof(MyPages.CardLevelsPage), icon: "fa-level-up")]
[assembly: NavigationLink(5200, "ReaderManage/LibraryCardLose", typeof(MyPages.LibraryCardLosePage), icon: "fa-bookmark")]
[assembly: NavigationLink(5300, "ReaderManage/LibraryCards", typeof(MyPages.LibraryCardsPage), icon: "fa-address-card")]