using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL;
using DTOO;
namespace BUSSS
{
    
    public class CategoryBUS
    {
        private CategoryBUS() { }


        private static CategoryBUS _instance;

        public static CategoryBUS GetInstance()
        {
            if (_instance == null)
            {
                _instance = new CategoryBUS();
            }
            return _instance;
        }
        public void AddCategory(string categoryName,string imageCategoryLocation)
        {
            Category category = new Category() {CategoryName = categoryName,CategoryImageLocation =imageCategoryLocation };
            CategoryDAL.GetInstance().Add(category);
        }
        public  List<Category> GetCategoryLst()
        {
            return CategoryDAL.GetInstance().GetLst();
        }
        public dynamic GetIdAndName()
        {
            return CategoryDAL.GetInstance().SelectIdAndName();
        }
        public bool UpdateCategory(int id,string categoryName,string imageCategoryLocation)
        {
            if (CategoryDAL.GetInstance().Update(id, categoryName,imageCategoryLocation))
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        public bool DeleteCategory(int id)
        {
            if (CategoryDAL.GetInstance().Delete(id))
            {
                return true;
            }
            else
            {
                return false ;
            }
        }
        public List<Category> GetCategoryByCondition(string condition)
        {
            return CategoryDAL.GetInstance().GetLstByCondition(condition);
        }
        public int GetId(string condition)
        {
            return CategoryDAL.GetInstance().SelectByNameCategory(condition);
        }
        public string GetImageLocationById (int id)
        {
            return CategoryDAL.GetInstance().SelectImageLocationById(id);
        }
        public List<string> GetImageLocationLst()
        {
            return CategoryDAL.GetInstance().SelectImageLocationLst();
        }
        public List<string> GetCategoryNameLst()
        {
            return CategoryDAL.GetInstance().SelectCategoryNameLst();
        }
    }
}
