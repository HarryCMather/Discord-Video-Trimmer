namespace Discord.Video.Trimmer.Persistence.Interfaces;

/// <summary>
/// Abstraction around File logic, as this cannot be unit tested.
/// </summary>
public interface IFileRepository
{
    /// <summary>
    /// Determines whether the specified file exists.
    /// </summary>
    /// <param name="filePath">The file to check.</param>
    /// <returns>True if the file exists, else false.</returns>
    bool Exists(string filePath);
}
