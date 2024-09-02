namespace JumpGame
{
    /*You are given an integer array nums. 
     * You are initially positioned at the array's first index, 
     * and each element in the array represents your maximum jump length 
     * at that position.
     * Return true if you can reach the last index, or false otherwise.*/
    public class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter an arary seperated by comma:");
            int[] nums = Console.ReadLine().Split(',').Select(int.Parse).ToArray();
            Console.WriteLine($"{CanJump(nums)}");

        }
        public static bool CanJump(int[] nums)
        {
            bool canJump = false;
            int index = 0;
            while(index< nums.Length)
            {
                index = index+nums[index];
                if (index==nums.Length-1)
                {
                    canJump = true;
                    break;
                }
                if (index < 0 || index >= nums.Length || nums[index]==0)
                {
                    break;
                }
            }
            return canJump;
        }
    }
}
