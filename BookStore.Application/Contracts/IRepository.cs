using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookStore.Application.Contracts
{
  public interface IRepository<T,TId>
  {
    IQueryable<T> GetAll();
    T GetById(TId id);

    bool Create(T entity);
    bool Update(T entity);
    bool Delete(TId id);
    int Save();
  }
}
