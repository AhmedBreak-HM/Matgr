using Microsoft.AspNetCore.Identity;

namespace Matgr.IdentityServer.Models
{
    public class ApplicationUser : IdentityUser
    {
        public string FristName { set; get; }

        public string LastName { set; get; }
    }
}
