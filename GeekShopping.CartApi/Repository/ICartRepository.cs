using GeekShopping.CartAPI.Data.ValueObject;
using System.Threading.Tasks;

namespace GeekShopping.CartAPI.Repository
{
    public interface ICartRepository
    {
        Task<CartVO> FindCartByUserId(string userid);
        Task<CartVO> SaveOrUpdateCart(CartVO cart);
        Task<bool> RemoveFromCart(long cartDetailsId);
        Task<bool> ApplyCoupom(string userId, string couponCode);
        Task<bool> RemoveCoupom(string userId);
        Task<bool> ClearCart(string userId);

    }
}
