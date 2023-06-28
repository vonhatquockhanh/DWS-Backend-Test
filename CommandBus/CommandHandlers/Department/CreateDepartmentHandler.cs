using System.Threading;
using System.Threading.Tasks;
using APIDWS.CommandBus.Commands;
using APIDWS.IRepositories;
using APIDWS.Models;
using MediatR;

namespace APIDWS.CommandBus
{

    public class CreateDepartmentHandler : IRequestHandler<CreateDepartmentCommand, Department>
    {
        private readonly IDepartmentRepository _departmentRepository;
        public CreateDepartmentHandler(IDepartmentRepository departmentRepository)
        {
            this._departmentRepository = departmentRepository;
        }

        public async Task<Department> Handle(CreateDepartmentCommand request, CancellationToken cancellationToken)
        {
            return await _departmentRepository.CreateDepartment(request.Department);
        }
    }
}