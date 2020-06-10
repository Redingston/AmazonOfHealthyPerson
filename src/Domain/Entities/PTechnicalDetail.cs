using System;
using System.Collections.Generic;
using System.Text;

namespace Domain.Entities
{
    public class PTechnicalDetail
    {
        public long Id { get; set; }

        public long CountryId { get; set; }
        public Country CountryProducer { get; set; }
        public Product Product { get; set; }
    }
}
