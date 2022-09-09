using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SaberInteractiveTest
{
    static public class Task1
    {
        static public string GetBinaryNumber(int decNumber)
        {
            string result = "";
            while (decNumber != 0)
            {
                result = decNumber % 2 + result;
                decNumber = decNumber / 2;
            }
            return result;
        }
    }
}
