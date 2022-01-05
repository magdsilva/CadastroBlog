using ApiCursoBalta.Modelos;
using ApiCursoBalta.Repositorios;
using System;


namespace ApiCursoBalta.Telas.GestRole
{
    public static class ListRole
    {
        public static void Load()
        {
            Console.Clear();
            Console.WriteLine("Lista de Perfil");
            Console.WriteLine("-------------");
            List();
            Console.ReadKey();
            MenuRole.Load();
        }

        private static void List()
        {
            var repository = new Repository<Role>(Database.Connection);
            var roles = repository.Get();
            foreach (var item in roles)
                Console.WriteLine($"{item.Id} - {item.Name} - {item.Slug}");
        }
    }
}
