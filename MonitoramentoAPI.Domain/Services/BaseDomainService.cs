using MonitoramentoAPI.Domain.Contracts.Data;
using MonitoramentoAPI.Domain.Contracts.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MonitoramentoAPI.Domain.Services
{
    public abstract class BaseDomainService<Entity> : IBaseDomainService<Entity>
        where Entity : class
    {
        //atributo 
        private readonly IBaseRepository<Entity> repository;

        protected BaseDomainService(IBaseRepository<Entity> repository)
        {
            this.repository = repository;
        }

        public virtual void Add(Entity entity)
        {
            repository.Insert(entity);
        }

        public virtual List<Entity> GetAll()
        {
            return repository.FindAll();
        }

        public List<Entity> GetAll(int skip, int take)
        {
            return repository.FindAll(skip, take);
        }

        public virtual Entity GetById(Guid id)
        {
            return repository.FindById(id);
        }

        public virtual void Modify(Entity entity)
        {
            repository.Update(entity);
        }

        public virtual void Remove(Entity entity)
        {
            repository.Delete(entity);
        }

        //public virtual void Dispose()
        //{
        //    repository.Dispose();
        //}
    }
}
