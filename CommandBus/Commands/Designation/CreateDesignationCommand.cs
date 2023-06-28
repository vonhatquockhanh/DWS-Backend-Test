using APIDWS.Models;
using MediatR;

namespace APIDWS.CommandBus.Commands
{
    public class CreateDesignationCommand : IRequest<Designation>
    {
        public CreateDesignationCommand(Designation designation)
        {
            Designation = designation;
        }
        public Designation Designation { get; }
    }
}