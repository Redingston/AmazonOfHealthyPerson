using System;
using System.Collections.Generic;
using System.Text;

namespace Domain.Entities
{
    public class PTag
    {
        public PTag()
        {
            Products = new HashSet<ProductToTag>();
        }
        public long Id { get; set; }
        public string Name { get; set; }

        public ICollection<ProductToTag> Products { get; set; }
    }
}
