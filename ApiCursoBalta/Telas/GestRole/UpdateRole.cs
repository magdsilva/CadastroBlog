using System;
using ApiCursoBalta.Modelos;
using ApiCursoBalta.Repositorios;

namespace ApiCursoBalta.Telas.GestRole
{
    public static class UpdateRole
    {
        public static void Load()
        {
            Console.Clear();
            Console.WriteLine("Atualizando um Perfil");
            Console.WriteLine("-------------");
            Console.Write("Id: ");
            var id = Console.ReadLine();

            Console.Write("Nome: ");
            var name = Console.ReadLine();

            Console.Write("Slug: ");
            var slug = Console.ReadLine();

            Update(new Role
            {
                Id = int.Parse(id),
                Name = name,
                Slug = slug
            });
            Console.ReadKey();
            MenuRole.Load();
        }

        public static void Update(Role role)
        {
            try
            {
                var repository = new Repository<Role>(Database.Connection);
                repository.Update(role);
                Console.WriteLine("Perfil atualizado com sucesso!");
            }
            catch (Exception ex)
            {
                Console.WriteLine("Não foi possível atualizar o Perfil");
                Console.WriteLine(ex.Message);
            }
        }
    }
}