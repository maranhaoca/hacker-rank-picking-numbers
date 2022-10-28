using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Src
{
    public class Result
    {
        /*
         * Complete the 'pickingNumbers' function below.
         *
         * The function is expected to return an INTEGER.
         * The function accepts INTEGER_ARRAY a as parameter.
         */

        public static int pickingNumbers(List<int> a)
        {
            a.Sort();
            int maxLength = 0;

            for (int i = 0; i < a.Count - 1; i++)
            {
                int count = 1;
                for (int j = i + 1; j < a.Count; j++)
                {
                    if (a[j] - a[i] <= 1)
                    {
                        count++;
                    } else
                    {
                        break;
                    }
                }
                maxLength = count > maxLength ? count : maxLength;
            }

            return maxLength;
        }
    }
}