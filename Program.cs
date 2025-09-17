namespace Challenge4._3
{
    internal class Program
    {
        static void ReverseArrayInplace<T>(T[] array)
        {
            T tempHead = default(T);
            T tempTail = default(T);
            for (int i = 0; i <= array.Length / 2; i++)
            {
                tempHead = array[i];
                tempTail = array[array.Length - 1 - i];

                array[i] = tempTail;
                array[array.Length - 1 - i] = tempHead;
            }
            string output = string.Join(", ", array);
            Console.WriteLine(output);
        }
        static void Main(string[] args)
        {
            string[] array = { "H", "a", "n", "n", "a", "h" };
            ReverseArrayInplace(array);
            Console.WriteLine("and return");
            ReverseArrayInplace(array);
        }
    }
}

