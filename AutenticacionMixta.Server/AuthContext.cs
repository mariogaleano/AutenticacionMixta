using System.Data.Entity;
using AutenticacionMixta.Server.Entities;
using Microsoft.AspNet.Identity.EntityFramework;

namespace AutenticacionMixta.Server
{
    public class AuthContext : IdentityDbContext<IdentityUser>
    {
        public AuthContext()
            : base("AuthContext")
        {
     
        }

        public DbSet<Client> Clients { get; set; }
        public DbSet<RefreshToken> RefreshTokens { get; set; }
    }

}