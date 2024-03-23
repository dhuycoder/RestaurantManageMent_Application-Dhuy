using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using DTOO;
namespace DAL
{
    public class VoucherDAL
    {
        RestaurantManage restaurantManage = new RestaurantManage();
        private VoucherDAL() { }

        private static VoucherDAL _instance;

        public static VoucherDAL GetInstance()
        {

            if (_instance == null)
            {
                _instance = new VoucherDAL();
            }
            return _instance;

        }
        public decimal SelectDiscountPercentByCode(string code)
        {
            var discount = (from v in restaurantManage.vouchers
                            where v.Code == code
                            select v.Discount).FirstOrDefault();
            return discount;
        }
        public DateTime SelectDateTimeByCode(string code)
        {
            var discount = (from v in restaurantManage.vouchers
                            where v.Code == code
                            select v.Due).FirstOrDefault();
            return discount;
        }
        public Voucher SelectVoucherByCode(string code)
        {
            var discount = (from v in restaurantManage.vouchers
                            where v.Code == code
                            select v).FirstOrDefault();
            return discount;
        }
    }
}
