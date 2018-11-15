using System;

namespace Weather
{
    class SnowInfo
    {
        public int Hour { get; set; }
        public float Volume { get; set; }


        public override string ToString()
        {
            string textFormat = "Volume in Last {0} hours : {1}";
            string result = ("[ Snow ]" + Environment.NewLine);
            result += (string.Format(textFormat, Hour, Volume) + Environment.NewLine);
            return result;
        }
    }
}
