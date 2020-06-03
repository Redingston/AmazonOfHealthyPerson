using System;
using System.Collections.Generic;
using System.Text;

namespace Domain.Entities
{
    public class City
    {
        public City()
        {
            Streets = new HashSet<Street>();
        }
        public long Id { get; set; }
        public string Name { get; set; }
        public uint PostCode { get; set; }
        public ICollection<Street> Streets { get; set; }
        public Country Country { get; set; }
    }
}
