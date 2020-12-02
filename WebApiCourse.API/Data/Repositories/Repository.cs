using System.Collections.Generic;
using System.Linq;
using Microsoft.EntityFrameworkCore;
using WebApiCourse.API.Data.Repositories;
using WebApiCourse.Domain.Models;

namespace WebApiCourse.API.Data
{
    public class Repository<T> : IRepository<T> where T : BaseEntity
    {
        protected readonly ApplicationContext _context;

        public Repository(ApplicationContext context)
        {
            _context = context;
        }

        public void Add(T entity)
        {
            _context.Add(entity);
        }

        public void Remove(T entity)
        {
            _context.Remove(entity);
        }

        public void Update(T entity)
        {
            _context.Update(entity);
        }

        public bool SaveChanges()
        {
            return _context.SaveChanges() > 0;
        }

        public virtual ICollection<T> ToList()
        {
            return _context.Set<T>().ToList();
        }

        public virtual T GetById(int id)
        {
            return _context.Set<T>().FirstOrDefault(x => x.Id == id);
        }
    }
}