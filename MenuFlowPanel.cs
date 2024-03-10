using BUSSS;
using DTOO;
using Microsoft.Identity.Client;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GUI
{
    public partial class MenuFlowPanel : Form
    {
        public static FlowLayoutPanel flpnlR = new FlowLayoutPanel();
        public static List<FoodCard> foodMenuLst = new List<FoodCard>();
        public static List<foodCardRIght> foodMenuLstRight = new List<foodCardRIght>();
        public static List<CategoryCard> categoryMenuLst = new List<CategoryCard>();
        public static Label subPriceLBL = new Label();
        public static Label totalPriceLbl = new Label();
        public MenuFlowPanel()
        {
            InitializeComponent();
            // gán vào nó sẽ tự reset 
            flpnlR = menuFoodFlpnR;
            subPriceLBL = subTotalLbl;
            totalPriceLbl = totalLbl;

            LoadMenuFoodRight();
            LoadMenuFood();
            LoadMenuCategory();
            LoadTotalPrice();

        }
        public void LoadMenuFood()
        {
            // xóa ô cũ sau mỗi lần mở form
            if (foodMenuLst.Count > 0)
            {
                foodMenuLst.Clear();
            }
            int foodNumber = FoodBUS.GetInstance().getFood().Count;


            for (int i = 0; i < foodNumber; i++)
            {
                FoodCard foodCard = new FoodCard();
                try
                {
                    Food food = new Food();
                    food = FoodBUS.GetInstance().getFood().ToArray().GetValue(i) as Food; // lấy từ danh sách food trong database 
                    foodCard.FoodName = food.NameFood;
                    foodCard.FoodSizeNameCbb = FoodSizeBUS.GetInstance().GetFoodSizeNameLstByIdFood(food.NameFood);
                    foodCard.ImageLocation = food.ImageLocation;
                    foodCard.SizeMode = PictureBoxSizeMode.Zoom;
                    foodCard.Margin = new System.Windows.Forms.Padding(0, 10, 20, 20);
                    foodMenuLst.Add(foodCard);
                }
                catch (System.IndexOutOfRangeException ex)
                {
                    foodMenuLst.Remove(foodCard);
                }
            }
            foodMenuLst.ForEach(item =>
            {
                MenuFoodCardLeftflp.Controls.Add(item);
            });
        }
        public void LoadMenuFoodRight()
        {
            if (foodMenuLstRight.Count > 0)
            {
                menuFoodFlpnR.Controls.Clear();
            }
            foodMenuLstRight.ForEach(item =>
            {
                menuFoodFlpnR.Controls.Add(item);
            });
        }
        public void LoadMenuCategory()
        {
            if (categoryMenuLst.Count > 0)
            {
                categoryMenuLst.Clear();
                CategoryFlowPanel.Controls.Clear();
            }

            for (int i = 0; i<CategoryBUS.GetInstance().GetCategoryLst().Count; i++)
            {
                CategoryCard categoryCard = new CategoryCard();
                try
                {
                    // có thể thử select tất xong gọi đến từng đối tượng 

                    categoryCard.ImageLocation = CategoryBUS.GetInstance().GetCategoryLst()[i].CategoryImageLocation;
                    categoryCard.CategoryName = CategoryBUS.GetInstance().GetCategoryLst()[i].CategoryName;

                    categoryMenuLst.Add(categoryCard);
                }
                catch (System.IndexOutOfRangeException ex)
                {
                    categoryMenuLst.Remove(categoryCard);
                }
            }


            categoryMenuLst.ForEach(item =>
            {
                CategoryFlowPanel.Controls.Add(item);
            });
        }

        private void SearchFoodTxt_TextChanged(object sender, EventArgs e)
        {
            if (foodMenuLst.Count > 0)
            {
                foodMenuLst.Clear();
                MenuFoodCardLeftflp.Controls.Clear();
            }
            int foodNumber = FoodBUS.GetInstance().GetFoodByFoodName(SearchFoodTxt.Text).Count;
            for (int i = 0; i < foodNumber; i++)
            {
                FoodCard foodCard = new FoodCard();
                try
                {
                    Food food = new Food();
                    food =  FoodBUS.GetInstance().GetFoodByFoodName(SearchFoodTxt.Text).ToArray().GetValue(i) as Food; // lấy từ danh sách food trong database 
                    foodCard.FoodName = food.NameFood;
                    foodCard.FoodSizeNameCbb = FoodSizeBUS.GetInstance().GetFoodSizeNameLstByIdFood(food.NameFood);
                    foodCard.ImageLocation = food.ImageLocation;
                    foodCard.SizeMode = PictureBoxSizeMode.Zoom;
                    foodCard.Margin = new System.Windows.Forms.Padding(0, 10, 20, 20);
                    foodMenuLst.Add(foodCard);
                }
                catch (System.IndexOutOfRangeException ex)
                {
                    foodMenuLst.Remove(foodCard);
                }
            }
            foodMenuLst.ForEach(item =>
            {
                MenuFoodCardLeftflp.Controls.Add(item);
            });
        }

        public static void LoadTotalPrice()
        {
            decimal totalPrice = 0;
            decimal price = 0;
            foodMenuLstRight.ForEach((item) =>
            {
                price = decimal.Parse(item.FoodPrice.Replace("$", ""));
                totalPrice += price * decimal.Parse(item.FoodNumberLBL);


            });
            subPriceLBL.Text = "$"+ totalPrice.ToString();
            totalPriceLbl.Text = "$"+ totalPrice.ToString();


        }

        private void applyDiscountBtn_Click(object sender, EventArgs e)
        {
            if (subTotalLbl.Text == "$0")
            {
                MessageBox.Show("Bạn chưa chọn món ăn ");
            }
            else
            {
                decimal discountPercent = (decimal)VoucherBUS.GetInstance().GetDiscountByCode(CodeTxt.Text);
                decimal subTotal = decimal.Parse(subTotalLbl.Text.Replace("$", ""));
                decimal discountPrice = discountPercent/100 * subTotal;
                DiscountPriceLbl.Text = "$"+discountPrice.ToString();
                decimal totalPrice = subTotal - discountPrice;
                totalLbl.Text ="$"+totalPrice.ToString();
            }



        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void CheckOutBtn_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Thanh toán thành công");
            subTotalLbl.Text = "$0";
            DiscountPriceLbl.Text = "";
            totalLbl.Text ="";
            CodeTxt.Text = "";
            foodMenuLstRight.Clear();
            menuFoodFlpnR.Controls.Clear();

        }

        private void panel3_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
