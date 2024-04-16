using FSD.Domain.Dtos;

namespace FSD.Domain.Interfaces
{
    public interface IOrderService
    {
        Task<IEnumerable<OrderDto>> GetAllOrdersAsync();
        Task<OrderDto?> GetOrderByIdAsync(int id);
        Task<bool> CreateOrderAsync(OrderDto Order);
        Task<bool> UpdateOrderAsync(OrderDto Order);
        Task<bool> DeleteOrderAsync(int id);
    }
}
