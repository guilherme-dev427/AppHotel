using Microsoft.Extensions.Logging;

namespace AppHotel
{
    public static class MauiProgram
    {
        public static MauiApp CreateMauiApp()
        {
            var builder = MauiApp.CreateBuilder();
            builder
                .UseMauiApp<App>()
                .ConfigureFonts(fonts =>
                {
                    fonts.AddFont("OpenSans-Regular.ttf", "OpenSansRegular");
                    fonts.AddFont("OpenSans-Semibold.ttf", "OpenSansSemibold");
                    fonts.AddFont("Poppins-Regular.ttf", "PoppinsRegular");
                    fonts.AddFont("Poppins-Semibold.ttf", "PoppinsSemibold");
                    fonts.AddFont("Poppins-Bold.ttf", "PoppinsBold");
                    fonts.AddFont("Poppins-Black.ttf", "PoppinsBlack");
                    fonts.AddFont("Poppins-BlackItalic.ttf", "PoppinsBlackItalic");
                    fonts.AddFont("Poppins-BoldItalic.ttf", "PoppinsBoldItalic");
                    fonts.AddFont("Poppins-ExtraBold.ttf", "PoppinsExtraBold");
                    fonts.AddFont("Poppins-ExtraBoldItalic.ttf", "PoppinsExtraBoldItalic");
                    fonts.AddFont("Poppins-ExtraLight.ttf", "PoppinsExtraLight");
                    fonts.AddFont("Poppins-ExtraLightItalic.ttf", "PoppinsExtraLightItalic");
                    fonts.AddFont("Poppins-Italic.ttf", "PoppinsItalic");
                    fonts.AddFont("Poppins-Light.ttf", "PoppinsLight");
                    fonts.AddFont("Poppins-LightItalic.ttf", "PoppinsLightItalic");
                    fonts.AddFont("Poppins-Medium.ttf", "PoppinsMedium");
                    fonts.AddFont("Poppins-MediumItalic.ttf", "PoppinsMediumItalic");
                    fonts.AddFont("Poppins-SemiboldItalic.ttf", "PoppinsSemiboldItalic");
                    fonts.AddFont("Poppins-Thin.ttf", "PoppinsThin");
                    fonts.AddFont("Poppins-ThinItalic.ttf", "PoppinsThinItalic");
                });

#if DEBUG
    		builder.Logging.AddDebug();
#endif

            return builder.Build();
        }
    }
}
