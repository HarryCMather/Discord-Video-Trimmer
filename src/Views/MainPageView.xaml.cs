using Discord.Video.Trimmer.ViewModels;

namespace Discord.Video.Trimmer;

public partial class MainPageView : ContentPage
{
    public MainPageView(MainViewModel mainViewModel)
    {
        InitializeComponent();
        BindingContext = mainViewModel;
    }
}
