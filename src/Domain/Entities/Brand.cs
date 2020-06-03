﻿using System;
using System.Collections.Generic;
using System.Text;

namespace Domain.Entities
{
    public class Brand
    {
        public long Id { get; set; }
        public string Name { get; set; }
        public string FullName { get; set; }

        public string CountryRegistration { get; set; }
        public Country Country { get; set; }
    }
}
