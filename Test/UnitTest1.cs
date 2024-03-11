using CODE_TEST_ROHINI;

namespace Test;

public class Tests
{
    [SetUp]
    public void Setup()
    {
    }

    [Test]
    public void Test1()
    {
        var kmp_obj = new KmpAlgorithm();
        var text =
            "Polly put the kettle on, polly put the kettle on, polly put the kettle on we'll all have tea";
        var pattern = "Polly";
        var matchPositions = kmp_obj.KMPSearch(text, pattern);

        Assert.AreEqual(3, matchPositions.Count, "should be 3");
        Assert.AreEqual(new List<int>(3) { 0, 25, 50 }, matchPositions, "start index should be 0,25,50");

        pattern = "Ll";
        matchPositions = kmp_obj.KMPSearch(text, pattern);

        Assert.AreEqual(5, matchPositions.Count, "should be 5");
        Assert.AreEqual(new List<int>(5) { 2, 27, 52, 77, 81 }, matchPositions, "start index should be 2,27,52,77,81");

        // Basic Algorithm
        var basic = new Basic();
        pattern = "Polly";
        matchPositions = basic.PatternMatch(text, pattern);

        Assert.AreEqual(3, matchPositions.Count, "should be 3");
        Assert.AreEqual(new List<int>(3) { 0, 25, 50 }, matchPositions, "start index should be 0,25,50");

        pattern = "Ll";
        matchPositions = basic.PatternMatch(text, pattern);

        Assert.AreEqual(5, matchPositions.Count, "should be 5");
        Assert.AreEqual(new List<int>(5) { 2, 27, 52, 77, 81 }, matchPositions, "start index should be 2,27,52,77,81");
    }
}