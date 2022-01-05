using System;

namespace ApiCursoBalta.Telas.GestRole
{
    public static class MenuRole
    {
        public static void Load()
        {
            Console.Clear();
            Console.WriteLine("Gestão de Perfil");
            Console.WriteLine("--------------");
            Console.WriteLine("O que deseja fazer?");
            Console.WriteLine();
            Console.WriteLine("1 - Listar Perfil");
            Console.WriteLine("2 - Cadastrar Perfil");
            Console.WriteLine("3 - Atualizar Perfil");
            Console.WriteLine("4 - Excluir Perfil");
            Console.WriteLine();
            Console.WriteLine();
            var option = short.Parse(Console.ReadLine());

            switch (option)
            {
                case 1:
                    ListRole.Load();
                    break;
                case 2:
                    CreateRole.Load();
                    break;
                case 3:
                    UpdateRole.Load();
                    break;
                case 4:
                    DeleteRole.Load();
                    break;
                default: Load(); break;
            }
        }
    }
}
