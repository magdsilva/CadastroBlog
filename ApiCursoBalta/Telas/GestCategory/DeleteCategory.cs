using ApiCursoBalta.Modelos;
using ApiCursoBalta.Repositorios;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ApiCursoBalta.Telas.GestCategory
{
    public class DeleteCategory
    {
        public static void Load()
        {
            Console.Clear();
            Console.WriteLine("Excluir uma Categoria");
            Console.WriteLine("-------------");
            Console.Write("Qual o id da categoria que deseja exluir? ");
            var id = Console.ReadLine();

            Delete(int.Parse(id));
            Console.ReadKey();
            MenuCategory.Load();
        }

        public static void Delete(int id)
        {
            try
            {
                var repository = new Repository<Category>(Database.Connection);
                repository.Delete(id);
                Console.WriteLine("Categoria exluída com sucesso!");
            }
            catch (Exception ex)
            {
                Console.WriteLine("Não foi possível exluir a categoria");
                Console.WriteLine(ex.Message);
            }
        }
    }
}
