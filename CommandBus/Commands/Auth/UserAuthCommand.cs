using APIDWS.ViewModel;
using MediatR;

namespace APIDWS.CommandBus.Commands {
    public class UserAuthCommand : IRequest<TokenViewModel> {
        public string Email { get; set; }
        public string Password { get; set; }
    }
}