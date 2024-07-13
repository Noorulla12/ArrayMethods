
namespace ArrayMethods
{
    class Program
    {
        static void Main(string[] args)
        {
            var numbers = new[] { 1, 3, 7, 5, 9, 11, 12 };

            //Length 
            Console.WriteLine("Length of the Array: " + numbers.Length);

            //IndexOf

            var index = Array.IndexOf(numbers, 9);
            Console.WriteLine("index of 9 : " + index);

            //Clear()
            Array.Clear(numbers, 0, 2);
            Console.WriteLine("Effect of clear():");

            foreach (var number in numbers) 
                Console.WriteLine(number);

            //Copy()

            var another = new int[5];
            Array.Copy(numbers,another,5);

            Console.WriteLine("Effect of Copy(): ");

            foreach(var n in another)
                Console.WriteLine(n);
            //Sort()

            Array.Sort(numbers);

            Console.WriteLine("Effect of Sort(): ");

            foreach(var number in numbers)
                Console.WriteLine(number);
            //Reverse()

            Array.Reverse(numbers);

            Console.WriteLine("Effect of Reverse(): ");

            foreach(var number in numbers)
                Console.WriteLine(number);

        }
    }
}