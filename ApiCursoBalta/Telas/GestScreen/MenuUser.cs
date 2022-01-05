using System;
using BApiCursoBalta.Telas.TagScreen;

namespace ApiCursoBalta.Telas.GestScreen
{
    public static class MenuUser
    {
        public static void Load()
        {
            Console.Clear();
            Console.WriteLine("Gestão de Usuários");
            Console.WriteLine("--------------");
            Console.WriteLine("O que deseja fazer?");
            Console.WriteLine();
            Console.WriteLine("1 - Listar Usuários");
            Console.WriteLine("2 - Cadastrar Usuários");
            Console.WriteLine("3 - Atualizar Usuários");
            Console.WriteLine("4 - Excluir Usuários");
            Console.WriteLine();
            Console.WriteLine();
            var option = short.Parse(Console.ReadLine());

            switch (option)
            {
                case 1:
                    ListUser.Load();
                    break;
                case 2:
                    CreateUser.Load();
                    break;
                case 3:
                    UpdateUser.Load();
                    break;
                case 4:
                    DeleteUser.Load();
                    break;
                default: Load(); break;
            }
        }
    }
}
