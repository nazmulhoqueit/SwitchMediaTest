using System;
using System.Net.Http;
using System.Threading.Tasks;
using System.Net.Http.Headers;
using Newtonsoft.Json;
using System.Net;
using System.Text;

namespace SwitchMediaTest
{
    public class WebApiCall
    {
        string serverAddress = "http://www.colourlovers.com/";
        const int TIME_OUT = 120;
        const int IMAGE_TIME_OUT = 20;

        public async Task<HttpResponseMessage> DoApiCall(string URL, bool IsPostMethod)
        {
            HttpResponseMessage response;

            var handler = new HttpClientHandler()
            {
                AllowAutoRedirect = false
            };

            using (var client = new HttpClient(handler))
            {
                client.BaseAddress = new Uri(serverAddress);
                client.DefaultRequestHeaders.Accept.Clear();
                client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/xml"));
                client.Timeout = TimeSpan.FromSeconds(TIME_OUT);

                try
                {
                    if (IsPostMethod)
                        response = await client.PostAsync(URL, new StringContent(""));
                    else
                        response = await client.GetAsync(URL);

                    if (response.IsSuccessStatusCode)
                    {
                        return response;
                    }
                    else
                    {
                        response = null;
                        return response;
                    }
                }
                catch (HttpRequestException err)
                {
                    string errorMessage = err.Message;
                    return response = null;
                }
                catch (WebException webex)
                {
                    string errorMessage = webex.Message;
                    return response = null;
                }
            }
        }


        public async Task<HttpResponseMessage> DoApiCallPost<T>(string URL, T obj)
        {

            HttpResponseMessage response;

            var handler = new HttpClientHandler()
            {
                AllowAutoRedirect = false
            };

            using (var client = new HttpClient(handler))
            {
                client.BaseAddress = new Uri(serverAddress);
                client.DefaultRequestHeaders.Accept.Clear();
                client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));
                client.Timeout = TimeSpan.FromSeconds(TIME_OUT);

                try
                {
                    var json = JsonConvert.SerializeObject(obj);
                    var content = new StringContent(json, Encoding.UTF8, "application/json");

                    response = await client.PostAsync(URL, content);
                    
                    if (response.IsSuccessStatusCode)
                    {
                        return response;
                    }
                    else
                    {
                        response = null;
                        return response;
                    }
                }
                catch (HttpRequestException err)
                {
                    string errorMessage = err.Message;
                    return response = null;
                }
                catch (WebException webex)
                {
                    string errorMessage = webex.Message;
                    return response = null;
                }
            }
        }

       
        public async Task<byte[]> DownloadImageAsync(string imageUrl)
        {
            const int _downloadImageTimeoutInSeconds = IMAGE_TIME_OUT;
            HttpClient _httpClient = new HttpClient { Timeout = TimeSpan.FromSeconds(_downloadImageTimeoutInSeconds) };

            try
            {
                using (var httpResponse = await _httpClient.GetAsync(imageUrl))
                {
                    if (httpResponse.StatusCode == HttpStatusCode.OK)
                    {
                        return await httpResponse.Content.ReadAsByteArrayAsync();
                    }
                    else
                    {
                        //Url is Invalid
                        return null;
                    }
                }
            }
            catch (Exception e)
            {
                //Handle Exception
                return null;
            }
        }
    }
}