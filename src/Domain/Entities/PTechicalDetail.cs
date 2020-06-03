using System;
using System.Collections.Generic;
using System.Text;

namespace Domain.Entities
{
    public class PTechicalDetail
    {
        public long Id { get; set; }

        public long CountryId { get; set; }
        public Country CountryProducer { get; set; }
    }
}
