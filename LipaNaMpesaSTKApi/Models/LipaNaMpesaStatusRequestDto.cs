using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace LipaNaMpesaSTKApi.Models
{
    public class LipaNaMpesaStatusRequestDto
    {
        public string BusinessShortCode { get; set; }
        public string Passkey { get; set; }
        public string Timestamp { get; set; }
        public string CheckoutRequestID { get; set; }
        public string ConsumerSecret { get; set; }
        public string ConsumerKey { get; set; }

    }
}
