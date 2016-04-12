using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DesAlgo
{
    class CommonFunctions
    {
        public static string tobinary(string input)
        {
            StringBuilder sb = new StringBuilder();
            foreach (char L in input.ToCharArray())
            {
                sb.Append(Convert.ToString(L, 2).PadLeft(8, '0'));
            }
            return sb.ToString();
        }

    }
}
