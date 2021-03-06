﻿using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.Text;

namespace Domain.Entities
{
    public class Country
    {
        public Country()
        {
            Cities = new HashSet<City>();
            Brands = new HashSet<Brand>();
            UserProfiles = new HashSet<UserProfile>();
        }
        public long Id { get; set; }
        public string Name { get; set; }

        public ICollection<UserProfile> UserProfiles { get; set; }
        public ICollection<City> Cities { get; set; }
        public ICollection<Brand> Brands { get; set; }
    }
}
