using AutoMapper;
using B2CMpesaApi.Commands;
using B2CMpesaApi.Logic;
using B2CMpesaApi.Models;
using B2CMpesaApi.Models.DTOS;
using MediatR;
using MpesaApi.Controllers;
using MpesaApi.Models;
using System.Threading;
using System.Threading.Tasks;

namespace B2CMpesaApi.Handlers
{
    public class B2CCommandHandler : IRequestHandler<B2CCommand, object>
    {
        TokenRequest tokenRequest = new TokenRequest();

        private readonly IMapper _mapper;

        public B2CCommandHandler(IMapper mapper)
        {
            _mapper = mapper;
        }


        AuthApiController apiController = new AuthApiController();
        ProcessB2CTransaction processB2C = new ProcessB2CTransaction();
        Task<object> IRequestHandler<B2CCommand, object>.Handle(B2CCommand request, CancellationToken cancellationToken)
        {
            tokenRequest.ConsumerKey = request.b2CRequest.ConsumerKey;
            tokenRequest.consumersecret = request.b2CRequest.ConsumerSecret;

            var tokenResponse1 = (TokenResponse)apiController.GetAccessToken(tokenRequest);

            var b2CRequest1 = _mapper.Map<B2CRequest>(request.b2CRequest);

            var result= processB2C.ProcessTransaction1(b2CRequest1, tokenResponse1.AccessToken);
            return result;
        }
    }
}
