using MediatR;

namespace ShopKMS.Users.Services.CreateUser
{
    public class CreateUserCommand  : IRequest<int>
    {
        public string Name { get; set; }
        public string Email { get; set; }
        public string Phone { get; set; }
    }
}
