using CSharpFunctionalExtensions;

namespace KebabProjectV3.Domain.Models;

public class Image
{
    public Image(string fileName, string path)
    {
        FileName = fileName;
        Path = path;
    }

    public Guid ProductId { get; }
    public string FileName { get; } = string.Empty;
    public string Path { get; } = string.Empty;

    public static Result<Image> Create(string fileName, string path)
    {
        if (string.IsNullOrWhiteSpace(fileName)) return Result.Failure<Image>($"'{nameof(fileName)}' can't be null or empty");

        if (string.IsNullOrWhiteSpace(path)) return Result.Failure<Image>($"'{nameof(path)}' can't be null or empty");

        return Result.Success(new Image(fileName, path));
    }
}