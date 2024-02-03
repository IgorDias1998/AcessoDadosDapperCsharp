using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Blog.Models;
using Blog.Repositories;

namespace Blog.Screens.CategoryScreen
{
    public class CreateCategoryScreen
    {
        public static void Load()
        {
            Console.WriteLine("Criação de categoria");
            Console.WriteLine("----------------");
            Console.WriteLine("Nome: ");
            var name = Console.ReadLine();
            Console.WriteLine("Slug: ");
            var slug = Console.ReadLine();

            Create(new Category
            {
                Name = name,
                Slug = slug
            });
            Console.ReadKey();
            MenuCategoryScreen.Load();
        }

        public static void Create(Category category)
        {
            try
            {
                var repository = new Repository<Category>(Database.Connection);
                repository.Create(category);
                Console.WriteLine("Categoria criado com sucesso");
            }
            catch (Exception ex)
            {
                Console.WriteLine("Não foi possível criar o categoria");
                Console.WriteLine(ex.Message);
            }
        }  
    }
}