using AutoMapper;
using B2BMpesaApi.Commands;
using B2BMpesaApi.Logic;
using B2BMpesaApi.Models;
using MediatR;
using MpesaApi.Controllers;
using MpesaApi.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;

namespace B2BMpesaApi.Handlers
{
    public class B2BCommandHandler : IRequestHandler<B2bCommand, Object>
    {
        TokenRequest tokenRequest = new TokenRequest();

        private readonly IMapper _mapper;

        public B2BCommandHandler(IMapper mapper)
        {
            _mapper = mapper;
        }


        AuthApiController apiController = new AuthApiController();
        ProcessB2BTrans processB2C = new ProcessB2BTrans();
        public Task<object> Handle(B2bCommand request, CancellationToken cancellationToken)
        {
            tokenRequest.ConsumerKey = request.bRequestDto.ConsumerKey;
            tokenRequest.consumersecret = request.bRequestDto.ConsumerSecret;

            var tokenResponse1 = (TokenResponse)apiController.GetAccessToken(tokenRequest);

            var b2CRequest1 = _mapper.Map<B2BRequest>(request.bRequestDto);

            var result = processB2C.ProcessTransaction1(b2CRequest1, tokenResponse1.AccessToken);

            return result;
        }
    }
}
