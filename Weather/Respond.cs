using System;
using System.Collections.Generic;
using System.Linq;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;

namespace Weather
{
    class Respond
    {
        public WeatherInfo Weather { get; private set; }
        public WindInfo Wind { get; private set; }
        public MainInfo Main { get; private set; }
        public CloudInfo Cloud { get; private set; }
        public RainInfo RainVolume { get; private set; }
        public SnowInfo SnowVolume { get; private set; }
        public SystemInfo SystemInfo { get; private set; }


        public Respond ParseWeather(string json)
        {
            try
            {
                JObject weatherObject = JObject.Parse(json);
                IList<JToken> result = weatherObject["weather"].Children().ToList();

                if (result.Count > 0)
                    Weather = result[0].ToObject<WeatherInfo>();

            }
            catch (Exception e)
            {
                Weather = null;
            }

            return this;
        }

        public Respond ParseWind(string json)
        {
            try
            {
                JObject windObject = JObject.Parse(json);
                Wind = windObject["wind"].ToObject<WindInfo>();
            }
            catch (Exception e)
            {
                Wind = null;
            }

            return this;
        }

        public Respond ParseMain(string json)
        {
            try
            {
                JObject mainObject = JObject.Parse(json);
                Main = mainObject["main"].ToObject<MainInfo>();
            }
            catch (Exception e)
            {
                Main = null;
            }

            return this;
        }

        public Respond ParseCloud(string json)
        {
            try
            {
                JObject cloudObject = JObject.Parse(json);
                Cloud = cloudObject["clouds"].ToObject<CloudInfo>();
            }
            catch (Exception e)
            {
                Cloud = null;
            }

            return this;
        }

        public Respond ParseRain(string json)
        {
            try
            {
                JObject rainObject = JObject.Parse(json);
                RainVolume = new RainInfo();

                string rainJson = rainObject["rain"].ToString();
                Dictionary<string, string> dict = JsonConvert.DeserializeObject<Dictionary<string, string>>(rainJson);

                int hours = int.Parse(dict.Keys.ToArray()[0].Split('h')[0]);
                float volume = float.Parse(dict.Values.ToArray()[0]);

                RainVolume.Hour = hours;
                RainVolume.Volume = volume;
            }
            catch (Exception e)
            {
                RainVolume = null;
            }

            return this;
        }

        public Respond ParseSnow(string json)
        {
            try
            {
                JObject snowObject = JObject.Parse(json);
                SnowVolume = new SnowInfo();

                string snowJson = snowObject["snow"].ToString();
                Dictionary<string, string> dict = JsonConvert.DeserializeObject<Dictionary<string, string>>(snowJson);

                int hours = int.Parse(dict.Keys.ToArray()[0].Split('h')[0]);
                float volume = float.Parse(dict.Values.ToArray()[0]);

                SnowVolume.Hour = hours;
                SnowVolume.Volume = volume;
            }
            catch (Exception e)
            {
                SnowVolume = null;
            }

            return this;
        }

        public Respond ParseSystem(string json)
        {
            try
            {
                JObject systemObject = JObject.Parse(json);
                SystemInfo = systemObject["sys"].ToObject<SystemInfo>();
            }
            catch (Exception e)
            {
                SystemInfo = null;
            }

            return this;
        }
    }
}
