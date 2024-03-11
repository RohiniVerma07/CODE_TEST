namespace CODE_TEST_ROHINI;

public class KmpAlgorithm
{
    public static int[] GenerateLpsArray(string pattern)
    {
        var n = pattern.Length;
        var piTable = new int[n];
        piTable[0] = 0;
        var i = 1;
        var j = 0;
        while (i < n)
        {
            if (pattern[i] == pattern[j])
            {
                j += 1;
                piTable[i] = j;
            }
            else
            {
                if (j > 0)
                    while (j != 0)
                    {
                        j = piTable[j - 1];
                        if (pattern[j] == pattern[i])
                        {
                            j = j + 1;
                            piTable[i] = j;
                            break;
                        }

                        if (j == 0) piTable[i] = 0;
                    }
                else
                    piTable[i] = 0;
            }

            i = i + 1;
        }

        return piTable;
    }

    public List<int> KMPSearch(string text, string pattern)
    {
        text = text.ToLower();
        pattern = pattern.ToLower();
        var M = text.Length;
        var N = pattern.Length;
        var results = new List<int>();
        var lps = GenerateLpsArray(pattern);

        var i = 0; // index for text[]
        var j = 0; // index for pattern[]
        while (i < M)
        {
            if (pattern[j] == text[i])
            {
                j++;
                i++;
            }

            if (j == N)
            {
                results.Add(i - j);
                j = lps[j - 1];
            }

            // mismatch after j matches
            else if (i < M && pattern[j] != text[i])
            {
                if (j != 0)
                    j = lps[j - 1];
                else
                    i = i + 1;
            }
        }

        return results;
    }
}