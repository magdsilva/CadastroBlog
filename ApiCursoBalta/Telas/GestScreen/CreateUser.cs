using System;
using ApiCursoBalta.Modelos;
using ApiCursoBalta.Repositorios;

namespace ApiCursoBalta.Telas.GestScreen
{
    public static class CreateUser
    {
        public static void Load()
        {
            Console.Clear();
            Console.WriteLine("Novo Usuário");
            Console.WriteLine("-------------");
            Console.Write("Nome: ");
            var name = Console.ReadLine();

            Console.Write("Email: ");
            var email = Console.ReadLine();

            Console.Write("Password: ");
            var password = Console.ReadLine();

            Console.Write("Bio: ");
            var bio = Console.ReadLine();

            Console.Write("Image: ");
            var image = Console.ReadLine();

            Console.Write("Slug: ");
            var slug = Console.ReadLine();

            Create(new User
            {
               Name = name,
               Email = email,
               PasswordHash = password,
               Bio = bio,
               Image = image,
               Slug = slug
            });
            Console.ReadKey();
            MenuUser.Load();
        }

public static void Create(User user)
{
    try
    {
        var repository = new Repository<User>(Database.Connection);
        repository.Create(user);
        Console.WriteLine("Tag cadastrada com sucesso!");
    }
    catch (Exception ex)
    {
        Console.WriteLine("Não foi possível salvar a tag");
        Console.WriteLine(ex.Message);
    }
}
    }
}