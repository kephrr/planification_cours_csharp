using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace plannificationCours.back.core
{
    public interface IRepository<T>
    {
        T FindById(int id);

        int Add(T entity);

        int Update(T entity);

        int Delete(int id);

    }
}
