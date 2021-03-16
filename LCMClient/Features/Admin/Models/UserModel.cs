using System.Collections.Generic;
using System.Linq;

namespace LCMClient.Features.Admin.Models
{
    public class UserModel
    {
        public string UserID { get; set; }

        public string FirstName { get; set; }

        public string LastName { get; set; }

        public string Email { get; set; }

        public List<RoleModel> Roles { get; set; }

        public string RolesForDisplay
        {
            get
            {
                return string.Join(", ", Roles.Select(x => x.DisplayName));
            }
        }
    }
}
