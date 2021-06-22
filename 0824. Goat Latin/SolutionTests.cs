using Xunit;

public class SolutionTests
{
    [Fact]
    public void ExampleTest1()
    {
        var sentence = "I speak Goat Latin";
        var expected = "Imaa peaksmaaa oatGmaaaa atinLmaaaaa";
        Assert.Equal(expected, new Solution().ToGoatLatin(sentence));
    }

    [Fact]
    public void ExampleTest2()
    {
        var sentence = "The quick brown fox jumped over the lazy dog";
        var expected =
            "heTmaa uickqmaaa rownbmaaaa oxfmaaaaa umpedjmaaaaaa overmaaaaaaa hetmaaaaaaaa azylmaaaaaaaaa ogdmaaaaaaaaaa";
        Assert.Equal(expected, new Solution().ToGoatLatin(sentence));
    }
}