using System.Collections.Generic;

public class FirstNonRepeatedCharacter
{
    public static int Find(string text)
    {
        Dictionary<char, int> frequency =
            new Dictionary<char, int>();

        foreach (char c in text)
        {
            if (frequency.ContainsKey(c))
            {
                frequency[c]++;
            }
            else
            {
                frequency[c] = 1;
            }
        }

        for (int i = 0; i < text.Length; i++)
        {
            if (frequency[text[i]] == 1)
            {
                return i;
            }
        }

        return -1;
    }
}