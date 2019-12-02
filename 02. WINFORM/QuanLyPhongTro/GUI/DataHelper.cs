using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GUI
{
    public class DataHelper
    {
        public string Argument { get; set; }
        public double Value { get; set; }

        public static List<DataHelper> GetDataHelpers()
        {
            return new List<DataHelper> {
                    new DataHelper { Argument = "Russia",    Value = 17.0752},
                    new DataHelper { Argument = "Canada",    Value = 9.98467},
                    new DataHelper { Argument = "USA",       Value = 9.63142},
                    new DataHelper { Argument = "China",     Value = 9.59696},
                    new DataHelper { Argument = "Brazil",    Value = 8.511965},
                    new DataHelper { Argument = "Australia", Value = 7.68685},
                    new DataHelper { Argument = "India",     Value = 3.28759},
                    new DataHelper { Argument = "Others",    Value = 81.2}
                };
        }
    }
}
