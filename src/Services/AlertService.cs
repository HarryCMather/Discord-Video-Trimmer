using Discord.Video.Trimmer.Services.Interfaces;

namespace Discord.Video.Trimmer.Services;

public sealed class AlertService : IAlertService
{
    public async Task<string> ShowAlertAsync(string title, string[] buttonOptions)
    {
        // Using the first Window's Page here as this is a single-page application.
        // If I convert this to a multi-page application in the future, this will need to change.
        string selectedOption = await Application.Current!.Windows[0].Page!.DisplayActionSheet(title, null, null, buttonOptions);
        return selectedOption;
    }
}
