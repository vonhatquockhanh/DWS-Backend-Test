using APIDWS.Models;
using MediatR;

namespace APIDWS.CommandBus.Commands
{
    public class UpdateDepartmentCommand : IRequest<Department>
    {
        public UpdateDepartmentCommand(Department department)
        {
            Department = department;
        }
        public Department Department { get; }
    }
}