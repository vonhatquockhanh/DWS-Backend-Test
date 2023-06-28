using APIDWS.Models;
using MediatR;

namespace APIDWS.CommandBus.Commands {
    public class CreateEmployeeCommand : IRequest<Employee> {
        public CreateEmployeeCommand (Employee employee) {
            Employee = employee;
        }
        public Employee Employee { get; }
    }
}