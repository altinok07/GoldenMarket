using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GoldenMarket.Core.Interface
{
    public interface IBaseInterface<T> where T: class
    {
        int Add(T entity);
        bool Update(T entity);
        bool Delete(T entity);
        T Get(int Id);
        IEnumerable<T> GetAll();
        IEnumerable<T> GetActive();
    }
}
