using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.IO.Pipes;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DTOO;
namespace DAL
{
    public class FoodSizeDAL
    {
        public static RestaurantManage restaurantManage = new RestaurantManage();
        private FoodSizeDAL() { }


        private static FoodSizeDAL _instance;

        public static FoodSizeDAL GetInstance()
        {
            if (_instance == null)
            {
                _instance = new FoodSizeDAL();
            }
            return _instance;
        }
        public void Add(FoodSize foodSize)
        {

            restaurantManage.Add(foodSize);
            restaurantManage.SaveChanges();

        }
        public List<FoodSize> GetLst()
        {
            var foodSizelst = from f in restaurantManage.foodSizes
                              select f;
            return foodSizelst.ToList();
        }
        public dynamic GetLstByCondition(string condition)
        {

            int idFood = int.Parse(condition);
            // join bang
            var foodSizelst = from f in restaurantManage.foodSizes
                              where f.Food.IdFood == idFood
                              select new
                              {
                                  SizeName = f.SizeName,
                                  SizePrice = f.SizePrice
                              };
            return foodSizelst.ToList();
        }

        public int SelectIdByCondition(string sizeName, int idFood)
        {
            var IdFoodSize = from f in restaurantManage.foodSizes
                             where f.SizeName == sizeName  && f.IdFood == idFood
                             select f.SizeId;
            return IdFoodSize.FirstOrDefault();
        }
        public bool Update(int id, string foodSizeName, decimal foodSizePrice)
        {
            var foodSize = (from f in restaurantManage.foodSizes
                            where f.SizeId == id
                            select f).FirstOrDefault();
            if (foodSize!=null)
            {
                foodSize.SizeName = foodSizeName;
                foodSize.SizePrice = foodSizePrice;
                restaurantManage.SaveChanges();
                return true;
            }
            else return false;
        }
        public bool Delete(int id)
        {
            var foodSize = (from f in restaurantManage.foodSizes
                            where f.SizeId == id
                            select f).FirstOrDefault();
            if (foodSize!=null)
            {
                restaurantManage.Remove(foodSize);
                restaurantManage.SaveChanges();
                return true;
            }
            else return false;
        }
        public List<string> SelectFoodSizeNameLstByIdFood(int idFood)
        {
            var foodSizeNameLst = from f in restaurantManage.foodSizes
                                  where f.IdFood == idFood
                                  select f.SizeName;
            return foodSizeNameLst.ToList();

        }
        public List<decimal> SelectFoodSizePriceLstByIdFood(int idFood)
        {
            var foodSizePriceLst = from f in restaurantManage.foodSizes
                                   where f.IdFood == idFood
                                   select f.SizePrice;
            return foodSizePriceLst.ToList();
        }
        public decimal SelectFoodSizePriceByFoodSizeName(string foodSizeName, string foodName)
        {
            int id = FoodDAL.GetInstance().SelectIdByFoodName(foodName);
            var foodSizePrice = (from f in restaurantManage.foodSizes
                                 where f.SizeName == foodSizeName && f.IdFood == id
                                 select f.SizePrice).FirstOrDefault();
            return foodSizePrice;
        }
    }
}
