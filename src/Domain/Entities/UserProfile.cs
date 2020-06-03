using System;
using System.Collections.Generic;
using System.Text;

namespace Domain.Entities
{
    public class UserProfile
    {
        public UserProfile()
        {
            Countries = new HashSet<Country>();
            Cities = new HashSet<City>();
        }
        public long Id { get; set; }
        public string Name { get; set; }
        public string SecondName { get; set; }
        public string MiddleName { get; set; }
        public string Phone { get; set; }
        public string Photo { get; set; }

        public User User { get; set; }

        public long CurrentCountryId { get; set; }
        public ICollection<Country> Countries { get; set; }
        public long CurrentCityId { get; set; }
        public ICollection<City> Cities { get; set; }
    }
}
