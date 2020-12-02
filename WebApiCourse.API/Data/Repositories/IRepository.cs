using System.Collections.Generic;
using WebApiCourse.Domain.Models;

namespace WebApiCourse.API.Data.Repositories
{
    public interface IRepository<T> where T : BaseEntity
    {
        ICollection<T> ToList();
        T GetById(int id);
        void Add(T entity);
        void Remove(T entity);
        void Update(T entity);
        bool SaveChanges();
    }
}