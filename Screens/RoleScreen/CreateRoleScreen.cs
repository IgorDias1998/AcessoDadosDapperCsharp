using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Blog.Models;
using Blog.Repositories;

namespace Blog.Screens.RoleScreen
{
    public class CreateRoleScreen
    {
        public static void Load()
        {
            Console.WriteLine("Criação de perfil");
            Console.WriteLine("----------------");
            Console.WriteLine("Nome: ");
            var name = Console.ReadLine();
            Console.WriteLine("Slug: ");
            var slug = Console.ReadLine();

            Create(new Role
            {
                Name = name,
                Slug = slug
            });
            Console.ReadKey();
            MenuRoleScreen.Load();
            
        }

        public static void Create(Role role)
        {
            try
            {
                var repository = new Repository<Role>(Database.Connection);
                repository.Create(role);
                Console.WriteLine("Perfil criado com sucesso");
            }
            catch (Exception ex)
            {
                Console.WriteLine("Não foi possível criar o perfil");
                Console.WriteLine(ex.Message);
            }
        }
    }
}