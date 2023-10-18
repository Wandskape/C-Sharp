using OOP_2Lab;
using System;
using System.ComponentModel;

class Program
{
    static void Main(string[] args)
    {


        Abiturient Abiturient1 = new(1, "Иванов", "Иван", "Иванович", "Адрес1", "12345", new int[] { 4, 5, 4, 8, 9 });
        Abiturient Abiturient2 = new(2, "Петров", "Петр", "Петрович", "Адрес2", "67890", new int[] { 5, 4, 4, 7, 6 });
        Abiturient Abiturient3 = new(3, "Сидоров", "Сидор", "Сидорович", "Адрес3", "54321", new int[] { 3, 3, 4, 2, 2 });
        Abiturient Abiturient4 = new Abiturient();

        Abiturient[] abiturientsArray = new Abiturient[] { Abiturient1, Abiturient2, Abiturient3 };

        Abiturient.AbiturientInfo(abiturientsArray);
        Abiturient.AbiturientLoseMark(abiturientsArray);
        Abiturient.AbiturientSunMarkHiger(abiturientsArray);

        if (Abiturient1 == Abiturient2)
            Console.WriteLine("Объекты равны");
        else
            Console.WriteLine("Объекты различны");

        Console.WriteLine(Abiturient1.GetType());

        Abiturient.AbiturientAVGscore(Abiturient1);
        Abiturient.AbiturientMaxMinScore(Abiturient1);


        var abiturients = new { Abiturient1, Abiturient2, Abiturient3, group = 4 };
        Console.WriteLine($"Abiturient1: {abiturients.Abiturient1}, Abiturient2: {abiturients.Abiturient2}, Abiturient3: {abiturients.Abiturient3}, Group: {abiturients.group}");
    }
}


