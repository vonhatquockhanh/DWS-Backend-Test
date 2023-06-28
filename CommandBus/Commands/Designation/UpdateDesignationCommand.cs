using APIDWS.Models;
using MediatR;

namespace APIDWS.CommandBus.Commands
{
    public class UpdateDesignationCommand : IRequest<Designation>
    {
        public UpdateDesignationCommand(Designation designation)
        {
            Designation = designation;
        }
        public Designation Designation { get; }
    }
}