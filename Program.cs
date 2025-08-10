namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Question 1  

            Range<int> Range = new Range<int>(40, 60);
            Console.WriteLine("enter a number");
            int input = int.Parse(Console.ReadLine()); 
            if (Range.IsInRange(input))
            {
                Console.WriteLine("the number you entered is in Range");
            }
            else
            {
                Console.WriteLine("the number you entered is not in Range");
            }

            #endregion
        }
    }
}
