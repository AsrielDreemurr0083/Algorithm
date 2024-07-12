namespace Program
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region 선택 정렬
            //주어진 리스트 중에 최소값을 찾아서 맨 앞에 위치한 결과를
            //교체하는 방식으로 정렬하는 알고리즘
            //int[] array = new int[] { 3, 6, 7, 9, 5 };
            //
            //int targetIndex, temp;
            //
            //for (int i = 0; i < array.Length - 1; i++)
            //{
            //    targetIndex = i;
            //    for (int j = i+1; j < array.Length; j++)
            //    {
            //        if (array[j] < array[targetIndex])
            //        {
            //            targetIndex = j;
            //        }
            //    }
            //    if (i != targetIndex)
            //    {
            //        temp = array[i];
            //        array[i] = array[targetIndex];
            //        array[targetIndex] = temp;
            //    }
            //}
            //for (int i = 0; i < array.Length; i++)
            //{
            //    Console.Write(array[i] + " ");
            //}

            //정답

            int[] array = new int[] { 3, 6, 7, 9, 5 };

            for(int i = 0; i < array.Length; i++)
            {
                int min = array[i];
                int select = i;
                for(int j = i + 1; j < array.Length; j++)
                {
                    if(min > array[j])
                    {
                        min = array[j];

                        select = j;
                    }
                }
                int temp = array[i];

                array[i] = array[select];
                array[select] = temp;
            }

            for(int i = 0; i < array.Length; i++)
            {
                Console.Write(array[i] + " ");
            }

            #endregion
        }
    }
}
