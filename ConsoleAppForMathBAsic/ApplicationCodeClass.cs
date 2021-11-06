using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleAppForMathBAsic
{
   public  class ApplicationCodeClass
    {
        public string combineArrayStringWithSpace(string[] stringArray)
        {
             string str = default(string);
            if (null == stringArray || stringArray.Length == 0)
                return "";
            foreach (string item in stringArray)
            {
                string test = item.Trim();
                str += test + " ";
            }
            return str.Trim();
        }
           
    }
}
