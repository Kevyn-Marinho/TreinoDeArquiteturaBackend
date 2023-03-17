using ShopKMS.Users.Domain.Entities;

namespace ShopKMS.Users.Domain.Interfaces
{
    public interface IUsersRepository
    {
        public int CreateUser(User user);
    }
}
