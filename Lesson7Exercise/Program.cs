namespace Lesson7Exercise
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var objs = new List<object>();
            objs.Add(2.5d);
            objs.Add(2.0d);
            objs.Add(3);
            objs.Add(2);
            objs.Add("Hello ");
            objs.Add("world");

            double sum = 0;
            int total = 0;
            string sentance = "";

            Console.WriteLine("Produce a sum of objects");
            Console.WriteLine("Add ints to ints, floats to floats and concatenate strings");
            
            Console.WriteLine("---Print out type---");

            foreach (var obj in objs)
            {
                Console.WriteLine(obj.GetType());

                if (obj.GetType() == typeof(double))
                {
                    sum += (double)obj;
                }

                if (obj.GetType() == typeof(int))
                {
                    total += (int)obj;
                }

                if (obj.GetType() == typeof(string))
                {
                    sentance+= (string)obj;
                }
            }

            Console.WriteLine("Print out sum");

            

            Console.WriteLine($"Sum of ints: {total}");
            Console.WriteLine($"Sum of doubles: {sum}");
            Console.WriteLine($"Sum of Strings: {sentance}");

            Console.ReadLine();
        }
    }
}