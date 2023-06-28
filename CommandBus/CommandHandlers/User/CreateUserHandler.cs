using System.Threading;
using System.Threading.Tasks;
using APIDWS.CommandBus.Commands;
using APIDWS.IRepositories;
using APIDWS.Models;
using MediatR;

namespace APIDWS.CommandBus {

    public class CreateUserHandler : IRequestHandler<CreateUserCommand, User> {
        private readonly IUserRepository _userRepository;
        public CreateUserHandler (IUserRepository userRepository) {
            this._userRepository = userRepository;
        }

        public async Task<User> Handle (CreateUserCommand request, CancellationToken cancellationToken) {
            return await _userRepository.CreateUser (request.User);
        }
    }
}