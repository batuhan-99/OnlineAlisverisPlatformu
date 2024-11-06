using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OnlineAlisverisPlatformu.DataAccess.Entities;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace OnlineAlisverisPlatformu.DataAccess.Repositories.Interfaces
{
    public interface IGenericRepository<T> where T : class
    {
        Task<T> GetByIdAsync(int id);
        Task<IEnumerable<T>> GetAllAsync();
        Task AddAsync(T entity);
        void Update(T entity);
        void Delete(T entity);
    }
}