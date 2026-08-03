namespace LIS.Application.Exceptions;

public sealed class InvalidInputException : Exception
{
    public InvalidInputException(string message)
        : base(message)
    {
    }
}