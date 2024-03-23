using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTOO
{
    public class Food_Order
    {
        [Key]
        public int Id_Order {get;set;}
        public int Id_Food { get;set;}
        public string Size_Food { get;set;}
        public decimal Price { get;set;}
        public int Count_Food { get;set;}   
        public int Id_Bill { get;set;}
        [ForeignKey("Id_Bill")]
        public Bill Bill {  get;set;}
        [ForeignKey("Id_Food")]
        public Food Food { get;set;}

    }
}
