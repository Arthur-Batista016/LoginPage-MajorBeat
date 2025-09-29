using Microsoft.Extensions.Logging;
using Microsoft.Maui.Handlers;
using Microsoft.Maui.Platform;

namespace LoginPage
{
    public static class MauiProgram
    {
        public static MauiApp CreateMauiApp()
        {
            var builder = MauiApp.CreateBuilder();
#if ANDROID
            EntryHandler.Mapper.AppendToMapping("NoBorder", (handler, view) =>
            {
                handler.PlatformView.Background = null; // remove fundo padrão
            });
#endif


#if ANDROID
            EntryHandler.Mapper.AppendToMapping("PlaceholderColor", (handler, view) =>
            {
                if (view is Entry entry && handler.PlatformView != null)
                {
                    // pega a cor do MAUI (vinda do ViewModel) e converte pro Android
                    var mauiColor = entry.PlaceholderColor;
                    if (mauiColor != null)
                    {
                        handler.PlatformView.SetHintTextColor(mauiColor.ToPlatform());
                    }
                }
            });
#endif

#if ANDROID
            EntryHandler.Mapper.AppendToMapping("CustomEntry", (handler, view) =>
            {
                if (handler.PlatformView != null)
                {
                    // Placeholder color
                    var mauiColor = view.PlaceholderColor;
                    if (mauiColor != null)
                        handler.PlatformView.SetHintTextColor(mauiColor.ToPlatform());

                    // Remove a underline cinza
                    handler.PlatformView.BackgroundTintList = Android.Content.Res.ColorStateList.ValueOf(Android.Graphics.Color.Transparent);

                    // Se quiser definir a cor da barrinha manualmente:
                    // handler.PlatformView.BackgroundTintList = Android.Content.Res.ColorStateList.ValueOf(Android.Graphics.Color.White);
                }
            });
#endif





            builder
                .UseMauiApp<App>()
                .ConfigureFonts(fonts =>
                {
                    fonts.AddFont("OpenSans-Regular.ttf", "OpenSansRegular");
                    fonts.AddFont("OpenSans-Semibold.ttf", "OpenSansSemibold");
                });

#if DEBUG
    		builder.Logging.AddDebug();
#endif

            return builder.Build();
        }
    }
}
