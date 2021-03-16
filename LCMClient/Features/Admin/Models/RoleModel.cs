namespace LCMClient.Features.Admin.Models
{
    public class RoleModel
    {
        public string RoleName { get; set; }

        public string DisplayName { get; set; }

        public string RoleDescription { get; set; }

        public static string AdminRole { get; } = "Admin";
        public static string StaffRole { get; } = "Staff";
        public static string GuestRole { get; } = "Guest";
        public static string NarrationApproverRole { get; } = "NarrationApprover";
        public static string OrphanReadWriteRole { get; } = "OrphanReadWrite";
        public static string GuardianReadWriteRole { get; } = "GuardianReadWrite";
        public static string SponsorReadWriteRole { get; } = "SponsorReadWrite";
        public static string OrphanReadOnlyRole { get; } = "OrphanReadOnly";
        public static string GuardianReadOnlyRole { get; } = "GuardianReadOnly";
        public static string SponsorReadOnlyRole { get; } = "SponsorReadOnly";
    }
}
