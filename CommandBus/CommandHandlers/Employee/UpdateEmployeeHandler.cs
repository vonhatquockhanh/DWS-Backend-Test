using System.Threading;
using System.Threading.Tasks;
using APIDWS.CommandBus.Commands;
using APIDWS.IRepositories;
using APIDWS.Models;
using MediatR;

namespace APIDWS.CommandBus {

    public class UpdateEmployeeHandler : IRequestHandler<UpdateEmployeeCommand, Employee> {
        private readonly IEmployeeRepository _employeeRepository;
        public UpdateEmployeeHandler (IEmployeeRepository employeeRepository) {
            this._employeeRepository = employeeRepository;
        }

        public async Task<Employee> Handle (UpdateEmployeeCommand request, CancellationToken cancellationToken) {
            return await _employeeRepository.UpdateEmployee (request.Employee);
        }
    }
}