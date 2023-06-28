using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;
using APIDWS.IRepositories;
using APIDWS.Models;

namespace APIDWS.QueryBus.Queries
{
    public class GetAllDepartmentHandler : MediatR.IRequestHandler<GetAllDepartmentQuery, List<Department>>
    {
        private IDepartmentRepository departmentRepository;

        public GetAllDepartmentHandler(IDepartmentRepository repository)
        {
            departmentRepository = repository;
        }

        public Task<List<Department>> Handle(GetAllDepartmentQuery request, CancellationToken cancellationToken)
        {
            return Task.Run(() =>
            {
                return departmentRepository.GetAllDepartments();
            });
        }
    }
}