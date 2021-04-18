using Newtonsoft.Json;
using ReverseTransactionApi.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;

namespace ReverseTransactionApi.Logic
{
    public class ReverseTransaction
    {
        string stringData = "";
        public async Task<Object> ProcessTransaction1(ReverseTransactionRequest mpesaRequest, string token)
        {
            HttpClient client = new HttpClient();

            client.DefaultRequestHeaders.Clear();
            client.BaseAddress = new Uri("https://sandbox.safaricom.co.ke");

            client.DefaultRequestHeaders.Add("Authorization", $"Bearer {token}");
            var json = JsonConvert.SerializeObject(mpesaRequest);

            var httpContent = new StringContent(json, Encoding.UTF8, "application/json");

            var resWithToken = client.PostAsync("/mpesa/reversal/v1/request", httpContent).Result;

            stringData = resWithToken.Content.ReadAsStringAsync().Result;
            var response = JsonConvert.DeserializeObject<ReverseTransactionResponse>(stringData);
            return response;
        }
    }
}
