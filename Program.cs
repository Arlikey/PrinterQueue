using System.Collections;
using System.Reflection.Metadata.Ecma335;

namespace PrinterQueue
{
    /*internal class Program
    {
        static void Main(string[] args)
        {
            Printer printer = new Printer("AX2");

            printer.AddJob(new Document() { Name = "Very Important1", Description = "Hello World!1", Priority = Priority.Low });
            printer.AddJob(new Document() { Name = "Very Important2", Description = "Hello World!2", Priority = Priority.High });
            printer.AddJob(new Document() { Name = "Very Important3", Description = "Hello World!3", Priority = Priority.High });
            printer.AddJob(new Document() { Name = "Very Important4", Description = "Hello World!4", Priority = Priority.Medium });
            printer.AddJob(new Document() { Name = "Very Important5", Description = "Hello World!5", Priority = Priority.Low });

            printer.Print();
            printer.Print();
            printer.Print();
            printer.Print();

            Console.WriteLine(printer.IsHaveDocuments());
        }

        public enum Priority
        {
            High, Medium, Low
        }

        public class Document
        {
            public string Name { get; set; }
            public string Description { get; set; }
            public Priority Priority { get; set; }
            public override string ToString()
            {
                return $"Name - {Name}\nDescription: {Description}\nPriority: {Priority}";
            }
        }

        public class Printer
        {
            public string Name { get; set; }
            private Queue<Document>[] PrintQueue { get; set; }
            public Queue<Document> CompletedPrints { get; set; }

            public Printer(string Name)
            {
                this.Name = Name;
                PrintQueue = new Queue<Document>[Enum.GetNames(typeof(Priority)).Length].Select(x => x = new Queue<Document>()).ToArray();
                CompletedPrints = new Queue<Document>();
            }

            public void AddJob(Document job)
            {
                PrintQueue[(int)job.Priority].Enqueue(job);
            }

            public void Print()
            {
                var currentJob = PrintQueue.Where(x => x.Any()).FirstOrDefault()?.Dequeue();

                if (currentJob != null)
                {
                    Console.WriteLine($"Printed job:\n{currentJob}");
                    CompletedPrints.Enqueue(currentJob);
                }
            }

            public bool IsHaveDocuments() => PrintQueue.Where(x => x.Any()).FirstOrDefault() != null ? true : false;
        }
    }*/

    /*public class AdditionalTask1
    {
        static void Main(string[] args)
        {
            Random random = new Random();

            ArrayList arrayList = new ArrayList(50);

            for (int i = 0; i < arrayList.Capacity; i++)
            {
                arrayList.Add(random.Next(0, 10));
            }

            arrayList.Sort();

            Console.WriteLine(arrayList.BinarySearch(3));
        }
    }*/

    /*public class AdditionalTask2
    {
        static void Main(string[] args)
        {
            List<int> list = new List<int>(100);

            for (int i = 0; i < list.Capacity; i++)
            {
                list.Add(new Random().Next(1, 10));
            }

            for (int i = 0; i < list.Count; i++)
            {
                Console.WriteLine($"[{i}] {list[i]}");
            }

            GetHowManyTimesAppendEachNumber(list);
        }

        public static void GetHowManyTimesAppendEachNumber(List<int> list) 
        {
            Dictionary<int, int> keyValuePairs = new Dictionary<int, int>();
            foreach (int i in list)
            {
                if (keyValuePairs.ContainsKey(i))
                {
                    keyValuePairs[i]++;
                }
                else
                {
                    keyValuePairs.Add(i, 1);
                }
            }

            foreach (var item in keyValuePairs)
            {
                Console.WriteLine($"Number {item.Key} - {item.Value} time(s)");
            }
        }
    }*/

    /*public class AdditionalTask3
    {
        static void Main(string[] args)
        {
            int[] array = new int[10];

            for (int i = 0; i < array.Length; i++)
            {
                array[i] = new Random().Next(0, 10);
                Console.Write(array[i] + " ");
            }

            Console.WriteLine();

            Console.WriteLine(FindMax(array, 0, array.Length - 1));
        }

        public static int FindMax(int[] array, int from, int to)
        {
            if (to <= from + 1)
            {
                return Math.Max(array[from], array[to]);
            }

            return Math.Max(FindMax(array, from, (from + to) / 2), FindMax(array, (from + to) / 2 + 1, to));
        }
    }*/

