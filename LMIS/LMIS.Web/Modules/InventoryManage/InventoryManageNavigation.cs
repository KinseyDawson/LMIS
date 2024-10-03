using Serenity.Navigation;
using MyPages = LMIS.InventoryManage.Pages;
[assembly: NavigationMenu(4000, "InventoryManage", icon: "fa-database")]
[assembly: NavigationLink(4100, "InventoryManage/UpBookshelf", typeof(MyPages.UpBookshelfPage), icon: "fa-plus-square")]
[assembly: NavigationLink(4200, "InventoryManage/DownBookshelf", typeof(MyPages.DownBookshelfPage), icon: "fa-minus-square")]
[assembly: NavigationLink(4300, "InventoryManage/BookStore", typeof(MyPages.BookStorePage), icon: "fa fa-tasks")]
