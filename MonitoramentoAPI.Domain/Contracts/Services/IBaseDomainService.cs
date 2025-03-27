using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MonitoramentoAPI.Domain.Contracts.Services
{
    public interface IBaseDomainService<Entity> where Entity : class
    {
        void Add(Entity entity);
        void Modify(Entity entity);
        void Remove(Entity entity);

        List<Entity> GetAll();
        List<Entity> GetAll(int skip, int take);

        Entity GetById(Guid id);
    }
}
