using System.Collections.Generic;
using System.Linq;
using Xunit;

public class SolutionTests
{
    [Fact]
    public void ExampleTest1()
    {
        var s1 = "this apple is sweet";
        var s2 = "this apple is sour";
        var expected = new HashSet<string> {"sweet", "sour"};
        var actual = new Solution().UncommonFromSentences(s1, s2).ToHashSet();
        Assert.True(expected.All(x => actual.Contains(x)));
    }

    [Fact]
    public void ExampleTest2()
    {
        var s1 = "apple apple";
        var s2 = "banana";
        var expected = new HashSet<string> {"banana"};
        var actual = new Solution().UncommonFromSentences(s1, s2).ToHashSet();
        Assert.True(expected.All(x => actual.Contains(x)));
    }
}