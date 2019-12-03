using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GUI
{
    public class Str
    {
        public static string Remove(string str, char ch)
        {
            while (str.IndexOf(ch) != -1)
                str = str.Replace(ch.ToString(), "");

            return str;
        }
    }
}
