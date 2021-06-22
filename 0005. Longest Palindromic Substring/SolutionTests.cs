using System.Linq;
using Xunit;

public class SolutionTests
{
    [Fact]
    public void ExampleTest1()
    {
        var s = "babad";
        string[] expected = {"aba", "bab"};
        var actual = new Solution().LongestPalindrome(s);
        Assert.True(expected.Any(x => actual != null && actual.Contains(x)));
    }

    [Fact]
    public void ExampleTest2()
    {
        var s = "cbbd";
        var expected = "bb";
        Assert.Equal(expected, new Solution().LongestPalindrome(s));
    }

    [Fact]
    public void ExampleTest3()
    {
        var s = "a";
        var expected = "a";
        Assert.Equal(expected, new Solution().LongestPalindrome(s));
    }

    [Fact]
    public void ExampleTest4()
    {
        var s = "ac";
        string[] expected = {"a", "c"};
        var actual = new Solution().LongestPalindrome(s);
        Assert.True(expected.Any(x => actual != null && actual.Contains(x)));
    }

    [Fact]
    public void ExampleTest5()
    {
        var s = "bb";
        var expected = "bb";
        Assert.Equal(expected, new Solution().LongestPalindrome(s));
    }

    [Fact]
    public void ExampleTest6()
    {
        var s =
            "azwdzwmwcqzgcobeeiphemqbjtxzwkhiqpbrprocbppbxrnsxnwgikiaqutwpftbiinlnpyqstkiqzbggcsdzzjbrkfmhgtnbujzszxsycmvipjtktpebaafycngqasbbhxaeawwmkjcziybxowkaibqnndcjbsoehtamhspnidjylyisiaewmypfyiqtwlmejkpzlieolfdjnxntonnzfgcqlcfpoxcwqctalwrgwhvqvtrpwemxhirpgizjffqgntsmvzldpjfijdncexbwtxnmbnoykxshkqbounzrewkpqjxocvaufnhunsmsazgibxedtopnccriwcfzeomsrrangufkjfzipkmwfbmkarnyyrgdsooosgqlkzvorrrsaveuoxjeajvbdpgxlcrtqomliphnlehgrzgwujogxteyulphhuhwyoyvcxqatfkboahfqhjgujcaapoyqtsdqfwnijlkknuralezqmcryvkankszmzpgqutojoyzsnyfwsyeqqzrlhzbc";
        var expected = "sooos";
        Assert.Equal(expected, new Solution().LongestPalindrome(s));
    }

    [Fact]
    public void ExampleTest7()
    {
        var s =
            "zudfweormatjycujjirzjpyrmaxurectxrtqedmmgergwdvjmjtstdhcihacqnothgttgqfywcpgnuvwglvfiuxteopoyizgehkwuvvkqxbnufkcbodlhdmbqyghkojrgokpwdhtdrwmvdegwycecrgjvuexlguayzcammupgeskrvpthrmwqaqsdcgycdupykppiyhwzwcplivjnnvwhqkkxildtyjltklcokcrgqnnwzzeuqioyahqpuskkpbxhvzvqyhlegmoviogzwuiqahiouhnecjwysmtarjjdjqdrkljawzasriouuiqkcwwqsxifbndjmyprdozhwaoibpqrthpcjphgsfbeqrqqoqiqqdicvybzxhklehzzapbvcyleljawowluqgxxwlrymzojshlwkmzwpixgfjljkmwdtjeabgyrpbqyyykmoaqdambpkyyvukalbrzoyoufjqeftniddsfqnilxlplselqatdgjziphvrbokofvuerpsvqmzakbyzxtxvyanvjpfyvyiivqusfrsufjanmfibgrkwtiuoykiavpbqeyfsuteuxxjiyxvlvgmehycdvxdorpepmsinvmyzeqeiikajopqedyopirmhymozernxzaueljjrhcsofwyddkpnvcvzixdjknikyhzmstvbducjcoyoeoaqruuewclzqqqxzpgykrkygxnmlsrjudoaejxkipkgmcoqtxhelvsizgdwdyjwuumazxfstoaxeqqxoqezakdqjwpkrbldpcbbxexquqrznavcrprnydufsidakvrpuzgfisdxreldbqfizngtrilnbqboxwmwienlkmmiuifrvytukcqcpeqdwwucymgvyrektsnfijdcdoawbcwkkjkqwzffnuqituihjaklvthulmcjrhqcyzvekzqlxgddjoir";
        var expected = "gykrkyg";
        Assert.Equal(expected, new Solution().LongestPalindrome(s));
    }
}