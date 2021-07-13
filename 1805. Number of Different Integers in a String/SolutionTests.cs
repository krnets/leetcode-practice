using Xunit;

public class SolutionTests
{
    [Fact]
    public void ExampleTest1()
    {
        var word = "a123bc34d8ef34";
        var expected = 3;
        Assert.Equal(expected, new Solution().NumDifferentIntegers(word));
    }

    [Fact]
    public void ExampleTest2()
    {
        var word = "leet1234code234";
        var expected = 2;
        Assert.Equal(expected, new Solution().NumDifferentIntegers(word));
    }

    [Fact]
    public void ExampleTest3()
    {
        var word = "a1b01c001";
        var expected = 1;
        Assert.Equal(expected, new Solution().NumDifferentIntegers(word));
    }

    [Fact]
    public void ExampleTest4()
    {
        var word = "167278959591294";
        var expected = 1;
        Assert.Equal(expected, new Solution().NumDifferentIntegers(word));
    }

    [Fact]
    public void ExampleTest5()
    {
        var word =
            "2393706880236110407059624696967828762752651982730115221690437821508229419410771541532394006597463715513741725852432559057224478815116557380260390432211227579663571046845842281704281749571110076974264971989893607137140456254346955633455446057823738757323149856858154529105301197388177242583658641529908583934918768953462557716z97438020429952944646288084173334701047574188936201324845149110176716130267041674438237608038734431519439828191344238609567530399189316846359766256507371240530620697102864238792350289978450509162697068948604722646739174590530336510475061521094503850598453536706982695212493902968251702853203929616930291257062173c79487281900662343830648295410";
        var expected = 3;
        Assert.Equal(expected, new Solution().NumDifferentIntegers(word));
    }
}