﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace LCMClient.Features.Shared.Models
{
    public class SponsorModel
    {
        public int SponsorID { get; set; }

        public string FirstName { get; set; } = string.Empty;

        public string LastName { get; set; } = string.Empty;

        public string FullName { get; set; } = string.Empty;

        public string Address { get; set; }

        public string City { get; set; }

        public string State { get; set; }

        public string ZipCode { get; set; }

        public string Email { get; set; }

        public string MainPhone { get; set; }

        public DateTime EntryDate { get; set; }
    }
}
