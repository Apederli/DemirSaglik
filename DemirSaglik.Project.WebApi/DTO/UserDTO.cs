using System;
using DemirSaglik.Project.Entities;

namespace DemirSaglik.Project.WebApi.DTO
{
    public class UserDTO
    {
        public string Name { get; set; }

        public string Password { get; set; }

        public UserDTO()
        {
        }
    }
}
