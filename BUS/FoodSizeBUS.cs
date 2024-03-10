using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL;
using DTOO;
namespace BUSSS
{
    public class FoodSizeBUS
    {
        private FoodSizeBUS() { }


        private static FoodSizeBUS _instance;

        public static FoodSizeBUS GetInstance()
        {
            if (_instance == null)
            {
                _instance = new FoodSizeBUS();
            }
            return _instance;
        }
        public  bool AddFoodSize(string foodSizeName, string foodName, decimal foodPrice)
        {
            bool check = false;
            // check xem tên món có trong database món ăn không nếu có mới được thêm size cho món đó 
            foreach (var item in FoodDAL.GetInstance().getFoodName())
            {
                if (item.Equals(foodName))
                {
                    check = true ;
                    break;
                }
                else {
                    check = false;
                } 
            }
            if(check)
            {
                FoodSize foodSize = new FoodSize() { SizeName = foodSizeName, IdFood = FoodBUS.GetInstance().GetIdByNameFood(foodName), SizePrice = foodPrice };
                FoodSizeDAL.GetInstance().Add(foodSize);
                return true;
            }
            
                return false;
          
            
        }
        public  List<FoodSize> GetFoodSizeLst()
        {
            return FoodSizeDAL.GetInstance().GetLst();
        }
        public  dynamic GetFoodSizeLstByCondition(string condition)
        {
            return FoodSizeDAL.GetInstance().GetLstByCondition(condition);
        }
        public  int GetFoodSizeID(string foodSizeName,string foodName)
        {
            int idFood =  FoodBUS.GetInstance().GetIdByNameFood(foodName);
            return FoodSizeDAL.GetInstance().SelectIdByCondition(foodSizeName, idFood);
        }
        public  bool UpdateFoodSize(int id, string foodSizeName,decimal foodPrice)
        {
            if(FoodSizeDAL.GetInstance().Update(id, foodSizeName, foodPrice)) return true;
            else return false;
        }
        public bool DeleteFoodSize(int id)
        {
            if(FoodSizeDAL.GetInstance().Delete(id)) return true;
            else return false;
        }
        
        public List<string> GetFoodSizeNameLstByIdFood(string foodName)
        {
            int id = FoodDAL.GetInstance().SelectIdByFoodName(foodName);
            return FoodSizeDAL.GetInstance().SelectFoodSizeNameLstByIdFood(id);
        }
        public List<decimal> GetFoodSizePriceLstByIdFood(int idFood)
        {
            return FoodSizeDAL.GetInstance().SelectFoodSizePriceLstByIdFood(idFood);
        }
        public decimal GetFoodSizePriceByFoodSizeName(string foodSizeName,string foodName)
        {
            return FoodSizeDAL.GetInstance().SelectFoodSizePriceByFoodSizeName(foodSizeName,foodName);
        }
    }
}
