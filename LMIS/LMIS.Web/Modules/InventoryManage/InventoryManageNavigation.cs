using Serenity.Navigation;
using MyPages = LMIS.InventoryManage.Pages;

[assembly: NavigationMenu(4000, "InventoryManage", icon: "fa-database")]
[assembly: NavigationLink(4100, "InventoryManage/DownBookshelfs", typeof(MyPages.DownBookshelfsPage), icon: "fa-plus-square")]
[assembly: NavigationLink(4200, "InventoryManage/UpBookshelfs", typeof(MyPages.UpBookshelfsPage), icon: "fa-minus-square")]