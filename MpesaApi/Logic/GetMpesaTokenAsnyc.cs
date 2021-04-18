using MpesaApi.Models;
using Newtonsoft.Json;
using RestSharp;
using RestSharp.Authenticators;
using System;

namespace MpesaApi.Logic
{
    public class GetMpesaTokenAsnyc
    {
        public Object GetToken(TokenRequest tokenRequest)
        {
            RestClient restClient = new RestClient
            {
                Authenticator = new HttpBasicAuthenticator(tokenRequest.ConsumerKey, tokenRequest.consumersecret),
                BaseUrl = new Uri("https://sandbox.safaricom.co.ke"),


            };

            RestRequest request = new RestRequest("/oauth/v1/generate", Method.GET);

            request.AddParameter("grant_type", "client_credentials", ParameterType.QueryString);


            IRestResponse restResponse = restClient.Execute(request);


            if (restResponse != null && !string.IsNullOrEmpty(restResponse.Content))
            {

                TokenResponse tokenResponse = JsonConvert.DeserializeObject<TokenResponse>(restResponse.Content);
                return tokenResponse;

                // return restResponse.Content;

            }

            return string.Empty;

        }
    }
}
