﻿namespace Cadastro_de_CEPs.Models {
    public class Endereco {
        public int Id { get; set; }
        public string Complemento { get; set; }
        public string Bairro { get; set; }
        public string Cidade { get; set; }
        public string Logradouro { get; set; }
        public string CEP { get; set; }
        public string Estado { get; set; }

    }
}
