using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;
using APIDWS.IRepositories;
using APIDWS.Models;

namespace APIDWS.QueryBus.Queries
{
    public class GetAllDesignationHandler : MediatR.IRequestHandler<GetAllDesignationQuery, List<Designation>>
    {
        private IDesignationRepository designationRepository;

        public GetAllDesignationHandler(IDesignationRepository repository)
        {
            designationRepository = repository;
        }

        public Task<List<Designation>> Handle(GetAllDesignationQuery request, CancellationToken cancellationToken)
        {
            return Task.Run(() =>
            {
                return designationRepository.GetAllDesignations();
            });
        }
    }
}