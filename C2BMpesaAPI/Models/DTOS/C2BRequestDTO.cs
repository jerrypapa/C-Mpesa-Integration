using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace C2BMpesaAPI.Models.DTOS
{
    public class C2BRequestDTO
    {

        /// <summary>
        /// This is the Short Code receiving the amount being transacted.
        /// </summary>
        [JsonProperty("ShortCode")]
        public string ShortCode { get; set; }

        /// <summary>
        /// This is a unique identifier of the transaction type: There are two types of these Identifiers:
        /// CustomerPayBillOnline: This is used for Pay Bills shortcodes.
        /// CustomerBuyGoodsOnline: This is used for Buy Goods shortcodes.
        /// Buy Default this property is set to CustomerPayBillOnline
        /// </summary>
        [JsonProperty("CommandID")]
        public string CommandID { get; set; }

        /// <summary>
        /// This is the amount being transacted. The parameter expected is a numeric value.
        /// </summary>
        [JsonProperty("Amount")]
        public string Amount { get; set; }

        /// <summary>
        /// This is the phone number initiating the C2B transaction.(format: 2547XXXXXXXX)
        /// </summary>
        [JsonProperty("Msisdn")]
        public string Msisdn { get; set; }

        /// <summary>
        /// This is used on CustomerPayBillOnline option only. 
        /// This is where a customer is expected to enter a unique bill identifier, e.g an Account Number. 
        /// </summary>
        [JsonProperty("BillRefNumber")]
        public string BillRefNumber { get; set; }


        /// <summary>
        /// C2B Simulate data transfer object
        /// </summary>
        /// <param name="shortCode">This is the Short Code receiving the amount being transacted.</param>
        /// <param name="commandId">
        /// This is a unique identifier of the transaction type: There are two types of these Identifiers:
        /// CustomerPayBillOnline: This is used for Pay Bills shortcodes.
        /// CustomerBuyGoodsOnline: This is used for Buy Goods shortcodes.
        /// Buy Default this property is set to CustomerPayBillOnline
        /// </param>
        /// <param name="amount">
        /// This is the amount being transacted. The parameter expected is a numeric value.
        /// </param>
        /// <param name="msisdn">This is the phone number initiating the C2B transaction.(format: 2547XXXXXXXX)</param>
        /// <param name="billReferenceNumber">
        /// This is used on CustomerPayBillOnline option only. 
        /// This is where a customer is expected to enter a unique bill identifier, e.g an Account Number. 
        /// </param>
        public string ConsumerSecret { get; set; }
        public string ConsumerKey { get; set; }
    }
}
