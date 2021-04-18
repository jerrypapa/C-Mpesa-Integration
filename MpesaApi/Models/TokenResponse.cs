using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MpesaApi.Models
{
    public class TokenResponse
    {
        [JsonProperty("access_token")]
        public string AccessToken { get; private set; }

        /// <summary>
        /// time token expires
        /// </summary>
        [JsonProperty("expires_in")]
        public string ExpiresIn { get; private set; }


        [JsonProperty("requestId")]
        public string RequestID { get; private set; }

        public static explicit operator TokenResponse(Task<IActionResult> v)
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// time token expires
        /// </summary>
        [JsonProperty("errorCode")]
        public string ErrorCode { get; private set; }


        [JsonProperty("errorMessage")]
        public string ErrorMessage { get; private set; }



        /// <summary>
        /// 
        /// </summary>
        /// <param name="access_token">Access token required to access other Mpesa API endpoints</param>
        /// <param name="expires_in">time in seconds after which the token expires</param>
        public TokenResponse(string access_token, string expires_in, string requestId, string errorCode, string errorMessage)
        {
            AccessToken = access_token;
            ExpiresIn = expires_in;
            RequestID = requestId;
            ErrorCode = errorCode;
            ErrorMessage = errorMessage;

        }
    }
}
