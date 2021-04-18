using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AccountBalance.Models
{
    public class AccountBalanceResponse
    {

        public string OriginatorConversationID { get; set; }

        public string ConversationID { get; set; }

        public string ResponseCode { get; set; }

        public string ResponseDescription { get; set; }

}
}
