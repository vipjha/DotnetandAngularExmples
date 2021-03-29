﻿using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using vroom.Models;


namespace vroom.AddDbContext
{
    public class VroomDBContext:IdentityDbContext<IdentityUser>
    {
        public VroomDBContext(DbContextOptions<VroomDBContext> options) : base(options)
        {

        }
         
        public DbSet<Make> Makes { get; set; }
        public DbSet<Model> Models { get; set; }

        public DbSet<ApplicationUser> ApplicationUsers { get; set; }
    }
}
