using BookStore.Application.Contracts;
using BookStore.Context;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookStore.Infrastructure.Repositories
{
    public class Repository<T, TId> : IRepository<T, TId> where T : class
    {

        BookStoreContext _bookStoreContext;
        DbSet<T> DbSetEntity;


        public Repository(BookStoreContext bookStoreContext)
        {
            _bookStoreContext = bookStoreContext;
            DbSetEntity = _bookStoreContext.Set<T>();
        }




        public bool Create(T entity)
        {
            try
            {
                DbSetEntity.Add(entity);
                _bookStoreContext.SaveChanges();

                return true; 
            }
            catch (Exception ex)
            {
                return false; 
            }
        }

        public bool Delete(T entity)
        {
            try
            {
                DbSetEntity.Remove(entity);
                _bookStoreContext.SaveChanges();

                return true;
            }
            catch (Exception ex)
            {
                return false;
            }
        }

        public IQueryable<T> GetAll()
        {
            return DbSetEntity;
        }

        public T GetById(TId id)
        {
            return DbSetEntity.Find(id);
        }

        public int Save()
        {
            return _bookStoreContext.SaveChanges();
        }

        public bool Update(T entity)
        {
            try
            {
                DbSetEntity.Update(entity);
                _bookStoreContext.SaveChanges();

                return true;
            }
            catch (Exception ex)
            {
                return false;
            }
        }
    }
}
