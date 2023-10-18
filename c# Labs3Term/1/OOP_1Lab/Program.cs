using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_1Lab
{
    class Program
    {
        static void Main()
        {

            while (true)
            {
                Console.WriteLine("Введите число номер задания:");

                int number = int.Parse(Console.ReadLine());

                switch (number)
                {
                    case 1:
                        Types();
                        break;
                    case 2:
                        StringTask();
                        break;
                    case 3:
                        Arrays();
                        break;
                    case 4:
                        Typles();
                        break;
                    case 5:
                        {
                            int[] numbersArray = { 10, 5, 30, 20, 15 };
                            string ExampleText = "Пример строки";


                            (int max, int min, int sum, char firstChar) GetInfo(int[] arr, string str)
                            {
                                int maxNum = arr[0];
                                int minNum = arr[0];
                                int sumNum = 0;
                                char firstCharacter = str[0];

                                foreach (int num in arr)
                                {
                                    if (num > maxNum)
                                        maxNum = num;

                                    if (num < minNum)
                                        minNum = num;

                                    sumNum += num;
                                }

                                return (maxNum, minNum, sumNum, firstCharacter);
                            }

                            var result = GetInfo(numbersArray, ExampleText);

                            Console.WriteLine($"Максимальный элемент: {result.max}");
                            Console.WriteLine($"Минимальный элемент: {result.min}");
                            Console.WriteLine($"Сумма элементов: {result.sum}");
                            Console.WriteLine($"Первая буква строки: {result.firstChar}");
                        }
                        break;
                    case 6:
                        {
                            Console.WriteLine("Результат с checked:");
                            CheckedExample();

                            Console.WriteLine("\nРезультат с unchecked:");
                            UncheckedExample();
                        }
                        break;
                    case 7:
                        return;
                        break;
                    case 8:
                        Console.Clear();
                        break;
                    default:
                        Console.WriteLine("Неверный номер задания");
                        break;
                }
            }

        }
        static void CheckedExample()
        {
            checked
            {
                int maxValue = int.MaxValue;
                Console.WriteLine($"Максимальное значение int (checked): {maxValue}");

                try
                {
                    maxValue++;
                    Console.WriteLine($"Увеличенное значение int (checked): {maxValue}");
                }
                catch (OverflowException ex)
                {
                    Console.WriteLine($"OverflowException: {ex.Message}");
                }
            }
        }

        static void UncheckedExample()
        {
            unchecked
            {
                int maxValue = int.MaxValue;
                Console.WriteLine($"Максимальное значение int (unchecked): {maxValue}");


                maxValue++;
                Console.WriteLine($"Увеличенное значение int (unchecked): {maxValue}");
            }
        }

        static void Types()
        {
            bool boolTypeVariable;
            byte byteTypeVariable;
            sbyte sbyteTypeVariable;
            char charTypeVariable;
            decimal decimalTypeVariable;
            double doubleTypeVariable;
            float floatTypeVariable;
            int intTypeVariable;
            uint uintTypeVariable;
            nint nintTypeVariable;
            nuint nuintTypeVariable;
            long longTypeVariable;
            ulong ulongTypeVariable;
            short shortTypeVariable;
            ushort ushortTypeVariable;
            object objectTypeVariable;
            string stringTypeVariable;
            dynamic dynamicTypeVariable;

            Console.WriteLine("Введите тип bool: ");
            boolTypeVariable = Convert.ToBoolean(Console.ReadLine());
            Console.WriteLine("Переменная типа bool: " + boolTypeVariable);

            Console.WriteLine("Введите значение для типа byte: ");
            byteTypeVariable = Convert.ToByte(Console.ReadLine());
            Console.WriteLine("Переменная типа byte: " + byteTypeVariable);

            Console.WriteLine("Введите значение для типа sbyte: ");
            sbyteTypeVariable = Convert.ToSByte(Console.ReadLine());
            Console.WriteLine("Переменная типа sbyte: " + sbyteTypeVariable);

            Console.WriteLine("Введите значение для типа char: ");
            charTypeVariable = Convert.ToChar(Console.ReadLine());
            Console.WriteLine("Переменная типа char: " + charTypeVariable);

            Console.WriteLine("Введите значение для типа decimal: ");
            decimalTypeVariable = Convert.ToDecimal(Console.ReadLine());
            Console.WriteLine("Переменная типа decimal: " + decimalTypeVariable);

            Console.WriteLine("Введите значение для типа double: ");
            doubleTypeVariable = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Переменная типа double: " + doubleTypeVariable);

            Console.WriteLine("Введите значение для типа float: ");
            floatTypeVariable = Convert.ToSingle(Console.ReadLine());
            Console.WriteLine("Переменная типа float: " + floatTypeVariable);

            Console.WriteLine("Введите значение для типа int: ");
            intTypeVariable = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Переменная типа int: " + intTypeVariable);

            Console.WriteLine("Введите значение для типа uint: ");
            uintTypeVariable = Convert.ToUInt32(Console.ReadLine());
            Console.WriteLine("Переменная типа uint: " + uintTypeVariable);

            Console.WriteLine("Введите значение для типа nint: ");
            nintTypeVariable = (nint)Convert.ToInt64(Console.ReadLine());
            Console.WriteLine("Переменная типа nint: " + nintTypeVariable);

            Console.WriteLine("Введите значение для типа nuint: ");
            nuintTypeVariable = (nuint)Convert.ToUInt64(Console.ReadLine());
            Console.WriteLine("Переменная типа nuint: " + nuintTypeVariable);

            Console.WriteLine("Введите значение для типа long: ");
            longTypeVariable = Convert.ToInt64(Console.ReadLine());
            Console.WriteLine("Переменная типа long: " + longTypeVariable);

            Console.WriteLine("Введите значение для типа ulong: ");
            ulongTypeVariable = Convert.ToUInt64(Console.ReadLine());
            Console.WriteLine("Переменная типа ulong: " + ulongTypeVariable);

            Console.WriteLine("Введите значение для типа short: ");
            shortTypeVariable = Convert.ToInt16(Console.ReadLine());
            Console.WriteLine("Переменная типа short: " + shortTypeVariable);

            Console.WriteLine("Введите значение для типа ushort: ");
            ushortTypeVariable = Convert.ToUInt16(Console.ReadLine());
            Console.WriteLine("Переменная типа ushort: " + ushortTypeVariable);

            Console.WriteLine("Введите значение типа object: ");
            objectTypeVariable = Console.ReadLine();
            Console.WriteLine("Переменная типа object: " + objectTypeVariable);

            Console.WriteLine("Введите значение типа object: ");
            objectTypeVariable = Console.ReadLine();
            Console.WriteLine("Переменная типа object: " + objectTypeVariable);

            Console.WriteLine("Введите значение типа dynamic: ");
            dynamicTypeVariable = Console.ReadLine();
            Console.WriteLine("Переменная типа dynamic: " + dynamicTypeVariable);


            intTypeVariable = (int)doubleTypeVariable;
            intTypeVariable = (int)floatTypeVariable;
            intTypeVariable = (int)longTypeVariable;

            doubleTypeVariable = intTypeVariable;
            floatTypeVariable = intTypeVariable;
            longTypeVariable = intTypeVariable;
            intTypeVariable = shortTypeVariable;
            intTypeVariable = ushortTypeVariable;

            char BoxChar = 'A';
            object BoxForChar = BoxChar;

            BoxForChar = 'B';
            BoxChar = (char)BoxForChar;

            var indefiendTypeVariable = 505.2;
            Console.WriteLine("Тип неопределённой переменной: " + indefiendTypeVariable.GetType());


            int? intNullable = null;
            Console.WriteLine("Значение intNullable: " + intNullable);

            intNullable = 10;
            Console.WriteLine("Значение intNullable: " + intNullable);

            var intType = 505;
            Console.WriteLine("Значение intType: " + intType);

            //intType = 'A';
            //intType = "String";
            Console.WriteLine("Значение intType: " + intType);
        }

        static void StringTask()
        {
            char First = 'a';
            char Second = 'b';
            char Third = 'c';

            Console.WriteLine("литералы:" + First + Second + Third);
            if (First == Second || Second == Third || First == Third)
                Console.WriteLine("литералы одинаковы");
            else
                Console.WriteLine("литералы не одинаковы");

            string StringB1 = "скакал веселый кофе бревном зайчик";
            string StringB2 = "луна посадила на красный солнце пароход";
            string StringB3 = "мороженое танцевало на крыше дома";

            Console.WriteLine("Первая строка: " + StringB1);
            Console.WriteLine("Вторая строка: " + StringB2);
            Console.WriteLine("Третяя строка: " + StringB3);

            string concatenatedString = StringB1 + StringB2 + StringB3;

            Console.WriteLine("Объединённая строка: " + concatenatedString);

            string copyString = StringB1;

            Console.WriteLine("Скопированная строка: " + copyString);

            string subString = StringB2.Substring(2, 8);
            Console.WriteLine("Подстрока: " + subString);

            Console.WriteLine("Разделение на слова: ");
            for (int i = 0; i < StringB3.Length; i++)
            {
                if (StringB3[i] == ' ')
                {
                    Console.Write('\n');
                    continue;
                }
                Console.Write(StringB3[i]);
            }

            Console.Write('\n');

            string[] words = StringB3.Split(' ');
            Console.WriteLine("Разделение на слова: ");

            foreach (string word in words)
                Console.WriteLine(word);


            string insertString = StringB1.Insert(14, " жаба");
            Console.WriteLine("Вставка в строку подстроки: " + insertString);


            string removeString = StringB2.Remove(4, 9);
            Console.WriteLine("Удаление в строку подстроки: " + removeString);

            string[] StudentNames = { "Bob", "Jo" };
            int[] StudentAges = { 19, 22 };

            for (int i = 0; i < StudentAges.Length; i++)
            {
                string informationStudent = $"Имя ученика:{StudentNames[i]}, возраст:  {StudentAges[i]}.";
                Console.WriteLine(informationStudent);
            }

            string emptyString = "";
            string NullString = null;

            if (string.IsNullOrEmpty(emptyString))
                Console.WriteLine("Пустая строка: true");
            else
                Console.WriteLine("Пустая строка: false");

            if (string.IsNullOrEmpty(NullString))
                Console.WriteLine("Null-строка: true");
            else
                Console.WriteLine("Null-строка: false");


            NullString = "Новое значение пустой строки";
            Console.WriteLine("Пустая строка: " + NullString);

            NullString = "Новое значение Null-строки";
            Console.WriteLine("Null-строка: " + NullString);

            StringBuilder TestStringBuilder = new StringBuilder("ABC", 50);
            TestStringBuilder.Append(new char[] { 'D', 'E', 'F' });
            TestStringBuilder.AppendFormat("GHI{0}{1}", 'J', 'k');
            TestStringBuilder.Insert(0, "Alphabet: ");
            TestStringBuilder.Replace('k', 'K');
            Console.WriteLine("TestStringBuilder");
        }

        static void Arrays()
        {
            int[,] matrixArr = new int[3, 3];

            for (int i = 0; i < 3; i++)
            {
                for (int j = 0; j < 3; j++)
                {
                    matrixArr[i, j] = i * j;
                    Console.Write(matrixArr[i, j] + " ");
                }
                Console.WriteLine();
            }

            string[] stringsArray = { "веселая кофе машина", "путешествие лето приключение", "музыка вечер танец" };

            foreach (string elments in stringsArray)
                Console.WriteLine(elments);
            Console.WriteLine("Размер массива строк: " + stringsArray.Length);
            Console.Write("Выбирете строку которую хотите изменить: ");
            int answer = Convert.ToInt16(Console.ReadLine());
            Console.Write("Введите новое значение этой строки: ");
            string NewStringValue = Console.ReadLine();
            stringsArray[answer] = NewStringValue;
            Console.WriteLine(stringsArray[answer]);

            double[,] doubleArray = new double[3, 4];

            for (int i = 0; i < 3; i++)
                for (int j = 0; j < 4; j++)
                    doubleArray[i, j] = 0;



            int k = 2;
            for (int i = 0; i < 3; i++)
            {
                for (int j = 0; j < k; j++)
                {
                    Console.Write("Введите элемент[" + i + "][" + j + "]: ");
                    doubleArray[i, j] = Convert.ToDouble(Console.ReadLine());
                }
                k++;
            }

            k = 2;
            for (int i = 0; i < 3; i++)
            {
                for (int j = 0; j < k; j++)
                {
                    Console.Write(doubleArray[i, j] + " ");
                }
                k++;
                Console.WriteLine();
            }

            var myArray = new[] { 1, 2, 3, 4, 5 };
            var varString = "храмы в пустыне и джунглях";

            int[][] jaggedArray = new int[3][];
            jaggedArray[0] = new int[] { 1, 2 };
            jaggedArray[1] = new int[] { 4, 5, 6 };
            jaggedArray[2] = new int[] { 6, 7, 8, 9 };

        }

        static void Typles()
        {
            var MyTuple = (7, "London", 'B', "Trix", 1000000000UL);
            Console.WriteLine(MyTuple);

            Console.WriteLine(MyTuple.Item1 + MyTuple.Item3 + MyTuple.Item4);

            int item1 = MyTuple.Item1;
            string item2 = MyTuple.Item2;
            char item3 = MyTuple.Item3;
            string item4 = MyTuple.Item4;
            ulong item5 = MyTuple.Item5;
            Console.WriteLine($"Распаковка с использованием ItemN: {item1}, {item2}, {item3}, {item4}, {item5}");

            var (item6, item7, item8, item9, item10) = MyTuple;
            Console.WriteLine($"Распаковка с использованием деконструкции: {item6}, {item7}, {item8}, {item9}, {item10}");

            var MyTuple1 = ('m', 11);
            var MyTuple2 = ('m', 11);
            var MyTuple3 = ('v', 12);

            if (MyTuple1 == MyTuple2 || MyTuple2 == MyTuple3 || MyTuple1 == MyTuple3)
                Console.WriteLine("Среди трёх кортежей есть 2 одинаковых, а может и все 3");
            else
                Console.WriteLine("Среди трёх кортежей нет одинаковых");
        }
    }
}




