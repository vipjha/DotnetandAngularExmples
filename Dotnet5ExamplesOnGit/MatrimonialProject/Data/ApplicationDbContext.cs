using MatrimonialProject.Models;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace MatrimonialProject.Data
{
    public class ApplicationDbContext : IdentityDbContext<ApplicationUser>
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {

        }

        public  DbSet<Message> Messages { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Message>().HasKey(sc => new { sc.SenderId, sc.ReciverId });

            modelBuilder.Entity<Message>().HasOne(s => s.Sender)
                .WithMany(m => m.SentMessage)
                .HasForeignKey(k => k.SenderId)
                .OnDelete(DeleteBehavior.ClientSetNull);

            modelBuilder.Entity<Message>().HasOne(s => s.Receiver)
                .WithMany(m => m.RecivedMessage)
                .HasForeignKey(k => k.ReciverId)
                .OnDelete(DeleteBehavior.ClientSetNull);


            base.OnModelCreating(modelBuilder);
        }
    }
}
