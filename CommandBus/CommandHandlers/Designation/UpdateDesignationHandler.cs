using System.Threading;
using System.Threading.Tasks;
using APIDWS.CommandBus.Commands;
using APIDWS.IRepositories;
using APIDWS.Models;
using MediatR;

namespace APIDWS.CommandBus
{

    public class UpdateDesignationHandler : IRequestHandler<UpdateDesignationCommand, Designation>
    {
        private readonly IDesignationRepository _designationRepository;
        public UpdateDesignationHandler(IDesignationRepository designationRepository)
        {
            this._designationRepository = designationRepository;
        }

        public async Task<Designation> Handle(UpdateDesignationCommand request, CancellationToken cancellationToken)
        {
            return await _designationRepository.UpdateDesignation(request.Designation);
        }
    }
}