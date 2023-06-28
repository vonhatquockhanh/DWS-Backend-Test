using APIDWS.Models;
using MediatR;

namespace APIDWS.CommandBus.Commands {
    public class CreateUserCommand : IRequest<User> {
        public CreateUserCommand (User user) {
            User = user;
        }
        public User User { get; }
    }
}