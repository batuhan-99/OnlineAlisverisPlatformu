using Microsoft.EntityFrameworkCore;
using OnlineAlisverisPlatformu.DataAccess.Contexts;
using OnlineAlisverisPlatformu.DataAccess.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OnlineAlisverisPlatformu.DataAccess.Interfaces.Repositories;

namespace OnlineAlisverisPlatformu.DataAccess.Repositories
{
    public class ProductRepository : GenericRepository<Product>, IProductRepository
    {
        public ProductRepository(ApplicationDbContext context) : base(context) { }

        
        public async Task<IEnumerable<Product>> GetProductsByPriceRangeAsync(decimal minPrice, decimal maxPrice)
        {
            return await _dbSet.Where(p => p.Price >= minPrice && p.Price <= maxPrice).ToListAsync();
        }

        
        public async Task<IEnumerable<Product>> GetAvailableStockProductsAsync()
        {
            return await _dbSet.Where(p => p.StockQuantity > 0).ToListAsync();
        }
    }

}
