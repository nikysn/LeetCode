namespace Tasks;

public class PlusOne 
{
    public int[] PlusOnee(int[] digits) 
    {
        int a = digits.Length - 1;
            int b = 0;
            for (int i = a; i >= 0; i--)
            {
                if(digits[i] == 9)
                {
                    b++;
                }
                if (b == digits.Length )
                {
                    int[] result = new int[digits.Length + 1];
                    result[0] = 1;
                    return result;
                }
            }

            for (int i = a; i >= 0; i--)
            {
                if (digits[i] != 9)
                {
                    int[] result = new int[digits.Length];
                    result[i] = digits[i] + 1;

                    for (int j = 0; j < i; j++)
                    { 
                        result[j] = digits[j];
                    }
                    return result;
                }
            }
            return digits;
    }
}