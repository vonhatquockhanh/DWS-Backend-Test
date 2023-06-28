using System.Collections.Generic;
using APIDWS.Models;

namespace APIDWS.QueryBus
{
    public class GetSingleDepartmentQuery : MediatR.IRequest<Department>
    {
        public GetSingleDepartmentQuery(int id)
        {
            this.Id = id;
        }

        public int Id { get; }
    }
}