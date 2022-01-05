using ApiCursoBalta.Modelos;
using ApiCursoBalta.Repositorios;
using System;


namespace ApiCursoBalta.Telas.GestRole
{
    public static class DeleteRole
    {
        public static void Load()
        {
            Console.Clear();
            Console.WriteLine("Excluir uma perfil");
            Console.WriteLine("-------------");
            Console.Write("Qual o id do Perfil que deseja exluir? ");
            var id = Console.ReadLine();

            Delete(int.Parse(id));
            Console.ReadKey();
            MenuRole.Load();
        }

        public static void Delete(int id)
        {
            try
            {
                var repository = new Repository<Role>(Database.Connection);
                repository.Delete(id);
                Console.WriteLine("Perfil exluído com sucesso!");
            }
            catch (Exception ex)
            {
                Console.WriteLine("Não foi possível exluir o perfil");
                Console.WriteLine(ex.Message);
            }
        }
    }
}
