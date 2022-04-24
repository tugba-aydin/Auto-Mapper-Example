using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Linq;

namespace AutoMapperExample.Data
{
    public class Repository<T> : IRepository<T> where T : class
    {
        private readonly ProductDbContext dbContext;
        private readonly DbSet<T> table;
        public Repository(ProductDbContext _dbContext)
        {
            dbContext = _dbContext;
            table = dbContext.Set<T>();
        }
        public void Add(T entity)
        {
            table.Add(entity);
        }

        public void Delete(int id)
        {
            var entity = table.Find(id);
            table.Remove(entity);
        }

        public List<T> GetAll()
        {
            return table.ToList();
        }

        public T GetById(int id)
        {
            var entity = table.Find(id);
            return entity;
        }

        public void SaveAll()
        {
            dbContext.SaveChanges();
        }

        public void Update(T entity)
        {
            table.Attach(entity);
            dbContext.Entry(entity).State = EntityState.Modified;
        }
    }
}
