using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;
using APIDWS.IRepositories;
using APIDWS.Models;

namespace APIDWS.QueryBus.Queries {
    public class GetAllUserHandler : MediatR.IRequestHandler<GetAllUserQuery, List<User>> {
        private IUserRepository userRepository;

        public GetAllUserHandler (IUserRepository repository) {
            userRepository = repository;
        }

        public Task<List<User>> Handle (GetAllUserQuery request, CancellationToken cancellationToken) {
            return Task.Run (() => {
                return userRepository.GetAllUsers ();
            });
        }
    }
}