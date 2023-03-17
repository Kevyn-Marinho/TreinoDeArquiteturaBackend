using Moq;
using ShopKMS.Users.Domain.Entities;
using ShopKMS.Users.Domain.Interfaces;
using ShopKMS.Users.Infra.Repositories;
using ShopKMS.Users.Services.CreateUser;
using System.Threading;
using System.Threading.Tasks;
using Xunit;

namespace ShopKMS.Users.Tests
{
    public class CreateUserCommandHandlerTests
    {
        private readonly Mock<IUsersRepository> _repository;

        public CreateUserCommandHandlerTests()
        {
            _repository = new Mock<IUsersRepository>();

            Setup();
        }

        private void Setup()
        {
            _repository.Setup(e => e.CreateUser(It.IsAny<User>())).Returns(1);
        }

        [Fact]
        public async void ShouldNotCreateEmptyUser()
        {
            // arrange 
            CancellationToken token = new CancellationTokenSource().Token;
            CreateUserCommand command = new CreateUserCommand();
            var handler = new CreateUserCommandHandler(_repository.Object);

            // act
            int id = await handler.Handle(command, token);

            // assert
            Assert.True(id == 0);

        }
    }
}