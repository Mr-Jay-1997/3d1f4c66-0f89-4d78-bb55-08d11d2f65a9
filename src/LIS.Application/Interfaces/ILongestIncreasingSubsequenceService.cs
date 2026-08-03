namespace LIS.Application.Interfaces;

public interface ILongestIncreasingSubsequenceService
{
    IReadOnlyList<int> Find(string input);
}