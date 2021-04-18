using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace LipaNaMpesaSTKApi.Models
{
    public class LipaNaMpesaStatusResponse
    {
        public string MerchantRequestID { get; set; }
        public string CheckoutRequestID { get; set; }
        public string ResponseCode { get; set; }
        public string ResultDesc { get; set; }
        public string ResponseDescription { get; set; }
        public string ResultCode { get; set; }
        public string requestId { get; set; }
        public string errorCode { get; set; }
        public string errorMessage { get; set; }

    }
}
