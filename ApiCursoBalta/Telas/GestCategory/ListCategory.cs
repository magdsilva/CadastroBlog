using ApiCursoBalta.Modelos;
using ApiCursoBalta.Repositorios;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ApiCursoBalta.Telas.GestCategory
{
    public class ListCategory
    {
        public static void Load()
        {
            Console.Clear();
            Console.WriteLine("Lista de Ctaegorias");
            Console.WriteLine("-------------");
            List();
            Console.ReadKey();
            MenuCategory.Load();
        }

        private static void List()
        {
            var repository = new Repository<Category>(Database.Connection);
            var category = repository.Get();
            foreach (var item in category)
                Console.WriteLine($"{item.Id} - {item.Name} - {item.Slug}");
        }
    }
}
