using BUSSS;
using Restaurant_ManageMent_Application;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Common;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DTOO;
namespace GUI
{
    public partial class FoodCard : UserControl
    {
        public static Bill billAdd;
        public FoodCard()
        {
            InitializeComponent();

        }
   

        private string imageLocation;
        private PictureBoxSizeMode sizeMode;

        private Image image;
        private string foodName;
        private string foodSize;
        private List<string> foodSizeComboboxlst;

        [Category("Custom Props")]
        public string FoodName
        {
            get { return foodName; }
            set { foodName = value; foodNameTxt.Text = value; }
        }
     
        public Image Image
        {
            get { return image; }
            set { image = value; foodImage.Image = value; }
        }
        public PictureBoxSizeMode SizeMode
        {
            get { return sizeMode; }
            set { sizeMode = value; foodImage.SizeMode = value; }
        }
        public string FoodSize
        {
            get { return foodSize; }
            set { foodSize = value; }
        }
        public string ImageLocation
        {
            get { return imageLocation; }
            set { imageLocation = value; foodImage.ImageLocation = value; }
        }
        public List<string> FoodSizeNameCbb
        {
            get { return foodSizeComboboxlst; }
            set { foodSizeComboboxlst = value; foodSizeComboBox.DataSource = value; }
        }

        private void foodSizeComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            foodPriceTxt.Text = "$"+ FoodSizeBUS.GetInstance().GetFoodSizePriceByFoodSizeName(foodSizeComboBox.Text, foodNameTxt.Text).ToString();

        }

        private void iconButton1_Click(object sender, EventArgs e)
        {
            foodCardRIght foodCardRIght = new foodCardRIght();
            foodCardRIght.Width = MenuFlowPanel.flpnlR.Width;
            foodCardRIght.FoodName = foodNameTxt.Text;
            foodCardRIght.FoodNumberLBL = "1";
            foodCardRIght.FoodPrice = foodPriceTxt.Text;
            foodCardRIght.FoodSize = foodSizeComboBox.Text;
            foodCardRIght.ImageLocation = this.ImageLocation;
            foodCardRIght.SizeMode = PictureBoxSizeMode.Zoom;
            MenuFlowPanel.foodMenuLstRight.Add(foodCardRIght);
            MenuFlowPanel.flpnlR.Controls.Add(foodCardRIght);
            MenuFlowPanel.LoadTotalPrice();
            

        }
    }
}
