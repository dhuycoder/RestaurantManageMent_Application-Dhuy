using DTOO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class FoodOrderDAL
    {
     
        private static FoodOrderDAL _instance;
        private FoodOrderDAL()
        {
        }
        public static FoodOrderDAL getInstance()
        {
            if (_instance == null)
            {
                _instance = new FoodOrderDAL();
            }
            return _instance;
        }
        public void Add(Food_Order food_Order)
        {
            using(RestaurantManage restaurantManage = new RestaurantManage())
            {
                restaurantManage.Food_Order.Add(food_Order);
                restaurantManage.SaveChanges();
            }
            
        }
        public void Del(Food_Order food_Order)
        {
            using (RestaurantManage restaurantManage = new RestaurantManage())
            {
                restaurantManage.Food_Order.Remove(food_Order);
                restaurantManage.SaveChanges();
            }
                
        }
        public List<Food_Order> GetList()
        {
            using (RestaurantManage restaurantManage = new RestaurantManage())
            {
                var foodOrderLst = from f in restaurantManage.Food_Order
                                   select f;
                return foodOrderLst.ToList();
            }
               
        }

    }
}
