using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Blog.Models;
using Blog.Repositories;

namespace Blog.Screens.TagScreen
{
    public class CreateTagScreen
    {
        public static void Load() 
        {
            Console.WriteLine("Criação de Tags");
            Console.WriteLine("----------------");
            Console.WriteLine("Nome: ");
            var name = Console.ReadLine();
            Console.WriteLine("Slug: ");
            var slug = Console.ReadLine();

            Create(new Tag
            {
                Name = name,
                Slug = slug
            });
            Console.ReadKey();
            MenuTagScreen.Load();
        }

        public static void Create(Tag tag)
        {
            try
            {
                var repository = new Repository<Tag>(Database.Connection);
                repository.Create(tag);
                Console.WriteLine("Tag cadastrada com sucesso");
            }
            catch (Exception ex)
            {
                Console.WriteLine("Não foi possível cadastrar a tag");
                Console.WriteLine(ex.Message);
            }
        }
    }
}