using SwitchMediaTest.Interfaces;
using System.Collections.Generic;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace EDGE4AppShared.Storage
{
    public class SettingsAPI : ISettingsAPI
    {
               
        public SettingsAPI()
        {
           
        }

        async public Task<List<SchedulesValueModel>> GetSettings(int portfolioID, string siteRefNo, int loginId)
        {

            string returnMessage = string.Empty;
            List<SchedulesValueModel> settings = new List<SchedulesValueModel>();

            string URL = string.Format("api/SettingsData?portfolioId={0}&siteRefNo={1}&loginId={2}", portfolioID, siteRefNo, loginId);

            //Call Api
            WebApiCall objWebApi = new WebApiCall();
            var response = await objWebApi.DoApiCall(URL, false);

            //Read the response from webapi.
            if (response != null)
            {
                var content = await response.Content.ReadAsStringAsync();
                settings = JsonConvert.DeserializeObject<List<SchedulesValueModel>>(content);
            }

            return settings;
        }

        async public Task<List<SchedulesValueModel>> GetKPISettings(int portfolioID, string siteRefNo, int loginId)
        {

            string returnMessage = string.Empty;
            List<SchedulesValueModel> settingsKPI = new List<SchedulesValueModel>();

            string URL = string.Format("api/SettingsKPIData?portfolioId={0}&siteRefNo={1}&loginId={2}", portfolioID, siteRefNo, loginId);

            //Call Api
            WebApiCall objWebApi = new WebApiCall();
            var response = await objWebApi.DoApiCall(URL, false);

            //Read the response from webapi.
            if (response != null)
            {
                var content = await response.Content.ReadAsStringAsync();
                settingsKPI = JsonConvert.DeserializeObject<List<SchedulesValueModel>>(content);
            }

            return settingsKPI;
        }
    }
}

