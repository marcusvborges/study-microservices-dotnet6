using GeekShopping.CouponAPI.Data.ValueObject;
using System.Threading.Tasks;

namespace GeekShopping.Web.Repository
{
    public interface ICouponRepository
    {
        Task<CouponVO> GetCouponByCouponCode(string couponCode);
    }
}
