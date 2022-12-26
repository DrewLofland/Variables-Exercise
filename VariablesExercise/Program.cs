namespace VariablesExercise
{
    public class Program
    {
        static void Main(string[] args)
        {
            string dogName; //declaration syntax
            dogName = "Dexter"; //initializing variable
            int dogAge = 5; //declaring and initializing
            char firstInitial = 'D';
            bool isHungry = true;
            double dogWeight = 50.2;
            decimal dogHeight = 14.7m;
            Console.WriteLine($"My dog's name is {dogName}. He is {dogAge} years old. It is {isHungry} he is always hungry. He weighs {dogWeight} pounds and is {dogHeight} inches tall.");
        }
    }
}
