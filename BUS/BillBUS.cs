using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL;
using DTOO;
namespace BUS
{
    public class BillBUS
    {
        private static BillBUS _instance;
        private BillBUS() { }
        public static BillBUS Instance()
        {
            if(_instance == null)
                _instance = new BillBUS();
            return _instance;
        }
        public int GetBillIdMax()
        {
            return BillDAL.Instance().GetIdMax();
        }
        public void AddBill(Bill bill)
        {
            BillDAL.Instance().Add(bill);    
        }
        public List<Bill> GetBillList() {
            return BillDAL.Instance().GetList();
        }
        public void DelBill(Bill bill)
        {
            BillDAL.Instance().Del(bill);
        }
        public Bill GetBillById(int id)
        {
            return BillDAL.Instance().GetById(id);
        }
        public List<Bill> SearchBill(DateTime dateInvoice,decimal fromPrice,decimal toPrice)
        {
            List<Bill> bills = new List<Bill>();
            if(fromPrice == 0 && toPrice == 0)
            {
                foreach (var item in BillDAL.Instance().GetList())
                {
                    if(item.Date_invoice.DayOfYear == dateInvoice.DayOfYear)
                    {
                        bills.Add(item);
                    }
                }
            }
            else
            {
                foreach (var item in BillDAL.Instance().GetList())
                {
                    if (item.Date_invoice.DayOfYear == dateInvoice.DayOfYear && item.Total_Price >= fromPrice && item.Total_Price <= toPrice)
                    {
                        bills.Add(item);
                    }
                }
            }

            return bills;
        }
    }
}
