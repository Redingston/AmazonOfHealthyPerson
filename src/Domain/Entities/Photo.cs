using System;
using System.Collections.Generic;
using System.Text;

namespace Domain.Entities
{
    public class Photo
    {
        public long Id { get; set; }
        public string Data { get; set; }

        public Product Product { get; set; }
    }
}
