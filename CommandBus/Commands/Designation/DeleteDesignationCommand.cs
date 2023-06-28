using APIDWS.Models;
using MediatR;

namespace APIDWS.CommandBus.Commands
{
    public class DeleteDesignationCommand : IRequest<Designation>
    {
        public DeleteDesignationCommand(Designation designation)
        {
            Designation = designation;
        }
        public Designation Designation { get; }
    }
}