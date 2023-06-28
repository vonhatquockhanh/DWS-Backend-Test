using System.Threading;
using System.Threading.Tasks;
using APIDWS.CommandBus.Commands;
using APIDWS.IRepositories;
using APIDWS.Models;
using MediatR;

namespace APIDWS.CommandBus
{

    public class DeleteDepartmentHandler : IRequestHandler<DeleteDepartmentCommand, Department>
    {
        private readonly IDepartmentRepository _departmentRepository;
        public DeleteDepartmentHandler(IDepartmentRepository departmentRepository)
        {
            this._departmentRepository = departmentRepository;
        }

        public async Task<Department> Handle(DeleteDepartmentCommand request, CancellationToken cancellationToken)
        {
            return await _departmentRepository.DeleteDepartment(request.Department);
        }
    }
}