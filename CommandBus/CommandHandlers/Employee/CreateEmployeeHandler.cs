using System.Threading;
using System.Threading.Tasks;
using APIDWS.CommandBus.Commands;
using APIDWS.IRepositories;
using APIDWS.Models;
using MediatR;

namespace APIDWS.CommandBus {

    public class CreateEmployeeHandler : IRequestHandler<CreateEmployeeCommand, Employee> {
        private readonly IEmployeeRepository _employeeRepository;
        public CreateEmployeeHandler (IEmployeeRepository employeeRepository) {
            this._employeeRepository = employeeRepository;
        }

        public async Task<Employee> Handle (CreateEmployeeCommand request, CancellationToken cancellationToken) {
            return await _employeeRepository.CreateEmployee (request.Employee);
        }
    }
}