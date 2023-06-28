using APIDWS.Models;
using MediatR;

namespace APIDWS.CommandBus.Commands {
    public class UpdateEmployeeCommand : IRequest<Employee> {
        public UpdateEmployeeCommand (Employee employee) {
            Employee = employee;
        }
        public Employee Employee { get; }
    }
}