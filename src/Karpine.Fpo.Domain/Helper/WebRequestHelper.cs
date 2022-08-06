using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Net.Http.Headers;
using Newtonsoft.Json;
using System.Threading.Tasks;
using System.Text;
using System.Net;
using Microsoft.IdentityModel;
using IdentityModel.Client;
using System.Net.Http.Json;


/// <summary>
/// Summary description for WebRequestHelper
/// </summary>
/// 
namespace Karpine.Fpo.Domain.Helper
{
    public class WebRequestHelper
    {
        public WebRequestHelper()
        {
            //
            // TODO: Add constructor logic here
            //
        }

        public static async Task<string> GetWebRequest(string Url)
        {
            HttpClient client = new HttpClient();
            var content = await client.GetStringAsync(Url).ConfigureAwait(false);
            return content;
        }

        public static async Task<TxResult> CreateMessageAsync(string url, MessageObject message)
        {
            HttpClient client = new HttpClient();
            TxResult txResult = new TxResult();
            try
            {
                // Update port # in the following line.
                client.BaseAddress = new Uri(url);
                client.DefaultRequestHeaders.Accept.Clear();
                client.DefaultRequestHeaders.Accept.Add(
                    new MediaTypeWithQualityHeaderValue("application/json"));
                client.SetBearerToken(GetBearerToken().Result.ToString());
                HttpResponseMessage response = await client.PostAsJsonAsync(
                    url, message).ConfigureAwait(false);
                response.EnsureSuccessStatusCode();

                // Deserialize the updated product from the response body.
                txResult = await response.Content.ReadAsAsync<TxResult>().ConfigureAwait(false);
                // return URI of the created resource.
            }
            catch (Exception ex)
            {
            }
            return txResult;
        }

        public static async Task<MessageResult> RetrieveMessageAsync(string url)
        {
            HttpClient client = new HttpClient();
            MessageResult msgResult = new MessageResult();
            try
            {
                // Update port # in the following line.
                client.BaseAddress = new Uri(url);
                client.DefaultRequestHeaders.Accept.Clear();
                client.DefaultRequestHeaders.Accept.Add(
                    new MediaTypeWithQualityHeaderValue("application/json"));
                client.SetBearerToken(GetBearerToken().Result.ToString());
                HttpResponseMessage response = await client.GetAsync(
                    url).ConfigureAwait(false);
                response.EnsureSuccessStatusCode();

                // Deserialize the updated product from the response body.
                msgResult = await response.Content.ReadAsAsync<MessageResult>();
                // return URI of the created resource.
            }
            catch (Exception ex)
            {
            }
            return msgResult;
        }

        public static async Task<Karpine.Fpo.UserKeys> RetrieveUserKeysAsync(string url)
        {
            HttpClient client = new HttpClient();
            UserKeys msgResult = new UserKeys();
            try
            {
                // Update port # in the following line.
                client.BaseAddress = new Uri(url);
                client.DefaultRequestHeaders.Accept.Clear();
                client.DefaultRequestHeaders.Accept.Add(
                    new MediaTypeWithQualityHeaderValue("application/json"));
                client.SetBearerToken(GetBearerToken().Result.ToString());
                HttpResponseMessage response = await client.GetAsync(
                    url).ConfigureAwait(false);
                response.EnsureSuccessStatusCode();

                // Deserialize the updated product from the response body.
                msgResult = await response.Content.ReadAsAsync<UserKeys>();
                // return URI of the created resource.
            }
            catch (Exception ex)
            {
            }
            return msgResult;
        }

        public static async Task<TxResult> UpdateMessageAsync(string url, MessageObject messageObject)
        {
            HttpClient client = new HttpClient();
            TxResult txResult = new TxResult();
            try
            {
                // Update port # in the following line.
                client.BaseAddress = new Uri(url);
                client.DefaultRequestHeaders.Accept.Clear();
                client.DefaultRequestHeaders.Accept.Add(
                    new MediaTypeWithQualityHeaderValue("application/json"));
                client.SetBearerToken(GetBearerToken().Result.ToString());
                HttpResponseMessage response = await client.PutAsJsonAsync(
                    url, messageObject).ConfigureAwait(false);
                response.EnsureSuccessStatusCode();

                // Deserialize the updated product from the response body.
                txResult = await response.Content.ReadAsAsync<TxResult>();
                // return URI of the created resource.
            }
            catch (Exception ex)
            {
            }
            return txResult;
        }

        public static async Task<TxResult> DeleteMessageAsync(string url)
        {
            HttpClient client = new HttpClient();
            TxResult txResult = new TxResult();
            try
            {
                // Update port # in the following line.
                client.BaseAddress = new Uri(url);
                client.DefaultRequestHeaders.Accept.Clear();
                client.DefaultRequestHeaders.Accept.Add(
                    new MediaTypeWithQualityHeaderValue("application/json"));
                client.SetBearerToken(GetBearerToken().Result.ToString());
                HttpResponseMessage response = await client.DeleteAsync(
                    url).ConfigureAwait(false);
                response.EnsureSuccessStatusCode();

                // Deserialize the updated product from the response body.
                txResult = await response.Content.ReadAsAsync<TxResult>();
                // return URI of the created resource.
            }
            catch (Exception ex)
            {
            }
            return txResult;
        }

        public static async Task<string> GetBearerToken()
        {
            HttpClient client = new HttpClient();

            // discover endpoints from metadata
            var disco = await client.GetDiscoveryDocumentAsync("https://identity-sts.karpine.io").ConfigureAwait(false);
            if (disco.IsError)
            {
                Console.WriteLine(disco.Error);
            }


            // request token
            var tokenResponse = await client.RequestTokenAsync(new ClientCredentialsTokenRequest
            {
                Address = "https://identity-sts.karpine.io/connect/token",
                ClientId = "ARyTk2Eeaqm4eoZzNUaoi79HYi5egDmoAB",
                ClientSecret = "619860c4-c3fe-6045-6afa-c178e0480492",
                Scope = "Karpine_N3_Message",
                GrantType = "client_credentials"
            }).ConfigureAwait(false);

            if (tokenResponse.IsError)
            {
                Console.WriteLine(tokenResponse.Error);
            }
            string bearerToken = tokenResponse.AccessToken;

            return bearerToken;
        }
    }
}