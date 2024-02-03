using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Threading.Tasks;
using Blog.Models;
using Blog.Repositories;

namespace Blog.Screens.UserScreen
{
    public class UpdateUserScreen
    {
        public static void Load()
        {
            Console.WriteLine("Atualização de usuário");
            Console.WriteLine("----------------");
            Console.WriteLine("Id: ");
            var id = int.Parse(Console.ReadLine());
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

            Update(new User
            {
                Id = id,
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

        public static void Update(User user)
        {
            try
            {
                var repository = new Repository<User>(Database.Connection);
                repository.Update(user);
                Console.WriteLine("Usuário atualizado com sucesso");
            }
            catch (Exception ex)
            {
                Console.WriteLine("Não foi possível atualizar o usuário");
                Console.WriteLine(ex.Message);
            }
        }
    }
}