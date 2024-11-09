using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CMA.Domain.Entities.Common
{
    public class BaseEntity
    {
        public Guid Id { get; set; }
        public string CreatedBy { get; set; } = "Admin";
        public string? UpdatedBy { get; set; }
        public DateTime CreatedTime { get; set; } = DateTime.UtcNow;
        public DateTime? UpdatedTime { get; set; }
        public bool isDeleted { get; set; } = false;
    }
}
