using ConsoleApp1.Library;

namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // ----- Value Types -----

            var p1 = new Person
            {
                FirstName = "John",
                LastName = "Smith",
                Age = 22
            };

            var p2 = new Person
            {
                FirstName = "Jane",
                LastName = "Snow",
                Age = 32
            };

            Console.WriteLine($"P1 is {p1.FirstName} and P2 is {p2.FirstName} before swapping.");

            Swap(p1.FirstName, p2.FirstName);

            Console.WriteLine($"P1 is {p1.FirstName} and P2 is {p2.FirstName} after swapping.");

            // ----- Value Types -----

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
