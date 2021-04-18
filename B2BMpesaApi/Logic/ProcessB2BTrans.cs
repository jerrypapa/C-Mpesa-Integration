using B2BMpesaApi.Models;
using B2BMpesaApi.Models.DTOS;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;

namespace B2BMpesaApi.Logic
{
    public class ProcessB2BTrans
    {
        String stringData;
        public async Task<Object> ProcessTransaction1(B2BRequest mpesaRequest, string token)
        {
            HttpClient client = new HttpClient();

            client.DefaultRequestHeaders.Clear();
            client.BaseAddress = new Uri("https://sandbox.safaricom.co.ke");

            client.DefaultRequestHeaders.Add("Authorization", $"Bearer {token}");
            var json = JsonConvert.SerializeObject(mpesaRequest);

            var httpContent = new StringContent(json, Encoding.UTF8, "application/json");

            var resWithToken = client.PostAsync("/mpesa/b2b/v1/paymentrequest", httpContent).Result;

            stringData = resWithToken.Content.ReadAsStringAsync().Result;
            // return JsonConvert.DeserializeObject<Response>(stringData);
            var response = JsonConvert.DeserializeObject<B2BResponse>(stringData);
            return response;
        }
    }
}
