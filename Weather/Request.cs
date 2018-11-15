using System;
using System.Net.Http;
using System.Threading.Tasks;

namespace Weather
{
    class Request
    {
        const string API_ENDPOINT = "https://api.openweathermap.org/data/2.5/weather";

        HttpClient client;
        Uri domainName;

        string parameters;


        public Request()
        {
            client = new HttpClient();
            parameters = string.Empty;
        }

        public Request ResetParameters()
        {
            parameters = string.Empty;
            return this;
        }

        public Request SetCityID(string id)
        {
            parameters += ("?id=" + id);
            return this;
        }

        public Request SetTemperatureUnit(string unit)
        {
            parameters += ("&units=" + unit);
            return this;
        }

        public Request SetAPIKey(string apiKey)
        {
            parameters += ("&appid=" + apiKey);
            return this;
        }

        public async Task<Respond> GetRespond()
        {
            Respond respond = new Respond();

            try
            {
                domainName = new Uri(API_ENDPOINT + parameters);
                string strRespond = await client.GetStringAsync(domainName);

                respond
                    .ParseWeather(strRespond)
                    .ParseWind(strRespond)
                    .ParseMain(strRespond)
                    .ParseCloud(strRespond)
                    .ParseRain(strRespond)
                    .ParseSnow(strRespond)
                    .ParseSystem(strRespond);
            }
            catch (Exception e)
            {
            }

            return respond;
        }
    }
}
