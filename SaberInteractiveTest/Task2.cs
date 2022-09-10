using System.Text;

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
            char[] charWithoutDuplicates = new char[text.Length];
            int charCount = 0;
            int index = 0;

            charWithoutDuplicates[charCount] = text[index]; //Добавление первого символа строки в результирующий массив символов
            index++;
            
            for (;index < text.Length; index++) //Обработка оставшихся символов
            {
                if (text[index] == charWithoutDuplicates[charCount]) continue;
                charWithoutDuplicates[++charCount] = text[index];
            }

            return new string(charWithoutDuplicates, 0, charCount+1);
        }
        static public string RemoveDuplicates(StringBuilder text)
        {
            char[] charWithoutDuplicates = new char[text.Length];
            int charCount = 0;
            int index = 0;

            charWithoutDuplicates[charCount] = text[index]; //Добавление первого символа строки в результирующий массив символов
            index++;

            for (; index < text.Length; index++) //Обработка оставшихся символов
            {
                if (text[index] == charWithoutDuplicates[charCount]) continue;
                charWithoutDuplicates[++charCount] = text[index];
            }

            return new string(charWithoutDuplicates, 0, charCount + 1);
        }
    }
}
