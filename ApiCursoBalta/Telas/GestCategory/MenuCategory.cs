using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ApiCursoBalta.Telas.GestCategory
{
    public class MenuCategory
    {
        public static void Load()
        {
            Console.Clear();
            Console.WriteLine("Gestão de Categoria");
            Console.WriteLine("--------------");
            Console.WriteLine("O que deseja fazer?");
            Console.WriteLine();
            Console.WriteLine("1 - Listar Categoria");
            Console.WriteLine("2 - Cadastrar Categoria");
            Console.WriteLine("3 - Atualizar Categoria");
            Console.WriteLine("4 - Excluir Categoria");
            Console.WriteLine();
            Console.WriteLine();
            var option = short.Parse(Console.ReadLine());

            switch (option)
            {
                case 1:
                    ListCategory.Load();
                    break;
                case 2:
                    CreateCategoty.Load();
                    break;
                case 3:
                    UpdateCategory.Load();
                    break;
                case 4:
                    DeleteCategory.Load();
                    break;
                default: Load(); break;
            }
        }
    }
}
