using AlmostList.Client;
using Microsoft.Extensions.Logging;
using Newtonsoft.Json;

namespace AlmostList
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
				});
			JsonConvert.DefaultSettings = () => new JsonSerializerSettings
			{
				//Formatting = Formatting.Indented,
				//TypeNameHandling = TypeNameHandling.Objects,
				//ContractResolver = new CamelCasePropertyNamesContractResolver(),
				NullValueHandling = NullValueHandling.Ignore
				//Converters = new JsonConverter[] {new StringEnumConverter()}
			};

			builder.Services.AddMauiBlazorWebView();


			builder.Services.AddSingleton<BaseClient>();
#if DEBUG
            builder.Services.AddBlazorWebViewDeveloperTools();
			builder.Logging.AddDebug();
#endif
			return builder.Build();
        }
	}
}
