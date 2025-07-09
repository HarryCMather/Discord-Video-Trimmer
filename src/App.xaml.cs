namespace Discord.Video.Trimmer;

public partial class App : Application
{
    public App()
    {
        InitializeComponent();
    }

    protected override Window CreateWindow(IActivationState activationState)
    {
        bool isDeviceSupported = IsDevicePlatformSupported();
        Window window = CreateWindow(isDeviceSupported);
        return window;
    }

    private static bool IsDevicePlatformSupported()
    {
        return DeviceInfo.Platform == DevicePlatform.WinUI ||
               DeviceInfo.Platform == DevicePlatform.MacCatalyst;
    }

    private static Window CreateWindow(bool isDeviceSupported)
    {
        Page page = isDeviceSupported ? new AppShell() : new ContentPage();
        Window window = new(page);

        if (!isDeviceSupported)
        {
            page.Loaded += async (_, _) =>
            {
                await page.DisplayAlert(title: "Unsupported Platform", 
                                        message: "This application only supports Windows and MacCatalyst.",
                                        cancel: "Exit");
                
                // Platform-specific ways of exiting the application:
                #if ANDROID
                    Android.OS.Process.KillProcess(Android.OS.Process.MyPid());
                #elif IOS
                    System.Diagnostics.Process.GetCurrentProcess().CloseMainWindow();
                #endif
                
                // Platform-agnostic fallback way of exiting the application:
                Environment.Exit(0);
            };
        }
        
        return window;
    }
}
