using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Blog.Models;
using Blog.Repositories;

namespace Blog.Screens.UserScreen
{
    public class CreateUserScreen
    {
        public static void Load()
        {
            Console.WriteLine("Criação de usuário");
            Console.WriteLine("----------------");
            Console.WriteLine("Nome: ");
            var name = Console.ReadLine();
            Console.WriteLine("Email: ");
            var email = Console.ReadLine();
            Console.WriteLine("PasswordHASH: ");
            var passwordHash = Console.ReadLine();
            Console.WriteLine("Bio: ");
            var bio = Console.ReadLine();
            Console.WriteLine("Imagem: ");
            var image = Console.ReadLine();
            Console.WriteLine("Slug: ");
            var slug = Console.ReadLine();

            Create(new User
            {
                Name = name,
                Email = email,
                PasswordHash = passwordHash,
                Bio = bio,
                Image = image,
                Slug = slug
            });
            Console.ReadKey();
            MenuUserScreen.Load();
        }

        public static void Create(User user)
        {
            try
            {
                var repository = new Repository<User>(Database.Connection);
                repository.Create(user);
                Console.WriteLine("Usuário criado com sucesso");
            }
            catch (Exception ex)
            {
                Console.WriteLine("Não foi possível criar o usuário");
                Console.WriteLine(ex.Message);
            }
        }
    }
}