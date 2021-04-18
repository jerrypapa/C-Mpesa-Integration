using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ReverseTransactionApi.Models
{
    public class ReverseTransactionRequest
    {

        public string Initiator { get; set; }

        public string SecurityCredential { get; set; }
        public string CommandID { get; set; }
        public string TransactionID { get; set; }
        public string Amount { get; set; }
        public string ReceiverParty { get; set; }
        public string RecieverIdentifierType { get; set; }
        public string InitiResultURLator { get; set; }
        public string ResultURL { get; set; }
        public string QueueTimeOutURL { get; set; }

        public string Remarks { get; set; }
        public string Occasion { get; set; }

}
}
