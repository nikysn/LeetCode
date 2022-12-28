namespace Tasks;

public class SearchInsert 
{
    public int SearchInsertt(int[] nums, int target) 
    {
        int a = 0;
        int b = 0;
            for (int i = 0; i < nums.Length; i++)
            {
                if (nums[i] != target)
                {
                    a++;
                    continue;
                }
                if(nums[i] == target)
                {
                    return a;
                }
                nums[a] = nums[i];
                a += 1;
            }
             for (int j = 0; j < nums.Length; j++)
             {
                 if(target < nums[j])
                 {
                     return b;
                 }
                 b++;
             }
             return b;
    }
}