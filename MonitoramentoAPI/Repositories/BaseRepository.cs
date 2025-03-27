using Microsoft.EntityFrameworkCore;
using MonitoramentoAPI.Domain.Contracts.Data;
using MonitoramentoAPI.Infra.Contexts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MonitoramentoAPI.Infra.Repositories
{
    public class BaseRepository<Entity> : IBaseRepository<Entity>
        where Entity : class
    {
        private readonly SqlServerContext context;

        public BaseRepository(SqlServerContext context)
        {
            this.context = context;
        }

        public virtual void Delete(Entity entity)
        {
            context.Entry(entity).State = EntityState.Deleted;
            context.SaveChanges();
        }

        public virtual Entity Find(Func<Entity, bool> where)
        {
            return context.Set<Entity>().FirstOrDefault(where);
        }

        public virtual List<Entity> FindAll()
        {
            return context.Set<Entity>().ToList();
        }

        public virtual List<Entity> FindAll(Func<Entity, bool> where)
        {
            return context.Set<Entity>().Where(where).ToList();
            
        }

        public List<Entity> FindAll(int skip, int take)
        {
            return context.Set<Entity>()
                .Skip(skip)
                .Take(take)
                .ToList();
        }

        public List<Entity> FindAll(Func<Entity, bool> where, int skip, int take)
        {
            return context.Set<Entity>()
               .Where(where)
               .Skip(skip)
               .Take(take)
               .ToList();
        }

        public virtual Entity FindById(Guid id)
        {
            return context.Set<Entity>().Find(id);
        }

        public virtual void Insert(Entity entity)
        {
            context.Entry(entity).State = EntityState.Added;
            context.SaveChanges();
        }

        public virtual void Update(Entity entity)
        {
            context.Entry(entity).State = EntityState.Modified;
            context.SaveChanges();
        }
    }
}
