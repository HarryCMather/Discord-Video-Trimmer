using FFmpeg.NET;

namespace Discord.Video.Trimmer.Persistence.Interfaces;

public interface IFfmpegRepository
{
    Task<MetaData> GetMetadataAsync(string filePath);
}
