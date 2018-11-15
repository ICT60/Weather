using System;

namespace Weather
{
    class MainInfo
    {
        public float Temp { get; set; }
        public float Pressure { get; set; }
        public float Humidity { get; set; }
        public float Temp_Min { get; set; }
        public float Temp_Max { get; set; }
        public float Sea_Level { get; set; }
        public float Grnd_Level { get; set; }

        public override string ToString()
        {
            string result = ("[ Main ]" + Environment.NewLine);
            result += ("Temperature : " + Temp + " Celsius" + Environment.NewLine);
            result += ("Pressure : " + Pressure + " hPa" + Environment.NewLine);
            result += ("Humidity : " + Humidity + "%" + Environment.NewLine);
            result += ("Min Temperature : " + Temp_Min + " Celsius" + Environment.NewLine);
            result += ("Max Temperature : " + Temp_Max + " Celsius" + Environment.NewLine);
            return result;
        }
    }
}
