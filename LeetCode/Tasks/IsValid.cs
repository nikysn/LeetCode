namespace Tasks;

public class IsValid
 {
     private Dictionary<char, char> map = new Dictionary<char, char>()
     {
                {')', '('},
                {'}', '{'},
                {']', '['},
    };

    public bool IsValidd(string s) 
    {
        if(string.IsNullOrEmpty(s) || s.Length % 2 != 0)
        {
            return false;
        }
        
        Stack<char> stack = new Stack<char>();
        
        for (int i = 0; i < s.Length; i++)
        {
            char c = s[i];
            if(map.ContainsKey(c))
            {
                char top = stack.Count == 0 ? '#' : stack.Pop();
                if(top != this.map[c])
                {
                    return false;
                } 
            } 
            else 
            {
                stack.Push(c);
            }
        }
        return stack.Count == 0;
    }
}