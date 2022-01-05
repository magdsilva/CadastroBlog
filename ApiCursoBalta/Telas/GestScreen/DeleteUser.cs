using System;
using ApiCursoBalta.Modelos;
using ApiCursoBalta.Repositorios;

namespace ApiCursoBalta.Telas.GestScreen
{
    public static class DeleteUser
    {
        public static void Load()
        {
            Console.Clear();
            Console.WriteLine("Excluir uma Usuário");
            Console.WriteLine("-------------");
            Console.Write("Qual o id da Tag que deseja exluir? ");
            var id = Console.ReadLine();

            Delete(int.Parse(id));
            Console.ReadKey();
            MenuUser.Load();
        }

        public static void Delete(int id)
        {
            try
            {
                var repository = new Repository<User>(Database.Connection);
                repository.Delete(id);
                Console.WriteLine("Usuário exluída com sucesso!");
            }
            catch (Exception ex)
            {
                Console.WriteLine("Não foi possível exluir a tag");
                Console.WriteLine(ex.Message);
            }
        }
    }
}