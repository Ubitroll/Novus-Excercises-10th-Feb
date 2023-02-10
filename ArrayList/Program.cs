namespace ArrayList
{
    public class Person
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public int age { get; set; }
    }

    public class Program
    {
        static void Main(string[] args)
        {
            var Numbers = new List<int>();
            Random r = new Random();

            for (int x = 0; x < 10; x++)
            {
                int num = r.Next(0, 100);
                Numbers.Add(num);
            }

            foreach (int num in Numbers)
            {
                Console.Write(num + " ");
            }

            Console.WriteLine("-----------------------------");
            Console.WriteLine($"Average of random numbers is: {Numbers.Average()}");
            Numbers.Insert(10, 0);
            var index = Numbers.IndexOf(0);

            Console.WriteLine($"Index of position 0 is {index}");

            var count = Numbers.Count();
            Console.WriteLine($"Count is: {count}");
            Console.WriteLine("---------------------------");

            Console.WriteLine("Collections using List of Objects");
            var Student = new List<Person>
            {
                new Person() { FirstName = "Joe", LastName = "Bloggs", age = 23},
                new Person() { FirstName = "Steve", LastName = "May", age = 22},
                new Person() { FirstName = "Jack", LastName = "Jones", age = 24},
                new Person() { FirstName = "Tom", LastName = "Jones", age = 23}
            };

            Console.WriteLine($"Number of objects is: {Student.Count()}");

            foreach (var student in Student)
            {
                Console.WriteLine(student.FirstName);
                Console.WriteLine(student.LastName);
                Console.WriteLine(student.age);
                Console.WriteLine("---------------------------");
            }

            Console.ReadLine();
        }
    }
}