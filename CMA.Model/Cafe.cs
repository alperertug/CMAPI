using CMA.Model.Abstract;
using CMA.Model.ManyToMany;
using System.ComponentModel.DataAnnotations;

namespace CMA.Model
{
    public class Cafe : ModelBase
    {
        public string Name { get; set; }
        public string PhoneNumber { get; set; }
        [DataType(DataType.EmailAddress)]
        public string Email { get; set; }
        public string Address { get; set; }
        public string Country { get; set; }
        public string City { get; set; }
        public string District { get; set; }
        public TimeOnly OpeningTime { get; set; }
        public TimeOnly ClosingTime { get; set; }
        public bool IsOpen { get; set; } = false;
        public double? Rating { get; set; }
        public string? Image { get; set; }
        public ICollection<CafeCustomer>? CafeCustomers { get; set; } 
        public ICollection<CafeUser>? CafeUsers { get; set; } 
        public ICollection<Category>? Categories { get; set; }
        public ICollection<Offer>? Offers { get; set; }
        public ICollection<Product>? Products { get; set; }
        public ICollection<Table>? Tables { get; set; }
    }
}
