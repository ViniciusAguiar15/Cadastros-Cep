using Cadastro_de_CEPs.Database;
using Cadastro_de_CEPs.Models;
using Cadastro_de_CEPs.Services.Interfaces;
using System.Collections.Generic;
using System.Linq;

namespace Cadastro_de_CEPs.Services {
    public class EnderecoService : IEnderecoService {

        private readonly ApplicationDbContext _dbContext;
        public EnderecoService(ApplicationDbContext dbContext) {
            _dbContext = dbContext;
        }

        public Endereco Buscar(int id) {
            return _dbContext.Enderecos.FirstOrDefault(e => e.Id == id);
        }

        public void Cadastrar(Endereco endereco) {
            _dbContext.Add(endereco);
            _dbContext.SaveChanges();
        }
        public void Editar(Endereco endereco) {
            _dbContext.Update(endereco);
            _dbContext.SaveChanges();
        }

        public void Excluir(int id) {
            var endereco = Buscar(id);
            _dbContext.Remove(endereco);
            _dbContext.SaveChanges();
        }

        public List<Endereco> Listar() {
            return _dbContext.Enderecos.ToList();
        }
    }
}
