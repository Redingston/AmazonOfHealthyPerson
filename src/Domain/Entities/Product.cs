using System;
using System.Collections.Generic;
using System.Text;

namespace Domain.Entities
{
    public class Product
    {
        public Product()
        {
            Photos = new HashSet<Photo>();
            Categories = new HashSet<ProductToCategory>();
            Tags = new HashSet<ProductToTag>();
            Baskets = new HashSet<BasketToProduct>();
        }
        public long Id { get; set; }
        public string Name { get; set; }
        public string FullName { get; set; }
        public ulong Price { get; set; }
        public ushort Amount { get; set; }
        public string Description { get; set; }

        public long BrandId { get; set; }
        public Brand Brand { get; set; }

        public ICollection<Photo> Photos { get; set; }
        public PTechnicalDetail TechicalDetail { get; set; }
        public PAdditionalInformaion AdditionalInformaion { get; set; }

        public ICollection<BasketToProduct> Baskets { get; set; }
        public ICollection<ProductToCategory> Categories { get; set; }
        public ICollection<ProductToTag> Tags { get; set; }
    }
}
