﻿using CMA.Model.Abstract;
using CMA.Model.ManyToMany;
using System.ComponentModel.DataAnnotations.Schema;

namespace CMA.Model
{
    public class Offer : ModelBase
    {
        public string Name { get; set; }
        public string Description { get; set; }
        public string? Image { get; set; }
        public int? CafeId { get; set; }
        [ForeignKey("CafeId")]
        public Cafe? Cafe { get; set; }
        public ICollection<OfferProduct>? OfferProducts { get; set; }
    }
}
