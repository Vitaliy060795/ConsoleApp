using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.RegularExpressions;
using System.Collections;

namespace ConsoleApp1
{
    class SomeExampleNonStaticClass
    {
        
     public   static double somestaticfield;
        
        static SomeExampleNonStaticClass()
        {
            int a = 2;
            long b = 10;
            b = a;
            a = (int)b;
            Console.Read();
        }
    }


    class Program
    {
        static void Main(string[] args)
        {
            SomeExampleNonStaticClass classex1 = new SomeExampleNonStaticClass();// А здесь компилятор установит точку вызова нестатического конструктора по умолчанию.
            //Console.WriteLine(classex1.somestaticfield);


        }
      
      

        public static IEnumerable<string> MyLanguages(Dictionary<string, int> results)
        {
            var sortedDict = from entry in results orderby entry.Value descending select entry;
            List<string> answList = new List<string>();
            foreach (KeyValuePair<string, int> pair in sortedDict)
            {
                if (pair.Value > 59) answList.Add(pair.Key);
            }
            return answList;
        }

        public static bool IsLeapYear(int year)
        {
            if (year % 4 == 0 && (year / 100) % 4 == 0)
            { return true; }
            else
            { return false; }

        }

        public static string[] SortByLength(string[] array)//сортирует по количеству символов в строке в массиве
        {
            var res = array.OrderBy(t => t.Length);
            int count = 0;
            foreach(string i in res)
            {
                count++;
            }
            string[] mas = new string[count];
            count = 0;
            foreach(string i in res)
            {
                mas[count] = i;
                count++;
            }
            return mas;
        }

        public static int WhereIsHe(int p, int bef, int aft)
        {
            return Math.Min(1 + aft, p - bef);
        }

        public static string HighAndLow(string numbers)
        {
            string[] temp = numbers.Split(' ');
            int[] mass = new int[temp.Length];
            int count = 0;
            foreach (string i in temp)
            {
                int.TryParse(i, out int num);
                mass[count] = num;
                count++;
            }
            return $"{mass.Max()} {mass.Min()}";
        }


        public static string GeometricSequenceElements(int a, int r, int n)
        {
            int temps = a;
            string temp = "";
           for(int i = 0;i < n; i ++)
            {
                temp += temps.ToString();
                temp += ", ";
                temps = temps * r;
            }
            return temp.TrimEnd(' ', ',');
        }


        public static bool IsSquare1(int n)//возвращает корень
        {
            return Math.Sqrt(n) % 1 == 0;
        }


        public static bool IsSquare(int n)
        {
            if (n >= 0)
            {
                if(n == 0 || n == 1 )
                {
                    return true;
                }
                for(int i = 0; i < n; i++)
                {
                    if (i * i == n)
                    {
                        return true;
                    }
                }
            }
            else
            {
                return false;
            }
            return false;
        }


        public static string AlphabetWar(string fight)
        {
            int Right = 0;
            int Left = 0;
           for(int i = 0;i < fight.Length;i++)
            {
                switch(fight[i])
                {
                    case 'w':
                        Left += 4;
                        continue;
                    case 'p':
                        Left += 3;
                        continue;
                    case 'b':
                        Left += 2;
                        continue;
                    case 's':
                        Left += 1;
                        continue;
                    case 'm':
                        Right += 4;
                        continue;
                    case 'q':
                        Right += 3;
                        continue;
                    case 'd':
                        Right += 2;
                        continue;
                    case 'z':
                        Right += 1;
                        continue;
                    default:
                        continue;
                }
            }
            if (Right > Left)
            {
                return "Right side wins!";
            }
            else if (Left > Right)
            {
                return "Left side wins!";
            }
            else  
            {
                return "Let's fight again!";
            }
        }

        public static bool FitSquares(int a, int b, int m, int n)
        {
            if ((a <= m && a <= n && b <= m && b <= n) && (a + b <= m || a + b <= n))
            {
                return true;
            }
            else
            {
                return false;
            }
        }


        public static string ReverseWords(string str)
        {
            string[] garr = str.Split(' ');
            string temp = "";
            foreach(string i in garr)
            {
                char[] arr = i.ToCharArray();
                Array.Reverse(arr);
                temp += new string(arr);
                temp += " ";
            }
            string m = temp.TrimEnd(' ');
            return m;
        }

        public static int FindShort(string s)//разделяет строку в массив и записывает длину самого короткого слова
        {
            int temp = 0;
            string[] garr = s.Split(' ');
            foreach(string i in garr)
            {
                if(temp == 0 || i.Length < temp)
                {
                    temp = i.Length;
                }
                
            }
            return temp;
        }


            public static string Swap(string s)//меняет регистр
        {
            string temp = "";
            for(int i = 0;i < s.Length;i++)
            {
                if(s[i] == 'a' || s[i] == 'A' || s[i] == 'e' || s[i] == 'E' || s[i] == 'o' || s[i] == 'O' || s[i] == 'u' || s[i] == 'U' || s[i] == 'i' || s[i] == 'I'  )
                {
                    temp += char.ToUpper(s[i]);
                }
                else
                {
                    temp += s[i];
                }
            }
            return temp;
        }

