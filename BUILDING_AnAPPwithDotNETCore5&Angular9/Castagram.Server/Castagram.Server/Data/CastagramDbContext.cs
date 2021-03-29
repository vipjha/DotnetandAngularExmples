using Castagram.Server.Models;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace Castagram.Server.Data
{
    public class CastagramDbContext : IdentityDbContext<User>
    {
        public CastagramDbContext(DbContextOptions<CastagramDbContext> options)
            : base(options)
        {
        }
    }
}
