using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace LCMClient.Features.Sponsors.Models
{
    public class SponsorCreationModel
    {
        public string FirstName { get; set; } = string.Empty;

        public string LastName { get; set; } = string.Empty;

        public string Address { get; set; }

        public string City { get; set; }

        public string State { get; set; }

        public string ZipCode { get; set; }

        //[Email(ErrorMessage = "Invalid email address.")]
        public string Email { get; set; }

        //[Phone(ErrorMessage = "Invalid phone number.")]
        public string MainPhone { get; set; }
    }
}
