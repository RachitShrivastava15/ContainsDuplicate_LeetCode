namespace ContainsDuplicate
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] nums = {1,2,3,1};
            bool result = ContainsDuplicate(nums);
            Console.WriteLine(result);
        }

        public static bool ContainsDuplicate(int[] nums)
        {
            HashSet<int> hashValues = new HashSet<int>();

            for(int index = 0; index < nums.Length; index ++)
            {
                if (!hashValues.Add(nums[index]))
                return true;
            }
            return false;
        }
    }
}