using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TransactionStatusApi.Commands;

namespace B2CMpesaApi.Validation.FluentValidation
{
    public class TransStatusValidator : AbstractValidator<TransStatusCommand>
    {
        public TransStatusValidator()
        {
            RuleFor(v => v.b2CRequest.TransactionID).NotNull().WithMessage("TransactionID can not be null");
            RuleFor(v => v.b2CRequest.PartyA).NotNull().WithMessage("PartyA can not be null.");
            RuleFor(v => v.b2CRequest.ConsumerSecret).NotEmpty().WithMessage("ConsumerSecret can not be null.");
            RuleFor(v => v.b2CRequest.ConsumerKey).NotEmpty().WithMessage("ConsumerKey can not be null.");
            RuleFor(v => v.b2CRequest.SecurityCredential).NotEmpty().WithMessage("SecurityCredential can not be null.");
        }
    }
}
