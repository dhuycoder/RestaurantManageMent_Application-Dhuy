using DTOO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class BillDAL
    {
        
        private static BillDAL _instance;
        private BillDAL()
        {

        }
        public static BillDAL Instance()
        {
            if(_instance == null )
                _instance = new BillDAL();
            return _instance;
        }
        public int GetIdMax()
        {
            using (RestaurantManage restaurantManage = new RestaurantManage())
            {
                try
                {
                    var idMax = (from p in restaurantManage.Bill
                                 select p.Id_Bill).Max();
                    return idMax;
                }
                catch (System.InvalidOperationException ex)
                {
                    return 0;
                }
            }
        }
        public void Add(Bill bill)
        {
            using(RestaurantManage restaurant = new RestaurantManage())
            {
                restaurant.Bill.Add(bill);
                restaurant.SaveChanges();
            }
          
        }
        public void Del(Bill bill) {

            using (RestaurantManage restaurant = new RestaurantManage())
            {
                restaurant.Remove(bill);
                restaurant.SaveChanges();
            }
            
        }
        public List<Bill> GetList() {
            using(RestaurantManage restaurant=new RestaurantManage())
            {
                var billList = from b in restaurant.Bill
                               select b;
                return billList.ToList();
            }
            
        }
        public Bill GetById(int id)
        {
            using(RestaurantManage restaurant = new RestaurantManage())
            {
                var bill = (from b in restaurant.Bill
                            where b.Id_Bill == id
                            select b).FirstOrDefault();
                return bill;
            }
            
        }
        
    }
}
