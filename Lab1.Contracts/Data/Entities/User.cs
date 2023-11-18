using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Identity;

namespace Lab1.Contracts.Data.Entities
{
    public class User : IdentityUser, IBaseEntity
    {
        public string Name { get; set; }
        public string Surname { get; set; }
        public DateTime Birthday { get; set; }
        public string ImageAvatarUrl { get; set; }
    }
}
