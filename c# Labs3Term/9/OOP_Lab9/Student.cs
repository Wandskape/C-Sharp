using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections.ObjectModel;
using System.Collections.Specialized;

namespace OOP_Lab9
{
    internal class Student: IEnumerable, INotifyPropertyChanged
    {
        private string FirstName;
        private string LastName;
        private int Course;
        private int Group;
        private int[] Marks;

        public Student(string firstName, string lastName, int course, int group, int[] marks)
        {
            FirstName = firstName;
            LastName = lastName;
            Course = course;
            Group = group;
            Marks = marks;
        }

        public Student()
        {
            FirstName = "";
            LastName = "";
            Course = 0;
            Group = 0;
            foreach(int mark in Marks)
            {
                Marks[mark] = 0;
            }
        }

        public string FName
        {
            set { 
                if(value==" " || value == "")
                {
                    Console.WriteLine("Поле не может быть пустым или пробельным");
                }
                else { 
                FirstName = value;
                }
            }
            get { return FirstName; }
        }

        public string LName
        {
            set
            {
                if (value == " " || value == "")
                {
                    Console.WriteLine("Поле не может быть пустым или пробельным");
                }
                else
                {
                    LastName = value;
                }
            }
            get { return LastName; }
        }

        public int course
        {
            set
            {
                if (Convert.ToBoolean(value))
                {
                    Console.WriteLine("Поле не может быть пустым или пробельным");
                }
                else
                {
                    Course = value;
                }
            }
            get { return Course; }
        }

        public int group
        {
            set
            {
                if (Convert.ToBoolean(value))
                {
                    Console.WriteLine("Поле не может быть пустым или пробельным");
                }
                else
                {
                    Group = value;
                }
            }
            get { return Group; }
        }

        public void ShowStudent()
        {
            Console.WriteLine("Имя: " + FirstName);
            Console.WriteLine("Фамилия: " + LastName);
            Console.WriteLine("Курс: " + Course);
            Console.WriteLine("Группа: " + Group);
            Console.Write("Отметки: ");
            for(int i = 0; i < 5; i++)
            {
                if (i != 4)
                    Console.Write(Marks[i] + ", ");
                else
                    Console.Write(Marks[i] + ".");
            }
        }

        public IEnumerator GetEnumerator() => FirstName.GetEnumerator();

        public event PropertyChangedEventHandler PropertyChanged;

        protected void OnPropertyChanged(string propertyName)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }

    }
}
