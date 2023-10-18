using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_7LabTempl
{
    public interface IGenericCollection<T>
    {
        void Add(T item);
        bool Remove(T item);
        void Print();
        void SaveToFile(string fileName);
    }

    internal class CollectionType<T> : IGenericCollection<T> where T : new()
    {
        private T[] elements;
        private int count;

        public CollectionType(int capacity)
        {
            elements = new T[capacity];
            count = 0;
        }

        public void Add(T item)
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

        public bool Remove(T item)
        {
            for (int i = 0; i < count; i++)
            {
                if (EqualityComparer<T>.Default.Equals(elements[i], item))
                {
                    for (int j = i; j < count - 1; j++)
                    {
                        elements[j] = elements[j + 1];
                    }
                    elements[count - 1] = default(T);
                    count--;
                    return true;
                }
            }
            return false;
        }

        public bool Contains(T item)
        {
            foreach (T element in elements)
            {
                if (EqualityComparer<T>.Default.Equals(element, item))
                {
                    return true;
                }
            }
            return false;
        }

        public void Print()
        {
            foreach (T element in elements)
            {
                if (!EqualityComparer<T>.Default.Equals(element, default(T)))
                {
                    Console.WriteLine(element);
                }
            }
        }

        public void SaveToFile(string fileName)
        {
            try
            {
                string json = JsonConvert.SerializeObject(this);
                File.WriteAllText(fileName, json);
                Console.WriteLine($"Saved to {fileName}");
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error saving to file: {ex.Message}");
            }
            finally
            {
                using (StreamWriter file = File.CreateText(fileName)) { }
            }
        }


        public string[] GetElements()
        {
            return elements.Select(e => e.ToString()).ToArray();
        }
    }


    internal class SetString
    {
        private string[] elements;
        private int count;

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

        public static SetString operator >>(SetString set, string itemToRemove)
        {
            if (set.Contains(itemToRemove))
            {
                for (int i = 0; i < set.count; i++)
                {
                    if (set.elements[i] == itemToRemove)
                    {
                        set.elements[i] = null;
                        set.count--;
                        break;
                    }
                }
            }
            return set;
        }

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

        public static SetString operator <<(SetString set, string itemToAdd)
        {
            if (!set.Contains(itemToAdd))
            {
                if (set.count < set.elements.Length)
                {
                    set.elements[set.count] = itemToAdd;
                    set.count++;
                }
                else
                {
                    Array.Resize(ref set.elements, set.elements.Length * 2);
                    set.elements[set.count] = itemToAdd;
                    set.count++;
                }
            }
            return set;
        }

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
