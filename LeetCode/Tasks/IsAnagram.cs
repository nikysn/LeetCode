namespace Tasks;

public class IsAnagram 
{
    public bool IsAnagramm(string s, string t) 
    {
            char[] arrayS = s.ToCharArray();
            char[] arrayT = t.ToCharArray();
            int sum = 0;
            if (arrayS.Length == arrayT.Length)
            {
                Array.Sort(arrayS);
                Array.Sort(arrayT);

                for (int i = 0; i < arrayS.Length; i++)
                {
                    if (arrayS[i] == arrayT[i])
                    {
                        sum++;
                    }

                }
                if (sum == arrayS.Length) return true;
            }

            return false;
    }
}