        public static string Repeater(string s, int n)//пишет строку Х раз
        {
            string temp = "";
            for(int i = 0;i < n;i++)
            {
                temp += s;
            }
            return temp;
        }

        public static string TwoSort(string[] s)
        {
            string ret = "";
            List<string> listTemp = new List<string>();
          foreach(string temp in s)
            {
                listTemp.Add(temp);
            }
            listTemp.Sort(StringComparer.Ordinal);


            for (int i = 0;i < listTemp[0].Length;i++)
                {
                    ret += listTemp[0][i];
                    ret += "***";
                }
            return ret.TrimEnd('*');
            
        }

        public static int SumMul(int n, int m)
        {
            int temp = 0;
            if(n < m && n > 0)
            {
                for (int i = n; i <= m;i = i+n)
                {
                    temp += i ;
                }
            return temp;
            }
            throw new ArgumentException();
        }



        public static string Stringy(int size)
        {
            string m = "";
            for(int i = 1; i < size + 1;i++)
            {
               if(i % 2 == 0)
                {
                    m += "0";
                }
               else
                {
                    m += "1";
                }
            }
            return m;
            
        }

        public static string Solution(string str)
        {
            char[] arr = str.ToCharArray();
            Array.Reverse(arr);
            return new string(arr);
        }

        public static long[] Digitize(long n)
        {
            var temp = n.ToString().Reverse();
            int temp2 = 0;
            foreach(int i  in temp)
            {
                temp2++;
            }
            int count = 0;
            long[] temp3 = new long[temp2];
            foreach (char i in temp)
            {
                long.TryParse(i.ToString(), out long num);
                Console.WriteLine(num);
                temp3[count] = num;
                count++;
            }
            return temp3;
        }

        public static string[] StringToArray(string str)//Добовляет в массив слова которые в строке и через пробел
        {
            string[] garr = str.Split(' ');
            return garr;
        }

        public static int[] distinct(int[] a)
        {
            List<int> m = new List<int>();
            var temp = a.Distinct();
            foreach (int i in temp)
            {
                m.Add(i);
            }
            int[] ret = new int[m.Count];
            int count = 0;
            foreach(int k in m)
            {
                ret[count] = k;
                count++;
            }
            return ret;
        }

        public static string SwitchItUp(int number)
        {
                switch(number)
                {
                    case 0:
                        return "Zero";
                    case 1:
                        return "One";
                    case 2:
                        return "Two";
                    case 3:
                        return "Three";
                    case 4:
                        return "Four";
                    case 5:
                        return "Five";
                    case 6:
                        return "Six";
                    case 7:
                        return "Seven";
                    case 8:
                        return "Eight";
                    case 9:
                        return "Nine";
                
                }
            return "";
        }

        public static string ToAlternatingCase( string s)//меняет регистр на обратный
        {
            string temp = "";
            for(int i = 0; i < s.Length;i++)
            {
                if(char.IsLower(s[i]))
                {
                    temp += s[i].ToString().ToUpper();
                }
                else
                {
                    temp += s[i].ToString().ToLower();
                }
            }
            return temp;
        }

        public static bool Xor(bool a, bool b)
        {
            return a ^ b;
        }

        public static Boolean ContainAllRots(string strng, List<string> arr)
        {
            foreach (string x in arr)
            {
                if (x == strng || strng == "")
                {
                    return true;
                }
            }
            return false;
        }


        public static int Stray(int[] numbers)//удаляет из массива все одинаковые числа
        {
            return numbers.GroupBy(x => x).OrderBy(x => x.Count()).First().First();
        }

        public static bool Solution(string str, string ending)//Обрезает последниее символы в строке и стравнивает со второй строкой
        {
            if (str.EndsWith(ending))
            {
                return true;
            }
            else
            {
                return false;
            }
        }


        public static int ReverseNumbers(int n)//обратный порядок,сохраняя знак
        {
            string temp = n.ToString();
            int num = 0;
            string temp2 = "";
            if (temp[0] == '-')
            {
                temp2 = temp.TrimStart('-');
                temp2 = new string(temp2.Reverse().ToArray());
                int.TryParse(temp2, out num);
                num = num * (-1);
            }
            else
            {
                temp2 = n.ToString();
                temp2 = new string(temp2.Reverse().ToArray());
                int.TryParse(temp2, out num);

            }
            return num;


        }

        public static int NbDig(int n, int d)//перемножает все числа и возвращает число которое совпадает во всех перемноженных числах
        {
            int temp = 0;

            if (n >= 0 && d >= 0 && d <= 9)
            {
                char[] temp2 = d.ToString().ToCharArray();
                for (int i = 0; i <= n; i++)
                {
                    int k = i * i;
                    for (int j = 0; j < k.ToString().Length; j++)
                    {
                        if (k.ToString()[j] == temp2[0])
                        {
                            temp++;
                        }
                    }
                }
            }
            return temp;

        }

