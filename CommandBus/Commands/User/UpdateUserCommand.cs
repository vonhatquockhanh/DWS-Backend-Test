using APIDWS.Models;
using MediatR;

namespace APIDWS.CommandBus.Commands {
    public class UpdateUserCommand : IRequest<User> {
        public UpdateUserCommand (User user) {
            User = user;
        }
        public User User { get; }
    }
}