namespace Class13th__Dynamic_Programing_
{
    //시험 범위 들어감
    internal class Program
    {
        //static int Fibonacci(int num)
        //{
        //
        //    if(num == 1 || num == 2)
        //    {
        //        num = 1;
        //    }
        //    else
        //    {
        //        num = Fibonacci(num - 1) + Fibonacci(num - 2);
        //    }
        //    return num;            
        //}

        static int Fibonacci(int n, int[] list)
        {

            if (n <= 0)
            {
                return 0;
            }
            else if (n == 1)
            {
                return 1;
            }
            if (list[n] != 0)
            {
                return list[n];
            }

            return list[n] = Fibonacci(n - 1, list) + Fibonacci(n - 2, list);

        }


        static void Main(string[] args)
        {
            #region 동적 계획법
            // 특정 범위까지의 값을 구하기 위해서 그것과 다른 범위까지의 값을 이용하여
            // 효율적으로 값을 구하는 알고리즘

            // 메모이제이션
            // 프로그램이 동일한 계산을 반복해야 할 때, 이전에 계산한 값을
            // 메모리에 저장함으로써 동일한 계산을 반복 수행하는
            // 작업을 제거하여 프로그램의 실행 속도를 향상시키는 기법
            #endregion

            int[] array = new int[10000];

            Console.WriteLine(Fibonacci(45, array));
        }
    }
}
