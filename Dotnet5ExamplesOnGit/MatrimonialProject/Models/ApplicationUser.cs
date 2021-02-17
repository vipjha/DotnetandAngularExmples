using Matrimonial;
using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MatrimonialProject.Models
{
    public class ApplicationUser:IdentityUser
    {
        public string Name { get; set; }
        public string City { get; set; }
        public DateTime BirthDate { get; set; }
        public int Age { get; set; }
        public Gender Gender { get; set; }
        public string Cast { get; set; }
        public string Ocupations { get; set; }
        public double Salay { get; set; }
        public MatrialStatus MatrialStatus { get; set; }
        public Relegion Relegion { get; set; }
        public string ImagePath { get; set; }
        public ICollection<Message> SentMessage { get; set; }
        public ICollection<Message> RecivedMessage { get; set; }

    }
}

namespace Matrimonial
{
    public  enum Gender
    {
        Male,
        Female
    }

    public enum MatrialStatus
    {
        Single,
        Divorced
    }
    public enum Relegion
    {
        Hindu,
        Sikh,
        Muslim

    }
}
