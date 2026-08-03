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
        return input
            .Split(' ', StringSplitOptions.RemoveEmptyEntries)
            .Select(int.Parse)
            .ToArray();
    }

    private static IReadOnlyList<int> FindLongestIncreasingSubsequence(int[] numbers)
    {
        int n = numbers.Length;

        if (n == 0)
        {
            return Array.Empty<int>();
        }

        int[] dp = new int[n];
        int[] previous = new int[n];

        Array.Fill(dp, 1);
        Array.Fill(previous, -1);

        int bestIndex = 0;


        for (int i = 0; i < n; i++)
        {
            for (int j = 0; j < i; j++)
            {
                if (numbers[j] < numbers[i] && dp[j] + 1 > dp[i])
                {
                    dp[i] = dp[j] + 1;
                    previous[i] = j;
                }
            }

            // keep first occurrence when same length exists
            if (dp[i] > dp[bestIndex])
            {
                bestIndex = i;
            }
        }
        return BuildSequence(numbers, previous, bestIndex);
    }

    private static IReadOnlyList<int> BuildSequence(int[] numbers, int[] previous, int lastIndex)
    {
        List<int> sequence = new();

        while (lastIndex != -1)
        {
            sequence.Add(numbers[lastIndex]);
            lastIndex = previous[lastIndex];
        }

        sequence.Reverse();

        return sequence;
    }

}