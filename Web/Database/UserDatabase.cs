using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Web.Database
{
    public class UserDatabase : IdentityDbContext
    {
        public UserDatabase(DbContextOptions<UserDatabase> options) : base(options)
        {

        }
    }

}
