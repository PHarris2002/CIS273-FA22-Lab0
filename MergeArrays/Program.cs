using System.ComponentModel;

namespace MergeArrays
{

    public class Program
    {
        public static void Main(string[] args)
        {
            
        }

        public static int[] MergeSortedArrays(int[] array1, int[] array2)
        {
            //creates an empty list for adding numbers from arrays and for later flexible modification
            List<int> combinedArrayList = new List<int>();

            //adds all numbers from both arrays to the combinedArrayList
            foreach (int number in array1)
            {
                combinedArrayList.Add(number);
            }

            foreach (int number in array2)
            {
                combinedArrayList.Add(number);
            }

            //sorts all numbers in the now occupied combinedArrayList
            combinedArrayList.Sort();

            //converts the list into an array
            int[] combinedArray = combinedArrayList.ToArray();

            return combinedArray;
        }
    }

}