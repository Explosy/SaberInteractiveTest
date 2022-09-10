using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SaberInteractiveTest
{
    /// <summary>
    /// Класс реализующий функцию удаления дубликатов символов из строки.
    /// </summary>
    static public class Task2
    {
        /// <summary>
        /// Метод, удаляющий дубликаты из строки
        /// </summary>
        /// <param name="text">Исходная строка с дубликатами</param>
        /// <returns>Возвращает строку с неповторяющимися подряд символами</returns>
        static public string RemoveDuplicates(string text)
        {
            char currentChar;
            char[] charWithoutDuplicates = new char[text.Length];
            int charCount = 0;
            int index = 0;

            
            charWithoutDuplicates[charCount] = text[index]; //Добавление первого символа строки в результирующий массив символов
            index++;
            
            do //Обработка всех последующих символов
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
