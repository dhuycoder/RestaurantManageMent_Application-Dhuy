using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTOO
{
    [Table("Food")]
    public class Food
    {
        [Key]
        [Column("Id_Food")]
        public int IdFood { get; set; }
        [Column("Name_Food")]
        public string NameFood { get; set; }
       
        public int Id_Category { get; set; }

        [Column("ImageLocation")]
        public string ImageLocation { get; set; }
       
        [ForeignKey("Id_Category")]
        [Required]
        public virtual Category Category { get; set; }  
        public virtual List<FoodSize> FoodSizes { get; set; }
        public Food()
        {

        }
        public Food(int idFood, string nameFood, int idCategory,string imageLocation)
        {
            IdFood=idFood;
            NameFood=nameFood;
            Id_Category= idCategory;
            ImageLocation=imageLocation;
          
        }
    }
}
