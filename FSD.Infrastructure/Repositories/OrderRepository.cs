using FSD.Infrastructure.Context.Entities;
using FSD.Infrastructure.Context;
using FSD.Infrastructure.Interfaces;

namespace FSD.Infrastructure.Repositories
{
    public class OrderRepository : Repository<Order>, IOrderRepository
    {
        public OrderRepository(ApplicationDbContext context) : base(context)
        {
        }
    }
}

