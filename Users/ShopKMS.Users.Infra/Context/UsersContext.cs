using Microsoft.EntityFrameworkCore;
using ShopKMS.Users.Domain.Entities;

namespace ShopKMS.Users.Infra.Context
{
    public class UsersContext: DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(
                @"Server=localhost,1433;Database=ShopKMSUsers;UID=sa;PWD=yourStrong(!)Password;Trusted_Connection=True");
        }

        public DbSet<User> UsersDb { get; set; }

    }
}
