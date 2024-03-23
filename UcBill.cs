using BUS;
using BUSSS;
using DTOO;
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
    public partial class UcBill : UserControl
    {
        private int billId;
        private decimal subPrice;
        private decimal? discount;
        private decimal totalPrice;
        private DateTime dateInvoice;

        public UcBill()
        {
            InitializeComponent();
            tableLayoutPanel1.CellBorderStyle = TableLayoutPanelCellBorderStyle.Single;
        }
        public int BillId
        {
            get { return billId; }
            set { billId = value; LblBIllId.Text = value.ToString(); }
        }
        public decimal SubPrice
        {
            get { return subPrice; }
            set { subPrice = value; LblSubPrice.Text = value.ToString() +" đ"; }
        }
        public decimal? Discount
        {
            get { return discount; }
            set { discount = value; LblDiscountPrice.Text = value.ToString() +" đ"; }
        }
        public decimal TotalPrice
        {
            get { return totalPrice; }
            set { totalPrice = value; LblToltalPrice.Text = value.ToString() +" đ"; }
        }
        public DateTime DateInvoice
        {
            get { return dateInvoice; }
            set { dateInvoice = value; DtpDateInvoice.Value = value; }
        }

        private void guna2Button1_Click(object sender, EventArgs e)
        {
            Form1.FlpBill.Controls.Remove(this);
            // xoá food_order trước xóa bill sau 
            foreach (Food_Order food_Order in Food_OrderBUS.Instance().GetFoodOrderByIdBill(int.Parse(LblBIllId.Text)))
            {
                Food_OrderBUS.Instance().DelFoodOrder(food_Order);
            }
            BillBUS.Instance().DelBill(BillBUS.Instance().GetBillById(BillId));

        }

        private void guna2Button2_Click(object sender, EventArgs e)
        {
            DetailBill detailBill = new DetailBill(billId);
            detailBill.ShowDialog();
        }
    }
}
