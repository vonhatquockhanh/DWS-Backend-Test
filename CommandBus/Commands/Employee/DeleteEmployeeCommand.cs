using APIDWS.Models;
using MediatR;

namespace APIDWS.CommandBus.Commands {
    public class DeleteEmployeeCommand : IRequest<Employee> {
        public DeleteEmployeeCommand (Employee employee) {
            Employee = employee;
        }
        public Employee Employee { get; }
    }
}