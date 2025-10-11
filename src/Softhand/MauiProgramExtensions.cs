#if __ANDROID__
using Android.Hardware.Camera2;
using Java.Lang;
using Microsoft.Maui.LifecycleEvents;
#endif
using CommunityToolkit.Maui;
using Mopups.Hosting;
using UraniumUI;
namespace Softhand;

public static class MauiProgramExtensions
{
    public static MauiAppBuilder ConfigureUI(this MauiAppBuilder builder)
    {
        builder 
            .UseUraniumUI()
            .UseUraniumUIMaterial()
            .ConfigureMopups()
            .ConfigureFonts(fonts =>
            {
                fonts.AddMaterialSymbolsFonts();
                fonts.AddFontAwesomeIconFonts();
            });
        return builder;
    }
    public static MauiAppBuilder AddLogging(this MauiAppBuilder builder)
    {
#if DEBUG
        builder.Logging.AddDebug();
#endif
        return builder;
    }
    public static MauiAppBuilder AddHandlers(this MauiAppBuilder builder)
    {
        builder.ConfigureMauiHandlers(handlerCollection =>
        {
			handlerCollection.AddHandler<CallView, CallPageHandler>();
        });
        return builder;
    }
    public static MauiAppBuilder AddViewsAndViewModels(this MauiAppBuilder builder)
    {
        builder.Services.AddSingletonWithShellRoute<AVConfigPage, AVConfigPageViewModel>(Routes.AvConfigPage);
        builder.Services.AddSingletonWithShellRoute<AccountConfigPage, AccountConfigPageViewModel>(Routes.AccountConfigPage);
        builder.Services.AddSingletonWithShellRoute<BuddyPage, BuddyPageViewModel>(Routes.BuddyPage);
        builder.Services.AddSingletonWithShellRoute<BuddyConfigPage, BuddyConfigPageViewModel>(Routes.BuddyConfigPage);
        builder.Services.AddTransientWithShellRoute<CallPage, CallPageViewModel>(Routes.CallPage);
        return builder;
    }
     
    public static MauiAppBuilder AddServices(this MauiAppBuilder builder)
    {
        builder.Services.AddSingleton(typeof(INavigationContextService<>), typeof(NavigationContextService<>));
        builder.Services.AddSingleton<ISoftApp, SoftApp>();
        return builder;
    }

    public static MauiAppBuilder AddSentry(this MauiAppBuilder builder)
    {
        builder.UseSentry(options =>
        {
            options.Dsn = "";

            options.Experimental.EnableLogs = true;
     
            // Use debug mode if you want to see what the SDK is doing.
            // Debug messages are written to stdout with Console.Writeline,
            // and are viewable in your IDE's debug console or with 'adb logcat', etc.
            // This option is not recommended when deploying your application.
            options.Debug = true;
            options.AttachScreenshot = true;
            options.SampleRate = 1.0F;
            options.TracesSampleRate = 1.0F; // Capture 70% of transactions for performance monitoring.
                                             // We recommend adjusting this value in production.
                                             // Other Sentry options can be set here.

#if DEV
            options.Environment = "development";
#endif
#if PROD
            options.Environment = "production";
#endif
            options.CacheDirectoryPath = FileSystem.CacheDirectory;
            options.MaxCacheItems = 100;
            options.Release = AppInfo.VersionString;
            options.DiagnosticLevel = SentryLevel.Debug;
        });
        return builder;
    }

    public static MauiApp CreateMauiApp(this MauiAppBuilder builder) => builder
        .UseMauiApp<App>()
        .ConfigureUI()
        .UseMauiCommunityToolkit()
        .AddLogging()
        .AddServices()
        .AddHandlers()
        .AddSentry()
        .AddViewsAndViewModels()
        .Build();

}
 