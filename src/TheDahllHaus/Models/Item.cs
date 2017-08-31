using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace TheDahllHaus.Models
{
    [Table("Items")]
    public class Item
    {
        [Key]
        public int ItemId { get; set; }
        public string Name { get; set; }
        public string Image { get; set; }
        public string Price { get; set; }
        public string Description { get; set; }
        public bool Sale { get; set; }
        public int ShopId { get; set; }
        public virtual Shop Shop { get; set; }
        public int CategoryId { get; set; }
        public virtual Category Category { get; set; }
    }
}
