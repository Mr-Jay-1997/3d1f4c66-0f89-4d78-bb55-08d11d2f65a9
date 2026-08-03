namespace LIS.Application.Validators;

public static class InputValidator
{
    public static void Validate(string input)
    {
        if (string.IsNullOrWhiteSpace(input))
        {
            throw new ArgumentException("Input cannot be null, empty, or whitespace.", nameof(input));
        }

        if (input.Contains("  "))
        {
            throw new ArgumentException("Input must contain only single spaces between integers.", nameof(input));
        }

        string[] tokens = input.Split(' ');

        foreach (string token in tokens)
        {
            if (!int.TryParse(token, out _))
            {
                throw new ArgumentException($"'{token}' is not a valid integer.", nameof(input));
            }
        }
    }
}