        public static string Longest(string s1, string s2)//соеденяет строки и пишет в алфавитном порядке
        {
            string temp = "";
            temp += s1;
            temp += s2;
            temp = new string(temp.Distinct().ToArray());
            temp = String.Join("", temp.ToCharArray(0, temp.Length).OrderBy(c => c));
            return temp;
        }

        public static bool IsNegativeZero(double n)//проверяет отрицательный ноль или положительный
        {
            return double.IsNegativeInfinity(n) && n == 0.0;
        }


        public static string Accum(string s)
        {
            if (s.Length < 1) return "";

            StringBuilder sb = new StringBuilder();
            int count = 1;
            foreach (char c in s.ToLower())
                sb.Append(Char.ToUpper(c), 1)
                  .Append(c, count++ - 1)
                  .Append('-');

            return sb.ToString().TrimEnd('-');
        }


        public static long[] Seven(long m)//делится ли число на 7
        {
            long[] returns = new long[2];
            string g;
            long temps = m;
            long steps = 0;
            if (m.ToString().Length >= 3)
            {
                while (true)
                {
                    int.TryParse(temps.ToString()[temps.ToString().Length - 1].ToString(), out int num);
                    g = temps.ToString().Remove(temps.ToString().Length - 1);
                    long.TryParse(g, out long num2);
                    temps = num2 - (2 * num);
                    steps++;
                    if (temps.ToString().Length <= 2 && temps % 7 == 0)
                    {
                        returns[0] = temps;
                        returns[1] = steps;
                        break;
                    }
                    else if (temps.ToString().Length <= 2 && temps % 7 != 0)
                    {
                        returns[0] = temps;
                        returns[1] = steps;
                        break;
                    }
                }

            }
            else
            {
                if (m % 7 == 0)
                {
                    returns[0] = m / 7;
                    returns[1] = 0;
                }
                else
                {
                    returns[0] = 0;
                    returns[1] = 0;
                }

            }
            foreach (long c in returns)
            {
                Console.WriteLine(c);
            }
            return returns;
        }

        public static int UnluckyDays(int year)
        {
            // int day = (year % 4 != 0 || (year % 100 == 0 && year % 400 != 0)) ? 365 : 366;
            int j, m;
            m = 0;
            j = 1;

            for (int i = year; i < year + 100; i++)
            {
                for (j = 1; j <= 12; j++)
                {
                    DateTime dm = new DateTime(i, j, 13);
                    if (dm.DayOfWeek == DayOfWeek.Friday)
                        m += 1;
                }
            }
            return m;
        }

        public static int ExpressionsMatter(int a, int b, int c)//выводит самое большое число из примера
        {
            if (a > 0 && a < 10 && b > 0 && b < 10 && c > 0 && c < 10)
            {
                int aa = a * (b + c);
                int bb = a * b * c;
                int cc = a + b * c;
                int dd = (a + b) * c;
                int gg = a + b + c;
                int[] mas = new int[5] { aa, bb, cc, dd, gg };
                return mas.Max();
            }
            return 0;
        }




        public static string SubtractSum(int number)//возвращает число из списка
        {
            int temp = 0;
            if (number >= 10 && number < 10000)
            {
                char[] num = number.ToString().ToCharArray();
                foreach (char c in num)
                {
                    int.TryParse(c.ToString(), out int numsOut);
                    temp += numsOut;
                }
                int t = number - temp;
                while (t > 100)
                {
                    temp = 0;
                    num = t.ToString().ToCharArray();
                    foreach (char c in num)
                    {
                        int.TryParse(c.ToString(), out int numsOut);
                        temp += numsOut;
                    }
                    t = t - temp;
                }
                if (t <= 100)
                {
                    switch (t)
                    {
                        case 1: return "kiwi";
                        case 2: return "pear";
                        case 3: return "kiwi";
                        case 4: return "banana";
                        case 5: return "melon";
                        case 6: return "banana";
                        case 7: return "melon";
                        case 8: return "pineapple";
                        case 9: return "apple";
                        case 10: return "pineapple";
                        case 11: return "cucumber";
                        case 12: return "pineapple";
                        case 13: return "cucumber";
                        case 14: return "orange";
                        case 15: return "grape";
                        case 16: return "orange";
                        case 17: return "grape";
                        case 18: return "apple";
                        case 19: return "grape";
                        case 20: return "cherry";
                        case 21: return "pear";
                        case 22: return "cherry";
                        case 23: return "pear";
                        case 24: return "kiwi";
                        case 25: return "banana";
                        case 26: return "kiwi";
                        case 27: return "apple";
                        case 28: return "melon";
                        case 29: return "banana";
                        case 30: return "melon";
                        case 31: return "pineapple";
                        case 32: return "melon";
                        case 33: return "pineapple";
                        case 34: return "cucumber";
                        case 35: return "orange";
                        case 36: return "apple";
                        case 37: return "orange";
                        case 38: return "grape";
                        case 39: return "orange";
                        case 40: return "grape";
                        case 41: return "cherry";
                        case 42: return "pear";
                        case 43: return "cherry";
                        case 44: return "pear";
                        case 45: return "apple";
                        case 46: return "pear";
                        case 47: return "kiwi";
                        case 48: return "banana";
                        case 49: return "kiwi";
                        case 50: return "banana";
                        case 51: return "melon";
                        case 52: return "pineapple";
                        case 53: return "melon";
                        case 54: return "apple";
                        case 55: return "cucumber";
                        case 56: return "pineapple";
                        case 57: return "cucumber";
                        case 58: return "orange";
                        case 59: return "cucumber";
                        case 60: return "orange";
                        case 61: return "grape";
                        case 62: return "cherry";
                        case 63: return "apple";
                        case 64: return "cherry";
                        case 65: return "pear";
                        case 66: return "cherry";
                        case 67: return "pear";
                        case 68: return "kiwi";
                        case 69: return "pear";
                        case 70: return "kiwi";
                        case 71: return "banana";
                        case 72: return "apple";
                        case 73: return "banana";
                        case 74: return "melon";
                        case 75: return "pineapple";
                        case 76: return "melon";
                        case 77: return "pineapple";
                        case 78: return "cucumber";
                        case 79: return "pineapple";
                        case 80: return "cucumber";
                        case 81: return "apple";
                        case 82: return "grape";
                        case 83: return "orange";
                        case 84: return "grape";
                        case 85: return "cherry";
                        case 86: return "grape";
                        case 87: return "cherry";
                        case 88: return "pear";
                        case 89: return "cherry";
                        case 90: return "apple";
                        case 91: return "kiwi";
                        case 92: return "banana";
                        case 93: return "kiwi";
                        case 94: return "banana";
                        case 95: return "melon";
                        case 96: return "banana";
                        case 97: return "melon";
                        case 98: return "pineapple";
                        case 99: return "apple";
                        case 100: return "pineapple";
                    }
                }
            }
            return "";
        }


