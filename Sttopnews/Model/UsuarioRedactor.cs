namespace sttopnews.Models
{
    public class UsuarioRedactor : Usuario
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

        public Task<string> EditarNoticia(Noticias noticia)
        {
            throw new NotImplementedException();
        }
    }
}