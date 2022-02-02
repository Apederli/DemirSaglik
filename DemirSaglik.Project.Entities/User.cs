using System;
namespace DemirSaglik.Project.Entities
{
    public class User
    {
        public string Name { get; set; }

        public string Password { get; set; }

        public User()
        {
            Name = "demir@yahoo.com";
            Password = "1234";
        }
    }
}
