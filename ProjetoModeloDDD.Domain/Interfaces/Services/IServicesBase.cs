using System.Collections.Generic;

namespace ProjetoModeloDDD.Domain.Interfaces.Services
{
    public interface IServicesBase<TEntity> where TEntity:class
    {
        void Add(TEntity obj);

        TEntity GetById(int id);

        IEnumerable<TEntity> GetAll();

        void Uppdate(TEntity obj);

        void Remove(TEntity obj);

        void Dispose();

    }
}
