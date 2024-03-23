using BUS;
using BUSSS;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DAL;
using DTOO;
using Microsoft.EntityFrameworkCore.ChangeTracking;
namespace GUI
{
    public partial class DetailBill : Form
    {
        private int id;
        public DetailBill(int id)
        {
            InitializeComponent();
            this.id=id;
            LoadFoodOrder();
            flpFoodOrder.Width += 30;
        }
        private EntityEntry<Food_Order> e;
        public void LoadFoodOrder()
        {
            foreach (var item in Food_OrderBUS.Instance().GetFoodOrderByIdBill(id))
            {
                using (var dbContext = new RestaurantManage())
                {
                    e = dbContext.Entry(item);
                    e.Reference(p => p.Food).Load();
                }
                foodCardRIght foodCardRIght = new foodCardRIght();
                foodCardRIght.Width = flpFoodOrder.Width;
                foodCardRIght.FoodName = item.Food.NameFood;
                foodCardRIght.FoodNumberLBL = item.Count_Food.ToString();
                foodCardRIght.FoodPrice = item.Price.ToString();
                foodCardRIght.FoodSize = item.Size_Food;
                foodCardRIght.ImageLocation = FoodBUS.GetInstance().GetImageLocation(item.Id_Food);
                foodCardRIght.SizeMode = PictureBoxSizeMode.Zoom;
                foodCardRIght.BorderStyle = BorderStyle.FixedSingle;
                foodCardRIght.DelBtn.Visible = false;
                flpFoodOrder.Controls.Add(foodCardRIght);
            }

        }

        
    }
}
