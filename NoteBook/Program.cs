namespace NoteBook
{
    internal class Program
    {
        static int GCD(int a, int b)
        {
            while (b != 0)
            {
                int temp = b;
                b = a % b;
                a = temp;
            }
            return a;
        }
        static int LCM(int a, int b)
        {
            return Math.Abs(a * b) / GCD(a, b);
        }
        
        static void Main(string[] args)
        {
            int a = 56;
            int b = 98;

            Console.WriteLine(GCD(a, b));
            Console.WriteLine(LCM(a, b));
        }
    }
}