        public static string FakeBin1(string x)//если в строке число от 0 и до 4 -меняет на 0,если больше на 1
        {
            x = Regex.Replace(x, "[4321]", "0");
            x = Regex.Replace(x, "[56789]", "1");
            return x;
        }

        public static string FakeBin(string x)//если в строке число от 0 и до 4 -меняет на 0,если больше на 1
        {
            char[] temp = x.ToCharArray();
            string temp1 = "";
            foreach (char s in temp)
            {
                if (int.TryParse(s.ToString(), out int num))
                {
                    if (num >= 0 && num < 5)
                    {
                        temp1 += '0';
                    }
                    else
                    {
                        temp1 += '1';
                    }
                }
            }
            Console.WriteLine(temp1);
            return temp1;
        }
        public static float Combat(float health, float damage)//получаем остаток здоровья,если не 0 и дамаг не больше здоровья
        {
            if (health != 0 && damage <= health)
            { return health - damage; }
            else
            { return 0; }
        }

        public static int СenturyFromYear(int year)//определяет какой век
        {

            if (year % 100 != 0)
            {
                float temp = year / 100f;
                int temp1 = (int)temp + 1;
                return temp1;
            }
            else
            {
                return year / 100;
            }
        }

        public static int DutyFree(int normPrice, int Discount, int hol)//вычисляет процет от цены и делит на отпуск
        {
            float temp = normPrice / 100f * Discount;
            temp = hol / temp;
            int temp1 = (int)temp;
            return temp1;
        }

        public static int ToBinary(int n)//перевод в двоичную
        {
            int temp = 0;
            if (n > 0)
            {
                string BinaryCode = Convert.ToString(n, 2);
                int.TryParse(BinaryCode, out temp);
                return temp;
            }
            return temp;
        }

        public static string[] FixTheMeerkat(string[] a)//меняет порядок в одномерном массиве
        {
            Array.Reverse(a);
            return a;
        }


        public static string Problem(String a)//умножение чисел в строке
        {
            double temp;
            if (double.TryParse(a, out double num))
            {
                temp = num * 50 + 6;
                return temp.ToString();
            }
            else
            {
                return "Error";
            }

        }

        public static int Grow(int[] numbers)//все числа в массиве перемножает ,по порядку
        {
            int query;
            return query = numbers.Aggregate((x, y) => x * y);

        }

        public static bool CorrectTail(string body, string tail)//определяет конец строки с заданым символом
        {

            if (body.EndsWith(tail))
            {
                return true;
            }
            return false;
        }

        public static int[] Maps(int[] x)//перемножает массив на 2
        {
            int[] i = new int[x.Length];
            int temp = 0;
            foreach (int a in x)
            {
                i[temp] = a * 2;
                temp++;
            }
            return i;

        }

        public static int GetVowelCount1(string str)//подстчет букв которые совпадают 
        {
            return str.Count(i => "aeiou".Contains(i));
        }


