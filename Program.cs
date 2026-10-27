namespace QuickSort
{
    internal class Program
    {
        static void QuickSort(int[] A, int left, int right)
        {
            if (left < right)
            {
                int p = Partition(A, left, right);

                QuickSort(A, left, p - 1);
                QuickSort(A, p + 1, right);
            }
        }

        static int Partition(int[] A, int left, int right)
        {
            int pivot = A[left];
            int i = left + 1;
            int j = right;

            while (i <= j)
            {
                while (i <= right && A[i] <= pivot)                
                    i++;                

                while (j > left && A[j] > pivot)                
                    j--;                

                if (i < j)
                {
                    // Swap A[i] and A[j]
                    int temp = A[i];
                    A[i] = A[j];
                    A[j] = temp;
                }
            }

            // Place the pivot in its correct position
            int tempPivot = A[left];
            A[left] = A[j];
            A[j] = tempPivot;

            return j;
        }

        static void Main()
        {
            int[] A = { 38, 12, 27, 43, 9, 31, 18, 25 };

            Console.WriteLine("Original array:");
            Console.WriteLine(string.Join(", ", A));

            QuickSort(A, 0, A.Length - 1);

            Console.WriteLine("Sorted array:");
            Console.WriteLine(string.Join(", ", A));
        }
    }
}
