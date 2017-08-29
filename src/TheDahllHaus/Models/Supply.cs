using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;


namespace TheDahllHaus.Models
{
    [Table("Supplies")]
    public class Supply
    {
        [Key]
        public int SupplyId { get; set; }
        public string Name { get; set; }
        public string Type { get; set; }
        public string Color { get; set; }
        public string Theme { get; set; }
        public string Amount { get; set; }
        public string Description { get; set; }
    }
}
