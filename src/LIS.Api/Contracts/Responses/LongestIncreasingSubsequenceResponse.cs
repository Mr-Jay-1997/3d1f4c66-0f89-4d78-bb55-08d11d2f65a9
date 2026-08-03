namespace LIS.API.Contracts.Responses;

public sealed class LongestIncreasingSubsequenceResponse
{
    public IReadOnlyList<int> Sequence { get; set; } = Array.Empty<int>();

    public int Length => Sequence.Count;
}