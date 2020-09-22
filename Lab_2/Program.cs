using System;
using System.Text;
using System.Collections.Generic;
using System.Linq;
using Microsoft.VisualBasic.CompilerServices;
using System.Security.Cryptography.X509Certificates;
/*namespace Lab_2
{

}*/
/*class Program
   {
       static void Main(string[] args)
       {
           string a = "Roman";
           string b = "Sam";
           string d = "Takoi";
           string c = string.Concat(a, ' ', b, ' ', d);
           Console.WriteLine(c);
       }
}*/
namespace Lab_2
{
    class Program
    {
        static void Main()
        {
            ////-----------------------------------------------------------------------TASK1A------------------------------------------------------------------------------------------------------------
            //Console.WriteLine("==================================================================================================TASK1A=========================================================================================================");
            //Console.WriteLine("Введите переменную типа boolean");
            //bool t1a1 = Convert.ToBoolean(Console.ReadLine());
            //Console.WriteLine($"Введено значение типа boolean : {t1a1}\n");

            //Console.WriteLine("Введите переменную типа byte");
            //byte t1a2 = Convert.ToByte(Console.ReadLine());
            //Console.WriteLine($"Введено значение типа byte : {t1a2}\n");

            //Console.WriteLine("Введите переменную типа sbyte");
            //sbyte t1a3 = Convert.ToSByte(Console.ReadLine());
            //Console.WriteLine($"Введено значение типа sbyte : {t1a3}\n");

            //Console.WriteLine("Введите переменную типа char");
            //char t1a4 = Convert.ToChar(Console.ReadLine());
            //Console.WriteLine($"Введено значение типа char : {t1a4}\n");

            //Console.WriteLine("Введите переменную типа decimal");
            //decimal t1a5 = Convert.ToDecimal(Console.ReadLine());
            //Console.WriteLine($"Введено значение типа decimal : {t1a5}\n");

            //Console.WriteLine("Введите переменную типа double");
            //double t1a6 = Convert.ToDouble(Console.ReadLine());
            //Console.WriteLine($"Введено значение типа double : {t1a6}\n");

            //Console.WriteLine("Введите переменную типа float");
            //float t1a7 = Convert.ToSingle(Console.ReadLine());
            //Console.WriteLine($"Введено значение типа float : {t1a7}\n");

            //Console.WriteLine("Введите переменную типа int");
            //int t1a8 = Convert.ToInt32(Console.ReadLine());
            //Console.WriteLine($"Введено значение типа int : {t1a8}\n");

            //Console.WriteLine("Введите переменную типа uint");
            //uint t1a9 = Convert.ToUInt32(Console.ReadLine());
            //Console.WriteLine($"Введено значение типа uint : {t1a9}\n");

            //Console.WriteLine("Введите переменную типа long");
            //long t1a10 = Convert.ToInt64(Console.ReadLine());
            //Console.WriteLine($"Введено значение типа long : {t1a10}\n");

            //Console.WriteLine("Введите переменную типа ulong");
            //ulong t1a11 = Convert.ToUInt64(Console.ReadLine());
            //Console.WriteLine($"Введено значение типа ulong : {t1a11}\n");

            //Console.WriteLine("Введите переменную типа char short");
            //short t1a12 = Convert.ToInt16(Console.ReadLine());
            //Console.WriteLine($"Введено значение типа short : {t1a12}\n");

            //Console.WriteLine("Введите переменную типа char ushort");
            //ushort t1a13 = Convert.ToUInt16(Console.ReadLine());
            //Console.WriteLine($"Введено значение типа ushort {t1a13}\n");
            ////-----------------------------------------------------------------------TASK1B--------------------------------------------------------------------------------------------------------------------
            //Console.WriteLine("==================================================================================================TASK1B=========================================================================================================");

            //byte t1b1 = (byte)t1a3; //sbyte in byte
            //sbyte t1b2 = (sbyte)t1a2; //byte in sbyte
            //short t1b3 = (short)t1a7; // float in short
            //uint t1b4 = (uint)t1a11; //ulong in uint
            //int t1b5 = (int)t1a5; //decimal in int

            //Console.WriteLine($"Вывод явных преобразований {t1b1}, {t1b2}, {t1b3}, {t1b4}, {t1b5}\n");

            //double t1b6 = t1a7; //float in double
            //ushort t1b7 = t1a4; //char in ushort
            //uint t1b8 = t1a2; // byte in uint
            //decimal t1b9 = t1a8; //int in decimal
            //ulong t1b10 = t1a9; //uint in ulong

            //Console.WriteLine($"Вывод неявных преобразований {t1b6}, {t1b7}, {t1b8}, {t1b9}, {t1b10}\n");

            //Console.WriteLine($"{t1b1.GetType()} - тип данных который прошел неявное преобразование\n\n\n"); //Демонстрация работы неявно преобразованной переменной

            ////-----------------------------------------------------------------------TASK1C--------------------------------------------------------------------------------------------------------------------
            //Console.WriteLine("==================================================================================================TASK1C=========================================================================================================");

            //Int32 t1c1 = 5;
            //Object t1c2 = t1c1; // Упаковка t1c1; t1c2 указывает на упакованный объект. 
            //Int16 t1c3 = (Int16)(Int32)t1c2; // Распаковка, а затем приведение типа.

            ////-----------------------------------------------------------------------TASK1D--------------------------------------------------------------------------------------------------------------------
            //Console.WriteLine("==================================================================================================TASK1D=========================================================================================================");

            //Console.WriteLine($"{t1c1.GetType()} - тип запакованной переменной\n{t1c3.GetType()} - тип распакованной переменной");

            ////-----------------------------------------------------------------------TASK1E--------------------------------------------------------------------------------------------------------------------
            //Console.WriteLine("==================================================================================================TASK1E=========================================================================================================");

            //int? t1e1 = null;
            //if (t1e1.HasValue)
            //    Console.WriteLine($"{t1e1.Value} - значение nullable перемененной t1e1");
            //else
            //    Console.WriteLine("Переменна пуста");
            ////-----------------------------------------------------------------------TASK1F--------------------------------------------------------------------------------------------------------------------
            //Console.WriteLine("==================================================================================================TASK1F=========================================================================================================");

            ////var number = 5;
            ////number = "some text"; // ошибка, number определен как int  
            ////var сохраняет принцип строгой типизации в Си-шарп. Это означает, что после того, как для переменной уже был определен тип, 
            ////в нее нельзя записать данные другого типа:


            ////-----------------------------------------------------------------------TASK2A--------------------------------------------------------------------------------------------------------------------
            //Console.WriteLine("==================================================================================================TASK2A=========================================================================================================");

            //string t2a1 = "hello";
            //string t2a2 = "laba";
            //int result = string.Compare(t2a1, t2a2);

            //if (result < 0)
            //{
            //    Console.WriteLine("строки равны");
            //}
            //else Console.WriteLine("строки не равны");

            ////-----------------------------------------------------------------------TASK2B--------------------------------------------------------------------------------------------------------------------
            //Console.WriteLine("==================================================================================================TASK2B=========================================================================================================");

            //string t2b1 = "apple - fruit";
            //string t2b2 = "(some text)";
            //string t2b3 = "dog - animal";

            //string t2b4 = string.Concat(t2b1, " ", t2b2, " ", t2b3);
            //Console.WriteLine(t2b4 + " = объединение строк");

            //string t2b5 = t2b1.Insert(7, t2b2);
            //Console.WriteLine(t2b5 + " = вставка строки t2b2 в строку t2b1 начиная с 7 символа");

            //string t2b6 = t2b1.Substring(8);
            //Console.WriteLine(t2b6 + " = с 8ого символа - подстрока");

            //String[] t2b7 = { "Color1=red", "Color2=green", "Color3=blue" };
            //foreach (var t2b8 in t2b7)
            //{
            //    int position = t2b8.IndexOf("=");
            //    Console.WriteLine("Key: {0}, Value: '{1}'",
            //                   t2b8.Substring(0, position),
            //                   t2b8.Substring(position + 1));
            //}
            //Console.WriteLine("Выполнено разделение на слова");

            //int ind = t2b3.Length - 8;
            //// вырезаем последние 8 символов
            //t2b3 = t2b3.Remove(ind);
            //Console.WriteLine(t2b3);
            //Console.WriteLine("Выполнено удаление части строки");

            ////-----------------------------------------------------------------------TASK2С--------------------------------------------------------------------------------------------------------------------
            //Console.WriteLine("==================================================================================================TASK2С=========================================================================================================");

            //string t2c1 = "";
            //string t2c2 = null;
            //string t2c3 = "some text";
            //if (string.IsNullOrEmpty(t2c1))
            //    Console.WriteLine("Пустая или нулевая");
            //else
            //    Console.WriteLine("Есть текст");

            //if (string.IsNullOrEmpty(t2c2))
            //    Console.WriteLine("Пустая или нулевая");
            //else
            //    Console.WriteLine("Есть текст");

            //if (string.IsNullOrEmpty(t2c3))
            //    Console.WriteLine("Пустая или нулевая");
            //else
            //    Console.WriteLine("Есть текст");

            //if (t2c1 == t2c3)
            //    Console.WriteLine("Проверяемая строка пуста");
            //else
            //    Console.WriteLine("Проверяемая строка имеет текст");

            //if (t2c1 == t2c2)
            //    Console.WriteLine("одинаковые строки");
            //else
            //    Console.WriteLine("Одна строка null, а вторая пустая");

            //Console.WriteLine("Проверка метода IsNullOrEmpty и действия с пустыми строками");

            //// Создаётся StringBuilder для 50 символов.
            //// Инициализируется StringBuilder с буквами "ABC".
            //StringBuilder t2d1 = new StringBuilder("BC", 50);

            //// Добавление новых буква к строке (D, E, и F) к концу StringBuilder.
            //t2d1.Append(new char[] { 'D', 'E', 'f' });
            //Console.WriteLine(t2d1.Length + " букв: " + t2d1.ToString());

            ////Замена маленькой буквы на большую
            //t2d1.Replace('f', 'F');
            //Console.WriteLine(t2d1.Length + " букв: " + t2d1.ToString());

            ////Добавление строки в начало билдера
            //t2d1.Insert(0, "A");
            //Console.WriteLine(t2d1.Length + " букв: " + t2d1.ToString());

            ////Удаление 2 позиций начиная с 3ей  
            //t2d1.Remove(3, 2);
            //Console.WriteLine(t2d1.Length + " букв: " + t2d1.ToString());

            ////-----------------------------------------------------------------------TASK3--------------------------------------------------------------------------------------------------------------------
            //Console.WriteLine("==================================================================================================TASK3=========================================================================================================");

            //int[,] t3a2 = { { 1, 2, 3 }, { 4, 5, 6 }, { 7, 8, 9 }, { 10, 11, 12 }, { 13, 14, 15 } };//представление двумерного массива

            //int rows = t3a2.GetUpperBound(0) + 1;   //количество строк таблицы, представленной двухмерным массивом.
            //int columns = t3a2.Length / rows;       //количество элементов в каждой строке

            //for (int i = 0; i < rows; i++)
            //{
            //    for (int j = 0; j < columns; j++)
            //    {
            //        Console.Write($"{t3a2[i, j]} \t");
            //    }
            //    Console.WriteLine();
            //}

            //string[] t3b1 = new string[] { "Monday", "Tuesday", "Wensday", "Thursday", "Friday", "Saturday", "Sunday" };

            //Console.WriteLine("Размер массива: " + t3b1.Length);

            //foreach (string t3b4 in t3b1)
            //    Console.Write($"{t3b4}   ");
            //Console.WriteLine();

            //Console.WriteLine("Введите элемент массива который вы хотите заменить: ");
            //int t3b2 = Convert.ToInt32(Console.ReadLine());
            //Console.WriteLine("Введите замену элемента: ");
            //string t3b3 = Console.ReadLine();
            //t3b1[t3b2-1] = t3b3;
            //foreach (string t3b4 in t3b1)
            //    Console.Write($"{t3b4}   ");
            //Console.WriteLine("\n\n\n");


            //// Объявляем ступенчатый массив
            //int[][] t3c1 = new int[3][];
            //t3c1[0] = new int[2];
            //t3c1[1] = new int[3];
            //t3c1[2] = new int[4];

            //// Инициализируем ступенчатый массив
            //for (int i = 0; i < 2; i++)
            //{
            //    Console.Write("Введите {0} элемент массива ", i);
            //    int t3c2 = Convert.ToInt32(Console.ReadLine());
            //    t3c1[0][i] = t3c2;
            //}
           
            //Console.WriteLine();
            //for (int i = 0; i < 3; i++)
            //{
            //    Console.Write("Введите {0} элемент массива ", i);
            //    int t3c2 = Convert.ToInt32(Console.ReadLine());
            //    t3c1[1][i] = t3c2;
            //}

            //Console.WriteLine();
            //for (int i = 0; i < 4; i++)
            //{
            //    Console.Write("Введите {0} элемент массива ", i);
            //    int t3c2 = Convert.ToInt32(Console.ReadLine());
            //    t3c1[2][i] = t3c2;
            //}
            //for (int i = 0; i < 2; i++)
            //    Console.Write("{0}\t", t3c1[0][i]);
            //Console.WriteLine();
            //for (int i = 0; i < 3; i++)
            //    Console.Write("{0}\t", t3c1[1][i]);
            //Console.WriteLine();
            //for (int i = 0; i < 4; i++)
            //    Console.Write("{0}\t", t3c1[2][i]);

            //Console.WriteLine(); Console.WriteLine(); Console.WriteLine();

            //var t3d1 = new[] { 1, 2, 3, 4, 5, 6 };
            //var t3d2 = "text";
            //Console.Write("Вывод неявно типизированного массива: ");
            //for (int i = 0; i < t3d1.Length; i++)
            //    Console.Write("{0}\t", t3d1[i]);
            //Console.WriteLine();
            //Console.WriteLine("Вывод неявно типизированной строки: {0} ", t3d2);

            //-----------------------------------------------------------------------TASK4--------------------------------------------------------------------------------------------------------------------
            Console.WriteLine("==================================================================================================TASK4=========================================================================================================");

            (int, string, char, long, double) t4a1 = (1, "text", 's', 50, 4.5);
            Console.WriteLine($"Tuple with elements {t4a1.Item1}, {t4a1.Item2}, {t4a1.Item3}, {t4a1.Item4}, {t4a1.Item5}.");
            Console.WriteLine($"Tuple with elements  1 - '{t4a1.Item1}', 3 - '{t4a1.Item3}', 5 - '{t4a1.Item5}'.");

            //распоковка кортежа
            int t4a2 = t4a1.Item1;
            string t4a3 = t4a1.Item2;
            char t4a4 = t4a1.Item3;
            long t4a5 = t4a1.Item4;
            double t4a6 = t4a1.Item5;

            (int, double, short) t4d1 = (10, 8, 5);
            (int, long , ushort) t4d2 = (10, 8, 5);
            (int, long, int) t4d3 = (10, 4, 5);
            Console.WriteLine(t4d1 == t4d2);
            Console.WriteLine(t4d1 == t4d3);

            //-----------------------------------------------------------------------TASK5--------------------------------------------------------------------------------------------------------------------
            Console.WriteLine("==================================================================================================TASK5=========================================================================================================");

            (int, int, int, string) LocalFunction(int[] t5a1, string t5a2)
            {
                int maxel = t5a1.Max();
                int minel = t5a1.Min();
                int sumels = t5a1.Sum();
                string t5a3 = t5a2;
                return (maxel, minel, sumels, t5a3);
            }

            var t5a1 = new[] { 137, 423, 222, 111, 999, 108};
            string t5a2 = "text";
            Console.WriteLine(LocalFunction(t5a1, t5a2));

            //-----------------------------------------------------------------------TASK6--------------------------------------------------------------------------------------------------------------------
            Console.WriteLine("==================================================================================================TASK6=========================================================================================================");

            int t6a1 = Int32.MaxValue;
            int t6a2 = 123;
            Console.WriteLine(Check(t6a1, t6a2));
            Console.WriteLine(Uncheck(t6a1, t6a2));

            int Check(int t6a1, int t6a2)
            {
                try
                {
                    checked
                    {
                        int result = t6a1 + t6a2;
                        return result;
                    }
                }
                catch (Exception message)
                {
                    Console.WriteLine(message.Message);
                }
                return 0;
            }

            int Uncheck(int t6a1, int t6a2)
            {
                    unchecked
                    {
                        int result = t6a1 + t6a2;
                        return result;
                    }   
            }
        }
    }
}
