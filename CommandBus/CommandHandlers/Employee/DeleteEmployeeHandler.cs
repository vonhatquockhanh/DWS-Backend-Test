using System.Threading;
using System.Threading.Tasks;
using APIDWS.CommandBus.Commands;
using APIDWS.IRepositories;
using APIDWS.Models;
using MediatR;

namespace APIDWS.CommandBus {

    public class DeleteEmployeeHandler : IRequestHandler<DeleteEmployeeCommand, Employee> {
        private readonly IEmployeeRepository _employeeRepository;
        public DeleteEmployeeHandler (IEmployeeRepository employeeRepository) {
            this._employeeRepository = employeeRepository;
        }

        public async Task<Employee> Handle (DeleteEmployeeCommand request, CancellationToken cancellationToken) {
            return await _employeeRepository.DeleteEmployee (request.Employee);
        }
    }
}