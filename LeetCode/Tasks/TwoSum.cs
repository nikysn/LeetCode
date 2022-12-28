namespace Tasks;
public class TwoSum 
{
    public int[] TwoSumm(int[] nums, int target) 
    {
        int[] newArray = new int[2];
        for (int i = 0; i < nums.Length ; i++)
        {
            for (int j = 1; j < nums.Length ; j++)
           
            if(i != j && nums[i] + nums[j] == target) 
            {
                newArray[0] = i;
                newArray[1] = j;
                return newArray;
            }
        }
        return newArray;
    }
}
