using sttopnews.Models;

namespace Sttopnews.View.UsuarioLeitor;

public partial class PublicationPage : ContentPage
{
	public PublicationPage(Noticias noticias)
	{
		InitializeComponent();
		PreencherTela(noticias);
	}
	private void PreencherTela(Noticias noticias)
	{
		this.Title = noticias.Titulo;
		this.img.Source = noticias.Imagem;
		this.texto.Text = noticias.Corpo;
	}

    private void Button_Clicked(object sender, EventArgs e)
    {

    }
}