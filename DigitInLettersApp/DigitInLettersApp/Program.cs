using System;

namespace LettersApp
{
    class Program
    {
        static void Main()
        {
            int a;
            string s1 = "";                                              //Разряды
            string s2 = "";
            string s3 = "";
            string s4 = "";
            string s5 = "";
        Back1:                                                          // Метка на goto (Простите я знаю что это плохо его использовать)
            Console.WriteLine("Введите число до 9999");                 //Проверка на на размер числа и число ли это вообще
            try
            {
                a = Convert.ToInt32(Console.ReadLine());
                if (a > 9999)
                {
                    Console.WriteLine("Число слишком большое попробуйте снова");
                    Console.ReadKey();
                    Console.Clear();
                    goto Back1;
                }
                
            }
            catch
            {
                Console.WriteLine("Вы ввели не число, нажмите любую клавишу и попробуйте снова");
                Console.ReadKey();
                Console.Clear();
                goto Back1;
            }
            Console.WriteLine("");
            switch (a / 1000)                                                     //првоерка на число в разряде, и так для каждого разряда
            {
                case 1:
                    s1 = ("Тысяча ");
                    break;
                case 2:
                    s1 = ("Две тысячи ");
                    break;
                case 3:
                    s1 = ("Три тысячи ");
                    break;
                case 4:
                    s1 = ("Четыре тысячи ");
                    break;
                case 5:
                    s1 = ("Пять тысячь ");
                    break;
                case 6:
                    s1 = ("Шесть тысячь ");
                    break;
                case 7:
                    s1 = ("Семь тысячь ");
                    break;
                case 8:
                    s1 = ("Восемь тысячь ");
                    break;
                case 9:
                    s1 = ("Девять тысячь ");
                    break;
                default: break;
            }

            switch ((a % 1000) / 100)
            {
                case 1:
                    s2 = ("сто ");
                    break;
                case 2:
                    s2 = ("двести ");
                    break;
                case 3:
                    s2 = ("триста ");
                    break;
                case 4:
                    s2 = ("четыреста ");
                    break;
                case 5:
                    s2 = ("пятьсот ");
                    break;
                case 6:
                    s2 = ("шестьсот ");
                    break;
                case 7:
                    s2 = ("семьсот ");
                    break;
                case 8:
                    s2 = ("восемьсот ");
                    break;
                case 9:
                    s2 = ("девятьсот ");
                    break;
                default: break;
            }

            switch ((a % 100) / 10)
            {
                case 2:
                    s3 = ("двадцать ");
                    break;
                case 3:
                    s3 = ("тридцать ");
                    break;
                case 4:
                    s3 = ("сорок ");
                    break;
                case 5:
                    s3 = ("пятдесят ");
                    break;
                case 6:
                    s3 = ("шестьдесят ");
                    break;
                case 7:
                    s3 = ("семьдесят ");
                    break;
                case 8:
                    s3 = ("восемьдесят ");
                    break;
                case 9:
                    s3 = ("девяносто ");
                    break;
                default: break;
            }
            if (a % 100 >= 10 & a % 100 < 20)
            {
                switch (a % 100)
                {
                    case 10:
                        s4 = ("десять ");
                        break;
                    case 11:
                        s4 = ("одинадцать рублей ");
                        break;
                    case 12:
                        s4 = ("двенадцать рублей ");
                        break;
                    case 13:
                        s4 = ("тринадцать рублей ");
                        break;
                    case 14:
                        ; s4 = ("четырнадцать рублей ");
                        break;
                    case 15:
                        s4 = ("пятнадцать рублей ");
                        break;
                    case 16:
                        s4 = ("шестнадцать рублей ");
                        break;
                    case 17:
                        s4 = ("семнадцать рублей ");
                        break;
                    case 18:
                        s4 = ("восемнадцать рублей ");
                        break;
                    case 19:
                        s4 = ("девятнадцать рублей ");
                        break;
                }
            }
            else
            {
                switch (a % 10)
                {
                    case 1:
                        s4 = ("один рубль");
                        break;
                    case 2:
                        s4 = ("два рубля");
                        break;
                    case 3:
                        s4 = ("три рубля");
                        break;
                    case 4:
                        s4 = ("четыре рубля");
                        break;
                    case 5:
                        s4 = ("пять рублей");
                        break;
                    case 6:
                        s4 = ("шесть рублей");
                        break;
                    case 7:
                        s4 = ("семь рублей");
                        break;
                    case 8:
                        s4 = ("восемь рублей");
                        break;
                    case 9:
                        s4 = ("девять рублей");
                        break;
                }
            }
            if (a == 0)                                      //особые случаи
            {
                s1 = ("ноль рублей");
            }

            if (a % 10 == 0)
            {
                s5 = "рублей";
            }

            Console.WriteLine("");
            string sf = string.Join("", s1, s2, s3, s4, s5);
            sf = sf.Trim();
            sf = char.ToUpper(sf[0]) + sf.Substring(1);                        //делаем строку с большой буквы
            Console.WriteLine(sf);
        }
    }
}
