namespace Discord.Video.Trimmer.Services.Interfaces;

public interface IAlertService
{
    Task<string> ShowAlertAsync(string title, string[] buttonOptions);
}
