using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AptekApp
{
    public static class Extentions
    {
        public static bool isnotEmpty(string[]value,string CheckInput)
        {
            foreach(var val in value)
            {
                if (val == CheckInput)
                {
                    return false;
                }
            }
            return true;
        }
    }
}
