using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace api.Models
{
    public class Comment
    {
        public int Id { get; set; }
        public string Title { get; set; } = string.Empty; 
        public string Content { get; set; } = string.Empty; 
        public DateTime CreatedOn { get; set; } = DateTime.Now;
        public int? StockId { get; set; } //Foreign key
        public Stock? Stock { get; set; } //navigation property to Stock
        // , helps us to interact with the Stock entity through Comment entity
    }
}