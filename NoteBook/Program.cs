namespace NoteBook
{
    internal class Program
    {
        static void Sieve(int n)
        {
            int[] array = new int[n + 1];

            for(int i = 2; i < array.Length; i++)
            {
                array[i] = i;
            }

            for(int i = 2; i <= Math.Sqrt(n); i++)
            {
                if (array[i] == 0)
                {
                    continue;
                }

                for(int j = i * 2; j <= n; j += i)
                {
                    array[j] = 0;
                }
            }

            for(int i = 2; i <= n; i++)
            {
                if (array[i] != 0)
                {
                    Console.WriteLine(array[i]);
                }
            }
        }
        static void Main(string[] args)
        {
            Sieve(49);
        }
    }
}
