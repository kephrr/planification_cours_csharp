using plannificationCours.back.data.repositories;
using plannificationCours.back.services.impl;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace plannificationCours.back.services
{
    public class FabriqueServices
    {

        public static IUserService GetUserService(IUserRepository repository)
        {
            return UserService.getInstance(repository);
        }
        public static ISalleServices GetSalleServices(ISalleRepository repository)
        {
            return SalleService.GetInstance(repository);
        }
    }
}
