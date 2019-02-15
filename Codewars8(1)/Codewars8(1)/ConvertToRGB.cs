
using System;

namespace Codewars8_1_
{

    public class ConvertToRGB
    {
        public static string StringToRGB(string str)
        {
            char[] s = str.ToCharArray();
            int r = Convert.ToInt32($"{s[1]}{s[2]}", 16);
            int g = Convert.ToInt32($"{s[3]}{s[4]}", 16);
            int b = Convert.ToInt32($"{s[5]}{s[6]}", 16);
            return $"r:{r}, g:{g}, b:{b}";
        }
    }
}
