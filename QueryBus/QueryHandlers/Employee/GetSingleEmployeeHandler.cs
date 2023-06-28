using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;
using APIDWS.IRepositories;
using APIDWS.Models;
using MediatR;

namespace APIDWS.QueryBus.Queries {
    public class GetSingleEmployeeHandler : MediatR.IRequestHandler<GetSingleEmployeeQuery, Employee> {
        private IEmployeeRepository employeeRepository;

        public GetSingleEmployeeHandler (IEmployeeRepository repository) {
            employeeRepository = repository;
        }

        public Task<Employee> Handle (GetSingleEmployeeQuery request, CancellationToken cancellationToken) {
            return Task.Run (() => {
                var employee = employeeRepository.GetEmployeeById (request.Id);
                if (employee != null) {
                    return employee;
                };
                return null;
            });
        }
    }
}