using SwitchMediaTest.Model;
using System.Threading.Tasks;
using SwitchMediaTest.Interface;
using System;
using System.Xml.Linq;

namespace SwitchMediaTest.Storage
{
    public class HomeAPI : IHomeAPI
    {
        private IStorageAPI ApiStorage;

        public HomeAPI(IStorageAPI apiStorage)
        {
            ApiStorage = apiStorage;
        }

        async public Task<Image> GetImageAsync()
        {
            try
            {
                string returnMessage = string.Empty;

                Image imageModel = new Image();

                string URL = string.Format("api/patterns/random");

                //Call Api
                WebApiCall objWebApi = new WebApiCall();
                var response = await objWebApi.DoApiCall(URL, false);

                //Read the response from webapi.
                if (response != null)
                {
                    var content = await response.Content.ReadAsStringAsync();
                    XDocument doc = XDocument.Parse(content);
                    foreach (var item in doc.Descendants("pattern"))
                    {
                        imageModel.imageUrl = item.Element("imageUrl").Value.ToString();

                    }
                }
                else
                {
                    imageModel = null;
                }

                return imageModel;
            }
            catch(Exception e)
            {
                // record error log 

                return null;
            }
        }

        async public Task<byte[]> GetImageBytesAsync(string imageUrl)
        {

            try
            {
                WebApiCall objWebApi = new WebApiCall();
                var response = await objWebApi.DownloadImageAsync(imageUrl);

                //Read the response from webapi.
                if (response != null && response.Length > 0)
                {
                    return response;
                }

                return null;
            }
            catch(Exception e)
            {
                //record error log

                return null;
            }
        }
    }
}
