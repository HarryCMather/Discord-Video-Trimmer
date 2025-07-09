namespace Discord.Video.Trimmer.Models;

/// <summary>
/// Options related to Compression configuration, which is used for retrieving metadata,
/// trimming and encoding clips.
/// </summary>
public sealed class CompressionOptions
{
    /// <summary>
    /// The section key within appsettings.json that refers to Compression options.
    /// </summary>
    public const string SectionKey = nameof(CompressionOptions);
    
    /// <summary>
    /// The path to Ffmpeg's executable.
    /// Note: This should only be used when Ffmpeg isn't present within the System Path.
    /// </summary>
    public string FfmpegFallbackPath { get; set; }
    
    /// <summary>
    /// A folder to store temporary files,
    /// which need to be cleaned up after encoding has completed.
    /// </summary>
    public string TempPath { get; set; }
    
    /// <summary>
    /// Depending on the file size limit, there likely isn't much headroom for
    /// high-quality audio. If allowed, audio will be compressed to 128kbps to save bandwidth.
    /// </summary>
    public bool AllowLowQualityAudio { get; set; }
    
    /// <summary>
    /// Discord currently limits free users to 10MB.
    /// Although this seldom changes, it has changed before.
    /// Therefore, this should be configurable.
    /// </summary>
    public double MaxFileSizeMb { get; set; }
}
