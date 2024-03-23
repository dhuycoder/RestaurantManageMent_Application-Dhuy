using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTOO
{
    [Table("Voucher")]
    public class Voucher
    {
        [Key]
        [Column("Id_Voucher")]
        public int VoucherId { get; set; }
        [Column("Code")]
        public string Code { get; set;}
        [Column("Discount")]
        public decimal Discount { get; set; }
        [Column("Due_Date")]
        public DateTime Due { get; set; }
        [Column("Start_Date")]
        public DateTime Start_Date { get; set; }
        [Column("Min_Price")]
        public decimal Min_Price {  get; set; }
    }
}
