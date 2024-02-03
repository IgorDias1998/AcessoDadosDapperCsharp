using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Blog.Models;
using Blog.Repositories;

namespace Blog.Screens.UserScreen
{
    public class DeleteUserScreen
    {
        public static void Load()
        {
            Console.WriteLine("Atualização de usuário");
            Console.WriteLine("----------------");
            Console.WriteLine("Id do usuário que deseja deletar: ");
            var id = int.Parse(Console.ReadLine());

            Delete(id);

            Console.ReadKey();
            MenuUserScreen.Load();
        }

        public static void Delete(int id)
        {
            try
            {
                var repository = new Repository<User>(Database.Connection);
                repository.Delete(id);
                Console.WriteLine("Usuário deletado com sucesso");
            }
            catch (Exception ex)
            {
                Console.WriteLine("Não foi possível deletar o usuário");
                Console.WriteLine(ex.Message);
            }
        }
    }
}