using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTOO
{
    public class Bill
    {
        [Key]
        public int Id_Bill {  get; set; }
        public DateTime Date_invoice { get; set; }
        public decimal Sub_Price { get; set; }
        public decimal Total_Price { get;set; }
        public int? Id_Voucher {  get; set; }
        [ForeignKey("Id_Voucher")]
        public Voucher Voucher { get; set; }
 
    }
}
