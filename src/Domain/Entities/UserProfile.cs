using System;
using System.Collections.Generic;
using System.Text;

namespace Domain.Entities
{
    public class UserProfile
    {
        public long Id { get; set; }
        public string Name { get; set; }
        public string SecondName { get; set; }
        public string MiddleName { get; set; }
        public string Phone { get; set; }
        public string Photo { get; set; }

        public User User { get; set; }

        public long CountryId { get; set; }
        public Country Country { get; set; }
        public City City { get; set; }
    }
}
