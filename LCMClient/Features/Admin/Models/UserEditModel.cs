using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace LCMClient.Features.Admin.Models
{
    public class UserEditModel
    {
        [Required(ErrorMessage = "Please enter a first name.")]
        public string FirstName { get; set; }

        public string LastName { get; set; }

        [EmailAddress(ErrorMessage = "Invalid email address.")]
        [Required(ErrorMessage = "Please enter a valid email.")]
        public string Email { get; set; }    

        public List<RoleModel> Roles { get; set; }
    }
}
