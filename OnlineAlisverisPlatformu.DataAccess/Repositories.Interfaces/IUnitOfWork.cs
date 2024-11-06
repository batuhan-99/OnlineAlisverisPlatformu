using OnlineAlisverisPlatformu.DataAccess.Interfaces.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OnlineAlisverisPlatformu.DataAccess.Repositories.Interfaces;


namespace OnlineAlisverisPlatformu.DataAccess.Repositories.Interfaces
{
    public interface IUnitOfWork : IDisposable
    {
        IUserRepository Users { get; }
        IProductRepository Products { get; }
        IOrderRepository Orders { get; }
        IOrderProductRepository OrderProducts { get; }

        Task<int> CompleteAsync(); 
    }
}
