using System;
using ApiCursoBalta.Modelos;
using ApiCursoBalta.Repositorios;

namespace ApiCursoBalta.Telas.GestScreen
{
    public static class ListUser
    {
        public static void Load()
        {
            Console.Clear();
            Console.WriteLine("Lista de Usuários");
            Console.WriteLine("-------------");
            List();
            Console.ReadKey();
            MenuUser.Load();
        }

        private static void List()
        {
            var repository = new Repository<User>(Database.Connection);
            var users = repository.Get();
            foreach (var item in users)
                Console.WriteLine($"{item.Id} - {item.Name} ({item.Email} = {item.Slug})");
        }
    }
}