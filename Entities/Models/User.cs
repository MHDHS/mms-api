﻿using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;

namespace Entities.Models
{
    public class User : IdentityUser
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public bool? IsEnabled { get; set; }
    }
}
