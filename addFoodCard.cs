using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BUSSS;
using DTO;
using Guna.UI2.WinForms;
namespace GUI
{
    public partial class addFoodCard : Form
    {
        public static int idFood = 0;
        public static string imageLocation = "";
        public static Button addFoodSizebtn = new Button();
        public Guna2TextBox foodIdtxt = new Guna2TextBox();
        public Guna2TextBox foodNametxt = new Guna2TextBox();
        public Guna2ComboBox foodCategoryCbb = new Guna2ComboBox();
        public PictureBox foodImage = new Guna2PictureBox();
        public Guna2DataGridView foodDataGridView = new Guna2DataGridView();

        public addFoodCard()
        {
            InitializeComponent();
            LoadComboBox();
            addFoodSizebtn = AddFoodSizeBtn;
            addFoodSizebtn.Enabled = false;
            foodIdtxt = foodIdTxt;
            foodNametxt = foodNameTxt;
            foodCategoryCbb = categoryNameCbb;
            foodImage = ImageFoodPtb;
            foodDataGridView = foodSizeDgv;

        }
        // Load combobox
        private void LoadComboBox()
        {
            List<String> categoryNamelst = new List<String>();
            CategoryBUS.GetInstance().GetCategoryLst().ForEach(c => categoryNamelst.Add(c.CategoryName));
            categoryNameCbb.DataSource = categoryNamelst;
        }
        // ấn vào nút thêm size và giá cho món ắn
        private void addFoodSize(object sender, EventArgs e)
        {
            try
            {
                if (FoodSizeBUS.GetInstance().AddFoodSize(foodTilteTxt.Text, foodNameTxt.Text, decimal.Parse(FoodPriceTxt.Text)))
                {
                    MessageBox.Show("Thêm size thành công");
                }
                else
                {
                    MessageBox.Show("Thêm size không thành công ");
                }
            }
            catch (System.FormatException ex)
            {
                MessageBox.Show("vui long nhap day du thong tin");
            }




            LoadDataGridView();
        }
        public void LoadDataGridView()
        {
            string condition = foodIdTxt.Text;
            foodSizeDgv.DataSource = FoodSizeBUS.GetInstance().GetFoodSizeLstByCondition(condition);


        }

        private void guna2Button1_Click(object sender, EventArgs e)
        {
            try
            {
                OpenFileDialog dialog = new OpenFileDialog();
                dialog.Filter = "jpg files(*.jpg) | *.jpg | PNG files(*.png)|*.png| All files(*.*)|*.*";
                if (dialog.ShowDialog() == DialogResult.OK)
                {
                    imageLocation = dialog.FileName;
                    ImageFoodPtb.ImageLocation = imageLocation;
                }

            }
            catch
            {
                MessageBox.Show("An Error Ocurred", "error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void guna2Button3_Click(object sender, EventArgs e)
        {
            this.Close();
            
        }
  
        private void guna2Button2_Click(object sender, EventArgs e)
        {
            if (idFood == 0)
            {
                FoodBUS.GetInstance().AddFood(foodNameTxt.Text, categoryNameCbb.Text, imageLocation);
                MessageBox.Show("thêm thông tin món thành công");
                int id = FoodBUS.GetInstance().GetIdByNameFood(foodNameTxt.Text);
                foodIdtxt.Text = id.ToString();
                AddFoodSizeBtn.Enabled = true;
            }
            else
            {
                int categoryId = CategoryBUS.GetInstance().GetId(categoryNameCbb.Text);
                if (FoodBUS.GetInstance().UpdateFood(int.Parse(foodIdtxt.Text), foodNameTxt.Text, categoryId, ImageFoodPtb.ImageLocation))
                {
                    MessageBox.Show("Cập nhật thông tin món thành công ");


                }
                else
                {
                    MessageBox.Show("Cập nhật thông tin món không thành công ");
                }
                
                idFood = 0; // dựa vào idFood để thêm thông tin hoặc sửa thông tin nên phải reset lại sau mỗi lần sử dụng 
                this.Close();
            }
           

        }

        private void foodSizeDgv_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (foodSizeDgv.CurrentCell.OwningColumn.Name == "dgvEdit")
            {
                string foodName = foodNameTxt.Text;
                string foodSizeName = foodSizeDgv.CurrentRow.Cells["dgvFoodSize"].Value.ToString();
                // lấy ra idfoodsize để cập nhật theo id 
                int idFoodSize = FoodSizeBUS.GetInstance().GetFoodSizeID(foodSizeName, foodName);
                if (FoodPriceTxt.Text == "" && foodTilteTxt.Text != "") // cập nhật foodSize khi người dùng chỉ muốn chỉnh sửa size mà không chỉnh sửa giá 
                {
                    decimal foodPrice = decimal.Parse(foodSizeDgv.CurrentRow.Cells["dgvFoodPrice"].Value.ToString());
                    FoodSizeBUS.GetInstance().UpdateFoodSize(idFoodSize, foodTilteTxt.Text, foodPrice);
                    LoadDataGridView();
                }
                else if(foodTilteTxt.Text == "" && FoodPriceTxt.Text != "") // cập nhật foodSize khi người dùng chỉ muốn thay đổi giá mà không chỉnh sửa size 
                {
                    string foodTilte = foodSizeDgv.CurrentRow.Cells["dgvFoodSize"].Value.ToString();
                    FoodSizeBUS.GetInstance().UpdateFoodSize(idFoodSize,foodTilte,decimal.Parse( FoodPriceTxt.Text));
                    LoadDataGridView();
                }
                else // cập nhật khi người dungf muốn sửa cả size và giá 
                {
                    try
                    {
                        decimal priceUpdate = decimal.Parse(FoodPriceTxt.Text);
                        FoodSizeBUS.GetInstance().UpdateFoodSize(idFoodSize, foodTilteTxt.Text, priceUpdate);
                        LoadDataGridView();
                    }
                    catch (System.FormatException ex)
                    {
                        MessageBox.Show("vui lòng nhập size hoặc giá bạn muốn chỉnh sửa ");
                    }



                }
            }
            if (foodSizeDgv.CurrentCell.OwningColumn.Name == "dgvDel")
            {
                string foodName = foodNameTxt.Text;
                string foodSizeName = foodSizeDgv.CurrentRow.Cells["dgvFoodSize"].Value.ToString();
                int idFoodSize = FoodSizeBUS.GetInstance().GetFoodSizeID(foodSizeName, foodName);
                FoodSizeBUS.GetInstance()
                    .DeleteFoodSize(idFoodSize);
                LoadDataGridView();

            }
        }

       

       
    }
}
