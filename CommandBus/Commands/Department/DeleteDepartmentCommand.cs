using APIDWS.Models;
using MediatR;

namespace APIDWS.CommandBus.Commands
{
    public class DeleteDepartmentCommand : IRequest<Department>
    {
        public DeleteDepartmentCommand(Department department)
        {
            Department = department;
        }
        public Department Department { get; }
    }
}