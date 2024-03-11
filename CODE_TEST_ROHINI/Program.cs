// See https://aka.ms/new-console-template for more information

using CODE_TEST_ROHINI;

public class Progam
{
    private static void Main(string[] args)
    {
        // using advance solution   
        var text = "Polly put the kettle on, polly put the kettle on, polly put the kettle on we'll all have tea";
        var pattern = "Ll";

        var kmpAlgo = new KmpAlgorithm();
        var matchPositions = kmpAlgo.KMPSearch(text, pattern);
        Console.WriteLine("Pattern found at positions using advance solution:");
        foreach (var position in matchPositions)
            Console.WriteLine($"Start Position:\t\t{position}\t\t{text.Substring(position, pattern.Length)}");

        // Using Basic Solution
        Console.WriteLine("Pattern found at positions using basic solution");
        var bs = new Basic();
        var matches = bs.PatternMatch(text, pattern);
        foreach (var i in matches)
            Console.WriteLine("Start Position:\t\t" + i + "\t\t" + text.Substring(i, pattern.Length));
        Console.ReadKey();
    }
}