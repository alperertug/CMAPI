using CMA.Model.Abstract;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace CMA.Model
{
    public class CafeUser : ModelBase
    {
        public string FullName { get; set; }
        [DataType(DataType.EmailAddress)]
        public string Email { get; set; }
        public string PhoneNumber { get; set; }
        public DateOnly JoinDate { get; set; }
        public int? CafeId { get; set; }
        [ForeignKey("CafeId")]
        public Cafe? Cafe { get; set; }
    }
}
