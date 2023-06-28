using System;
using System.Collections.Generic;
using System.Linq;
using APIDWS.IRepositories;
using APIDWS.Models;
using FluentValidation;

namespace APIDWS.ModelsValidator
{

    public class DesignationValidator : AbstractValidator<Designation>
    {

        private readonly IDesignationRepository _designationRepository;
        public DesignationValidator(IDesignationRepository designationRepository)
        {
            _designationRepository = designationRepository;

            RuleFor(designation => designation.Name).NotNull().WithMessage("Please give designation name");
            RuleFor(designation => designation.Code).Must(IsCodeUnique).WithMessage("Code Already Exists, Please give a new code");
        }

        public bool IsCodeUnique(Designation editedUser, string newValue)
        {
            var designationSearchByCode = _designationRepository.GetDesignationByCode(newValue);
            if (designationSearchByCode == null)
                return true;
            return false;
        }
    }
}