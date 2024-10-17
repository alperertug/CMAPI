using CMA.Model.Interface;

namespace CMA.Model.Abstract
{
    public abstract class ModelBase : IModelBase
    {
        public int Id { get; set; }
        public string CreatedBy { get; set; }
        public string? UpdatedBy { get; set; }
        public DateTime CreatedTime { get; set; } = DateTime.Now;
        public DateTime? UpdatedTime { get; set; }
        public bool isDeleted { get; set; } = false;
    }
}
