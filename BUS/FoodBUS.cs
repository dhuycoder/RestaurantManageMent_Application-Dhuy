using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL;
using DTOO;
namespace BUSSS
{
    public sealed class FoodBUS
    {
        public static RestaurantManage restaurantManage = new RestaurantManage();
        private FoodBUS() { }


        private static FoodBUS _instance;

        public static FoodBUS GetInstance()
        {
            if (_instance == null)
            {
                _instance = new FoodBUS();
            }
            return _instance;
        }
        public  dynamic GetFoodInsertToDataGridView()
        {
            return FoodDAL.GetInstance().getFoodListWithCategory();
        }
        public void AddFood(string foodName, string categoryName, string imagelocation)
        {
            Food food = new Food() { NameFood = foodName, Id_Category = CategoryBUS.GetInstance().GetId(categoryName), ImageLocation = imagelocation };
            FoodDAL.GetInstance().Add(food);
        }
        public int GetIdByNameFood(string foodName)
        {
            return FoodDAL.GetInstance().SelectIdByFoodName(foodName);
        }
        public string GetImageLocation(int id)
        {
            return FoodDAL.GetInstance().SelectImageById(id);
        }
        public bool UpdateFood(int id, string foodName, int idCategory, string imageLocation)
        {
            if (FoodDAL.GetInstance().Update(id, foodName, idCategory, imageLocation)) { return true; }
            else { return false; }
        }
        public bool DeleteFood(int id)
        {
            if (FoodDAL.GetInstance().Delete(id))
            { 
                return true; 
            }
            else
            { 
                return false;
            }
        }
        public List<Food> getFood()
        {
            return FoodDAL.GetInstance().GetList();
        }
        public dynamic GetFoodByCondition(string condition)
        {
            return FoodDAL.GetInstance().GetLstByCondition(condition);
        }
        public List<Food> GetFoodByFoodName(string foodName)
        {
            return FoodDAL.GetInstance().SelectFoodByNameFood(foodName);
        }
    }
}
