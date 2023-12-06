namespace VariablesExercise
{
    public class Program
    {
        static void Main(string[] args)
        {
            string dogName = "Thor";
            int age = 11;
            char numberOfBowls = '5';
            bool isChubby = true;
            double dogToys = 15.645;
            decimal vetBill = 90.20m;
            
            Console.WriteLine($"My doggo's name is {dogName}. He is {age} years old.");
            Console.WriteLine($"{dogName} has {numberOfBowls} bowls for food and water.");
            Console.WriteLine($"It is {isChubby} that he is chubby, but he's cute so that's okay.");
            Console.WriteLine($"He has {dogToys} toys. The cost to go to the vet is {vetBill}");
        }
    }
}
