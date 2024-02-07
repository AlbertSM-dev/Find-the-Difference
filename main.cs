public class Solution {
    public char FindTheDifference(string s, string t) {
        var letter = s.ToList();

        for(int i = 0; i < t.Length; i++)
        {
            if(!letter.Remove(t[i]))
            {
                return t[i];
            }
        }
        return letter[0];
    }
}
