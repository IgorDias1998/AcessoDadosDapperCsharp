using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Blog.Screens.RoleScreen
{
    public class MenuRoleScreen
    {
        public static void Load()
        {
            Console.Clear();
            Console.WriteLine("Gestão de perfil");
            Console.WriteLine("-*-*-*-*-*-*-*-*");
            Console.WriteLine("O que deseja fazer?");
            Console.WriteLine();
            Console.WriteLine("1 - Listar perfil");
            Console.WriteLine("2 - Cadastrar perfil");
            Console.WriteLine("3 - Atualizar perfil");
            Console.WriteLine("4 - Deletar perfil");
            Console.WriteLine();
            Console.WriteLine();
            var option = short.Parse(Console.ReadLine()!);

            switch (option)
            {
                case 1:
                    ListRolesScreen.Load();
                    break;
                case 2:
                    CreateRoleScreen.Load();
                    break;
                case 3:
                    UpdateRoleScreen.Load();
                    break;
                case 4:
                    DeleteRoleScreen.Load();
                    break;
                    
                default: Load(); break;
            }
        }
    }
}