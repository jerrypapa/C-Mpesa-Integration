using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace B2BMpesaApi.Models
{
    public class B2BResponse
    {
        public string ConversationID { get; set; }

        public string OriginatorConversationID { get; set; }
        public string ResponseDescription { get; set; }
        public string requestId { get; set; }
        public string errorCode { get; set; }
        public string errorMessage { get; set; }


     

}

}
