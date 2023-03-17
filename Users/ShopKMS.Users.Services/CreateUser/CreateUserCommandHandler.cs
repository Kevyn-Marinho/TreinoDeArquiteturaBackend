using MediatR;
using ShopKMS.Users.Domain.Interfaces;
using ShopKMS.Users.Domain.Entities;
using Mapster;

namespace ShopKMS.Users.Services.CreateUser
{

    public class CreateUserCommandHandler : IRequestHandler<CreateUserCommand, int>
    {
        private readonly IUsersRepository _repository;

        public CreateUserCommandHandler(IUsersRepository repository)
        {
            _repository = repository;
        }

        public Task<int> Handle(CreateUserCommand request, CancellationToken cancellationToken)
        {
            var user = request.Adapt<User>();

            int id = _repository.CreateUser(user);

            return Task.FromResult(id);
        }
    }
}
