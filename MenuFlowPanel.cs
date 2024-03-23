using BUS;
using BUSSS;
using DAL;
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
            if (DateTime.Now > VoucherBUS.GetInstance().GetDue(CodeTxt.Text) || DateTime.Now < VoucherBUS.GetInstance().GetVoucherByCode(CodeTxt.Text).Start_Date)
            {
                MessageBox.Show("code khong hop le");
            }
            else 
            if (decimal.Parse(subTotalLbl.Text.Replace("$","")) > VoucherBUS.GetInstance().GetVoucherByCode(CodeTxt.Text).Min_Price)
            {
                    decimal discount = (decimal)VoucherBUS.GetInstance().GetDiscountByCode(CodeTxt.Text);
                    decimal subTotal = decimal.Parse(subTotalLbl.Text.Replace("$", ""));
                    DiscountPriceLbl.Text = "$"+discount.ToString();
                    decimal totalPrice = subTotal - discount;
                    totalLbl.Text ="$"+totalPrice.ToString();
                
            }
            else
            {
                MessageBox.Show("chua du don toi thieu");
            }
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }
        private void CheckOutBtn_Click(object sender, EventArgs e)
        {
            int billId = BillBUS.Instance().GetBillIdMax() +1;
            MessageBox.Show(billId.ToString());
            Bill bill = new Bill()
            {
                Id_Bill = billId,
                Date_invoice = DateTime.Now,
                Sub_Price = decimal.Parse(subPriceLBL.Text.Replace("$", "")),
                Id_Voucher = VoucherBUS.GetInstance().GetVoucherByCode(CodeTxt.Text) != null ? VoucherBUS.GetInstance().GetVoucherByCode(CodeTxt.Text).VoucherId : null,
                Total_Price = decimal.Parse(totalLbl.Text.Replace("$", ""))
            };
            BillBUS.Instance().AddBill(bill);
            foreach (var foodOrder in foodMenuLstRight)
            {
                Food_Order food_Orders = new Food_Order()
                {
                    Id_Food =  FoodBUS.GetInstance().GetIdByNameFood(foodOrder.FoodName),
                    Size_Food = foodOrder.FoodSize,
                    Price = decimal.Parse(foodOrder.FoodPrice.Replace("$", "")),
                    Count_Food = int.Parse(foodOrder.FoodNumberLBL),
                    Id_Bill = bill.Id_Bill,
                };
                Food_OrderBUS.Instance().AddFoodOrder(food_Orders);
            }
            MessageBox.Show("xuất hóa đơn thành công");
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
