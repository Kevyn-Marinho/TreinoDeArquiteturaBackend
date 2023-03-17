using ShopKMS.Users.Domain.Entities;
using ShopKMS.Users.Domain.Interfaces;
using ShopKMS.Users.Infra.Context;

namespace ShopKMS.Users.Infra.Repositories
{
    public class UsersRepository : IUsersRepository
    {
        public int CreateUser(User user)
        {
            using(var context = new UsersContext())
            {
                var @newUser = context.Add(user);
                context.SaveChanges();

                return newUser.Entity.Id;
            }
        }
    }
}
