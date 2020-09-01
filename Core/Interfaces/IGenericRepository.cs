using System;
using System.Collections.Generic;
using System.Text;

namespace Core.Interfaces
{
    public interface IGenericRepository<T> where T : class
    {
        //This Method will return all..
        public IEnumerable<T> GetAll();

        //This Method will return specific item..
        public T GetById(object id);

        public void Insert(T entity);
        public void Update(T entity);
        public void Delete(object id);
    }




}
