namespace Challenge4._3
{
    internal class Program
    {
        static void ReverseArrayInplace<T>(T[] array)
        {
            int left = 0, right = array.Length - 1;
            while (left < right)
            {
                (array[left], array[right]) = (array[right], array[left]);
                left++; right--;
            }

            string output = string.Join(", ", array);
            Console.WriteLine(output);
        }
        static void Main(string[] args)
        {
            string[] array = { "a", "b", "c", "d", "e", "f" };
            ReverseArrayInplace(array);
            Console.WriteLine("and return again");
            ReverseArrayInplace(array);

            string output = "Test";
            ReverseArrayInplace(output.ToArray());
        }
    }
}

