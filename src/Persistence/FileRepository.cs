using Discord.Video.Trimmer.Persistence.Interfaces;

namespace Discord.Video.Trimmer.Persistence;

public sealed class FileRepository : IFileRepository
{
    public bool Exists(string filePath)
    {
        return File.Exists(filePath);
    }
}
