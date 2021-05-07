using static T3.S3Ledger.Web.Enums;

namespace T3.S3Ledger.Web.Models
{
    public partial class UserModel : BaseOrgModel
    {
        public string UserName { get; set; }
        public string Password { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Email { get; set; }
        public Role Role { get; set; }
        public bool Verified { get; set; }
    }
}