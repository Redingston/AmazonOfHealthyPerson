using System;
using System.Collections.Generic;
using System.Text;

namespace Domain.Entities
{
    public class Brand
    {
        public Brand()
        {
            Products = new HashSet<Product>();
        }
        public long Id { get; set; }
        public string Name { get; set; }
        public string FullName { get; set; }

        public long CountryRegistrationId { get; set; }
        public Country Country { get; set; }

        public ICollection<Product> Products { get; set; }
    }
}
