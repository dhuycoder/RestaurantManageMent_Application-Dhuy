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
    public partial class CategoryCard : UserControl
    {
        private string imageLocation;
        private string categoryName;
        public CategoryCard()
        {
            InitializeComponent();
        }
        public string ImageLocation
        {
            get { return imageLocation; }
            set { imageLocation = value; CategoryImagePtb.ImageLocation = value; }
        }
        public string CategoryName
        { get { return categoryName; } set {  categoryName = value; CategoryNameLbl.Text = value; } }
    }
}
