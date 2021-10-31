using Milestone.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Milestone.Service
{
    public interface IDataService
    {
        bool findUser(UserModel user);
        bool createUser(UserModel user);
    }
}
