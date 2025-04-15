using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MonitoramentoAPI.Domain.Contracts.Data
{
    public interface IBaseRepository<Entity> where Entity : class
    {
        void Insert(Entity entity);
        void Update(Entity entity);
        void Delete(Entity entity);

        List<Entity> FindAll();
        List<Entity> FindAll(int skip, int take);

        List<Entity> FindAll(Func<Entity, bool> where);
        List<Entity> FindAll(Func<Entity, bool> where, int skip, int take);

        Entity FindById(Guid id);
        Entity Find(Func<Entity, bool> where);
        void Dispose();
    }
}
