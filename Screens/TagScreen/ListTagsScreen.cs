using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Blog.Models;
using Blog.Repositories;

namespace Blog.Screens.TagScreen
{
    public class ListTagsScreen
    {
        public static void Load() 
        {
            Console.WriteLine("Lista de Tags");
            Console.WriteLine("----------------");
            List();
            Console.ReadKey();
            MenuTagScreen.Load();
        }

        private static void List(){
            var repository = new Repository<Tag>(Database.Connection);
            var tags = repository.Get();
            foreach (var item in tags)
                Console.WriteLine($"{item.Id} - {item.Name} ({item.Slug})");         
        }
    }
}