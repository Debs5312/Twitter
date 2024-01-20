using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using Model;

namespace Persistance
{
    public class UserContext : IdentityDbContext<AppUser>
    {
        public UserContext(DbContextOptions options) : base(options)
        {

        }
        protected override void OnConfiguring(DbContextOptionsBuilder dbContextOptionsBuilder)
        {
            Connection connection = new Connection();
            dbContextOptionsBuilder.UseSqlServer(connection.ConnectionString);
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            var hasher = new PasswordHasher<AppUser>();

            modelBuilder.Entity<AppUser>().HasData(
                new AppUser {
                    DisplayName = "Deb",
                    UserName = "deb",
                    Email = "debojyotisaha5@gmail.com",
                    NormalizedEmail = "DEBOJYOTISAHA5@GMAIL.COM",
                    NormalizedUserName = "DEB",
                    PasswordHash = hasher.HashPassword(null, "Deb@123")
                },
                new AppUser {
                    DisplayName = "Debojyoti",
                    UserName = "debs5312",
                    Email = "debs5312@gmail.com",
                    NormalizedEmail = "DEBS5312@GMAIL.COM",
                    NormalizedUserName = "DEBS5312",
                    PasswordHash = hasher.HashPassword(null, "Debojyoti@123")
                },
                new AppUser {
                    DisplayName = "Jaya",
                    UserName = "jaya",
                    Email = "jayasaha69@gmail.com",
                    NormalizedEmail = "JAYASAHA69@GMAIL.COM",
                    NormalizedUserName = "JAYA",
                    PasswordHash = hasher.HashPassword(null, "Jaya@123")
                }
            );
            base.OnModelCreating(modelBuilder);
        }
    }
}