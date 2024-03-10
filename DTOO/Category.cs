using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTOO
{
    [Table("Category")]
    public class Category
    {
        [Key]
        [Column("Id_Category")]
        public int CategoryId {get;set; }
        [Column("Name_Category")]
        public string CategoryName { get;set; }
        [Column("Image_Category")]
        public string CategoryImageLocation { get;set; }

        public Category() { }
        public Category(int CategoryId, string CategoryName)
        {
            this.CategoryId = CategoryId;
            this.CategoryName = CategoryName;
        }
    }
}
