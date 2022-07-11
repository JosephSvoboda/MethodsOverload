using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Methodsoverload
{
    internal class AddMethod
    {
        public static int Add(int a, int b)
        {
            return a + b; 
        }
        public static decimal Add(decimal a, decimal b)
        {
            return a + b;
        }
        public static string Add(int a, int b, bool c)
        {
			var sum = a + b;

			if (c == true && sum > 1)
			{
				return $"{sum} dollars";
			}
			else if (c == true && sum == 1)
			{
				return $"{sum} dollar";
			}
			else if (c == true && sum < 1)
			{
				return $"{sum} dollars";
			}
			else
			{
				return sum.ToString();
			}
		}
    }
}
