﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework_Theme_03
{
    class Program
    {
        static void Main(string[] args)
        {
            #region(task)
            // Просматривая сайты по поиску работы, у вас вызывает интерес следующая вакансия:

            // Требуемый опыт работы: без опыта
            // Частичная занятость, удалённая работа
            //
            // Описание 
            //
            // Стартап «Micarosppoftle» занимающийся разработкой
            // многопользовательских игр ищет разработчиков в свою команду.
            // Компания готова рассмотреть C#-программистов не имеющих опыта в разработке, 
            // но желающих развиваться в сфере разработки игр на платформе .NET.
            //
            // Должность Интерн C#/
            //
            // Основные требования:
            // C#, операторы ввода и вывода данных, управляющие конструкции 
            // 
            // Конкурентным преимуществом будет знание процедурного программирования.
            //
            // Не технические требования: 
            // английский на уровне понимания документации и справочных материалов
            //
            // В качестве тестового задания предлагается решить следующую задачу.
            //
            // Написать игру, в которою могут играть два игрока.
            // При старте, игрокам предлагается ввести свои никнеймы.
            // Никнеймы хранятся до конца игры.
            // Программа загадывает случайное число gameNumber от 12 до 120 сообщая это число игрокам.
            // Игроки ходят по очереди(игра сообщает о ходе текущего игрока)
            // Игрок, ход которого указан вводит число userTry, которое может принимать значения 1, 2, 3 или 4,
            // введенное число вычитается из gameNumber
            // Новое значение gameNumber показывается игрокам на экране.
            // Выигрывает тот игрок, после чьего хода gameNumber обратилась в ноль.
            // Игра поздравляет победителя, предлагая сыграть реванш
            // 
            // * Бонус:
            // Подумать над возможностью реализации разных уровней сложности.
            // В качестве уровней сложности может выступать настраиваемое, в начале игры,
            // значение userTry, изменение диапазона gameNumber, или указание большего количества игроков (3, 4, 5...)

            // *** Сложный бонус
            // Подумать над возможностью реализации однопользовательской игры
            // т е игрок должен играть с компьютером


            // Демонстрация
            // Число: 12,
            // Ход User1: 3
            //
            // Число: 9
            // Ход User2: 4
            //
            // Число: 5
            // Ход User1: 2
            //
            // Число: 3
            // Ход User2: 3
            //
            // User2 победил!
            #endregion


            // Приветствие
            Console.WriteLine("Приветствую вас игроки.\n Вы в игре.");   // Игра приветствует игроков


            // создание игроков в кол-ве до 2-5 
            #region (Количество игроков)

            while (true)   // цикл необходим на случай если пользователь решит создать больше 5 игроков
            {
                Console.WriteLine("сколько игроков будет участвовать?:");
                int gamers = int.Parse(Console.ReadLine());

                if (gamers == 2)                // каскад условий для выбора количества игроков (наверное надо было делать через switch)
                {
                    Console.WriteLine("Игрок 1 представьтесь пожалуста:");
                    String User1 = (Console.ReadLine());
                    Console.WriteLine("Игрок 2 представьтесь пожалуста:");
                    String User2 = (Console.ReadLine());
                }
                else
                {
                    if (gamers == 3)
                    {
                        Console.WriteLine("Игрок 1 представьтесь пожалуста:");
                        String User1 = (Console.ReadLine());
                        Console.WriteLine("Игрок 2 представьтесь пожалуста:");
                        String User2 = (Console.ReadLine());
                        Console.WriteLine("Игрок 3 представьтесь пожалуста:");
                        string User3 = (Console.ReadLine());
                    }
                    else
                    {
                        if (gamers == 4)
                        {
                            Console.WriteLine("Игрок 1 представьтесь пожалуста:");
                            String User1 = (Console.ReadLine());
                            Console.WriteLine("Игрок 2 представьтесь пожалуста:");
                            String User2 = (Console.ReadLine());
                            Console.WriteLine("Игрок 3 представьтесь пожалуста:");
                            string User3 = (Console.ReadLine());
                            Console.WriteLine("Игрок 4 представьтесь пожалуста:");
                            string User4 = (Console.ReadLine());
                        }
                        else
                        {
                            if (gamers == 5)
                            {
                                Console.WriteLine("Игрок 1 представьтесь пожалуста:");
                                String User1 = (Console.ReadLine());
                                Console.WriteLine("Игрок 2 представьтесь пожалуста:");
                                String User2 = (Console.ReadLine());
                                Console.WriteLine("Игрок 3 представьтесь пожалуста:");
                                string User3 = (Console.ReadLine());
                                Console.WriteLine("Игрок 4 представьтесь пожалуста:");
                                string User4 = (Console.ReadLine());
                                Console.WriteLine("Игрок 5 представьтесь пожалуста:");
                                string user5 = (Console.ReadLine());
                            }
                            else
                            {
                                Console.WriteLine("Слишком много игроков))))");
                            }
                        }
                    }
                }
                break;
            }
            #endregion


            // возможность изменения максимального значения загадоного числа (размер игры)

            #region(Размер игры)

            int gameNumber;  // переменная для числа игры
            int randmax;     // переменная для ограничения игры

            while (true)
            {
                Console.WriteLine("Введите пожалуйста желаемый размер игры от 12 до 300:");  // программма просит пользователя ввести размер игры я ограничил это число 12 и 300
                randmax = int.Parse(Console.ReadLine());

                if (randmax > 11 && randmax < 301)     // каскад условий который ограничивает размер загадываемого числа
                {
                    break;
                }
                else
                {
                    if (randmax > 300)
                    {
                        Console.WriteLine("Слишком большой размер)))))");
                    }
                    else
                    {
                        Console.WriteLine("Слишком маленьки роазмер игры все быстро закончится");
                    }
                }
            }
            Random rand = new Random();
            gameNumber = rand.Next(12, randmax);  // создается случайным образом число в пределах заданных параметров
            #endregion

            // возможность изменения шага хода (сложность)

            #region(Шаг игры)
            int userTry;
            int maxLimitTurn = 4;  // Ограничение максимального значения хода

            #endregion

            #region(Тело игры)
            while (gameNumber > 0)      
            {
                Console.WriteLine($"Остаток: {gameNumber}");

                //switch (gameNumber)
                //    case 1:
                Console.WriteLine("Your turn:");
                userTry = int.Parse(Console.ReadLine());

                if (userTry > maxLimitTurn)
                {
                    Console.WriteLine("Your turn:");
                }
                else
                {
                    gameNumber = gameNumber - userTry;
                }
            }

            Console.WriteLine($"game over: {gameNumber}");
            #endregion

            Console.ReadKey();
        }
    }
}
