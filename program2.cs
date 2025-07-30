public class Problem2
{
    public static void MoveZeroes(int[] nums)
    {
        int pos = 0;
        for (int i = 0; i < nums.Length; i++)
        {
            if (nums[i] != 0)
            {
                nums[pos] = nums[i];
                pos++;
            }
        }
        for (int i = pos; i < nums.Length; i++)
        {
            nums[i] = 0;
        }
    }
}
