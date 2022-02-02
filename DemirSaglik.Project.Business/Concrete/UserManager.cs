using System;
using DemirSaglik.Project.Business.Abstract;
using DemirSaglik.Project.Entities;

namespace DemirSaglik.Project.Business.Concrete
{
    public class UserManager:IUserService
    {
        public UserManager()
        {
        }

        User user = new User();

        public bool Login(User loginUser)
        {
            if (user.Name.Equals(loginUser.Name) && user.Password.Equals(loginUser.Password))
            {
                return true;
            }

            return false;
        }
    }
}
