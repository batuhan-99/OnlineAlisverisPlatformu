using OnlineAlisverisPlatformu.DataAccess.Contexts;
using OnlineAlisverisPlatformu.DataAccess.Interfaces.Repositories;
using OnlineAlisverisPlatformu.DataAccess.Repositories.Interfaces;
using System.Threading.Tasks;

namespace OnlineAlisverisPlatformu.DataAccess.Repositories
{
    public class UnitOfWork : IUnitOfWork
    {
        private readonly ApplicationDbContext _context;

        public IUserRepository Users { get; private set; }
        public IProductRepository Products { get; private set; }
        public IOrderRepository Orders { get; private set; }
        public IOrderProductRepository OrderProducts { get; private set; }

        public UnitOfWork(ApplicationDbContext context,
                          IUserRepository userRepository,
                          IProductRepository productRepository,
                          IOrderRepository orderRepository,
                          IOrderProductRepository orderProductRepository)
        {
            _context = context;
            Users = userRepository;
            Products = productRepository;
            Orders = orderRepository;
            OrderProducts = orderProductRepository;
        }

        public async Task<int> CompleteAsync()
        {
            return await _context.SaveChangesAsync(); // Değişiklikleri kaydeder
        }

        public void Dispose()
        {
            _context.Dispose();
        }
    }
}
