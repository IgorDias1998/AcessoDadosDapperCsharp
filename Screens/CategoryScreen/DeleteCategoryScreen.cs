using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Blog.Models;
using Blog.Repositories;

namespace Blog.Screens.CategoryScreen
{
    public class DeleteCategoryScreen
    {
public static void Load()
        {
            Console.WriteLine("Deletar categoria");
            Console.WriteLine("----------------");
            Console.WriteLine("Id da categoria que deseja deletar: ");
            var id = int.Parse(Console.ReadLine());

            Delete(id);

            Console.ReadKey();
            MenuCategoryScreen.Load();
        }

        public static void Delete(int id)
        {
            try
            {
                var repository = new Repository<Category>(Database.Connection);
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