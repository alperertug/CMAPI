using CMA.Model.Abstract;
using CMA.Model.ManyToMany;
using System.ComponentModel.DataAnnotations;

namespace CMA.Model
{
    public class Customer : ModelBase
    {
        public string UserName { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string? PhoneNumber { get; set; }
        [DataType(DataType.EmailAddress)]
        public string Email { get; set; }
        public int? Score { get; set; }
        public string? Image { get; set; }
        public ICollection<CafeCustomer>? CafeCustomers { get; set; }
        public ICollection<Order>? Orders { get; set; }
    }
}
