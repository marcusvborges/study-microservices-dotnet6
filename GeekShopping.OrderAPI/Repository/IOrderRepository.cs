using GeekShopping.PaymentAPI.Model;
using System.Threading.Tasks;

namespace GeekShopping.PaymentAPI.Repository
{
    public interface IOrderRepository
    {
        Task<bool> AddOrder(OrderHeader header);
        Task UpdateOrderPaymentStatus(long orderHeaderId, bool paid);
    }
}