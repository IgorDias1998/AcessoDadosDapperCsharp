using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Blog.Screens.UserScreen
{
    public class MenuUserScreen
    {
        public static void Load()
        {
            Console.Clear();
            Console.WriteLine("Gestão de usuários");
            Console.WriteLine("-*-*-*-*-*-*-*-*");
            Console.WriteLine("O que deseja fazer?");
            Console.WriteLine();
            Console.WriteLine("1 - Listar usuários");
            Console.WriteLine("2 - Cadastrar usuário");
            Console.WriteLine("3 - Atualizar usuário");
            Console.WriteLine("4 - Delete usuário");
            Console.WriteLine();
            Console.WriteLine();
            var option = short.Parse(Console.ReadLine()!);

            switch (option)
            {
                case 1:
                    ListUsersScreen.Load();
                    break;
                case 2:
                    CreateUserScreen.Load();
                    break;
                case 3:
                    UpdateUserScreen.Load();
                    break;
                case 4:
                    DeleteUserScreen.Load();
                    break;
                    
                default: Load(); break;
            }
        }
    }
}