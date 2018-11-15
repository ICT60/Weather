using System;

namespace Weather
{
    class WeatherInfo
    {
        public int ID { get; set; }
        public string Main { get; set; }
        public string Description { get; set; }
        public string Icon { get; set; }

        public override string ToString()
        {
            string result = ("[ Weather ]" + Environment.NewLine);
            result += ("Main : " + Main + Environment.NewLine);
            result += ("Description : " + Description + Environment.NewLine);
            return result;
        }
    }
}
