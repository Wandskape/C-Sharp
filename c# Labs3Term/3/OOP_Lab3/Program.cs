using OOP_3Lab;
using System;
using System.Collections.Generic;
using System.Data.SqlTypes;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

class Program
{
    static void Main()
    {
        SetString set1 = new SetString(5);
        SetString set2 = new SetString(5);

        set1.Add("Apple");
        set1.Add("Banana");
        set1.Add("Cherry");
        set1.Add("Date");
        set1.Add("Fig");

        set2.Add("Apple");
        set2.Add("Date");
        set2.Add("Fig");



        set1.Print();

        //set1 = set1 >> set1.GetElementsNumb(2);

        set1.Print();

        Console.WriteLine(set2 < set1);

        Console.WriteLine(set2 != set1);

        //set2 = set2 << set1.GetElementsNumb(2);

        set2.Print();

        set1.Sum();
        set1.Difference();
        set1.Count();
        set1.SmallestWord();
        set1.sortWord();
    }
}