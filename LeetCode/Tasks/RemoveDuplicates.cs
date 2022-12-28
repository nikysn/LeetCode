namespace Tasks;
public class RemoveDuplicates 
{
    public int RemoveDuplicatess(int[] nums) 
    {
        int a = 1;
            for (int i = 1; i < nums.Length; i++)
            {
                if (nums[i] != nums[i - 1])
                {
                   nums[a] = nums[i];
                  a += 1;
                }
            }
            return a;
    }
}