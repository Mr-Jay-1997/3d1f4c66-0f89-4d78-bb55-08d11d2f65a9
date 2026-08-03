namespace LIS.Application.Tests.TestData;

public static class TestDataReader
{
    public static string ReadInput(string fileName)
    {
        string path = Path.Combine(AppContext.BaseDirectory, "TestData", fileName);
        if (!File.Exists(path))
            throw new FileNotFoundException($"File not found: {path}");
        return File.ReadAllText(path);
    }
}