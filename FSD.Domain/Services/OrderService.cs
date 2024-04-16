using AutoMapper;
using FSD.Domain;
using FSD.Domain.Dtos;
using FSD.Domain.Interfaces;
using FSD.Infrastructure.Context.Entities;
using FSD.Infrastructure.Interfaces;

namespace FSD.Domain.Services
{
    public class OrderService : IOrderService
    {
        private readonly IMapper _mapper;
        private readonly IOrderRepository _OrderRepository;

        public OrderService(IMapper mapper, IOrderRepository OrderRepository)
        {
            _mapper = mapper;
            _OrderRepository = OrderRepository;
        }

        public async Task<IEnumerable<OrderDto>> GetAllOrdersAsync()
        {
            var result = await _OrderRepository.GetAllAsync();
            return _mapper.Map<IEnumerable<OrderDto>>(result);
        }

        public async Task<OrderDto?> GetOrderByIdAsync(int id)
        {
            var result = await _OrderRepository.GetByIdAsync(id);
            return _mapper.Map<OrderDto>(result);
        }

        public async Task<bool> CreateOrderAsync(OrderDto Order)
        {
            var OrderEntity = _mapper.Map<Order>(Order);

            var result = await _OrderRepository.InsertAsync(OrderEntity);

            return result;
        }

        public async Task<bool> UpdateOrderAsync(OrderDto Order)
        {
            var OrderMap = _mapper.Map<Order>(Order);

            var result = await _OrderRepository.UpdateAsync(OrderMap);

            return result;
        }

        public async Task<bool> DeleteOrderAsync(int id)
        {
            var Order = await _OrderRepository.GetByIdAsync(id);

            if (Order is null)
                return false;
            
            var result = await _OrderRepository.DeleteAsync(Order);

            return result;
        }
    }
}

