using BUSSS;
using DAL;
using DTOO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BUS
{
    public class Food_OrderBUS
    {
        private Food_OrderBUS() { }


        private static Food_OrderBUS _instance;

        public static Food_OrderBUS Instance()
        {
            if (_instance == null)
            {
                _instance = new Food_OrderBUS();
            }
            return _instance;
        }
        public void AddFoodOrder(Food_Order food_Order)
        {
            FoodOrderDAL.getInstance().Add(food_Order);
        }
        public void DelFoodOrder(Food_Order food_Order)
        {
            FoodOrderDAL.getInstance().Del(food_Order);
        }
        public List<Food_Order> GetFoodOrderByIdBill(int id)
        {
            List<Food_Order> food_Orders = new List<Food_Order>();
            foreach (Food_Order food_order in FoodOrderDAL.getInstance().GetList()) 
            { 
                if(food_order.Id_Bill == id)
                {
                    food_Orders.Add(food_order);
                }
            }
            return food_Orders;
        }
    }
}
