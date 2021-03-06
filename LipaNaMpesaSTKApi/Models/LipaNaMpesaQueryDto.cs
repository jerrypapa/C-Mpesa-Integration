using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LipaNaMpesaSTKApi.Models
{
    public class LipaNaMpesaQueryDto
    {
        
            /// <summary>
            /// This is organizations shortcode (Paybill or Buygoods - A 5 to 6 digit account number) 
            /// used to identify an organization and receive the transaction.
            /// </summary>
            [JsonProperty("BusinessShortCode")]
            public string BusinessShortCode { get; private set; }

            /// <summary>
            /// Lipa Na Mpesa Online PassKey
            /// </summary>
            public string Passkey { get; private set; }

            /// <summary>
            /// This is the password used for encrypting the request sent: A base64 encoded string. 
            /// The base64 string is a combination of Shortcode+Passkey+Timestamp
            /// </summary>
            [JsonProperty("Password")]
            public string Password { get; private set; }


            /// <summary>
            /// This is the Timestamp of the transaction, 
            /// normaly in the formart of YEAR+MONTH+DATE+HOUR+MINUTE+SECOND (YYYYMMDDHHMMSS) 
            /// Each part should be atleast two digits apart from the year which takes four digits.
            /// </summary>
            [JsonProperty("Timestamp")]
            public string Timestamp { get; private set; } = DateTime.Now.ToString("yyyyMMddHHmmss");

            /// <summary>
            /// This is a global unique identifier of the processed checkout transaction request.
            /// e.g ws_CO_DMZ_123212312_2342347678234
            /// </summary>
            [JsonProperty("CheckoutRequestID")]
            public string CheckoutRequestID { get; private set; }



            /// <summary>
            /// LipaNaMpesa Query transaction status data transfer object
            /// </summary>
            /// <param name="businessShortCode">
            /// This is organizations shortcode (Paybill or Buygoods - A 5 to 6 digit account number) 
            /// used to identify an organization and receive the transaction.
            /// </param>
            /// <param name="passkey">Lipa Na Mpesa Online PassKey</param>
            /// <param name="timeStamp">
            /// This is the Timestamp of the transaction, 
            /// normaly in the formart of YEAR+MONTH+DATE+HOUR+MINUTE+SECOND (YYYYMMDDHHMMSS) 
            /// Each part should be atleast two digits apart from the year which takes four digits.
            /// </param>
            /// <param name="checkoutRequestId">
            /// This is a global unique identifier of the processed checkout transaction request.
            /// e.g ws_CO_DMZ_123212312_2342347678234
            /// </param>
            public LipaNaMpesaQueryDto(string businessShortCode, string passkey, DateTime timeStamp,
                string checkoutRequestId)
            {
                var formattedTimestamp = timeStamp.ToString("yyyyMMddHHmmss");

                BusinessShortCode = businessShortCode;
                Passkey = passkey;
                Timestamp = formattedTimestamp;
                Password = CalculatePassword(businessShortCode, passkey, formattedTimestamp);
                CheckoutRequestID = checkoutRequestId;

            }

            /// <summary>
            /// This method creates the necessary base64 encoded string that encrypts the request sent 
            /// </summary>
            private string CalculatePassword(string shortCode, string passkey, string timestamp)
            {
                return Convert.ToBase64String(Encoding.GetEncoding("ISO-8859-1").GetBytes(shortCode + passkey + timestamp));
            }

        }
    }
