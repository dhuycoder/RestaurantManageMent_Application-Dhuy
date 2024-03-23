using BUS;
using DTOO;
using DAL;
using Microsoft.EntityFrameworkCore.ChangeTracking;
using Microsoft.EntityFrameworkCore;
using static Dapper.SqlMapper;
namespace GUI
{
    public partial class Form1 : Form
    {
        public static FlowLayoutPanel FlpBill;

        private List<UcBill> ucBillList = new List<UcBill>();

        public Form1()
        {
            InitializeComponent();
            LoadBillLst();
            FlpBill= flpBill;
            flpBill.Width += 30; // cộng ở flowpanel thêm do có thanh Scroll 
        }


        private EntityEntry<Bill> e;
        public void LoadBillLst()
        {
            flpBill.Controls.Clear();
            ucBillList.Clear();

            foreach (Bill bill in BillBUS.Instance().GetBillList())
            {
                using (RestaurantManage restaurantManage = new RestaurantManage())
                {
                    e = restaurantManage.Entry(bill);
                    e.Reference(p => p.Voucher).Load();
                }
                UcBill ucBill = new UcBill()
                {
                    BillId = bill.Id_Bill,
                    SubPrice = bill.Sub_Price,
                    Discount = bill.Voucher != null ? bill.Voucher.Discount : 0,
                    TotalPrice = bill.Total_Price,
                    DateInvoice = bill.Date_invoice
                };
                ucBillList.Add(ucBill);


            }
            foreach (UcBill ucBill in ucBillList)
            {
                flpBill.Controls.Add(ucBill);
            }

        }

        private void Fill(object sender, EventArgs e)
        {
            flpBill.Controls.Clear();
            ucBillList.Clear();

            foreach (Bill bill in BillBUS.Instance().SearchBill(DtpInvoiceDate.Value, NbrFromPrice.Value, NbrToPrice.Value))
            {
                UcBill ucBill = new UcBill()
                {
                    BillId = bill.Id_Bill,
                    SubPrice = bill.Sub_Price,
                    Discount = bill.Voucher != null ? bill.Voucher.Discount : 0,
                    TotalPrice = bill.Total_Price,
                    DateInvoice = bill.Date_invoice
                };

                ucBillList.Add(ucBill);

            }
            foreach (UcBill ucBill in ucBillList)
            {
                flpBill.Controls.Add(ucBill);
            }
        }

        private void guna2Button2_Click(object sender, EventArgs e)
        {
            LoadBillLst();
        }
    }
}
