using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace CatCounter
{
    public class CatCounterClass
    {
        public int CatCounter(string findcat) {
            int counter = 0;
            string catpat = @"(?i)cats?";
            foreach (Match item in Regex.Matches(findcat, catpat))
            {
                counter++;
            }
            return counter;

        }

    };
}
