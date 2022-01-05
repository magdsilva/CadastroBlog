using System.Collections.Generic;
using Dapper.Contrib.Extensions;

namespace ApiCursoBalta.Modelos
{
    [Table("[Post]")]
    public class Post
    {
        public int Id { get; set; }
        public string Name { get; set; }
    }
}