    /*public class AdditionalTask4
    {
        static void Main(string[] args)
        {
            List<Figure> figures = new List<Figure>();

            figures.Add(new Circle() { Perimeter = 3.14f, Square = 25.3f });
            figures.Add(new Square() { Perimeter = 31.2f, Square = 745f });
            figures.Add(new Circle() { Perimeter = 543.3f, Square = 21.3f });
            figures.Add(new Circle() { Perimeter = 423.3f, Square = 756.3f });
            figures.Add(new Square() { Perimeter = 55f, Square = 453.2f });


            Console.WriteLine("\n\nСОРТИРОВКА ПО ВОЗРАСТАНИЮ ПЛОЩАДЕЙ\n\n");
            figures.Sort((Figure x, Figure y) => { if (x.Square > y.Square) return 1; else if (x.Square < y.Square) return -1; else return 0; });

            foreach (Figure f in figures)
            {
                Console.WriteLine(f);
            }

            Console.WriteLine("\n\nСОРТИРОВКА ПО УБЫВАНИЮ ПЕРИМЕТРОВ\n\n");
            figures.Sort((Figure x, Figure y) => { if (x.Perimeter < y.Perimeter) return 1; else if (x.Perimeter > y.Perimeter) return -1; else return 0; });

            foreach (Figure f in figures)
            {
                Console.WriteLine(f);
            }
        }

        public abstract class Figure
        {
            public float Perimeter { get; set; }
            public float Square { get; set; }
        }

        public class Circle : Figure
        {
            public override string ToString()
            {
                return $"Circle: perimeter = {Perimeter}, square = {Square}";
            }
        }

        public class Square : Figure
        {
            public override string ToString()
            {
                return $"Square: perimeter = {Perimeter}, square = {Square}";
            }
        }
    }*/

    /*public class AdditionalTask5
    {
        static void Main(string[] args)
        {
            List<Journalist> journalists =
            [
                new Journalist() { Name = "Bob", Salary = 1200m},
                new Journalist() { Name = "John", Salary = 700m},
                new Journalist() { Name = "Jacob", Salary = 1500m},
            ];

            Newspaper newspaper = new Newspaper() { Name = "New York Times", Circulation = 25000, CountOfLanes = 300, Journalists = journalists};

            Console.WriteLine(newspaper.GetFullInformation());

            Console.WriteLine($"Sum of salaries: {newspaper.GetSumOfSalaries()}");

            List<Journalist> journalistsWithSmallSalary = newspaper.GetJournalistsWithSalaryBelowAverage();

            Console.WriteLine($"Average Salary : {newspaper.GetAverageSalary()}");

            foreach (Journalist journalist in journalistsWithSmallSalary)
            {
                Console.WriteLine(journalist);
            }

            newspaper.IncreaseSalaryBy(20);

            newspaper.DecreaseSalaryBy(20);

            Console.WriteLine(newspaper.GetFullInformation());

            List<Journalist> journalistsWithDesiredSalary = newspaper.GetJournalistsWithDesiredSalary(840);

            foreach (Journalist journalist in journalistsWithDesiredSalary)
            {
                Console.WriteLine(journalist);
            }

        }

        public class Newspaper
        {
            public string Name { get; set; }
            public int Circulation { get; set; }
            public int CountOfLanes { get; set; }
            public List<Journalist> Journalists { get; set; } = new List<Journalist>();
            public string GetFullInformation()
            {
                string fullInformation = string.Empty;

                fullInformation += $"Name - {Name}\nCirculation - {Circulation}\nCount Of Lanes - {CountOfLanes}\nJournalists:\n";

                foreach (Journalist journalist in Journalists)
                {
                    fullInformation += $"\t{journalist}\n";
                }

                return fullInformation;
            }

            public decimal GetSumOfSalaries()
            {
                decimal sum = 0;

                foreach (Journalist journalist in Journalists)
                {
                    sum += journalist.Salary;
                }

                return sum;
            }

            public decimal GetAverageSalary()
            {
                return Journalists.Average(x => x.Salary);
            }

            public List<Journalist> GetJournalistsWithSalaryBelowAverage()
            {
                List<Journalist> journalists = new List<Journalist>();
                
                decimal averageSalary = GetAverageSalary();
                
                foreach (Journalist journalist in Journalists)
                {
                    if (journalist.Salary < averageSalary)
                    {
                        journalists.Add(journalist);
                    }
                }

                return journalists;
            }

            public List<Journalist> GetJournalistsWithSalaryAboveAverage()
            {
                List<Journalist> journalists = new List<Journalist>();

                decimal averageSalary = GetAverageSalary();

                foreach (Journalist journalist in Journalists)
                {
                    if (journalist.Salary > averageSalary)
                    {
                        journalists.Add(journalist);
                    }
                }

                return journalists;
            }

            public void IncreaseSalaryBy(decimal percent)
            {
                foreach (Journalist journalist in GetJournalistsWithSalaryBelowAverage())
                {
                    journalist.Salary *= 1 + percent/100;
                }
            }

            public void DecreaseSalaryBy(decimal percent)
            {
                foreach (Journalist journalist in GetJournalistsWithSalaryAboveAverage())
                {
                    journalist.Salary /= 1 + percent / 100;
                }
            }

            public List<Journalist> GetJournalistsWithDesiredSalary(decimal salary)
            {
                List<Journalist> journalists = new List<Journalist>();

                foreach (Journalist journalist in Journalists)
                {
                    if (journalist.Salary == salary)
                    {
                        journalists.Add(journalist);
                    }
                }

                return journalists;
            }
        }

        public class Journalist
        {
            public string Name { get; set; }
            public decimal Salary { get; set; }

            public override string ToString()
            {
                return $"Name - {Name}, Salary - {Salary}";
            }
        }
    }*/
}
