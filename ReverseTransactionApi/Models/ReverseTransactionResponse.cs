using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ReverseTransactionApi.Models
{
    public class ReverseTransactionResponse
    {
        public string OriginatorConversationID { get; set; }
        public string ConversationID { get; set; }
        public string ResponseCode { get; set; }
        public string ResponseDescription { get; set; }

}
}
