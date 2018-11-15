using System;

namespace Weather
{
    class WindInfo
    {
        public string Speed { get; set; }
        public string Deg { get; set; }

        public override string ToString()
        {
            string result = "[ Wind ]" + Environment.NewLine;
            result += ("Speed : " + Speed + " meter/sec" + Environment.NewLine);
            result += ("Degree : " + Deg + " degree" + Environment.NewLine);
            return result;
        }
    }
}
