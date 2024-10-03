using Serenity.Navigation;
using MyPages = LMIS.BookManage.Pages;
[assembly: NavigationMenu(3000, "BookManage", icon: "fa-bank")]
[assembly: NavigationLink(3100, "BookManage/Author", typeof(MyPages.AuthorPage), icon: "fa-pencil")]
[assembly: NavigationLink(3200, "BookManage/Book", typeof(MyPages.BookPage), icon: "fa-book")]
[assembly: NavigationLink(3300, "BookManage/Bookshelf", typeof(MyPages.BookshelfPage), icon: "fa-list")]
[assembly: NavigationLink(3400, "BookManage/Category", typeof(MyPages.CategoryPage), icon: "fa-bars")]
[assembly: NavigationLink(3500, "BookManage/Publisher", typeof(MyPages.PublisherPage), icon: "fa-building")]