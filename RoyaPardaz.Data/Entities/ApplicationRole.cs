using Microsoft.AspNetCore.Identity;
using System;

namespace RoyaPardaz.Data.Entities
{
    public class ApplicationRole : IdentityRole<Guid>
    {

        public string Descriptions { get; set; }


    }
}
