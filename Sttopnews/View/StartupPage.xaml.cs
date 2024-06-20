using Sttopnews.NavBar;
using System.Runtime.CompilerServices;
using Microsoft.Maui.Animations;
namespace Sttopnews.View;

public partial class StartupPage : ContentPage
{
	public StartupPage()
	{
		InitializeComponent();
        //Chamar();
    }

    private  void Chamar()
    {
        //await Animar();
    }

    private async Task Animar()
	{
        await lk.RotateTo(360, 2000);
        lk.Rotation = 0;
    }

    private async void Logar_Clicked(object sender, EventArgs e)
    {
       await Navigation.PushAsync(new LoginPage());
    }
}