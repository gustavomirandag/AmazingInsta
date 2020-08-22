using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace AmazingInsta.Common.Domain
{
    public interface IRepository<TKey,TEntity>
    {
        void Create(TEntity entity);
        TEntity Read(TKey id);
        IEnumerable<TEntity> ReadAll();
        void Update(TEntity entity);
        void Delete(TKey id);
        int SaveChange();
        Task<int> SaveChanesAsync();
    }
}
