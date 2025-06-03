namespace DoLoop
{
    internal class Program
    {
        static void Main(string[] args)
        {
            bool isValid;
            int age;
            int testNumber = 0;
            do
            {
                Console.WriteLine(testNumber);
                testNumber += 3;
            }
            while (testNumber < 10);
            //do
            //{
            //    Console.WriteLine("What is your age: ");
            //    string ageText = Console.ReadLine();

            //    isValid = int.TryParse(ageText, out age);

            //    if (isValid == false)
            //    {
            //        Console.WriteLine("That was an invalid age");
            //    }
            //} while (isValid == false);

            //Console.WriteLine($"Your age is {age}");

            //while (isValid == false)
            //{

            //}
        }
    }
}
