using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TransactionStatusApi.Models.Dtos
{
    public class TransStatusDto
    {
        public string Initiator { get; set; }
        public string SecurityCredential { get; set; }
        public string CommandID { get; set; }

        public string TransactionID { get; set; }
        public string PartyA { get; set; }
        public string IdentifierType { get; set; }
        public string ResultURL { get; set; }
        public string QueueTimeOutURL { get; set; }

        public string Remarks { get; set; }
        public string Occasion { get; set; }

        public string ConsumerSecret { get; set; }
        public string ConsumerKey { get; set; }
    }
}
