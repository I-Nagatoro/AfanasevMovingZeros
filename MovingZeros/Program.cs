namespace MovingZeros
{
    class Program
    {
        static void MoveZeroes(int[] nums)
        {
            int notZero= 0;
            for (int i = 0; i < nums.Length; i++)
            {
                if (nums[i] != 0)
                {
                    nums[notZero] = nums[i];
                    notZero++;
                }
            }
            for (int i = notZero; i < nums.Length; i++)
            {
                nums[i] = 0;
            }
        }
        static void Main(string[] args)
        {
            int[] nums = { 0, 1, 0, 3, 12 };
            MoveZeroes(nums);
            foreach (int i in nums)
            {
                Console.Write(i + " ");
            }
        }
    }
}
