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
            UserProfiles = new HashSet<UserProfile>();
        }
        public long Id { get; set; }
        public string Name { get; set; }
        public string PostCode { get; set; }

        public long CountryId { get; set; }
        public Country Country { get; set; }

        public ICollection<UserProfile> UserProfiles { get; set; }

        public ICollection<Street> Streets { get; set; }
    }
}
