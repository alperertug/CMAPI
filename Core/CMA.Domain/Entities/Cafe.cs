using CMA.Domain.Entities.Common;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CMA.Domain.Entities
{
    public class Cafe : BaseEntity
    {
        public string Name { get; set; }
        public string PhoneNumber { get; set; }
        [DataType(DataType.EmailAddress)]
        public string Email { get; set; }
        public string Address { get; set; }
        public string Country { get; set; }
        public string City { get; set; }
        public string District { get; set; }
        public TimeOnly? OpeningTime { get; set; }
        public TimeOnly? ClosingTime { get; set; }
        public bool IsOpen { get; set; } = false;
        public double? Rank { get; set; }
        public string? Image { get; set; }
        public ICollection<CafeUser>? CafeUsers { get; set; }
        public ICollection<Category>? Categories { get; set; }
        public ICollection<Offer>? Offers { get; set; }
        public ICollection<Product>? Products { get; set; }
        public ICollection<Table>? Tables { get; set; }
    }
}
