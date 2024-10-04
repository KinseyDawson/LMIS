using Serenity.Navigation;
using MyPages = LMIS.ReaderManage.Pages;

[assembly: NavigationMenu(5000, "ReaderManage", icon: "fa-exchange")]
[assembly: NavigationLink(5100, "ReaderManage/CardLevel", typeof(MyPages.CardLevelPage), icon: "fa-level-up")]
[assembly: NavigationLink(5200, "ReaderManage/LibraryCard", typeof(MyPages.LibraryCardPage), icon: "fa-address-card")]
[assembly: NavigationLink(5300, "ReaderManage/UserBill", typeof(MyPages.UserBillPage), icon: "fa fa-money")]