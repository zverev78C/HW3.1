﻿using System;
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
            Console.WriteLine("Приветствую тебя игрок)))");   // приветствие игрока

            string card;                                     // задание переменной для карт
            int sum = 0;                                     // инициализация переменной для суммы очков
            
            for (int counter = 1; counter < 6; counter++)          // создание цикла со счетчико м в 5 карт
            {
              Console.Write($"Введите значение {counter} карты:");  // программа просит игрока ввсети карту
                card = (Console.ReadLine());

                switch (card)                             // в блоке свитч происходит перебор значений карт и при совпадении в сумму добовляется соответствующие количество очков
                {
                    case "2": sum = sum + 2; break;
                    case "3": sum = sum + 3; break;
                    case "4": sum = sum + 4; break;
                    case "5": sum = sum + 5; break;
                    case "6":  sum = sum + 6; break;
                    case "7":  sum = sum + 7; break;
                    case "8":  sum = sum + 8; break;
                    case "9":  sum = sum + 9; break;
                    case "10": sum = sum + 10; break;
                    case "j":  sum = sum + 10;break;
                    case "J": sum = sum + 10; break;
                    case "q": sum = sum + 10; break;
                    case "Q": sum = sum + 10; break;
                    case "k": sum = sum + 10; break;
                    case "K": sum = sum + 10; break;
                    case "t": sum = sum + 10; break;
                    case "T": sum = sum + 10; break;
                    default: Console.WriteLine("Такой карты не существует в колоде попробуйте еще раз:"); // при несовпадении программа просит ввсети карту заново (счетчик не засчитывает попытку)
                        counter += -1;
                        break;

                }

            }

            Console.Write($"Сумма карт на руках: {sum}");   // выводится количество очков на руках

            Console.ReadKey(); //  необходимо зациклить игру что бы она начиналась с начала 
        }
    }
}
