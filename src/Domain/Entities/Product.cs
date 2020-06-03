using System;
using System.Collections.Generic;
using System.Text;

namespace Domain.Entities
{
    public class Product
    {
        public Product()
        {
            Photos = new List<string>();
            Categories = new HashSet<PCategory>();
            Tags = new HashSet<PTag>();
        }
        public long Id { get; set; }
        public string Name { get; set; }
        public string FullName { get; set; }
        public ulong Price { get; set; }
        public string Description { get; set; }
        public List<string> Photos { get; set; }

        public long BrandId { get; set; }
        public Brand Brand { get; set; }

        public long CategoryId { get; set; }
        public ICollection<PCategory> Categories { get; set; }

        public long TagId { get; set; }
        public ICollection<PTag> Tags { get; set; }

        public PTechicalDetail TechicalDetail { get; set; }
        public PAdditionalInformaion AdditionalInformaion { get; set; }
    }
}
