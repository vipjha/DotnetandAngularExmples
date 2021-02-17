﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MatrimonialProject.Models
{
    public class Message
    {
        public string Content { get; set; }
        public string SenderId { get; set; }
        public string ReciverId { get; set; }
        public ApplicationUser Sender { get; set; }
        public ApplicationUser Receiver { get; set; }
    }
}
