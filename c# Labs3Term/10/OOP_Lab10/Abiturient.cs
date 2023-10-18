using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_Lab10
{
    internal class Abiturient
    {
        private static int idCounter = 0; // Счетчик для вычисления уникального ID
        private readonly int ID; // Уникальный ID для каждого абитуриента
        private string lastName;
        private string firstName;
        private string orderName;
        private string address;
        private string phoneNumber;
        private int[] marks = new int[5];

        public const string UniversityName = "БГТУ";

        private static int instanceCount = 0;

        public Abiturient(int ID, string lastName, string firstName, string orderName, string address, string phoneNumber, int[] marks)
        {
            this.ID = ID;
            this.lastName = lastName;
            this.firstName = firstName;
            this.orderName = orderName;
            this.address = address;
            this.phoneNumber = phoneNumber;
            this.marks = marks;
            instanceCount++;
        }

        public Abiturient()
        {
            this.lastName = "LName";
            this.firstName = "FName";
            this.orderName = "OName";
            this.address = "Adress";
            this.phoneNumber = "33-333-33-33";
            this.marks = marks;
        }

        public Abiturient(string lastName, string firstName, string orderName = "No Order", string address = "No Address", string phoneNumber = "No Phone", int[] marks = null)
        {
            ID = GetHashCode();
            this.lastName = lastName;
            this.firstName = firstName;
            this.orderName = orderName;
            this.address = address;
            this.phoneNumber = phoneNumber;
            this.marks = marks ?? new int[0];
        }

        static Abiturient()
        {
            //конструктор статических полей
        }

        public Abiturient(int id)
        {
            ID = id;
        }

        public string LastName
        {
            get { return lastName; }
            set
            {
                if (!string.IsNullOrWhiteSpace(value))
                    lastName = value;
                else
                    throw new ArgumentException("Фамилия не может быть пустой.");
            }
        }

        public string FirstName
        {
            get { return firstName; }
            set
            {
                if (!string.IsNullOrWhiteSpace(value))
                    firstName = value;
                else
                    throw new ArgumentException("Имя не может быть пустым.");
            }
        }

        private string OrderName
        {
            get { return OrderName; }
            set
            {
                if (!string.IsNullOrWhiteSpace(value))
                    OrderName = value;
                else
                    throw new ArgumentException("Отчество не может быть пустым.");
            }
        }

        public string Address
        {
            get { return address; }
            set
            {
                if (!string.IsNullOrWhiteSpace(value))
                    address = value;
                else
                    throw new ArgumentException("Адрес не может быть пустым.");
            }
        }

        private string PhoneNumber
        {
            get { return PhoneNumber; }
            set
            {
                if (!string.IsNullOrWhiteSpace(value))
                    PhoneNumber = value;
                else
                    throw new ArgumentException("Номер телефона не может быть пустым.");
            }
        }

        public int[] Marks
        {
            get { return marks; }
            set
            {
                if (value != null && value.Length > 0)
                {
                    foreach (int mark in value)
                    {
                        if (mark < 2 || mark > 10)
                            throw new ArgumentException("Оценки должны быть в диапазоне от 2 до 10.");
                    }
                    marks = value;
                }
                else
                    throw new ArgumentException("Не указаны оценки или массив оценок пуст.");
            }
        }

        public static void DisplayClassInfo()
        {
            Console.WriteLine("Название класса: Абитуриент");
            Console.WriteLine("Количество экземпляров: " + instanceCount);
            Console.WriteLine("Название университета: " + UniversityName);
        }

        public static void AbiturientInfo(Abiturient[] abiturients)
        {
            foreach (Abiturient abiturient in abiturients)
            {
                Console.WriteLine("Информация по " + (idCounter + 1) + " абитуриенту");
                Console.WriteLine("Фамилия: " + abiturient.lastName);
                Console.WriteLine("Имя: " + abiturient.firstName);
                Console.WriteLine("Отчество: " + abiturient.orderName);
                Console.WriteLine("Адрес: " + abiturient.address);
                Console.WriteLine("Телефонный номер: " + abiturient.phoneNumber);
                Console.WriteLine("Отметка по первому экзамену: " + abiturient.marks[0]);
                Console.WriteLine("Отметка по второму экзамену: " + abiturient.marks[1]);
                Console.WriteLine("Отметка по третьему экзамену: " + abiturient.marks[2]);
                Console.WriteLine("Отметка по четвёртому экзамену: " + abiturient.marks[3]);
                Console.WriteLine("Отметка по пятому экзамену: " + abiturient.marks[4]);

            }
        }

        public void AbiturientInfoSolo(Abiturient abiturient)
        {
                Console.WriteLine("Фамилия: " + abiturient.lastName);
                Console.WriteLine("Имя: " + abiturient.firstName);
                Console.WriteLine("Отчество: " + abiturient.orderName);
                Console.WriteLine("Адрес: " + abiturient.address);
                Console.WriteLine("Телефонный номер: " + abiturient.phoneNumber);
        }

        public static void AbiturientLoseMark(Abiturient[] abiturients)
        {
            Console.WriteLine("Информация по абитуриентам с неудовлетворительными отметками: ");
            foreach (Abiturient abiturient in abiturients)
            {
                if (abiturient.marks[0] < 4 || abiturient.marks[1] < 4 || abiturient.marks[2] < 4 || abiturient.marks[3] < 4 || abiturient.marks[4] < 4)
                {
                    Console.WriteLine("Номер абитуриента: " + (idCounter + 1));
                    Console.WriteLine("Фамилия: " + abiturient.lastName);
                }
            }
        }

        public static void AbiturientSunMarkHiger(Abiturient[] abiturients)
        {
            int answer;
            Console.WriteLine("Сумма баллов не может быть больше 49 и ниже 10: ");
            answer = Convert.ToInt16(Console.ReadLine());
            Console.WriteLine("Информация по абитуриентам с суммой баллов выше заданной отметками: ");
            foreach (Abiturient abiturient in abiturients)
            {
                if (abiturient.marks.Sum() > answer)
                {
                    Console.WriteLine("Номер абитуриента: " + (abiturient.ID));
                    Console.WriteLine("Фамилия: " + abiturient.lastName);
                }
            }
        }

        public static void AbiturientAVGscore(Abiturient abiturient)
        {
            Console.Write("Средний балл абитуриента: ");
            Console.WriteLine(abiturient.marks.Sum() / 5);
        }

        public static void AbiturientMaxMinScore(Abiturient abiturient)
        {
            Console.Write("Максимальный балл абитуриента: ");
            Console.WriteLine(abiturient.marks.Max());
            Console.Write("Минимальный балл абитуриента: ");
            Console.WriteLine(abiturient.marks.Min());
        }
    }
}
