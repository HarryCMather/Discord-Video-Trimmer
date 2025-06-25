using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;

namespace Discord.Video.Trimmer.ViewModels;

public partial class MainViewModel : ObservableObject
{
    // TODO: I need to replace this with an actual implementation,
    // just trying to keep the PR small enough for now, hence placeholders:
    [ObservableProperty]
    private string sampleText = "Hello World!";

    [ObservableProperty]
    private string progressText = string.Empty;
    
    [RelayCommand]
    private void UpdateProgress()
    {
        SampleText = "Hello World!";
        ProgressText = "Updating...";
    }
}
