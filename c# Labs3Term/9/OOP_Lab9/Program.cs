using System;
using System.Collections.ObjectModel;
using System.Collections.Specialized;
using OOP_Lab9;

namespace OOP_Lab9
{
    public class Program
    {
        public static void Main()
        {
            Queue<Student> studentQueue = new Queue<Student>(10);

            ObservableCollection<Student> students = new ObservableCollection<Student>();

            students.CollectionChanged += Students_CollectionChanged;

            Student student1 = new Student("John", "Doe", 1, 101, new int[] { 9, 9, 9, 8, 7 });
            studentQueue.Enqueue(student1);

            Student student2 = new Student("Alice", "Smith", 2, 201, new int[] { 8, 8, 7, 7, 6 });
            studentQueue.Enqueue(student2);

            Student student3 = new Student("Bob", "Johnson", 3, 301, new int[] { 7, 7, 6, 6, 5 });
            studentQueue.Enqueue(student3);

            Student student4 = new Student("Emily", "Williams", 2, 201, new int[] { 9, 9, 9, 9, 9 });
            studentQueue.Enqueue(student4);

            Student student5 = new Student("Michael", "Brown", 4, 401, new int[] { 6, 6, 5, 5, 4 });
            studentQueue.Enqueue(student5);

            Student student6 = new Student("Olivia", "Jones", 1, 101, new int[] { 8, 8, 8, 8, 7 });
            studentQueue.Enqueue(student6);

            Student student7 = new Student("William", "Davis", 3, 301, new int[] { 7, 7, 6, 6, 6 });
            studentQueue.Enqueue(student7);

            Student student8 = new Student("Mia", "Martin", 2, 201, new int[] { 9, 8, 9, 8, 7 });
            studentQueue.Enqueue(student8);

            Student removedStudent = studentQueue.Dequeue();

            string searchName = "John";
            Student foundStudent = studentQueue.FirstOrDefault(student => student.FName == searchName);

            foreach (Student student in studentQueue)
            {
                student.ShowStudent();
            }

            // ----------------------------\\
            Queue<int> queue = new Queue<int>();

            queue.Enqueue(1);
            queue.Enqueue(2);
            queue.Enqueue(3);
            queue.Enqueue(4);
            queue.Enqueue(5);

            foreach (int item in queue)
            {
                Console.WriteLine(item);
            }

            int n = 2;

            for (int i = 0; i < n; i++)
            {
                queue.Dequeue();
            }

            foreach (int item in queue)
            {
                Console.WriteLine(item);
            }

            queue.Enqueue(6);
            queue.Enqueue(7);
            queue.Enqueue(8);
            queue.Enqueue(9);
            queue.Enqueue(10);

            foreach (int item in queue)
            {
                Console.WriteLine(item);
            }

            List<int> list = new List<int>(queue);

            foreach (int item in list)
            {
                Console.WriteLine(item);
            }

            int valueToFind = 7;
            bool found = list.Contains(valueToFind);

            if (found)
            {
                Console.WriteLine($"Значение {valueToFind} найдено во второй коллекции.");
            }
            else
            {
                Console.WriteLine($"Значение {valueToFind} не найдено во второй коллекции.");
            }

            //---------------------------\\

            void Students_CollectionChanged(object sender, NotifyCollectionChangedEventArgs e)
            {
                if (e.Action == NotifyCollectionChangedAction.Add)
                {
                    Console.WriteLine("Добавлен элемент в коллекцию.");
                }
                else if (e.Action == NotifyCollectionChangedAction.Remove)
                {
                    Console.WriteLine("Удален элемент из коллекции.");
                }
            }

            students.Add(new Student("John", "Doe", 1, 101, new int[] { 90, 85, 78, 92 }));
            students.Add(new Student("Alice", "Smith", 2, 102, new int[] { 88, 92, 76, 85 }));

            students.RemoveAt(1);
        }
    }
}
