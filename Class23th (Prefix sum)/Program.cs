namespace Class23th__Prefix_sum_
{
    internal class Program
    {

        static void Main(string[] args)
        {
            #region 누적합
            //특정한 배열이 있을 때 해당 배열까지의 합을 의미한다.


            int[] sum = new int[] { 7, 3, 4, 5, 1 };

            for (int i = 1; i < sum.Length; i++)
            {
                sum[i] = sum[i - 1] + sum[i];
            }

            for (int i = 0; i < sum.Length; i++)
            {
                Console.WriteLine(sum[i]);
            }

            Console.WriteLine(sum[4] - sum[3 - 1]);

            #endregion
        }
    }
}