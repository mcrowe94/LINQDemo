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

            var evens = numbers.Where(numbers => numbers % 2 == 0).OrderBy(x => x);

            foreach (var item in evens)
            {
                Console.WriteLine(item);
            }
        }
    }
}