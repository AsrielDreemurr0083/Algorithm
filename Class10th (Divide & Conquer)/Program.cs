namespace Class10th__Divide___Conquer_
{
    #region
    internal class Program
    {
        //static void Merge(int[] arr, int[] left, int[] right)
        //{
        //    int i = 0, j = 0, k = 0;
        //
        //    while (i < left.Length && j < right.Length)
        //    {
        //        if (left[i] <= right[j])
        //            arr[k++] = left[i++];
        //        else
        //            arr[k++] = right[j++];
        //    }
        //
        //    while (i < left.Length)
        //        arr[k++] = left[i++];
        //
        //    while (j < right.Length)
        //        arr[k++] = right[j++];
        //}
        //
        //static void Sort(int[] array)
        //{
        //    if (array.Length < 2)
        //        return;
        //
        //    int mid = array.Length / 2;
        //    int[] left = new int[mid];
        //    int[] right = new int[array.Length - mid];
        //
        //    // 분할(Divide)
        //    for (int i = 0; i < mid; i++)
        //        left[i] = array[i];
        //    for (int i = mid; i < array.Length; i++)
        //        right[i - mid] = array[i];
        //
        //    // 정복(Conquer)
        //    Sort(left);
        //    Sort(right);
        //
        //    // 결합(Combine)
        //    Merge(array, left, right);
        //}
        //
        //static void PrintArray(int[] arr)
        //{
        //    foreach (int num in arr)
        //        Console.Write(num + " ");
        //    Console.WriteLine();
        //}
        #endregion
        static int Find(int[] list, int left, int right)
        {
            if (left == right)
            {
                return list[left];
            }
            else
            {
                int maxLeft = Find(list, left, (left + right) / 2);
                int maxRight = Find(list, (left + right) / 2 + 1, right);
                if (maxLeft > maxRight)
                {
                    return maxLeft;
                }
                else
                {
                    return maxRight;
                }

            }

        }



        static void Main(string[] args)
        {
            #region 분할 정복
            // 주어진 문제를 2개 이상의 부분으로 문제를 나눈 뒤 각 부분
            // 문제에 대한 답을 재귀 호출을 이용해서 계산한 다음, 그 답으로부터
            // 전체 문제의 답을 계산해내는 알고리즘

            // 분할(Divide)  : 주어진 문제를 두 개 혹은 그 이상의 형식으로 나눈다.

            // 정속(Conquer) : 나누어진 문제를 재귀적으로 해결해서 나누어진 문제를
            //                 더 이상 나누어 문제를 필요없을 때 까지 계속 분할

            // 통합(Combine) : 나누어서 해결한 문제들을 통합해서 원래 문제의 해답을 생성
            //int[] arr = { 3, 6, 1, 5, 77, 4, 3, 19 };
            //
            //Console.WriteLine("Original array:");
            //PrintArray(arr);
            //
            //Sort(arr);
            //
            //Console.WriteLine("\nSorted array:");
            //PrintArray(arr);

            #endregion
            // 주어진 문제를 2개 이상의 부분으로 문제를 나눈 뒤 각 부분
            // 문제에 대한 답을 재귀 호출을 이용해서 계산한 다음, 그 답으로부터
            // 전체 문제의 답을 계산해내는 알고리즘

            // 분할(Divide)  : 주어진 문제를 두 개 혹은 그 이상의 형식으로 나눈다.

            // 정속(Conquer) : 나누어진 문제를 재귀적으로 해결해서 나누어진 문제를
            //                 더 이상 나누어 문제를 필요없을 때 까지 계속 분할

            // 통합(Combine) : 나누어서 해결한 문제들을 통합해서 원래 문제의 해답을 생성

            int[] array = { 5, 13, 2, 4 };

            Console.WriteLine(Find(array, 0, array.Length - 1));
        }
    }
}