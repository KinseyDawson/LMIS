using Serenity.Navigation;
using MyPages = LMIS.BookManage.Pages;
[assembly: NavigationMenu(3000, "BookManage", icon: "fa-bank")]
[assembly: NavigationLink(3100, "BookManage/Authors", typeof(MyPages.AuthorsPage), icon: "fa-pencil")]
[assembly: NavigationLink(3200, "BookManage/Books", typeof(MyPages.BooksPage), icon: "fa-book")]
[assembly: NavigationLink(3300, "BookManage/Bookshelfs", typeof(MyPages.BookshelfsPage), icon: "fa-list")]
[assembly: NavigationLink(3400, "BookManage/Categories", typeof(MyPages.CategoriesPage), icon: "fa-bars")]
[assembly: NavigationLink(3500, "BookManage/Publishers", typeof(MyPages.PublishersPage), icon: "fa-building")]