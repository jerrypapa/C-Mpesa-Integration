using AuthMpesaApi.Commands;
using MediatR;
using MpesaApi.Logic;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;

namespace AuthMpesaApi.Handlers
{
    public class GetTokenCommandHandler : IRequestHandler<GetTokenCommand, Object>
    {
        GetMpesaTokenAsnyc getMpesaTokenAsync = new GetMpesaTokenAsnyc();
        public Task<object> Handle(GetTokenCommand request, CancellationToken cancellationToken)
        {
            return (Task<object>)getMpesaTokenAsync.GetToken(request.tokenRequest);
        }
    }
}
