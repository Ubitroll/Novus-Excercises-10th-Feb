namespace DictionaryApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            IDictionary<string,int> numberNames = new Dictionary<string,int>();
            numberNames.Add("Joe", 22); // (Key, Value)
            numberNames.Add("Jack", 23);
            numberNames.Add("Tom", 24);

            foreach(KeyValuePair<string,int> pair in numberNames)
            {
                Console.WriteLine($"Key: {pair.Key}, Value: {pair.Value}");
            }

            IDictionary<string,string> objectTypes = new Dictionary<string,string>();

            objectTypes.Add("Fruits", "Apple, Banana, Orange, Grapes, Pineapple");
            objectTypes.Add("Vegetables", "Sprouts, Carrots, Cauliflower, Peas");
            objectTypes.Add("Furniture", "Table, Chair, Sofa, Stool");
            objectTypes.Add("Hardware", "Hammer, Screwdriver, Nails, Screws, Crowbar");

            foreach(KeyValuePair<string,string> pair in objectTypes)
            {
                Console.WriteLine($"Key: {pair.Key}, Value: {pair.Value}");
            }
                
            Console.ReadLine();
        }
    }
}