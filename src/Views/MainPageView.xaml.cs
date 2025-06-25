using Discord.Video.Trimmer.ViewModels;

namespace Discord.Video.Trimmer.Views;

public partial class MainPageView : ContentPage
{
    public MainPageView(MainViewModel mainViewModel)
    {
        InitializeComponent();
        BindingContext = mainViewModel;
    }
}
