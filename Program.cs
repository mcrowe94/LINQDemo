namespace LINQDemo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var myFamily = new List<string>() { "Monica", "Jake", "Audrey", "Benjamin" };

            var shortList = myFamily.Where(name => name.Length == 4);

            foreach(var family in shortList)
            {
                Console.WriteLine(family); //will return family member with only 4 letters in their name
            }
        }
    }
}