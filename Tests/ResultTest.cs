using System.Collections.Generic;
using Xunit;
using Src;

namespace Tests;

public class ResultTest
{
    [Fact]
    public void Test1()
    {
        var a = new List<int> { 1, 1, 2, 2, 4, 4, 5, 5, 5 };

        int expected = 5;
        int actual = Result.pickingNumbers(a);

        Assert.Equal(expected, actual);
    }

    [Fact]
    public void Test2()
    {
        var a = new List<int> { 1, 2, 2, 3, 1, 2 };

        int expected = 5;
        int actual = Result.pickingNumbers(a);

        Assert.Equal(expected, actual);
    }

    [Fact]
    public void Test3()
    {
        var a = new List<int> { 4, 6, 5, 3, 3, 1 };

        int expected = 3;
        int actual = Result.pickingNumbers(a);

        Assert.Equal(expected, actual);
    }

    [Fact]
    public void Test4()
    {
        var a = new List<int> { 4, 6, 5, 3, 3, 1 };

        int expected = 22;
        int actual = Result.pickingNumbers(a);

        Assert.Equal(expected, actual);
    }
}