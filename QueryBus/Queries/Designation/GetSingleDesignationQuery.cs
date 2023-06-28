using System.Collections.Generic;
using APIDWS.Models;

namespace APIDWS.QueryBus
{
    public class GetSingleDesignationQuery : MediatR.IRequest<Designation>
    {
        public GetSingleDesignationQuery(int id)
        {
            this.Id = id;
        }

        public int Id { get; }
    }
}