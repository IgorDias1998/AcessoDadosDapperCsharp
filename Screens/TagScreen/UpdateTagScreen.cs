using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Blog.Models;
using Blog.Repositories;

namespace Blog.Screens.TagScreen
{
    public class UpdateTagScreen
    {
        public static void Load() 
        {
            Console.WriteLine("Atualização de Tags");
            Console.WriteLine("----------------");
            Console.WriteLine("Id: ");
            var id = Console.ReadLine();
            Console.WriteLine("Nome: ");
            var name = Console.ReadLine();
            Console.WriteLine("Slug: ");
            var slug = Console.ReadLine();

            Update(new Tag
            {
                Id = int.Parse(id),
                Name = name,
                Slug = slug
            });
            Console.ReadKey();
            MenuTagScreen.Load();
        }

        public static void Update(Tag tag)
        {
            try
            {
                var repository = new Repository<Tag>(Database.Connection);
                repository.Update(tag);
                Console.WriteLine("Tag atualizada com sucesso");
            }
            catch (Exception ex)
            {
                Console.WriteLine("Não foi possível atualizar a tag");
                Console.WriteLine(ex.Message);
            }
        }
    }
}