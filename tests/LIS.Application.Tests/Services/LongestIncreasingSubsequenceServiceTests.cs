using FluentAssertions;
using LIS.Application.Services;
using LIS.Application.Tests.TestData;
using Xunit;

namespace LIS.Tests.Services;

public class LongestIncreasingSubsequenceServiceTests
{
    private readonly LongestIncreasingSubsequenceService _service;

    public LongestIncreasingSubsequenceServiceTests()
    {
        _service = new LongestIncreasingSubsequenceService();
    }

    [Fact]
    public void Find_Should_Return_LongestIncreasingSubsequence_For_TestCase1()
    {
        string input = "6 1 5 9 2";
        var result = _service.Find(input);
        result.Should().Equal(new[] { 1, 5, 9 });
    }

    [Fact]
    public void Find_Should_Return_LongestIncreasingSubsequence_For_TestCase2()
    {
        string input = TestDataReader.ReadInput("TestCase2_Input.txt");
        int[] expected = { 1710, 2461, 9288, 10195, 10431, 12485 };
        var result = _service.Find(input);
        result.Should().Equal(expected);
    }

    [Fact]
    public void Find_Should_Return_LongestIncreasingSubsequence_For_TestCase3()
    {
        string input = TestDataReader.ReadInput("TestCase3_Input.txt");
        int[] expected = { 10298, 10897, 12291, 15037, 18446, 23435, 25333, 27266 };
        var result = _service.Find(input);
        result.Should().Equal(expected);
    }

    [Fact]
    public void Find_Should_Return_LongestIncreasingSubsequence_For_TestCase4()
    {
        string input = TestDataReader.ReadInput("TestCase4_Input.txt");
        int[] expected = { 3862, 16353, 22813, 28735 };
        var result = _service.Find(input);
        result.Should().Equal(expected);
    }

    [Fact]
    public void Find_Should_Return_LongestIncreasingSubsequence_For_TestCase5()
    {
        string input = TestDataReader.ReadInput("TestCase5_Input.txt");
        int[] expected = { 11084, 11970, 24975, 30922 };
        var result = _service.Find(input);
        result.Should().Equal(expected);
    }

    [Fact]
    public void Find_Should_Return_LongestIncreasingSubsequence_For_TestCase6()
    {
        string input = TestDataReader.ReadInput("TestCase6_Input.txt");
        int[] expected = { 3808, 3908, 10386, 19306 };
        var result = _service.Find(input);
        result.Should().Equal(expected);
    }

    [Fact]
    public void Find_Should_Return_LongestIncreasingSubsequence_For_TestCase7()
    {
        string input = TestDataReader.ReadInput("TestCase7_Input.txt");
        int[] expected = { 125, 1841, 5882, 18464, 28317, 31497 };
        var result = _service.Find(input);
        result.Should().Equal(expected);
    }

    [Fact]
    public void Find_Should_Return_LongestIncreasingSubsequence_For_TestCase8()
    {
        string input = TestDataReader.ReadInput("TestCase8_Input.txt");
        int[] expected = { 9139, 17687, 25106, 26202, 27592, 30937 };
        var result = _service.Find(input);
        result.Should().Equal(expected);
    }

    [Fact]
    public void Find_Should_Return_LongestIncreasingSubsequence_For_TestCase9()
    {
        string input = TestDataReader.ReadInput("TestCase9_Input.txt");
        int[] expected = { 918, 1089, 5133, 7725, 18035, 24605, 26716, 27095 };
        var result = _service.Find(input);
        result.Should().Equal(expected);
    }

    [Fact]
    public void Find_Should_Return_LongestIncreasingSubsequence_For_TestCase10()
    {
        string input = "6 2 4 6 1 5 9";
        int[] expected = { 2, 4, 6 };
        var result = _service.Find(input);
        result.Should().Equal(expected);
    }

    [Fact]
    public void Find_Should_Return_LongestIncreasingSubsequence_For_TestCase11()
    {
        string input = "6 2 4 3 1 5 9";
        int[] expected = { 1, 5, 9 };
        var result = _service.Find(input);
        result.Should().Equal(expected);
    }
}