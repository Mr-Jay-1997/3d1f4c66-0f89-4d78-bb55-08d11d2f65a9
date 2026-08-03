using LIS.Application.Interfaces;
using LIS.Application.Validators;

namespace LIS.Application.Services;

public sealed class LongestIncreasingSubsequenceService : ILongestIncreasingSubsequenceService
{
    public IReadOnlyList<int> Find(string input)
    {
        InputValidator.Validate(input);

        int[] numbers = ParseInput(input);

        return FindLongestIncreasingSubsequence(numbers);
    }

    private static int[] ParseInput(string input)
    {
        return input.Split(' ').Select(int.Parse).ToArray();
    }

    private static IReadOnlyList<int> FindLongestIncreasingSubsequence(int[] numbers)
    {
        throw new NotImplementedException();
    }
}