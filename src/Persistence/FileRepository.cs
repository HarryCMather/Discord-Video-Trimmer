using System.Diagnostics.CodeAnalysis;
using Discord.Video.Trimmer.Persistence.Interfaces;

namespace Discord.Video.Trimmer.Persistence;

[ExcludeFromCodeCoverage(Justification = "File IO logic shouldn't be tested at unit testing level.")]
public sealed class FileRepository : IFileRepository
{
    public bool Exists(string filePath)
    {
        return File.Exists(filePath);
    }
}
