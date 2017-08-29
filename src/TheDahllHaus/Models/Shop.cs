using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;


namespace TheDahllHaus.Models
{
    [Table("Shops")]
    public class Shop
    {
        [Key]
        public int ShopId { get; set; }
        public string Name { get; set; }
    }
}
