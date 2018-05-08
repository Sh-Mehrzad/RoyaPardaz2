using Microsoft.AspNetCore.Identity;
using System;

namespace RoyaPardaz.Data.Entities
{
    public class ApplicationUser : IdentityUser<Guid>
    {
        public string Name { get; set; }
        public string Family { get; set; }        
        public string CellPhone { get; set; }
                
    }
}
