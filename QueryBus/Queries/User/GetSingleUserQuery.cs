using System.Collections.Generic;
using APIDWS.Models;

namespace APIDWS.QueryBus.Queries {
    public class GetSingleUserQuery : MediatR.IRequest<User> {
        public GetSingleUserQuery (int id) {
            this.Id = id;
        }

        public int Id { get; }
    }
}