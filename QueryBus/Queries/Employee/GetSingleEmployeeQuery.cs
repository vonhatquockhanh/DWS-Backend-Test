using System.Collections.Generic;
using APIDWS.Models;

namespace APIDWS.QueryBus.Queries {
    public class GetSingleEmployeeQuery : MediatR.IRequest<Employee> {
        public GetSingleEmployeeQuery (int id) {
            this.Id = id;
        }

        public int Id { get; }
    }
}