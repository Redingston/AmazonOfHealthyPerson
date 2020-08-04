using System;
using System.Collections.Generic;
using System.Text;

namespace Domain.Entities
{
   public  class PAdditionalInformaion
    {
        public long Id { get; set; }

        public long ProductId { get; set; }
        public Product Product { get; set; }
    }
}
