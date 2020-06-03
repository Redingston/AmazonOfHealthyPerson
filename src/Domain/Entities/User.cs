﻿using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.Text;

namespace Domain.Entities
{
    public class User: IdentityUser<long>
    {
        public ICollection<UserToRole> UserToRoles { get; set; }
    }
}
