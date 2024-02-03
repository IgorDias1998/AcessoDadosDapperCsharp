using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Blog.Models;
using Blog.Repositories;

namespace Blog.Screens.CategoryScreen
{
    public class ListCategoriesScreen
    {
        public static void Load()
        {
            Console.WriteLine("Lista de categorias");
            Console.WriteLine("----------------");
            List();
            Console.ReadKey();
            MenuCategoryScreen.Load();
        }

        public static void List()
        {
            var repository = new Repository<Category>(Database.Connection);
            var categories = repository.Get();
            foreach (var item in categories)
                Console.WriteLine($"Id: {item.Id} -> {item.Name} - {item.Slug}");
        }
    }
}