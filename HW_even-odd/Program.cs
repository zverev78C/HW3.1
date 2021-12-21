using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HW_even_odd
{
    class Program
    {
        static void Main(string[] args)

        {
            Console.WriteLine("Введите целое число:");    // программа просит пользователя ввести число
            int number = int.Parse( Console.ReadLine());  // переменная для введенного числа

            if (number % 2 == 0)  // определение четности числа через деление с остатком
            {
                Console.WriteLine("Число четное");  // действие при четности числа
            }
            else
            {
                Console.WriteLine("Число не четное");  // действие при не четности числа
            }
            Console.ReadKey();  // консоль ожидает нажатия любой кнопки для закрытия 
        }
    }
}
