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
using DAO;
namespace GUI
{
    public partial class CategoryForm : Form

    {
        public CategoryForm()
        {
            InitializeComponent();
            LoadDataGridView();

        }
        // hàm thêm loại sản phẩm 
        private void AddCategory(object sender, EventArgs e)
        {
            AddCategoryItem addCategory = new AddCategoryItem();
            addCategory.ShowDialog();
            LoadDataGridView();
        }
        private void LoadDataGridView()
        {
            Categorydgv.DataSource = CategoryBUS.GetInstance().GetIdAndName();
        }

        private void Categorydgv_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            AddCategoryItem category = new AddCategoryItem();
            if (Categorydgv.CurrentCell.OwningColumn.Name == "dgvEdit")
            {
                AddCategoryItem.id  = (int)Categorydgv.CurrentRow.Cells["dgvId"].Value;
                category.categoryNameTxt.Text = Categorydgv.CurrentRow.Cells["dgvName"].Value.ToString();
                category.pictureBox.ImageLocation = CategoryBUS.GetInstance().GetImageLocationById(AddCategoryItem.id);
 
                category.ShowDialog();
                
                LoadDataGridView();
            }
            if (Categorydgv.CurrentCell.OwningColumn.Name == "dgvDel")
            {
                int id = (int)Categorydgv.CurrentRow.Cells["dgvId"].Value;
                if (CategoryBUS.GetInstance().DeleteCategory(id))
                {
                    MessageBox.Show("Xóa sản phẩm thành công");
                }
                else
                {
                    MessageBox.Show("Xóa sản phẩm thất bại ");
                }
                LoadDataGridView();

            }

        }
        // Sự kiện Search  
        private void SearchCategory(object sender, EventArgs e)
        {
            string searchCategory = SearchTxt.Text;
            if (searchCategory == "")
            {
                LoadDataGridView();
            }
            else
            { 
                var lst = CategoryBUS.GetInstance().GetCategoryByCondition(searchCategory);
                Categorydgv.DataSource = lst;
            }
        }
    }
}
