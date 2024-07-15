namespace Class6th__Shell_Sort_
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region 쉘 정렬
            // 먼 거리의 요소들을 먼저 정렬하여 배열을 부분적으로 정렬한 후,
            // 점진적으로 더 작은 간격을 사용하는 정렬 알고리즘

            //1. 먼저 정렬해야 할 리스트를 일정한 기준에 따라 분류
            //2. 연속적이지 않은 여러 개의 부분 리스트를 생성
            //3. 각 부분 리스트를 삽입 정렬을 이용해서 정렬
            //4. 모든 부분 리스트가 정렬되면 다시 전체 리스트를 더 작은 개수의 부분 리스트로 만든 후에 정렬을 반복
            //5. 리스트의 개수가 1이 될 때까지 반복
            //배열의 크기 -1

            //int[] array = new int[] { 10, 8, 6, 20, 4, 3, 22, 1, 0, 15, 16 };
            //Console.WriteLine("정렬 전 배열:");
            //Console.WriteLine(string.Join(" ", array));
            //
            //// 외부 루프: gap을 점진적으로 줄여감
            //for (int gap = array.Length / 2; gap > 0; gap /= 2)
            //{
            //    for (int i = gap; i < array.Length; i++)
            //    {
            //        int temp = array[i];
            //        int j;
            //        for (j = i; j >= gap && array[j - gap] > temp; j -= gap)
            //        {
            //            array[j] = array[j - gap];
            //        }
            //        array[j] = temp;
            //    }
            //}
            //
            //Console.WriteLine("\n정렬 후 배열:");
            //Console.WriteLine(string.Join(" ", array));

            int[] array = new int[] { 10, 8, 6, 20, 4, 3, 22, 1, 0, 15, 16 };

            int gap = 0;
            int i = 0;
            int j = 0;
            int key = 0;

            for (gap = array.Length / 2; gap > 0; gap /= 2)
            {
                if (gap % 2 == 0)
                {
                    gap++;
                }

                for (i = gap; i < array.Length; i++)
                {
                    key = array[i];

                    for (j = i; j >= gap && array[j - gap] > key; j -= gap)
                    {
                        array[j] = array[j - gap];
                    }

                    array[j] = key;
                }
            }

            for (int k = 0; k < array.Length; k++)
            {
                Console.WriteLine(array[k]);
            }
            #endregion
        }
    }
}
