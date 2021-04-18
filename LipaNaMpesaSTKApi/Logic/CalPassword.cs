using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LipaNaMpesaSTKApi.Logic
{
    public class CalPassword
    {
       public string CalculatePassword(string shortCode, string passkey, string timestamp)
        {
            return Convert.ToBase64String(Encoding.GetEncoding("ISO-8859-1").GetBytes(shortCode + passkey + timestamp));
        }
    }
}
