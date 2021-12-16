using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _21
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Приветствую тебя игрок)))");

            string card;
            int sum = 0;
            int j = 10;
            for (int counter = 1; counter < 6; counter++)
            {
              Console.Write($"Введите значение {counter} карты:");
                card = (Console.ReadLine());

                switch (card)
                {
                    case "6":  sum = sum + 6; break;
                    case "7":  sum = sum + 7; break;
                    case "8":  sum = sum + 8; break;
                    case "9":  sum = sum + 9; break;
                    case "10": sum = sum + 10; break;
                    case "j":  sum = sum + 10;break;
                    default: Console.WriteLine("Такой карты не существует вколоде попробуйте еще раз:");
                        counter += -1;
                        break;

                }

            }

            Console.Write($"Сумма карт на руках: {sum}");

            Console.ReadKey(); //  необходимо зациклить игру что бы она начиналась с начала 
        }
    }
}
