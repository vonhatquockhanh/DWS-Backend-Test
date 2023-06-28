using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;
using APIDWS.IRepositories;
using APIDWS.Models;
using MediatR;

namespace APIDWS.QueryBus.Queries
{
    public class GetSingleDesignationHandler : MediatR.IRequestHandler<GetSingleDesignationQuery, Designation>
    {
        private IDesignationRepository designationRepository;

        public GetSingleDesignationHandler(IDesignationRepository repository)
        {
            designationRepository = repository;
        }

        public Task<Designation> Handle(GetSingleDesignationQuery request, CancellationToken cancellationToken)
        {
            return Task.Run(() =>
            {
                var designation = designationRepository.GetDesignationById(request.Id);
                if (designation != null)
                {
                    return designation;
                };
                return null;
            });
        }
    }
}