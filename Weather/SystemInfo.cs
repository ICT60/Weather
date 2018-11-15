using System;

namespace Weather
{
    class SystemInfo
    {
        public string Type { get; set; }
        public int ID { get; set; }
        public string Message { get; set; }
        public string CountryCode { get; set; }
        public double SunRise{ get; set; }
        public double SunSet { get; set; }

        public override string ToString()
        {
            DateTime sunRiseDate = new DateTime(1970, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc);
            DateTime sunSetDate = new DateTime(1970, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc);

            sunRiseDate = sunRiseDate.AddSeconds(SunRise);
            sunSetDate = sunSetDate.AddSeconds(SunSet);

            string result = ("[ System ]" + Environment.NewLine);

            result += ("Sun Rise : " + sunRiseDate.ToLocalTime() + Environment.NewLine);
            result += ("Sun Set : " + sunSetDate.ToLocalTime() + Environment.NewLine);

            return result;
        }
    }
}
