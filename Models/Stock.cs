using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace api.Models
{
    public class Stock
    {
        public int Id { get; set; }
        public string Symbol { get; set; } = string.Empty; //prevent NullReferenceException
        public string Company { get; set; } = string.Empty;
        [Column(TypeName = "decimal(18,2)")] // allow 18 digits with 2 decimal places
        public decimal Purchase { get; set; }
        [Column(TypeName = "decimal(18,2)")]
        public decimal LastDiv { get; set; }
        public string Industry { get; set; } = string.Empty;
        public long MarketCap { get; set; } //the total value of a company's shares currently in circulation

        public List<Comment> Comments { get; set; } = new List<Comment>();
        
    }
}