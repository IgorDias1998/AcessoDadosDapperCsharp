using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Blog.Models;
using Blog.Repositories;

namespace Blog.Screens.RoleScreen
{
    public class ListRolesScreen
    {
        public static void Load()
        {
            Console.WriteLine("Lista de perfis");
            Console.WriteLine("----------------");
            List();
            Console.ReadKey();
            MenuRoleScreen.Load();
            
        }

        public static void List()
        {
            var repository = new Repository<Role>(Database.Connection);
            var roles = repository.Get();
            foreach (var item in roles)
                Console.WriteLine($"Id -> {item.Id} - {item.Name} - {item.Slug}");
        }
    }
}