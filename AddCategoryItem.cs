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
using DTOO;
using Guna.UI2.WinForms;
namespace GUI
{
    public partial class AddCategoryItem : Form
    {
        public static string imageCategoryLocation = "";
        public static int id; // id loại sản phẩm 
        public Guna2PictureBox pictureBox = new Guna2PictureBox();
        public Guna2TextBox categoryNameTxt = new Guna2TextBox(); // khai báo textbox để gọi từ form khác 

        public AddCategoryItem()
        {
            InitializeComponent();
            categoryNameTxt =CategoryNameTxt;
            pictureBox = ImageCategoryPtb;
        }

        // nút close Form 
        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        // nút save category 
        private void btnSave_Click(object sender, EventArgs e)
        {
            // nếu id chưa thay đổi gì thì là thêm sản phẩm 
            if (id == 0)
            {
                CategoryBUS.GetInstance().AddCategory(CategoryNameTxt.Text,imageCategoryLocation);
                MessageBox.Show("Thêm thông tin thành công ");
            }
            // nếu id thay đổi thì là cập nhật sản phẩm 
            else
            {
                if (CategoryBUS.GetInstance().UpdateCategory(id, categoryNameTxt.Text,imageCategoryLocation))
                {
                    id = 0; // gán lại id về 0 sau mỗi lần cập nhật xong 
                    MessageBox.Show("Cập nhật  thông tin thành công ");
                }
                else
                {
                    MessageBox.Show("Cập nhật thông tin thất bại ");
                }
                this.Close();
            }
            

        }

        private void BrowseBtn_Click(object sender, EventArgs e)
        {
            try
            {
                OpenFileDialog dialog = new OpenFileDialog();
                dialog.Filter = "jpg files(*.jpg) | *.jpg | PNG files(*.png)|*.png| All files(*.*)|*.*";
                if (dialog.ShowDialog() == DialogResult.OK)
                {
                    imageCategoryLocation = dialog.FileName;
                    ImageCategoryPtb.ImageLocation = imageCategoryLocation;
                }
            }
            catch
            {
                MessageBox.Show("An Error Ocurred", "error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
