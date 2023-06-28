using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;
using APIDWS.IRepositories;
using APIDWS.Models;

namespace APIDWS.QueryBus.Queries {
    public class GetAllEmployeeHandler : MediatR.IRequestHandler<GetAllEmployeeQuery, List<Employee>> {
        private IEmployeeRepository employeeRepository;

        public GetAllEmployeeHandler (IEmployeeRepository repository) {
            employeeRepository = repository;
        }

        public Task<List<Employee>> Handle (GetAllEmployeeQuery request, CancellationToken cancellationToken) {
            return Task.Run (() => {
                return employeeRepository.GetAllEmployees ();
            });
        }
    }
}