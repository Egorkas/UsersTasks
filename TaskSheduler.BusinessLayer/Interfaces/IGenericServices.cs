using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TaskSheduler.BusinessLayer.Interfaces
{
    public interface IGenericServices<TService> where TService : class
    {
        void Create(TService item);
        TService FindById(int id);
        IEnumerable<TService> GetAll();
        IEnumerable<TService> Get(Func<TService, bool> predicate);
        void Remove(TService item);
        void Update(TService item);
    }
}
