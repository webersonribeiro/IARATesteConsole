using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace IARATesteConsole
{
    public class ValidArrayNumbers
    {
        public List<int> ContainsValueImpar(int[] values)
        {
            List<int> list = new List<int>(values);
            var numbersFound = list.Where(x => x % 2 != 0);
            return numbersFound.ToList();
        }
    }
}
