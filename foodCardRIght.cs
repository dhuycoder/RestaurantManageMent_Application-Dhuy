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
    public partial class foodCardRIght : UserControl
    {
        public foodCardRIght()
        {
            InitializeComponent();
        }
        private string foodSize;
        private string imageLocation;
        private PictureBoxSizeMode sizeMode;
        private string foodPrice;
        private string foodName;
        private string foodNumberLbl;

      
        

        [Category("Custom Props")]
        public string FoodName
        {
            get { return foodName; }
            set { foodName = value; foodNameLbl.Text = value; }
        }
        public string FoodPrice
        {
            get { return foodPrice; }
            set { foodPrice = value; foodPriceLbl.Text = value; }
        }
        public PictureBoxSizeMode SizeMode
        {
            get { return sizeMode; }
            set { sizeMode = value; foodImage.SizeMode = value; }
        }
        public string ImageLocation
        {
            get { return imageLocation; }
            set { imageLocation = value; foodImage.ImageLocation = value; }
        }
        public string FoodSize
        {
            get { return foodSize; }
            set { foodSize = value; foodSizeLbl.Text = value; }
        }
        public string FoodNumberLBL
        {
            get { return foodNumberLbl; }
            set { foodNumberLbl = value; FoodNumberLbl.Text = value; }
        }
        private void DelFoodCardRightBtn_Click(object sender, EventArgs e)
        {
            MenuFlowPanel.foodMenuLstRight.Remove(this);
            MenuFlowPanel.flpnlR.Controls.Remove(this);
            MenuFlowPanel.LoadTotalPrice();
        }
        public int Number;
        private void PlusBtn_Click(object sender, EventArgs e)
        {
            Number = int.Parse(FoodNumberLbl.Text);
            Number += 1;
            this.FoodNumberLBL  = Number.ToString();
            MenuFlowPanel.LoadTotalPrice();

        }

        private void MinusBtn_Click(object sender, EventArgs e)
        {
            Number = int.Parse(FoodNumberLbl.Text);
            Number -= 1;
            if (Number == 0)
            {
                MenuFlowPanel.foodMenuLstRight.Remove(this);
                MenuFlowPanel.flpnlR.Controls.Remove(this);
            }
            this.FoodNumberLBL = Number.ToString();
            MenuFlowPanel.LoadTotalPrice();
        }
    }
}
