using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.Text;

namespace Domain.Entities
{
    public class User: IdentityUser<long>
    {
        public UserProfile UserProfile { get; set; }
        public ICollection<UserToRole> UserToRoles { get; set; }
    }
}
