using plannificationCours.back.core.impl;
using plannificationCours.back.data.enums;
using plannificationCours.back.data.repositories.impl;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace plannificationCours.back.data.repositories
{
    public class FabriqueRepositories
    {

        public static Database GetInstance(RepositoryName repositoryName)
        {
            switch (repositoryName)
            {
                case RepositoryName.UserRepository:
                    return UserRepository.GetInstance();
                    break;
                case RepositoryName.SalleRepository:
                    return SalleRepository.GetInstance();
                    break;


                default:
                    return UserRepository.GetInstance();


            }


        }

    }
}
