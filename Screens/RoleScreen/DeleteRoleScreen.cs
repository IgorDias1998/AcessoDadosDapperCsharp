using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Blog.Models;
using Blog.Repositories;

namespace Blog.Screens.RoleScreen
{
    public class DeleteRoleScreen
    {
        public static void Load()
        {
            Console.WriteLine("Deletar perfil");
            Console.WriteLine("----------------");
            Console.WriteLine("Id do perfil que deseja deletar: ");
            var id = int.Parse(Console.ReadLine());

            Delete(id);

            Console.ReadKey();
            MenuRoleScreen.Load();
        }

        public static void Delete(int id)
        {
            try
            {
                var repository = new Repository<Role>(Database.Connection);
                repository.Delete(id);
                Console.WriteLine("Perfil deletado com sucesso");
            }
            catch (Exception ex)
            {
                Console.WriteLine("Não foi possível deletar o perfil");
                Console.WriteLine(ex.Message);
            }
        }
    }
}