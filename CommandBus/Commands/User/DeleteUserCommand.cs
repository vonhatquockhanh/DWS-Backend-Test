using APIDWS.Models;
using MediatR;

namespace APIDWS.CommandBus.Commands {
    public class DeleteUserCommand : IRequest<User> {
        public DeleteUserCommand (User user) {
            User = user;
        }
        public User User { get; }
    }
}