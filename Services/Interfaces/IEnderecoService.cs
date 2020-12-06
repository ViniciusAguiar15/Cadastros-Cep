using Cadastro_de_CEPs.Models;
using System.Collections.Generic;

namespace Cadastro_de_CEPs.Services.Interfaces {
    public interface IEnderecoService {
        Endereco Buscar(int id);
        void Cadastrar(Endereco endereco);
        void Editar(Endereco endereco);
        void Excluir(int id);
        List<Endereco> Listar();
    }
}
