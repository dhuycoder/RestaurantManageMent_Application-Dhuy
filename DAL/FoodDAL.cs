using DTOO;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public sealed class FoodDAL
    {
     
        private FoodDAL() { }


        private static FoodDAL _instance;

        public static FoodDAL GetInstance()
        {
            if (_instance == null)
            {
                _instance = new FoodDAL();
            }
            return _instance;
        }
        public void Add(Food food)
        {
            using(RestaurantManage restaurantManage = new RestaurantManage())
            {
                restaurantManage.foods.Add(food);
                restaurantManage.SaveChanges();
            }
          
        }
        public List<Food> GetList()
        {
            using (RestaurantManage restaurantManage = new RestaurantManage())
            {
                var foodList = from food in restaurantManage.foods
                               select food;
                return foodList.ToList();
            }
                
        }
        public dynamic getFoodListWithCategory()
        {
            using (RestaurantManage restaurantManage = new RestaurantManage())
            {
                var foodlist = from f in restaurantManage.foods
                               select new
                               {
                                   FoodId = f.IdFood,
                                   FoodName = f.NameFood,
                                   CategoryName = f.Category.CategoryName
                               };
                return foodlist.ToList();
            }
                
        }
        public int SelectIdByFoodName(string foodName)
        {
            using (RestaurantManage restaurantManage = new RestaurantManage())
            {
                var IdFood = (from f in restaurantManage.foods
                              where f.NameFood == foodName
                              select f.IdFood).FirstOrDefault();
                return IdFood;
            }
                
        }
        public bool Update(int id, string foodName, int idCategory, string imageLocation)
        {
            using (RestaurantManage restaurantManage = new RestaurantManage())
            {
                var food = (from f in restaurantManage.foods
                            where f.IdFood == id
                            select f).FirstOrDefault();
                if (food!= null)
                {
                    food.NameFood = foodName;
                    food.Id_Category = idCategory;
                    food.ImageLocation = imageLocation;
                    restaurantManage.SaveChanges();
                    return true;
                }
                else return false;
            }

        }
        public string SelectImageById(int id)
        {
            using (RestaurantManage restaurantManage = new RestaurantManage())
            {
                var imageLocation = (from f in restaurantManage.foods
                                     where f.IdFood == id
                                     select f.ImageLocation).FirstOrDefault();
                return imageLocation.ToString();
            }
                
        }
        public bool Delete(int id)
        {
            using (RestaurantManage restaurantManage = new RestaurantManage())
            {
                var food = (from f in restaurantManage.foods
                            where f.IdFood == id
                            select f).FirstOrDefault();
                if (food!= null)
                {
                    restaurantManage.Remove(food);
                    restaurantManage.SaveChanges();
                    return true;
                }
                else { return false; }
            }
                

        }
        public List<string> getFoodName()
        {
            using (RestaurantManage restaurantManage = new RestaurantManage())
            {
                var foodNameLst = from f in restaurantManage.foods
                                  select f.NameFood;
                return foodNameLst.ToList();
            }
               
        }
        public dynamic GetLstByCondition(String condition)
        {
            using (RestaurantManage restaurantManage = new RestaurantManage())
            {
                if (int.TryParse(condition, out _))
                {
                    var item = from f in restaurantManage.foods
                               where f.IdFood == int.Parse(condition)
                               select new
                               {
                                   FoodId = f.IdFood,
                                   FoodName = f.NameFood,
                                   CategoryName = f.Category.CategoryName
                               };
                    return item.ToList();
                }
                else
                {
                    var item = from f in restaurantManage.foods
                               where f.NameFood.Contains(condition)
                               select new
                               {
                                   FoodId = f.IdFood,
                                   FoodName = f.NameFood,
                                   CategoryName = f.Category.CategoryName
                               };
                    return item.ToList();
                }
            }
              

        }
        public List<Food> SelectFoodByNameFood(string foodName)
        {
            using (RestaurantManage restaurantManage = new RestaurantManage())
            {
                var foodlst = from f in restaurantManage.foods
                              where f.NameFood.Contains(foodName.Trim())
                              select f;
                return foodlst.ToList();
            }
                
        }
    }
}
