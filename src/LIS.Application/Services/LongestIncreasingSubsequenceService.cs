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
        if (numbers.Length == 0)
        {
            return Array.Empty<int>();
        }

        int bestStart = 0;
        int bestLength = 1;

        int currentStart = 0;
        int currentLength = 1;

        for (int i = 1; i < numbers.Length; i++)
        {
            if (numbers[i] > numbers[i - 1])
            {
                currentLength++;
            }
            else
            {
                if (currentLength > bestLength)
                {
                    bestLength = currentLength;
                    bestStart = currentStart;
                }

                currentStart = i;
                currentLength = 1;
            }
        }

        // Check the last sequence
        if (currentLength > bestLength)
        {
            bestLength = currentLength;
            bestStart = currentStart;
        }

        int[] result = new int[bestLength];

        Array.Copy(numbers, bestStart, result, 0, bestLength);

        return result;
    }

}