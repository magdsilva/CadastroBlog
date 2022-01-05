using ApiCursoBalta.Telas.TagScreen;
using ApiCursoBalta.Telas.GestScreen;
using Microsoft.Data.SqlClient;
using System;
using ApiCursoBalta.Telas.GestRole;
using ApiCursoBalta.Telas.GestCategory;

namespace ApiCursoBalta
{
    class Program
    {
        private const string CONNECTION_STRING = @"Server=localhost,1433;Database=blog;User ID=sa;Password=maGS0501;TrustServerCertificate=True";

        static void Main(string[] args)
        {
            Database.Connection = new SqlConnection(CONNECTION_STRING);
            Database.Connection.Open();

            Load();

            Console.ReadKey();
            Database.Connection.Close();
        }

        private static void Load()
        {
            Console.Clear();
            Console.WriteLine("Meu Blog");
            Console.WriteLine("-----------------");
            Console.WriteLine("O que deseja fazer?");
            Console.WriteLine();
            Console.WriteLine("1 - Gestão de usuário");
            Console.WriteLine("2 - Gestão de perfil");
            Console.WriteLine("3 - Gestão de categoria");
            Console.WriteLine("4 - Gestão de tag");
            Console.WriteLine();
            Console.WriteLine();
            var option = short.Parse(Console.ReadLine()!);

            switch (option)
            {
                case 1:MenuUser.Load(); break;
                case 2:MenuRole.Load(); break;
                case 3:MenuCategory.Load(); break;
                case 4:MenuTagScreen.Load();
                    break;
                default: Load(); break;
                
            }
        }
    }
}