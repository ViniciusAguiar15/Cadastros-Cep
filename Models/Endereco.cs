using System.ComponentModel.DataAnnotations;

namespace Cadastro_de_CEPs.Models {
    public class Endereco {
        [Required(ErrorMessage = "Campo de preenchimento obrigatório.")]
        public int Id { get; set; }

        [Required(ErrorMessage = "Campo de preenchimento obrigatório.")]
        [StringLength(8, ErrorMessage = "O tamanho deve ser de 8 caracteres.")]
        public string CEP { get; set; }

        [Required(ErrorMessage = "Campo de preenchimento obrigatório.")]
        [MaxLength(255, ErrorMessage = "O tamanho não pode ultrapassar 255 digitos")]
        public string Logradouro { get; set; }

        [MaxLength(255, ErrorMessage = "O tamanho não pode ultrapassar 255 digitos")]
        public string Complemento { get; set; }

        [Required(ErrorMessage = "Campo de preenchimento obrigatório.")]
        [MaxLength(255, ErrorMessage = "O tamanho não pode ultrapassar 255 digitos")]
        public string Bairro { get; set; }

        [Required(ErrorMessage = "Campo de preenchimento obrigatório.")]
        [MaxLength(255, ErrorMessage = "O tamanho não pode ultrapassar 255 digitos")]
        public string Cidade { get; set; }

        [Required(ErrorMessage = "Campo de preenchimento obrigatório.")]
        [MaxLength(255, ErrorMessage = "O tamanho não pode ultrapassar 255 digitos")]
        public string Estado { get; set; }

    }
}
