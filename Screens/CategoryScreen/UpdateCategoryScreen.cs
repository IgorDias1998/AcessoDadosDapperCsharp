using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Blog.Models;
using Blog.Repositories;

namespace Blog.Screens.CategoryScreen
{
    public class UpdateCategoryScreen
    {
        public static void Load()
        {
            Console.WriteLine("Atualização de categoria");
            Console.WriteLine("----------------");
            Console.WriteLine("Id: ");
            var id = int.Parse(Console.ReadLine());
            Console.WriteLine("Nome: ");
            var name = Console.ReadLine();
            Console.WriteLine("Slug: ");
            var slug = Console.ReadLine();

            Update(new Category
            {
                Id = id,
                Name = name,
                Slug = slug
            });
            Console.ReadKey();
            MenuCategoryScreen.Load();
        }

        public static void Update(Category category)
        {
            try
            {
                var repository = new Repository<Category>(Database.Connection);
                repository.Update(category);
                Console.WriteLine("Categoria atualizado com sucesso");
            }
            catch (Exception ex)
            {
                Console.WriteLine("Não foi possível atualizar a categoria");
                Console.WriteLine(ex.Message);
            }
        }        
    }
}