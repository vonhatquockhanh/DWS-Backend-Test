using APIDWS.Models;
using APIDWS.ViewModel;
using MediatR;

namespace APIDWS.CommandBus {
    public class UserRegisterCommand : IRequest<User> {
        public User User { get; }

        public UserRegisterCommand (User user) {
            User = user;
        }
    }
}