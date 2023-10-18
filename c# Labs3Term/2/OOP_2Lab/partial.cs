using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_2Lab
{
    internal class partial
    {

        public string Name { get; set; }
        public int Age { get; set; }

        // Конструктор
        public partial(string name, int age)
        {
            Name = name;
            Age = age;
        }

        // Переопределение метода Equals
        public override bool Equals(object obj)
        {
            if (obj == null || GetType() != obj.GetType())
            {
                return false;
            }

            partial other = (partial)obj;
            return Name == other.Name && Age == other.Age;
        }

        // Переопределение метода GetHashCode
        public override int GetHashCode()
        {
            return (Name?.GetHashCode() ?? 0) ^ Age.GetHashCode();
        }

        // Переопределение метода ToString
        public override string ToString()
        {
            return $"Name: {Name}, Age: {Age}";
        }
    }

}
