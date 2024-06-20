using Sttopnews.Controller;
using Syncfusion.Maui.TabView;
namespace Sttopnews.View.UsuarioLeitor;

public partial class MainPage : ContentPage
{
    private SfTabView tabView;  
    public MainPage()
	{
		InitializeComponent();
        BindingContext = this;
        tabView = new SfTabView();
        this.Content = tabView;
    }
    private void Listas()
    {
        tabView.ItemsSource = new CollectionTabviewController().ListaNoticias();
    }
	public void CarregarCarrossel(bool T)
	{
        
	}

    private async void searchbutton_Clicked(object sender, EventArgs e)
    {
        await Navigation.PushAsync(new SearchPage());
    }

    private void OnScrollViewScrolled(object sender, ScrolledEventArgs e)
    {
		
    }
}

