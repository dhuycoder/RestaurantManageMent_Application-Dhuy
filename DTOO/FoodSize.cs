using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTOO
{
    [Table("FoodSize")]
    public class FoodSize
    {
        [Key]
        [Column("Id_Size")]
        public int SizeId { get; set; }
        [Column("Size_Name")]
        public string SizeName { get; set; }
        [Column("Price_Size")]
        public decimal SizePrice { get; set;}
        [Column("Id_Food")]
        public int IdFood { get; set; }
        [ForeignKey("IdFood")]
        [Required]
        public virtual Food Food { get; set; }
        public FoodSize() { }
        public FoodSize(int sizeId, string sizeName, int idFood, decimal sizePrice)
        {
            SizeId=sizeId;
            SizeName=sizeName;
            IdFood = idFood;
            SizePrice=sizePrice;
        }
    }
}
