using Sttopnews.NavBar;
using Sttopnews.View;
using Sttopnews.View.UsuarioLeitor;

namespace Sttopnews;

public partial class App : Application
{
	public App()
	{
		InitializeComponent();

		MainPage = new NavigationPage(new StartupPage());
        Microsoft.Maui.Handlers.EntryHandler.Mapper.AppendToMapping("BorderLessEntry", (handler, view) =>
        {
#if ANDROID
            handler.PlatformView.Background = null;
            handler.PlatformView.SetBackgroundColor(Android.Graphics.Color.Transparent);
#elif WINDOWS
            handler.PlatformView.Background = null;
         
#elif IOS
            handler.PlatformView.BackgroundColor = UIKit.UIColor.Clear;
            handler.PlatformView.Layer.BorderWidth = 0;
            handler.PlatformView.BorderStyle = UIKit.UITextBorderStyle.None;
#endif
        });

    }

}
