namespace SaberInteractiveTest
{
    /// <summary>
    /// Класс реализующий функцию получения двоичного представления числа.
    /// </summary>
    static public class Task1
    {
        /// <summary>
        /// Метод получения двоичного представления десятичного числа
        /// </summary>
        /// <param name="decNumber">Число в десятичной системе счисления</param>
        /// <returns>Строка - двоичное представление</returns>
        static public string GetBinaryNumber(int decNumber)
        {
            int digitCount = 0;
            int point = 0;
            char[] binaryDigits = new char[32];
            int bitChecker = 1 << 30;
            
            if ((decNumber & int.MinValue) == int.MinValue) //Проверка знака исходного числа
            {
                binaryDigits[digitCount++] = '1';
            }
            else
            {
                while ((decNumber & bitChecker) == 0) //Пропуск первых незначимых нулей, если число положительное
                {
                    bitChecker >>= 1;
                    point++;
                }
            }
            
            for (; point < 31; point++) //Проверка разрядов на предмет их значения
            {
                if ((decNumber & bitChecker) == bitChecker)
                {
                    binaryDigits[digitCount++] = '1';
                }
                else
                {
                    binaryDigits[digitCount++] = '0';
                }
                bitChecker >>= 1;
            }
            return new string(binaryDigits, 0, digitCount);
        }
    }
}
