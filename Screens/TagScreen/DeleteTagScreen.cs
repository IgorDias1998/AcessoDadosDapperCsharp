using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Blog.Models;
using Blog.Repositories;

namespace Blog.Screens.TagScreen
{
    public class DeleteTagScreen
    {
        public static void Load() 
        {
            Console.WriteLine("Excluisão de Tags");
            Console.WriteLine("----------------");
            Console.WriteLine("Qual o ID da tag que deseja excluir: ");
            var id = Console.ReadLine();


            Delete(int.Parse(id));
            Console.ReadKey();
            MenuTagScreen.Load();
        }

        public static void Delete(int id)
        {
            try
            {
                var repository = new Repository<Tag>(Database.Connection);
                repository.Delete(id);
                Console.WriteLine("Tag excluída com sucesso");
            }
            catch (Exception ex)
            {
                Console.WriteLine("Não foi possível excluir a tag");
                Console.WriteLine(ex.Message);
            }
        }
    }
}