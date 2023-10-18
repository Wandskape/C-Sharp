using System;

namespace OOP_Lab10
{
    class Progrem
    {
        static void Main()
        {
            string[] Mounth = { "January", "February", "March", "April", "May", "June", "July", "August", "September", "October", "November", "December" };
            int answer = 4;
            var selectedMounth = new List<string>();

            foreach (string el in Mounth)
            {
                if (el.Length > answer)
                    selectedMounth.Add(el);
            }

            foreach (var month in selectedMounth)
            {
                Console.WriteLine(month);
            }
            Console.WriteLine("===============================================================");

            var selectedMounth3 = new List<string>();

            foreach (string el in Mounth)
            {
                if (el.Length == answer)
                    selectedMounth3.Add(el);
            }

            foreach (var month in selectedMounth3)
            {
                Console.WriteLine(month);
            }
            Console.WriteLine("===============================================================");


            var selectedMounth2 = new List<string>();

            foreach (string el in Mounth)
            {
                if (el.StartsWith("J") || el.StartsWith("F") || el.StartsWith("A") || el.StartsWith("D"))
                    selectedMounth2.Add(el);
            }

            foreach (var month in selectedMounth2)
            {
                Console.WriteLine(month);
            }
            Console.WriteLine("===============================================================");


            var sortedMonths = Mounth.OrderBy(month => month);

            foreach (var month in sortedMonths)
            {
                Console.WriteLine(month);
            }
            Console.WriteLine("===============================================================");


            Abiturient Abiturient1 = new(1, "Иванов", "Иван", "Иванович", "Адрес1", "12345", new int[] { 4, 5, 4, 8, 9 });
            Abiturient Abiturient2 = new(2, "Петров", "Петр", "Петрович", "Адрес2", "67890", new int[] { 5, 4, 4, 7, 6 });
            Abiturient Abiturient3 = new(3, "Сидоров", "Сидор", "Сидорович", "Адрес3", "54321", new int[] { 3, 3, 4, 2, 2 });
            Abiturient Abiturient4 = new(4, "Козлов", "Козел", "Козлович", "Адрес4", "67890", new int[] { 3, 2, 3, 2, 2 });
            Abiturient Abiturient5 = new(5, "Смирнов", "Смир", "Смирнович", "Адрес5", "98765", new int[] { 4, 3, 4, 4, 3 });
            Abiturient Abiturient6 = new(6, "Морозов", "Мороз", "Морозович", "Адрес6", "13579", new int[] { 5, 5, 5, 5, 5 });
            Abiturient Abiturient7 = new(7, "Васильев", "Василиса", "Васильевна", "Адрес7", "24680", new int[] { 3, 4, 3, 4, 4 });
            Abiturient Abiturient8 = new(8, "Зайцев", "Зайчик", "Зайцевич", "Адрес8", "87654", new int[] { 4, 4, 4, 3, 3 });
            Abiturient Abiturient9 = new(9, "Никитин", "Никита", "Никитич", "Адрес9", "11223", new int[] { 5, 5, 5, 4, 5 });
            Abiturient Abiturient10 = new(10, "Павлов", "Павел", "Павлович", "Адрес10", "33445", new int[] { 3, 4, 3, 3, 4 });
            Abiturient Abiturient11 = new(11, "Соколов", "Сокол", "Соколович", "Адрес11", "55667", new int[] { 5, 5, 5, 5, 5 });
            Abiturient Abiturient12 = new(12, "Федоров", "Федор", "Федорович", "Адрес12", "76878", new int[] { 4, 3, 4, 3, 4 });
            Abiturient Abiturient13 = new(13, "Исаев", "Исай", "Исаевич", "Адрес13", "98989", new int[] { 3, 2, 3, 3, 2 });
            Abiturient Abiturient14 = new(14, "Гаврилов", "Гаврила", "Гаврилович", "Адрес14", "10101", new int[] { 5, 4, 4, 4, 5 });
            Abiturient Abiturient15 = new(15, "Лебедев", "Лебедь", "Лебедевич", "Адрес15", "12121", new int[] { 3, 4, 3, 3, 4 });


            Abiturient[] abiturientsArray = new Abiturient[] { Abiturient1, Abiturient2, Abiturient3, Abiturient4, Abiturient5, Abiturient6, Abiturient7, Abiturient8, Abiturient9, Abiturient10, Abiturient11, Abiturient12, Abiturient13, Abiturient14, Abiturient15 };

            var abiturientsWithLowMarks = abiturientsArray.Where(abiturient => abiturient.Marks.Any(mark => mark < 4)).ToList();

            foreach (var abiturient in abiturientsWithLowMarks)
            {
                abiturient.AbiturientInfoSolo(abiturient);
            }

            Console.WriteLine("===============================================================");


            int answerS = 30;
            var abiturientsWithHighTotalMarks = abiturientsArray.Where(abiturient => abiturient.Marks.Sum() > answerS).ToList();

            foreach (var abiturient in abiturientsWithHighTotalMarks)
            {
                abiturient.AbiturientInfoSolo(abiturient);
            }

            Console.WriteLine("===============================================================");


            int subjectIndex = 0;
            var abiturientsWithPerfectScore = abiturientsArray.Count(abiturient => abiturient.Marks[subjectIndex] == 10);

            Console.WriteLine(abiturientsWithPerfectScore);

            Console.WriteLine("===============================================================");


            var sortedAbiturients = abiturientsArray.OrderBy(abiturient => abiturient.LastName).ToArray();

            foreach (var abiturient in sortedAbiturients)
            {
                abiturient.AbiturientInfoSolo(abiturient);
            }

            Console.WriteLine("===============================================================");


            var lowestScoringAbiturients = abiturientsArray.OrderBy(abiturient => abiturient.Marks.Average()).TakeLast(4).ToArray();

            foreach (var abiturient in lowestScoringAbiturients)
            {
                abiturient.AbiturientInfoSolo(abiturient);
            }

            Console.WriteLine("===============================================================");

            var query = from abiturient in abiturientsArray
                        where abiturient.Marks.Sum() > 25
                        group abiturient by abiturient.Address into courseGroup
                        let avgScore = courseGroup.Average(a => a.Marks.Average())
                        orderby avgScore descending
                        select new
                        {
                            Address = courseGroup.Key,
                            AverageScore = avgScore,
                            TopAbiturient = courseGroup.First()
                        };

            foreach (var result in query)
            {
                Console.WriteLine($"Address: {result.Address}, Average Score: {result.AverageScore}");
                Console.WriteLine($"Top Abiturient: {result.TopAbiturient.LastName}, {result.TopAbiturient.FirstName}");
            }
        }
    }
}