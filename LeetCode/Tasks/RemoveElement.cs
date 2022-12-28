namespace Tasks;
public class RemoveElement {
    public int RemoveElementt(int[] nums, int val) 
    {
       int a = 0;

            for (int i = 1; i < nums.Length; i++)
            {
                if (nums[i] == val)
                {
                    continue;
                }
                nums[a] = nums[i];
                a += 1;
            }
            return a;
    }
}