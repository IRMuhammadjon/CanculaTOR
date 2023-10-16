using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CanculaTOR
{
    static class funcions
    {
        public static int Add_two_numbers(int a,int b)
        {
            return a + b;
        }

        public static int Add_list_of_numbers(string text)
        {
            int[] ia = text.Split(',').Select(n => Convert.ToInt32(n)).ToArray();
            return ia.Sum();
        }
    }

}
