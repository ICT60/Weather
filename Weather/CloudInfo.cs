using System;

namespace Weather
{
    class CloudInfo
    {
        public int All { get; set; }

        public override string ToString()
        {
            string result = ("[ Cloud ]" + Environment.NewLine);
            result += ("Cloudiness : " + All + "%" + Environment.NewLine);
            return result;
        }
    }
}
