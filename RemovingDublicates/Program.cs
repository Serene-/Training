using System.Collections.Immutable;

namespace RemovingDublicates
{
    /*
      Given an integer array nums sorted in non-decreasing order, 
      remove the duplicates in-place such that each unique element appears only once. 
      The relative order of the elements should be kept the same. 
      Then return the number of unique elements in nums.
      Consider the number of unique elements of nums to be k, to get accepted,
      you need to do the following things:
      Change the array nums such that the first k elements of nums contain the
      unique elements in the order they were present in nums initially. 
      The remaining elements of nums are not important as well as the size of nums.
        Return k.
     */
    public class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter an array of integers seperated by space");
            string input=Console.ReadLine();    
            int[] array = input.Split(' ').Select(int.Parse).ToArray();
            Array.Sort(array);
            HashSet<int> set = new HashSet<int>();
            foreach (int i in array)
            {
                set.Add(i);
            }
            Console.WriteLine(String.Join(' ',set));
            Console.WriteLine("Unique elements are {0}",set.Count);
        }
    }
}
