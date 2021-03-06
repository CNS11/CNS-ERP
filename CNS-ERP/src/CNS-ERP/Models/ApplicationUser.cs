﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;

namespace CNSS_ERP.DAL.Models
{
    // Add profile data for application users by adding properties to the ApplicationUser class
    public class ApplicationUser : IdentityUser
    {
        public virtual UserAdditionalInfos userAdditionalInfos { get; set; }
    }
    public class ApplicationRole : IdentityRole
    {
    }
}
