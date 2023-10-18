using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_3Lab
{
    internal class SetString
    {
        private string[] elements;
        private int count;

        public class Production
        {
            public int Id { get; set; }
            public string OrganizationName { get; set; }

            public Production(int id, string organizationName)
            {
                Id = id;
                OrganizationName = organizationName;
            }
        }

        public class Developer
        {
            public string FullName { get; set; }
            public int Id { get; set; }
            public string Department { get; set; }

            public Developer(string fullName, int id, string department)
            {
                FullName = fullName;
                Id = id;
                Department = department;
            }
        }

        public SetString(int capacity)
        {
            elements = new string[capacity];
            count = 0;
        }

        public void Add(string item)
        {
            if (!Contains(item))
            {
                if (count < elements.Length)
                {
                    elements[count] = item;
                    count++;
                }
                else
                {
                    // Расширение массива, если он заполнен
                    Array.Resize(ref elements, elements.Length * 2);
                    elements[count] = item;
                    count++;
                }
            }
        }

        public bool Contains(string item)
        {
            foreach (string element in elements)
            {
                if (element == item)
                {
                    return true;
                }
            }
            return false;
        }

        public void Print()
        {
            foreach (string element in elements)
            {
                if (element != null)
                {
                    Console.WriteLine(element);
                }
            }
        }

        //public static SetString operator >>(SetString set, string itemToRemove)
        //{
        //    if (set.Contains(itemToRemove))
        //    {
        //        for (int i = 0; i < set.count; i++)
        //        {
        //            if (set.elements[i] == itemToRemove)
        //            {
        //                set.elements[i] = null;
        //                set.count--;
        //                break;
        //            }
        //        }
        //    }
        //    return set;
        //}

        public static bool operator <(SetString set1, SetString set2)
        {
            int counter = 0;
            foreach (string element in set2.elements)
            {
                if (set1.Contains(element))
                    counter++;
            }

            if (counter == set2.count)
            {
                Console.WriteLine("set2 является подмножетвом set1");
                return true;
            }
            else
                return false;


        }

        public static bool operator >(SetString set1, SetString set2)
        {
            return set2 < set1;
        }

        public static bool operator !=(SetString set1, SetString set2)
        {
            int counter = 0;

            if (set1.count != set2.count)
                return true;

            foreach (string element in set2.elements)
            {
                if (set1.Contains(element))
                    counter++;
            }

            if (counter == set2.count)
            {
                Console.WriteLine("множества ровны");
                return false;
            }
            else
                return true;


        }

        public static bool operator ==(SetString set1, SetString set2)
        {
            return set2 == set1;
        }

        //public static SetString operator <<(SetString set, string itemToAdd)
        //{
        //    if (!set.Contains(itemToAdd))
        //    {
        //        if (set.count < set.elements.Length)
        //        {
        //            set.elements[set.count] = itemToAdd;
        //            set.count++;
        //        }
        //        else
        //        {
        //            Array.Resize(ref set.elements, set.elements.Length * 2);
        //            set.elements[set.count] = itemToAdd;
        //            set.count++;
        //        }
        //    }
        //    return set;
        //}

        public static bool operator %(SetString set1, SetString set2)
        {
            int counter = 0;
            foreach (string element in set2.elements)
            {
                if (set1.Contains(element))
                    counter++;
            }

            if (counter != 0)
            {
                Console.WriteLine("множества пересекаются");
                return true;
            }
            else
                return false;


        }

        //public static void SmallestWord(SetString set)
        //{
        //    string buff = set.elements[0];

        //    foreach (string element in set.elements)
        //        if (element.Length < buff.Length)
        //            buff = element;
        //    Console.WriteLine("Самое короткое слово: " + buff);

        //}

        //public static void sortWord(SetString set)
        //{
        //    var sortedNames = set.elements.OrderBy(name => name);

        //    foreach (var name in sortedNames)
        //    {
        //        Console.WriteLine(name);
        //    }

        //}

        public string[] GetElements()
        {
            return elements;
        }

        public string GetElementsNumb(int number)
        {
            return elements[number];
        }
    }
}
