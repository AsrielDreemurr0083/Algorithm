namespace Class8th__Two_Pointer_
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region 투 포인터
            // 두 개의 포인터를 두고 값들을 비교하여 문제를 해결하는 알고리즘

            // 1. 시작점과 끝점이 첫번쨰 원소의 인덱스를 가리키게 한다.
            // 2. 현재 부분합이 M과 같다면 카운트 한다.
            // 3. 현재 부분합이 M보다 작다면 end를 1 증가시킨다.
            // 4. 현재 부분합이 M보다 크거나 같다면 start를 1 증가시킨다.

            //int[] array = new int[] { 1, 2, 3, 2, 5 };
            //
            //int start = 0;
            //int end = 0;
            //int m = 5;
            //int sum = 0;
            //int count = 0;
            //
            //for (int i = 0; i < array.Length; i++)
            //{
            //    
            //    if (array[start] + array[end] < m)
            //    {
            //        end++;
            //    }else if (array[start] + array[end] >= m)
            //    {
            //        start++;
            //    }
            //    
            //    if (array[start] + array[end] == m)
            //    {
            //        count++;
            //    }
            //
            //}
            //
            //Console.WriteLine(count);

            //int[] array = new int[] { 1, 2, 3, 2, 5 };
            //int m = 5;
            //int count = 0;
            //int sum = 0;
            //
            //for (int start = 0, end = 0; end < array.Length; end++)
            //{
            //
            //    sum += array[end];
            //
            //    while (sum > m && start < end)
            //    {
            //        sum -= array[start];
            //        start++;
            //    }
            //
            //    if (sum == m)
            //    {
            //        count++;
            //    }
            //}
            //
            //Console.WriteLine(count);

            //정답

            int count = 0;
            int sum = 0;

            int start = 0;
            int end = 0;

            int m = 5;

            int[] list = new int[] { 1, 2, 5, 2, 5 };

            while (start <= end)
            {
                if (sum >= m)
                {
                    sum -= list[start++];
                }
                else if (end >= list.Length)
                {
                    break;
                }
                else
                {
                    sum += list[end++];
                }
                if (sum == m)
                {
                    count++;
                }

            }
            Console.WriteLine("Count의 값 : " + count);

            #endregion
        }


    }
}