namespace _03._Old_Books
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string targetBook = Console.ReadLine();

            int checkedBooks = 0; // counter

            bool isFound = false; // flag

            string currentBook;
            while ((currentBook = Console.ReadLine()) != "No More Books")
            {

                if (currentBook == targetBook)
                {
                    isFound = true;
                    break;
                }
                checkedBooks++;
            }

            if (isFound)
            {
                Console.WriteLine($"You checked {checkedBooks} books and found it.");
            }
            else
            {
                Console.WriteLine("The book you search is not here!");
                Console.WriteLine($"You checked {checkedBooks} books.");
            }
        }
    }
}