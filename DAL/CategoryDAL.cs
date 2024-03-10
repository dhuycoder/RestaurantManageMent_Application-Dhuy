using DTOO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class CategoryDAL
    {
        public static RestaurantManage restaurantManage = new RestaurantManage();
        private CategoryDAL() { }


        private static CategoryDAL _instance;

        public static CategoryDAL GetInstance()
        {

            if (_instance == null)
            {
                _instance = new CategoryDAL();
            }
            return _instance;

        }


        public void Add(Category category)
        {
            restaurantManage.categories.Add(category);
            restaurantManage.SaveChanges();
        }
        public List<Category> GetLst()
        {

            var list = from c in restaurantManage.categories
                       select c;
            return list.ToList();
        }
        public dynamic SelectIdAndName()
        {

            var list = from c in restaurantManage.categories
                       select new
                       {
                           CategoryId = c.CategoryId,
                           CategoryName = c.CategoryName
                       };
            return list.ToList();
        }
        public bool Delete(int id)
        {
            var item = (from c in restaurantManage.categories
                        where c.CategoryId == id
                        select c).FirstOrDefault();
            if (item != null)
            {
                restaurantManage.Remove(item);
                restaurantManage.SaveChanges();
                return true;
            }
            else { return false; }
        }
        public bool Update(int id, string categoryName, string imageCategoryLocation)
        {
            var item = (from c in restaurantManage.categories
                        where c.CategoryId == id
                        select c).FirstOrDefault();
            if (item != null)
            {
                item.CategoryName = categoryName;
                item.CategoryImageLocation = imageCategoryLocation;
                restaurantManage.SaveChanges();

                return true;
            }
            else { return false; }

        }
        public List<Category> GetLstByCondition(String condition)
        {
            if (int.TryParse(condition, out _))
            {
                var item = from c in restaurantManage.categories
                           where c.CategoryId == int.Parse(condition)
                           select c;
                return item.ToList();
            }
            else
            {
                var item = from c in restaurantManage.categories
                           where c.CategoryName.Contains(condition.Trim())
                           select c;
                return item.ToList();
            }

        }
        public int SelectByNameCategory(string categoryName)
        {
            var IdCategory = (from c in restaurantManage.categories
                              where c.CategoryName == categoryName
                              select c.CategoryId).FirstOrDefault();
            return IdCategory;
        }
        public string SelectImageLocationById(int id)
        {
            var imageLocation = (from c in restaurantManage.categories
                                 where c.CategoryId == id
                                 select c.CategoryImageLocation).FirstOrDefault();
            return imageLocation;
        }
        public List<string> SelectImageLocationLst()
        {
            var imageLocationLst = from c in restaurantManage.categories
                                   select c.CategoryImageLocation;
            return imageLocationLst.ToList();
        }
        public List<string> SelectCategoryNameLst()
        {
            var categoryNameLst = from c in restaurantManage.categories
                                  select c.CategoryName;
            return categoryNameLst.ToList();
        }
    }
}
