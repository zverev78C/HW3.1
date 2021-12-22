using System;
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

            string User1 = "1";
            string User2 = "2";
            string User3 = "3";
            string User4 = "4";
            string User5 = "5";
            int gamers = 0;                // переменная количества игроков
            string ActiveName = "1";   // переменная для имени активного игрока
            int ActiveUser = gamers;   // переменная для очередности ходов
            int cpuTry = 1;            // переменная для хода компьютера
            int gameNumber;  // переменная для числа игры
            int randmax;     // переменная для ограничения игры
            string revenge;


            Console.WriteLine("сколько игроков будет участвовать?:");
            gamers = int.Parse(Console.ReadLine());

            for (int UserName = 1; UserName <= gamers; UserName++)
            {
                Console.WriteLine($"Игрок {UserName} представьтесь пожалуста:");
                ActiveName = (Console.ReadLine());

                switch (UserName)
                {
                    case 1: User1 = ActiveName; break;
                    case 2: User2 = ActiveName; break;
                    case 3: User3 = ActiveName; break;
                    case 4: User4 = ActiveName; break;
                    case 5: User5 = ActiveName; break;
                    default: Console.WriteLine("WTF");
                        break;
                }
            }
           
            #endregion

            // возможность изменения максимального значения загаданного числа (размер игры)
            #region(Размер игры)

            

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
                        Console.WriteLine("Слишком маленький размер игры все быстро закончится");
                    }
                }
            }
            #endregion

            // возможность изменения шага хода (сложность)
            #region(Шаг игры)

            Console.WriteLine("ВВедите пожалуйста желаемый шаг игры (максимально возможный ход игрока)");
            int maxLimitTurn = int.Parse(Console.ReadLine());  // Ограничение максимального значения хода

            int userTry;


            #endregion

            #region(Тело игры)
            do
            {
                Random rand = new Random();
                gameNumber = rand.Next(12, randmax);  // создается случайным образом число в пределах заданных параметров

                if (gamers == 1)
                {
                    User2 = "CPU";
                    gamers = 2;

                    while (gameNumber > 0)
                    {
                        ActiveUser++;
                        if (ActiveUser > gamers)
                        {
                            ActiveUser = 0;
                        }

                        else
                        {
                            switch (ActiveUser)
                            {
                                case 1:
                                    Console.WriteLine($"Остаток: {gameNumber}");
                                    Console.WriteLine($"{User1} ваш ход:");
                                    userTry = int.Parse(Console.ReadLine());

                                    if (userTry > maxLimitTurn)
                                    {
                                        Console.WriteLine($"Слишком большой ход максимум {maxLimitTurn}\nПопробуйте еще раз:");
                                    }
                                    else
                                    {
                                        gameNumber = gameNumber - userTry;
                                    }
                                    break;
                                case 2:
                                    Console.WriteLine($"Остаток: {gameNumber}");
                                    Console.WriteLine($"{User2} ваш ход:");

                                    if (gameNumber < maxLimitTurn * 2)
                                    {
                                        if (gameNumber <= maxLimitTurn)
                                        {
                                            cpuTry = gameNumber;
                                            gameNumber = gameNumber - cpuTry;
                                        }
                                        else
                                        {
                                            cpuTry = gameNumber - maxLimitTurn - 1;
                                            gameNumber = gameNumber - cpuTry;
                                            Console.WriteLine($"{cpuTry}");
                                        }
                                    }
                                    else
                                    {
                                        cpuTry = gameNumber - maxLimitTurn;
                                        gameNumber = gameNumber - maxLimitTurn;
                                        Console.WriteLine($"{maxLimitTurn}");
                                    }
                                    break;
                                default:
                                    Console.WriteLine("WTF");
                                    break;
                            }
                        }
                    }
                }
                else
                {
                    while (gameNumber > 0)      // Оновной цикл игры
                    {
                        ActiveUser++;
                        if (ActiveUser > gamers)
                        {
                            ActiveUser = 0;
                        }
                        else
                        {
                            switch (ActiveUser)
                            {
                                case 1:
                                    ActiveName = User1;
                                    break;
                                case 2:
                                    ActiveName = User2;
                                    break;
                                case 3:
                                    ActiveName = User3;
                                    break;
                                case 4:
                                    ActiveName = User4;
                                    break;
                                case 5:
                                    ActiveName = User5;
                                    break;
                            }

                            Console.WriteLine($"Остаток: {gameNumber}");
                            Console.WriteLine($"{ActiveName} ваш ход:");
                            userTry = int.Parse(Console.ReadLine());

                            if (userTry > maxLimitTurn)
                            {
                                Console.WriteLine($"Слишком большой ход максимум {maxLimitTurn}\nПопробуйте еще раз:");
                            }
                            else
                            {
                                gameNumber = gameNumber - userTry;
                            }
                        }
                    }
                }
                #endregion

                // окончание игры
                Console.WriteLine($"game over: {ActiveName} победил, поздравляю!!!");
                Console.WriteLine($"Матч Реванш? нажмите 1");
                revenge = (Console.ReadLine());
            } while (revenge == "1");

            Console.ReadKey();
        }
    }
}
