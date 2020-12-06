namespace Cadastro_de_CEPs.Models {
    public class Retorno {
        public Retorno(string mensagem, string complemento) {
            Mensagem = mensagem;
            Complemento = complemento;
        }

        public string Mensagem { get; set; }
        public string Complemento { get; set; }
    }
}
