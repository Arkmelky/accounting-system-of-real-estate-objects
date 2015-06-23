using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Client.AdditionalFunctionality
{
    public static class SearchHelper
    {
        public static bool CompareStrings(string searchStr, string objStr)
        {
            bool flag = false;
            char firstSymbol = searchStr[0];
            int i, j;

            for (i = 0; i < objStr.Count(); i++)
            {
                if (searchStr[0] == objStr[i])
                {
                    for (j = 0; j < searchStr.Count() && i + j < objStr.Count(); j++)
                    {
                        if (searchStr[j] != objStr[j + i])
                        {
                            flag = false;
                            break;
                        }
                    }
                    if (j == searchStr.Count())
                    {
                        return true;
                    }
                }
            }
            return false;

            /*
             * for (i = 0; i < searchStr.Count(); i++)
            {
                for (j = 0; j < objStr.Count(); j++)
                {
                    if (searchStr[i] == objStr[j])
                    {
                        flag = true;
                        break;
                    }
                }
                if (!flag)
                {
                    break;
                }
                else
                {
                    flag = false;
                }
            }
            if (i == searchStr.Count())
            {
                return true;
            }
            else
            {
                return false;    
            }
             */

        }
    }
}
