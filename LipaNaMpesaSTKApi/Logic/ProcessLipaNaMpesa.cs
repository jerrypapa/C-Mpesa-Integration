using LipaNaMpesaSTKApi.Models;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;

namespace LipaNaMpesaSTKApi.Logic
{
    public class ProcessLipaNaMpesa
    {
        string stringData = "";
        public void ProcessTransaction(LipaNaMpesaOnlineDto mpesaRequest, string b2cUrl, string token)
        {


            if (mpesaRequest == null)
            {
                //return null;
            }
            string serializedBodyRequest = JsonConvert.SerializeObject(mpesaRequest);
            HttpWebRequest httpRequest = (HttpWebRequest)WebRequest.Create(b2cUrl);
            httpRequest.ContentType = "application/json";
            httpRequest.Method = "POST";
            httpRequest.Headers.Add("Authorization", "Bearer" + token);
            using (var streamWriter = new StreamWriter(httpRequest.GetRequestStream()))
            {
                streamWriter.Write(serializedBodyRequest);
                streamWriter.Flush();
                streamWriter.Close();
            }
            try
            {
                HttpWebResponse httpResponse = (HttpWebResponse)httpRequest.GetResponse();
                var result = "";
                using (var responseStream = new StreamReader(httpResponse.GetResponseStream()))
                {
                    result = responseStream.ReadToEnd();
                }
                var b2CResponse = JsonConvert.DeserializeObject<String>(result);
                if (b2CResponse == null)
                {
                    // return null;
                }
                //return b2CResponse;
            }
            catch (Exception Ex)
            {
                //return null;
            }
        }

        public async Task<Object> ProcessTransaction1(LipaNaMpesaOnlineDto mpesaRequest, string token)
        {
            HttpClient client = new HttpClient();

            client.DefaultRequestHeaders.Clear();
            client.BaseAddress = new Uri("https://sandbox.safaricom.co.ke");

            client.DefaultRequestHeaders.Add("Authorization", $"Bearer {token}");
            var json = JsonConvert.SerializeObject(mpesaRequest);

            var httpContent = new StringContent(json, Encoding.UTF8, "application/json");

            var resWithToken = client.PostAsync("/mpesa/stkpush/v1/processrequest", httpContent).Result;

            stringData = resWithToken.Content.ReadAsStringAsync().Result;
            var response = JsonConvert.DeserializeObject<LipaNaMpesaResponse2>(stringData);
            return response;
        }

        public async Task<Object> ProcessTransaction2(LipaNaMpesaStatusRequest mpesaRequest, string token)
        {
            HttpClient client = new HttpClient();

            client.DefaultRequestHeaders.Clear();
            client.BaseAddress = new Uri("https://sandbox.safaricom.co.ke");

            client.DefaultRequestHeaders.Add("Authorization", $"Bearer {token}");
            var json = JsonConvert.SerializeObject(mpesaRequest);

            var httpContent = new StringContent(json, Encoding.UTF8, "application/json");

            var resWithToken = client.PostAsync("/mpesa/stkpushquery/v1/query", httpContent).Result;

            stringData = resWithToken.Content.ReadAsStringAsync().Result;
            var response = JsonConvert.DeserializeObject<LipaNaMpesaStatusResponse>(stringData);
            return response;
        }
    }
}
