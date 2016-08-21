using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;

namespace CNS_ERP.Models
{
    // Add profile data for application users by adding properties to the ApplicationUser class
    public class ApplicationUser : IdentityUser
    {
        public virtual InformacjeUzytkownika informacjeUzytkownika { get; set; }
    }
    public class ApplicationRole : IdentityRole
    {
    }
}
