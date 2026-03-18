using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Books.DAL.Entities.Identity
{
    public class AppUserRoleEntity : IdentityUserRole<string>
    {
        public AppUserEntity? User { get; set; }
        public AppRoleEntity? Role { get; set; }
    }
}
