using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.Text;

namespace Domain.Entities
{
    public class Role: IdentityRole<long>
    {
        public ICollection<UserToRole> UserToRoles { get; set; }
    }
}
