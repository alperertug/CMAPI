using CMA.Domain.Entities.Common;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CMA.Domain.Entities
{
    public class Offer : BaseEntity
    {
        public string Name { get; set; }
        public string Description { get; set; }
        public double Discount { get; set; }
        public double Price { get; set; }
        public string? Image { get; set; }
        public Cafe Cafe { get; set; }
        public ICollection<Product> Products { get; set; }
    }
}
