using System.Collections.Concurrent;

namespace PartitionArray
{
//    Given an integer array nums, return true if you can partition the array
//    into two subsets such that the sum of the elements in both subsets
//    is equal or false otherwise.
//Example 1:
//Input: nums = [1, 5, 11, 5]
//Output: true
//Explanation: The array can be partitioned as [1, 5, 5] and[11].
    public class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter an integer array, all elements on one line separated by comma :");
            int[] array = Console.ReadLine().Split(',').Select(x => int.Parse(x)).ToArray();
            Console.WriteLine(CanPartition(array));
        }
        public static bool CanPartition(int[] array)
        {
            int sum = array.Sum();
            int targetSum = 0;
            bool result=false;
            if (sum % 2 == 0)
            {
                int averageSum = sum / 2;
                for (int i = 0;i<array.Length;i++)
                {
                    if(averageSum> targetSum) targetSum += array[i];
                    for(int j=0;j<array.Length;j++)
                    {
                        if (averageSum> targetSum && i!=j) targetSum += array[j];
                    }
                    if(averageSum== targetSum)
                    {
                        result = true;
                        //Console.WriteLine(targetSum);
                        break;
                    }
                    targetSum = 0;
                }
            }
            else return false;
            return result;
        }
    }
}
