using B2CMpesaApi.Models;
using MpesaApi.Controllers;
using MpesaApi.Models;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;

namespace B2CMpesaApi.Logic
{
    public class ProcessB2CTransaction
    {
        string stringData = "";
        public void ProcessTransaction(B2CRequest mpesaRequest, string b2cUrl, string token) {

            
            if (mpesaRequest == null)
            {
                //return null;
            }
            string serializedBodyRequest = JsonConvert.SerializeObject(mpesaRequest);
            HttpWebRequest httpRequest = (HttpWebRequest)WebRequest.Create(b2cUrl);
            httpRequest.ContentType = "application/json";
            httpRequest.Method = "POST";
            httpRequest.Headers.Add("Authorization", "Bearer" +token);
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
                var b2CResponse = JsonConvert.DeserializeObject<Response>(result);
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

        public async Task<Object> ProcessTransaction1(B2CRequest mpesaRequest,string token)
        {
            HttpClient client = new HttpClient();

            client.DefaultRequestHeaders.Clear();
            client.BaseAddress = new Uri("https://sandbox.safaricom.co.ke");

            client.DefaultRequestHeaders.Add("Authorization", $"Bearer {token}");
            var json = JsonConvert.SerializeObject(mpesaRequest);

            var httpContent = new StringContent(json, Encoding.UTF8, "application/json");

            var resWithToken = client.PostAsync("/mpesa/b2c/v1/paymentrequest", httpContent).Result;

            stringData = resWithToken.Content.ReadAsStringAsync().Result;
           // return JsonConvert.DeserializeObject<Response>(stringData);
            var response =JsonConvert.DeserializeObject<Response>(stringData);
            return response;
        }
    }
}
