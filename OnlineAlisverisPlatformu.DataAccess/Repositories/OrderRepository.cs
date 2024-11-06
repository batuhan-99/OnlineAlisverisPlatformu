using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using OnlineAlisverisPlatformu.DataAccess.Contexts;
using OnlineAlisverisPlatformu.DataAccess.Entities;
using OnlineAlisverisPlatformu.DataAccess.Interfaces.Repositories;

namespace OnlineAlisverisPlatformu.DataAccess.Repositories
{
    public class OrderRepository : GenericRepository<Order>, IOrderRepository
    {
        public OrderRepository(ApplicationDbContext context) : base(context)
        {
        }

        
    }
}
