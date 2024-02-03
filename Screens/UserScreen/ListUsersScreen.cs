using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Blog.Models;
using Blog.Repositories;

namespace Blog.Screens.UserScreen
{
    public class ListUsersScreen
    {
        public static void Load()
        {
            Console.WriteLine("Lista de usuários");
            Console.WriteLine("----------------");
            List();
            Console.ReadKey();
            MenuUserScreen.Load();
        }

        public static void List()
        {
            var repository = new Repository<User>(Database.Connection);
            var users = repository.Get();
            foreach (var user in users)
                Console.WriteLine($"Id: {user.Id} -> {user.Name} - {user.Email} - {user.Image} - {user.Bio} - {user.Slug}");
        }
    }
}