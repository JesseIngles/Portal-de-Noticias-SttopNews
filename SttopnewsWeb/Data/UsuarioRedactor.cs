using SttopnewsWeb.Interfaces;

namespace SttopnewsWeb.Data
{
    public class UsuarioRedactor : Usuario, IUsuarioRedactor
    {
        //Variavies para Consumir a Api
        HttpClient client = new HttpClient();
        HttpResponseMessage response;

        /*ATRIBUTOS ESPECÍFICOS DO REDACTOR*/
        public bool NivelAcesso { get; set; } = false;

        public Task<bool> CadastrarNoticia(Noticias noticia)
        {
            throw new NotImplementedException();
        }

        public Task<Noticias> CarregarNoticia(int id)
        {
            throw new NotImplementedException();
        }

        public Task<List<Noticias>> CarregarNoticias()
        {
            throw new NotImplementedException();
        }

        public Task<string> CriarConta(Usuario user)
        {
            throw new NotImplementedException();
        }

        public Task<string> EditarNoticia(Noticias noticia)
        {
            throw new NotImplementedException();
        }

        public Task<Usuario> FazerLogin(Usuario user)
        {
            throw new NotImplementedException();
        }

        public Task<bool> FazerLogOut(string telefone, bool status)
        {
            throw new NotImplementedException();
        }
    }
}