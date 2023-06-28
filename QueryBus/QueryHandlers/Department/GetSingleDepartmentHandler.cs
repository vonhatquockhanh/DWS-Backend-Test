using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;
using APIDWS.IRepositories;
using APIDWS.Models;
using MediatR;

namespace APIDWS.QueryBus.Queries
{
    public class GetSingleDepartmentHandler : MediatR.IRequestHandler<GetSingleDepartmentQuery, Department>
    {
        private IDepartmentRepository departmentRepository;

        public GetSingleDepartmentHandler(IDepartmentRepository repository)
        {
            departmentRepository = repository;
        }

        public Task<Department> Handle(GetSingleDepartmentQuery request, CancellationToken cancellationToken)
        {
            return Task.Run(() =>
            {
                var department = departmentRepository.GetDepartmentById(request.Id);
                if (department != null)
                {
                    return department;
                };
                return null;
            });
        }
    }
}