        public static int GetVowelCount(string str)//подстчет букв которые совпадают
        {
            int vowelCount = 0;
            for (int i = 0; i < str.Length; i++)
            {
                if (str[i] == 'a' || str[i] == 'e' || str[i] == 'i' || str[i] == 'o' || str[i] == 'u')
                {
                    vowelCount++;
                }
            }
            return vowelCount;



        }

        public static string HowManyDalmatians1(int n)//возвращает из лста долматинцев
        {
            string respond = "";
            List<string> dogs = new List<string>()
            {
                "Hardly any",
                "More than a handful!",
                "Woah that's a lot of dogs!",
                "101 DALMATIONS!!!"
            };
            if (n > 0 && n <= 10)
            {
                int P = 0;

                return dogs[0];
            }
            else if (n > 10 && n <= 50)
            {
                return dogs[1];
            }
            else if (n > 50 && n < 101)
            {
                return dogs[2];
            }
            else if (n == 101)
            {
                return dogs[3];
            }
            else
            {
                return respond;
            }
        }



        public static bool Check(object[] a, object x)//Cравнивает обьекты из массива на обьект в аргументе
        {
            for (int i = 0; i < a.Length; i++)
            {
                if (x.Equals(a[i]))
                {
                    return true;
                }
            }
            return false;
        }

        public static double basicOp(char operation, double value1, double value2)//калькулятор
        {
            switch (operation)
            {
                case '+':
                    return value1 + value2;
                case '-':
                    return value1 - value2;
                case '*':
                    return value1 * value2;
                case '/':
                    return value1 / value2;

            }
            return -1;
        }

        public static int[] ReverseSeq1(int n)//обратный порядок n better
        {
            return Enumerable.Range(1, n).Reverse().ToArray();
        }

        public static int[] ReverseSeq(int n)//обратный порядок n
        {
            int temp = 0;
            for (int j = 1; j <= n; j++)
            {
                temp++;
            }
            int[] array = new int[temp];
            int count = 0;
            for (int i = n; i >= 1; i--)
            {

                array[count] = i;
                count++;
            }
            foreach (int f in array)
            {
                Console.WriteLine(f);
            }
            return array;
        }

        public static string Greet(string name, string owner)//проверяет одинаковые ли слова
        {
            if (name.ToUpper().Equals(owner.ToUpper()))
            {
                return "Hello boss";
            }
            else
            {
                return "Hello guest";
            }


        }

