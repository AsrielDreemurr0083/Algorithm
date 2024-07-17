namespace Program
{
    internal class Program
    {
        

        static void Main(string[] args)
        {
            #region 이진 탐색
            //탐색 범위를 반으로 나누어 찾는 값을 포함하는 범위를
            //좁혀가는 방식으로 동작하는 탐색 알고리즘           
            int[] sortedArray = { 1, 3, 5, 7, 9, 11, 13, 15, 17, 19 };
            int target = 11;

            int left = 0;
            int right = sortedArray.Length - 1;
            int result = -1;

            while (left <= right)
            {
                int mid = left + (right - left) / 2;

                if (sortedArray[mid] == target)
                {
                    result = mid;
                    break;
                }
                else if (sortedArray[mid] < target)
                {
                    left = mid + 1;
                }
                else
                {
                    right = mid - 1;
                }
            }

            if (result != -1)
            {
                Console.WriteLine(target + " location is " + result);
            }
            else
            {
                Console.WriteLine("target has not found");
            }


                #endregion
            }
    }
}
