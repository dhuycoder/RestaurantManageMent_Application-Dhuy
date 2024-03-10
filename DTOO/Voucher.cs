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
        [Column("Discount_percent")]
        public int Discount { get; set; }
    }
}
