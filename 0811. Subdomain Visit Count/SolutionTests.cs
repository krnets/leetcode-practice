using System.Linq;
using NUnit.Framework;

[Parallelizable(scope: ParallelScope.All)]
public class SolutionTests
{
    [Test]
    public void ExampleTest1()
    {
        string[] input = {"9001 discuss.leetcode.com"};
        string[] expected = {"9001 discuss.leetcode.com", "9001 leetcode.com", "9001 com"};
        var actual = new Solution().SubdomainVisits(input);
        
        Assert.IsTrue(expected.All(x => actual.Contains(x)));
        // Assert.IsTrue(expected.OrderBy(x=>x).SequenceEqual(actual.OrderBy(x=>x)));
    }

    [Test]
    public void ExampleTest2()
    {
        string[] input = {"900 google.mail.com", "50 yahoo.com", "1 intel.mail.com", "5 wiki.org"};
        string[] expected =
        {
            "901 mail.com", "50 yahoo.com", "900 google.mail.com", "5 wiki.org", "5 org", "1 intel.mail.com", "951 com"
        };

        var actual = new Solution().SubdomainVisits(input);
        
        Assert.IsTrue(expected.All(x => actual.Contains(x)));
        // Assert.IsTrue(expected.Union(actual).SequenceEqual(expected));
        // Assert.IsTrue(expected.OrderBy(x=>x).SequenceEqual(actual.OrderBy(x=>x)));
    }
}