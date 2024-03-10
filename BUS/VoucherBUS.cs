using DAL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DTOO;
namespace BUSSS
{
    public class VoucherBUS
    {
        public static RestaurantManage restaurantManage = new RestaurantManage();
        private VoucherBUS() { }

        private static VoucherBUS _instance;

        public static VoucherBUS GetInstance()
        {
            if (_instance == null)
            {
                _instance = new VoucherBUS();
            }
            return _instance;
        }
        public int GetDiscountByCode(string code)
        {
            return VoucherDAL.GetInstance().SelectDiscountPercentByCode(code);
        }
    }
}
