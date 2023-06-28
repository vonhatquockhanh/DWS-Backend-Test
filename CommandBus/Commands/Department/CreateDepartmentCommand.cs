using APIDWS.Models;
using MediatR;

namespace APIDWS.CommandBus.Commands
{
    public class CreateDepartmentCommand : IRequest<Department>
    {
        public CreateDepartmentCommand(Department department)
        {
            Department = department;
        }
        public Department Department { get; }
    }
}