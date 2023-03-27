namespace LINQDemo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //var myFamily = new List<string>() { "Monica", "Jake", "Audrey", "Benjamin" };

            //var shortList = myFamily.Where(name => name.Length == 4);

            //foreach(var family in shortList)
            //{
            //    Console.WriteLine(family); //will return family member with only 4 letters in their name
            //}

            var numbers = new List<int> { 6, 7, 3, 9, 2, 8, 1, 4, 0, 5 };

            //var evens = numbers.Where(numbers => numbers % 2 == 0).OrderBy(x => x);

            //foreach (var item in evens)
            //{
            //    Console.WriteLine(item);
            //}

            //var lessThan4 = numbers.Where(x => x < 4);

            //foreach(var num in lessThan4)
            //{
            //    Console.WriteLine(num);
            //}

            var maxNum = numbers.Max();
            var minNum = numbers.Min();
            var avgNum = numbers.Average();
            var sumNum = numbers.Sum();
            var index = numbers.IndexOf(7);

            Console.WriteLine($"Highest number: {maxNum}");
            Console.WriteLine($"Lowest number: {minNum}");
            Console.WriteLine($"Index of 7 value: {index}");
        }
    }
}