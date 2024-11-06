using Microsoft.EntityFrameworkCore;
using OnlineAlisverisPlatformu.DataAccess.Contexts;
using OnlineAlisverisPlatformu.DataAccess.Entities;
using OnlineAlisverisPlatformu.DataAccess.Interfaces.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Threading.Tasks;

namespace OnlineAlisverisPlatformu.DataAccess.Repositories
{
    public class OrderProductRepository : GenericRepository<OrderProduct>, IOrderProductRepository
    {
        public OrderProductRepository(ApplicationDbContext context) : base(context)
        {
        }

        
        public async Task<IEnumerable<OrderProduct>> FindAsync(Expression<Func<OrderProduct, bool>> predicate)
        {
            return await _dbSet.Where(predicate).ToListAsync();
        }

       
    }
}