        public static bool is_uppercase(string arg)//проверяет на верхний регистр
        {
            if (arg.Equals(arg.ToUpper()))
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public static string Remove_char(string s)//удаляет первый и последний символ в слове
        {
            char[] temp = s.ToCharArray();
            int i = temp.Length;
            if (temp.Length > 1)
            {
                return s.Substring(1, i - 2);

            }
            return s;
        }
        public static string HowMuchILoveYou(int nb_petals)//какой будет выбран цветок
        {
            switch (nb_petals % 6)//остаток деления
            {
                case 5:
                    return "madly";
                case 1:
                    return "I love you";
                case 2:
                    return "a little";
                case 3:
                    return "a lot";
                case 4:
                    return "passionately";
                case 0:
                    return "not at all";
            }
            return "null";
        }

        public static double getVolumeOfCubiod(double length, double width, double height)//Объем прямоугольного параллелепипеда.
        {
            return length * width * height;
        }

        public static int Litres(double time)//Преобразование типов в наименьшую сторону
        {
            double temp = 0.5f * time;
            int temp2 = (int)temp;
            return temp2;
        }

        public static string RemoveExclamationMarks(string s)//метод Replace
        {
            return s.Replace("!", "");
        }

        public static string AreYouPlayingBanjo(string name)
        {
            char[] temp = name.ToCharArray();
            if (temp[0] == 'r' || temp[0] == 'R')
            {
                return $"{name} + plays banjo";
            }
            else
            {
                return $"{name} + does not play banjo";
            }
        }

        public static bool IsLockNessMonster(string sentence)//нахождение схожих слов
        {
            if (sentence.ToUpper().Contains("tree Fiddy".ToUpper()) || sentence.ToUpper().Contains("3.50".ToUpper()) || sentence.ToUpper().Contains("three fifty.".ToUpper()))
            {
                return true;
            }
            return false;
        }

        public static bool IsOpposite(string s1, string s2)//Сравнение строки,игнорирующие регистр букв
        {
            if (s1 == "" && s2 == "")
            {
                return false;
            }
            if (String.Equals(s1, s2, StringComparison.CurrentCultureIgnoreCase))
                return true;
            else
            {
                return false;
            }
        }



        public string dnaToRna(string dna)//change letter
        {
            return dna.Replace('T', 'U');
        }

        public static int TotalPoints(string[] games)//разделяет строку символом :
        {
            int x = 0;
            int y = 0;
            int sum = 0;

            if (games.Length > 9)
            {

                for (int i = 0; i < games.Length; i++)
                {
                    string[] numbers = games[i].Split(new char[] { (':') });
                    int.TryParse(numbers[0], out x);
                    int.TryParse(numbers[1], out y);
                    if (x > y) sum += 3;
                    else if (x < y) sum += 0;
                    else if (x == y) sum += 1;
                }
                return sum;
            }
            return 0;
        }




        public static IEnumerable<string> GooseFilter(IEnumerable<string> birds)//удаляет из массивов,одинаковые строки
        {
            string[] geese = new string[] { "African", "Roman Tufted", "Toulouse", "Pilgrim", "Steinbacher" };
            List<string> mods2 = birds.Except(geese).ToList();
            return mods2;
        }


        public static int ReverseNumber(int n)//обратный порядок
        {
            int temp = int.Parse(new string(n.ToString().ToCharArray().Reverse().ToArray()));
            Console.WriteLine(temp);
            return temp;
        }

        public static int Multiply(int number)//умножить на 5 столько раз,сколько цифр
        {
            string g = number.ToString();
            g = Regex.Replace(g, "[-+*/]", "");
            int temp = g.Length;
            int t = number;
            for (int i = 1; i <= temp; i++)
            {
                t = t * 5;
            }
            return t;
        }

        public static string[] AddLength1(string str)//тоже самое что и снизу ток в одну строку
        {
            string[] inputArr = str.Split(' ');
            string[] resultArr = new string[inputArr.Count()];

            for (int i = 0; i < inputArr.Length; i++)
            {
                resultArr[i] = $"{inputArr[i]} {inputArr[i].Length}";
            }

            return resultArr;

        }

        public static string[] AddLength(string str)// строка должна содержать пробел и длину массива
        {
            string temp2 = "";
            string[] temp;
            string[] array = new string[] { };
            List<string> tempList = new List<string>();
            char[] m = str.ToCharArray();
            if (str.Length > 0)
            {
                int temp3 = 0;
                for (int i = 0; i < m.Length; i++)
                {
                    if (m[i] == ' ')
                    {
                        temp2 += $" {temp3}";
                        tempList.Add(temp2);
                        temp3 = 0;
                        temp2 = "";

                    }
                    else if (i == m.Length - 1)
                    {
                        temp3++;
                        temp2 += m[i];
                        temp2 += $" {temp3}";
                        tempList.Add(temp2);
                    }
                    else
                    {
                        temp3++;
                        temp2 += m[i];
                    }
                }
                array = new string[tempList.Count];
                int temp4 = 0;

                foreach (string n in tempList)
                {
                    array[temp4] = n;
                    temp4++;
                }
                return array;
            }
            return array;
        }

        public static int StringToNumber(String str)//парсит строку в число
        {
            int.TryParse(str, out int num);
            return num;
        }

        public static int Min(int[] list)//нахождение мин числа
        {
            int m = list.Max();
            return m;
        }

        public static int Max(int[] list)//max number
        {
            Console.WriteLine(list.Max());
            return list.Min();
        }

        public static string Position(char alphabet)
        {
            int num = char.ToUpper(alphabet) - 64;//
                                                  // Console.WriteLine(num);
            return $"Position of alphabet: {num.ToString()}";
        }

        public static double SumArray(double[] array)//сумма масива
        {

            double temp = 0;
            for (int i = 0; i < array.Length; i++)
            {
                temp += array[i];
            }
            return temp;
        }

        public static bool IsDigit(string s)//если в строке только одно число целое или с плавающей
        {
            if (double.TryParse(s, out double temp))
            {
                return true;
            }
            else
            {
                return false;
            }

        }

        public static List<int> MultipleOfIndex(List<int> xs)//кратное число индексу
        {
            List<int> array = new List<int>();
            if (xs.Count > 1)
            {
                for (int i = 0; i < xs.Count; i++)
                {
                    if (xs[i] % i == 0)
                    {
                        array.Add(xs[i]);
                    }
                    else { continue; }
                }
                return array;
            }
            return null;
        }

        public static string StringClean(string s)//исключает числа из строки
        {
            return s = Regex.Replace(s, "[0-9]", "", RegexOptions.IgnoreCase);
        }

        public static string Greets(string name)
        {
            return $"Hello, {name} how are you doing today?";
        }


        public static double FindAverage(double[] array)//Среднее число
        {
            if (array.Length == 0) return 0;
            return array.Average();
        }

        public static int SquareSum(int[] n)//все числа в квадрат
        {
            return n.Sum(i => i * i);
        }

        public static ulong OddCount(ulong n)
        {
            return n / 2;
        }

        public static string repeatStr(int n, string s)//Повторяет строку
        {
            return string.Concat(Enumerable.Repeat(s, n));
        }


        public static string Correct(string text)// замена символа
        {
            string temp = "";
            char[] array = text.ToCharArray();
            for (int i = 0; i < array.Length; i++)
            {
                if (array[i] == 'S')
                {
                    array[i] = '5';
                }
                else if (array[i] == 'O')
                {
                    array[i] = '0';
                }
                else if (array[i] == 'I')
                {
                    array[i] = '1';
                }
                temp += array[i];
            }

            return temp;
        }


        public static string CreatePhoneNumber(int[] numbers)//строка в виде номера телефона
        {
            string ret = "";
            int[] array = new int[] { 0, 1, 2, 3, 4, 5, 6, 7, 8, 9 };
            if (numbers.Length == 10)
            {
                for (int i = 0; i < numbers.Length; i++)
                {
                    for (int j = 0; j < array.Length; j++)
                    {
                        if (numbers[i] == array[j])
                        {
                            ret = $"({numbers[0]}{numbers[1]}{numbers[2]}) {numbers[3]}{numbers[4]}{numbers[5]}-{numbers[6]}{numbers[7]}{numbers[8]}{numbers[9]}";
                        }
                    }
                }
                return ret;
            }
            else
            {
                return ret;
            }
        }
        public static int[] ArrayDiff(int[] a, int[] b)//удаляет одинаковые значения
        {
            return a.Where(n => !b.Contains(n)).ToArray();
        }


        public static int GetAge(string inputString)//сколько лет в строке
        {
            char[] input = inputString.ToCharArray();
            int num = 0;
            char[] numbers = new char[] { '0', '1', '2', '3', '4', '5', '6', '7', '8', '9' };

            for (int j = 0; j < numbers.Length; j++)
            {
                if (input[0] == numbers[j])
                {
                    int.TryParse(input[0].ToString(), out num);
                    return num;
                }
            }
            return num;

        }

        public static int CountSheeps(bool[] sheeps)// щиталка овец
        {
            int temp = 0;
            bool[] tempBool = null;
            if (sheeps != null)
            {
                for (int i = 0; i < sheeps.Length; i++)
                {
                    if (sheeps[i] == true)
                    {
                        temp++;
                    }
                }
            }
            return temp;
        }


        public static int FindSmallestInt(int[] args)//вернуть меньшее число
        {
            return args.Min();
        }

        public static bool Hero(int bullets, int dragons)//выживит ли дракон
        {
            int temp = dragons * 2;
            if (bullets < temp)
            {
                return false;
            }
            else if (bullets > temp)
            {
                return true;
            }
            else
            {
                return true;
            }
        }

        public static object[] RemoveEveryOther(object[] arr)// удаление каждого второго элемента массива
        {
            bool tempBool = false;

            List<object> array = new List<object>();
            for (int i = 0; i < arr.Length; i += 2)
            {
                array.Add(arr[i]);
            }
            object[] ret = new object[array.Count];
            for (int i = 0; i < array.Count; i++)
            {
                ret[i] = array[i];
            }
            return ret;
        }

        public static int[] InvertValues(int[] input)//все числа в в обратный знак
        {
            List<int> list = new List<int>();
            int[] mm = null;

            int a = -1;
            int o = 0;
            if (input != null)
            {
                for (int i = 0; i < input.Length; i++)
                {
                    list.Add(input[i] * a);
                }
                int[] returnMas = new int[list.Count];
                foreach (int temp in list)
                {
                    returnMas[o] = temp;
                    o++;
                }
                return returnMas;
            }
            else
            {
                return mm;
            }
        }


        public static List<int> ReverseList(List<int> list)// обратный порядок
        {
            List<int> array = new List<int>();

            if (list != null)
            {
                for (int i = list.Count - 1; i >= 0; i--)
                {
                    array.Add(list[i]);
                    Console.WriteLine(list[i]);
                }
            }

            return array;
        }

        public static int Enough(int cap, int on, int wait)//Будет ли достаточно места?
        {
            int sum = 0;
            int sum2 = 0;
            if (on + wait <= cap)
            {
                Console.WriteLine(1);
                return 0;
            }
            else
            {
                sum = cap - on;
                sum2 = wait - sum;
                return sum2;
            }
        }
        public static string NoSpace(string input)//убирает пробелы в стриге
        {
            string text = "";
            char[] m = input.ToCharArray();
            foreach (char mn in m)
            {
                if (mn != ' ')
                {
                    text = text + mn;
                }
            }
            return text;
        }

        public static bool Feast(string beast, string dish)//Праздник многих зверей
        {

            char[] numbers = new char[] { '0', '1', '2', '3', '4', '5', '6', '7', '8', '9' };
            char[] tempBeast;
            char[] tempDish;
            int temp = 0;
            int temp1 = 0;
            char b = ' ';
            char d = ' ';
            char c = ' ';
            char a = ' ';
            tempBeast = beast.ToCharArray();
            tempDish = dish.ToCharArray();
            foreach (char m in tempBeast)
            {
                foreach (char s in numbers)
                {
                    if (m != s)
                    {
                        temp++;
                        if (temp > 1)
                        {
                            b = tempBeast[0];
                            int i = tempBeast.Length - 1;
                            a = tempBeast[i];
                        }
                    }
                    else
                    {
                        return false;
                    }
                }
            }
            foreach (char m in tempDish)
            {
                foreach (char s in numbers)
                {
                    if (m != s)
                    {
                        temp1++;
                        if (temp1 > 1)
                        {
                            int i = tempDish.Length - 1;
                            d = tempDish[0];
                            c = tempDish[i];
                        }
                    }
                    else
                    {
                        return false;
                    }
                }
            }
            if (b == d && c == a)
            {
                return true;
            }

            return false;
        }



        public static int SumMix(object[] x)//Сумма смешанного массива
        {
            int temp = 0;
            for (int i = 0; i < x.Length; i++)
            {
                if (int.TryParse(x[i].ToString(), out int num))
                {
                    temp += num;
                }
            }
            return temp;
        }

        public static int FinalGrade(int exam, int projects)
        {
            if (exam >= 0 && exam <= 100 && projects >= 0)
            {
                if (exam > 90 || projects > 10)
                {
                    return 100;
                }
                else if (exam > 75 && projects > 5)
                {
                    return 90;
                }
                else if (exam > 50 && projects > 1)
                {
                    return 75;
                }
            }

            return 0;

        }

        public static int[] CountPositivesSumNegatives(int[] input)//Количество позитивов / сумма негативов
        {
            int[] array = new int[2];
            int[] arrayNull = new int[0];
            int k = 0;
            int j = 0;
            int temp = 0;
            if (input != null && input.Length > 0)
            {
                for (int i = 0; i < input.Length; i++)
                {
                    if (input[i] > 0)
                    {
                        k++;
                        array[0] = k;

                    }
                    else if (input[i] == 0)
                    {
                        continue;
                    }
                    else
                    {
                        j = j + input[i];
                        array[1] = j;
                    }
                }
                return array;
            }
            else
            {
                return arrayNull;
            }

        }
        public static int summation(int num)// сумма числа массива
        {
            int sum = 0;
            if (num > 0)
            {
                for (int i = 1; i < num + 1; i++)
                {
                    sum += i;
                }
            }
            return sum;
        }
        public static int[] DivisibleBy(int[] numbers, int divisor)// Найти числа, которые делятся на данное число и записываются в массив
        {
            List<int> m = new List<int>();
            int j = 0;
            for (int i = 0; i < numbers.Length; i++)
            {
                if (numbers[i] % divisor == 0)
                {
                    m.Add(numbers[i]);
                }
            }
            foreach (int ms in m)
            {
                j++;
            }
            int[] massive = new int[j];
            for (int k = 0; k < m.Count; k++)
            {
                massive[k] = m[k];
            }
            return massive;
        }

        public static string Greet(string language) // Приветствие по языку ,используя словари
        {
            Dictionary<string, string> lang = new Dictionary<string, string>
            {
                {"english", "Welcome"},
{ "czech", "Vitejte"},
{ "danish", "Velkomst"},
{ "dutch", "Welkom"},
{ "estonian", "Tere tulemast"},
{ "finnish", "Tervetuloa"},
{ "flemish", "Welgekomen"},
{ "french", "Bienvenue"},
{ "german", "Willkommen"},
{ "irish", "Failte"},
{ "italian", "Benvenuto"},
{ "latvian", "Gaidits"},
{ "lithuanian", "Laukiamas"},
{ "polish", "Witamy"},
{ "spanish", "Bienvenido"},
{ "swedish", "Valkommen"},
{ "welsh", "Croeso"}
                };
            foreach (KeyValuePair<string, string> m in lang)
            {
                if (m.Key == language)
                {
                    return m.Value;
                }
            }
            return "Welcome";

        }

        public static char GetChar(int charcode)// Возвращает символ Unicode
        {
            char character = (char)charcode;
            return character;


        }
        public static bool isDivisible(long n, long x, long y)//Чи n ділиться на x та y?
        {
            if (n > 0 && x > 0 && y > 0)
            {
                if (n % x == 0 && n % y == 0)
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }
            return false;
        }


        public static void Divisors(int n)// Вычисляет какие цыфры делятся
        {
            List<int> array = new List<int>();
            if (n > 1)
            {
                for (int i = 2; i < n; i++)
                {
                    if (n % i == 0)
                    {
                        array.Add(i);
                    }
                }
                foreach (int arr in array)
                {
                    Console.Write($" {arr}");
                }

            }
            else
            {
                Console.WriteLine("Введите большее число");
            }
        }
        public static int CountBits(int n)//Меняет в двоичную форму и вычисляет сколько битов
        {
            int count = 0;
            if (n >= 0)
            {
                string BinaryCode = Convert.ToString(n, 2);
                Console.WriteLine(BinaryCode);
                long a = long.Parse(BinaryCode);
                char[] mass = BinaryCode.ToCharArray();
                foreach (char m in mass)
                {
                    if (m == '1')
                    {
                        count++;
                    }
                }
                return count;
            }
            else
            {
                return 0;
            }


        }
        public static string AbbrevName(string name)// Берет массив стрингов и инициалы пишет с большой буквы
        {
            string[] words = name.Split(' ');
            string m = "";
            string a = ".";
            int i = words.Length - 1;
            foreach (string word in words)
            {
                word.ToCharArray();
                m += word[0].ToString().ToUpper();
                if (word != words[i])
                {
                    m += a;
                }
            }
            return m;
        }
    }

}
