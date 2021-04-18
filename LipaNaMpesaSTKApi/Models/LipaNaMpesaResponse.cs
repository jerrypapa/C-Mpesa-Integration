using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace LipaNaMpesaSTKApi.Models
{
    public class LipaNaMpesaResponse
    {

        public string MerchantRequestID { get; set; }

        public string CheckoutRequestID { get; set; }

        public string ResponseCode { get; set; }

        public string ResponseDescription { get; set; }

        public string CustomerMessage { get; set; }
       

    }
    public class LipaNaMpesaResponse2
    {

        public string requestId { get; set; }

        public string errorCode { get; set; }

        public string errorMessage { get; set; }

        public string ResponseDescription { get; set; }

        public string CustomerMessage { get; set; }
        public string MerchantRequestID { get; set; }

        public string CheckoutRequestID { get; set; }

        public string ResponseCode { get; set; }


    }
}

