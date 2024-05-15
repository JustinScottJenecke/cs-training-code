namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int x = 5, y = 6;

            Console.WriteLine($"X is {x} and Y is {y} before swapping.");

            Swap(x, y);

            Console.WriteLine($"X is {x} and Y is {y} after swapping.");

            static void Swap(object a, object b) {
                object temp = a;
                a = b;
                b = temp;
            }
        }
    }
}
