using System.Threading;
using System.Threading.Tasks;
using APIDWS.CommandBus.Commands;
using APIDWS.IRepositories;
using APIDWS.Models;
using MediatR;

namespace APIDWS.CommandBus
{

    public class UpdateDepartmentHandler : IRequestHandler<UpdateDepartmentCommand, Department>
    {
        private readonly IDepartmentRepository _departmentRepository;
        public UpdateDepartmentHandler(IDepartmentRepository departmentRepository)
        {
            this._departmentRepository = departmentRepository;
        }

        public async Task<Department> Handle(UpdateDepartmentCommand request, CancellationToken cancellationToken)
        {
            return await _departmentRepository.UpdateDepartment(request.Department);
        }
    }
}