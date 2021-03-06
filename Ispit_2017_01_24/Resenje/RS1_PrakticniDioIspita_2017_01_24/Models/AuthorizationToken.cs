﻿using System;
using System.ComponentModel.DataAnnotations.Schema;

namespace RS1_PrakticniDioIspita_2017_01_24.Models
{
    public class AuthorizationToken
    {
        public int Id { get; set; }
        public string Value { get; set; }

        [ForeignKey(nameof(User))]
        public int UserId { get; set; }
        public User User { get; set; }

        public DateTime DateCreated { get; set; }
        public string IpAddress { get; set; }
    }
}