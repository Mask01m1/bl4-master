using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace Basic.Lesson_4._1
{
    partial class Practice
    {
        //B4-P1/25. If_TimeOfDayGreeting
        public static void B4_P1_25_If_TimeOfDayGreeting()
        {
        }

        //B4-P2/25. If_NumbersComparing
        public static void B4_P2_25_If_NumbersComparing()
        {
        }

        //B4-P3/25. If_PositiveNumbersComparing
        public static void B4_P3_25_If_PositiveNumbersComparing()
        {
        }

        //B4-P4/25. If_Akinator5Numbers
        public static void B4_P4_25_If_Akinator5Numbers()
        {

        }

        //B4-P5/25. Switch_DayOfWeek
        public static void B4_P5_25_Switch_DayOfWeek()
        {
        }

        //B4-P6/25. Switch_GameNavigation
        public static void B4_P6_25_Switch_GameNavigation()
        {

        }

        //B4-P7/25. For_10OddEven
        public static void B4_P7_25_For_10OddEven()
        {

        }


        //B4-P8/25. For_3DevideNumbers
        public static void B4_P8_25_For_3DevideNumbers()
        {
        }


        //B4-P9/25. For_Matrix10x10
        public static void B4_P9_25_For_Matrix10x10()
        {

        }


        //B4-P10/25. For_HelloWorld
        public static void B4_P10_25_For_HelloWorld()
        {
        }


        //B4_P11/25. For_Afrochildren
        public static void B4_P11_25_For_Afrochildren()
        {

        }


        //B4-P12/25. For_Minus10OddEven
        public static void B4_P12_25_For_Minus10OddEven()
        {
        }


        //B4-P13/25 For_LettersCount
        public static void B4_P13_25_For_LettersCount()
        {
            int c = 0, i = 0;
            int leng;
            char temp;
            Console.Write("введите слово: ");
            string word = Console.ReadLine();

            leng = word.Length;

            while (i < leng)
            {
                temp = word[i];
                if (temp == 'a')
                {
                    c++;
                }

                i++;
            }

            Console.WriteLine($"количество букв'а'равно: {c}");
        }


        //B4-P14/25 *For_AlphabetBack
        public static void B4_P14_25_For_AlphabetBack()
        {
            for (char i = 'z'; i >= 'a'; i--)
            {
                Console.Write($"{i} ");
            }

            Console.ReadKey(true);
        }


        //B4-P15/25 While_OddEventNumber
        public static void B4_P15_25_While_OddEventNumber()
        {

        }


        //B4-P16/25 DoWhile_OddEventNumber
        public static void B4_P16_25_DoWhile_OddEventNumber()
        {

        }


        //B4-P17/25 While_HelloWorld
        public static void B4_P17_25_While_HelloWorld()
        {
        }


        //B4-P18/25 While_Multiplier
        public static void B4_P18_25_While_Multiplier()
        {
            int a1 = 1, a2 = 1;
            Console.Write("введите число ");
            int a = Convert.ToInt32(Console.ReadLine());
            Console.Write("второе число ");
            int b = Convert.ToInt32(Console.ReadLine());

            while (b == 0)
            {
                a = 0;
            }

            while (b == 1)
            {
                a = 1;
            }

            while (b > 1 && a2 <= b)
            {
                a1 *= a;
                a2++;
            }

            Console.Write($"число {a} в степени {b} равно:{a1}");
        }


        //B4-P19/25 While_SolveNumberAdding
        public static void B4_P19_25_While_SolveNumberAdding()
        {

        }


        //B4-P20/25 While_DiceGame
        public static void B4_P20_25_While_DiceGame()
        {
            int b = 0, move = 0;
        statloop:
            Console.Write("введите число от одного до шести: ");
            int a = Convert.ToInt32(Console.ReadLine());
            while (a > 0 && a <= 6)
            {
                move += a;
                while (move < 25)
                {
                    goto statloop;
                }

                while (move >= 25)
                {
                    Console.WriteLine("you win!");
                    break;
                }

                break;
            }

            if (a <= 0 || a >= 6)
            {
                Console.WriteLine("вы ввели неправильное число");
            }
        }


        //B4-P21/25 *While_DiceGameMultiplePlayers
        public static void dB4_P21_25_While_DiceGameMultiplePlayers()
        {
            int b = 0, move = 0, move1 = 0;
        statloop:
            Console.WriteLine("первый игрок введите число от одного до шести: ");
            int a = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("второй игрок введите число от одного до шести: ");
            int a1 = Convert.ToInt32(Console.ReadLine());
            while ((a > 0 && a <= 6) && (a1 > 0 && a1 <= 6))
            {
                move += a;
                move1 += a1;
                while ((move < 25) && (move1 < 25))
                {
                    Console.Write($"Ходы первого игрока: {move} ");
                    Console.WriteLine($"Ходы второго игрока: {move1} ");
                    goto statloop;
                }

                while (move >= 25)
                {
                    Console.WriteLine("Победил первый игрок");
                    break;
                }

                while (move1 >= 25)
                {
                    Console.WriteLine("победил второй игрок");
                    break;
                }

                break;
            }

            if (a <= 0 || a >= 6)
            {
                Console.WriteLine("первый игрок ввел неправильное число");
            }

            if (a1 <= 0 || a1 >= 6)
            {
                Console.WriteLine("второй игрок ввел неправильное число");
            }
        }


        //B4-P22_25 *While_Akinator100Numbers
        public static void B4_P22_25_While_Akinator100Numbers()
        {
            int i = 0;
            double num = 100;
            Console.WriteLine("Загадайте число от 1 до 100");
            int x = Convert.ToInt16(Console.ReadLine());

            while (x != num)
            {
                if (x < num)
                {
                    num = Math.Ceiling(num = num / 2 - 1);
                    //Console.Write($"{mass[num]} ");

                }
                if (x > num)
                {
                    num = Math.Ceiling(num = num / 2 + num);
                    //Console.Write($"{num} ");

                }

                i++;
                Console.Write($"{i}:{num} ");
            }
        }


        //B4-P23/25 IfElse_Calcultor
        public static void B4_P23_25_IfElse_Calcultor()
        {

        }


        //B4-P24_25 Switch_Calculator
        public static void B4_P24_25_Switch_Calculator()
        {

        }


        //B4-P25/25 Cycle_WordRevercse
        public static void B4_P25_25_Cycle_WordRevercse()
        {
            int leng;
            char temp;
            Console.Write("введите слово: ");
            string word = Console.ReadLine();

            leng = word.Length;
            while (leng >= 1)
            {
                leng--;
                temp = word[leng];
                Console.Write(temp);
            }
        }
    }
}