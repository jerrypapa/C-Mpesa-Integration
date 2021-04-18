﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace B2BMpesaApi.Models
{
    public class B2BRequest
    {
        public string Initiator { get; set; }
        public string SecurityCredential { get; set; }
        public string CommandID { get; set; }

        public string Amount { get; set; }
        public string PartyA { get; set; }
        public string SenderIdentifierType { get; set; }

        public string PartyB { get; set; }
        public string RecieverIdentifierType { get; set; }
        public string Remarks { get; set; }
        public string QueueTimeOutURL { get; set; }
        public string ResultURL { get; set; }
        public string AccountReference { get; set; }
        
    }
}
