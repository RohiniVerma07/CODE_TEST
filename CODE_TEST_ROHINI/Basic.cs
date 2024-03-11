namespace CODE_TEST_ROHINI;

public class Basic
{
    public List<int> PatternMatch(string text, string patter)
    {
        var list = new List<int>();
        for (var i = 0; i < text.Length; i++)
        {
            var word = MySubStringMethod(i, patter.Length + i, text);
            if (word.ToLower() == patter.ToLower()) list.Add(i);
            // Console.WriteLine(word);
        }

        return list;
    }

    public string MySubStringMethod(int startIndex, int endIndex, string text)
    {
        var word = "";
        for (var i = startIndex; i < endIndex; i++)
            if (i < text.Length)
                word = word + text[i];

        return word;
    }
}