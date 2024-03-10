using BUSSS;
using DAO;
using Guna.UI2.WinForms;
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
    public partial class FoodForm : Form
    {

        public FoodForm()
        {

            InitializeComponent();
            LoadDataGridView();
        }

        private void addFoodbtn_Click(object sender, EventArgs e)
        {
            addFoodCard addFoodCard = new addFoodCard();
            addFoodCard.ShowDialog();
            LoadDataGridView();
        }
        private void LoadDataGridView()
        {
            FoodDgv.DataSource = FoodBUS.GetInstance().GetFoodInsertToDataGridView();
        }

        private void FoodDgv_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            addFoodCard AddFoodCard = new addFoodCard();
            if (FoodDgv.CurrentCell.OwningColumn.Name == "dgvEdit")
            {
                string condition = FoodDgv.CurrentRow.Cells["dgvName"].Value.ToString();
                addFoodCard.idFood = (int)FoodDgv.CurrentRow.Cells["dvgId"].Value;
                AddFoodCard.foodIdtxt.Text = addFoodCard.idFood.ToString();
                AddFoodCard.foodNametxt.Text = FoodDgv.CurrentRow.Cells["dgvName"].Value.ToString();
                AddFoodCard.foodCategoryCbb.SelectedItem =(string) FoodDgv.CurrentRow.Cells["dgvCategory"].Value.ToString();
  
                AddFoodCard.foodImage.ImageLocation = FoodBUS.GetInstance().GetImageLocation((int)FoodDgv.CurrentRow.Cells["dvgId"].Value);
                AddFoodCard.foodDataGridView.DataSource = FoodSizeBUS.GetInstance().GetFoodSizeLstByCondition((FoodDgv.CurrentRow.Cells["dvgId"].Value.ToString()));
                addFoodCard.addFoodSizebtn.Enabled= true;
                AddFoodCard.ShowDialog();
                addFoodCard.idFood = 0;
                LoadDataGridView();
            }
            if (FoodDgv.CurrentCell.OwningColumn.Name == "dgvDel")
            {
                int id = (int)FoodDgv.CurrentRow.Cells["dvgId"].Value;
                if (FoodBUS.GetInstance().DeleteFood(id))
                {
                    MessageBox.Show("Xóa sản phẩm thành công ");
                }
                else
                    MessageBox.Show("Xóa sản phẩm thất bại ");
                LoadDataGridView();
            }
        }

        private void SearchFood(object sender, EventArgs e)
        {
            FoodDgv.DataSource =  FoodBUS.GetInstance().GetFoodByCondition(SearchFoodTxt.Text);
        }
    }
}
