using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SaberInteractiveTest
{
    static public class Task2
    {
        static public string RemoveDuplicates(string text)
        {
            char currentChar;
            char[] charWithoutDuplicates = new char[text.Length];
            int charCount = 0;
            int index = 0;


            charWithoutDuplicates[charCount] = text[index];
            index++;
            do
            {
                currentChar = text[index];
                if (currentChar != charWithoutDuplicates[charCount])
                {
                    charWithoutDuplicates[++charCount] = currentChar;
                }
                index++;
            }
            while (index < text.Length);

            return new string(charWithoutDuplicates, 0, charCount+1);
        }
    }
}
