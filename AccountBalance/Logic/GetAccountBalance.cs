using AccountBalance.Models;
using Newtonsoft.Json;
using System;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;

namespace AccountBalance.Logic
{
    public class GetAccountBalance
    {
        string stringData = "";
        public async Task<Object> ProcessTransaction1(AccountBalanceDto mpesaRequest, string token)
        {
            HttpClient client = new HttpClient();

            client.DefaultRequestHeaders.Clear();
            client.BaseAddress = new Uri("https://sandbox.safaricom.co.ke");

            client.DefaultRequestHeaders.Add("Authorization", $"Bearer {token}");
            var json = JsonConvert.SerializeObject(mpesaRequest);

            var httpContent = new StringContent(json, Encoding.UTF8, "application/json");

            var resWithToken = client.PostAsync("/mpesa/transactionstatus/v1/query", httpContent).Result;

            stringData = resWithToken.Content.ReadAsStringAsync().Result;
            var response = JsonConvert.DeserializeObject<AccountBalanceResponse>(stringData);
            return response;
        }
    }
}

