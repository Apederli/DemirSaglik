using System;
using DemirSaglik.Project.Entities;

namespace DemirSaglik.Project.Business.Abstract
{
    public interface IUserService
    {
        bool Login(User user);
    }
}
