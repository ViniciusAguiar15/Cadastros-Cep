using Cadastro_de_CEPs.Models;
using Cadastro_de_CEPs.Services.Interfaces;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;

namespace Cadastro_de_CEPs.Controllers {
    [Route("api/[controller]")]
    [ApiController]
    public class EnderecoController : ControllerBase {


        private readonly IEnderecoService _enderecoService;

        public EnderecoController(IEnderecoService enderecoService) {
            _enderecoService = enderecoService;
        }

        [HttpGet]
        public IActionResult ListarEnderecos() {
            try {
                var enderecos = _enderecoService.Listar();

                if (enderecos.Count == 0) {
                    throw new Exception("Nenhum endereco encontrado.");
                }

                return Ok(enderecos);
            } catch (Exception e) {
                return new NotFoundObjectResult(new Retorno("Não foi possível listar os registros do sistem", e.Message));
            }

        }

        [HttpGet("{id}")]
        public IActionResult BuscarEndereco(int id) {
            try {
                var endereco = _enderecoService.Buscar(id);

                if (endereco == null) {
                    throw new Exception("Endereco não encontrado.");
                }

                return Ok(endereco);
            } catch (Exception e) {
                return new NotFoundObjectResult(new Retorno("Não foi possível buscar o registro no sistem", e.Message));
            }

        }

        [HttpPost]
        public IActionResult CadastrarEndereco([FromBody] Endereco endereco) {
            try {
                _enderecoService.Cadastrar(endereco);
                return Ok("Endereço cadastrado com sucesso.");
            } catch (Exception e) {
                return Conflict(new Retorno("Não foi possível cadastrar o registro no sistem", e.Message));
            }

        }

        [HttpPut]
        public IActionResult AlterarEndereco([FromBody] Endereco endereco) {
            try {
                _enderecoService.Editar(endereco);
                return Ok("Endereço editado com sucesso.");
            } catch (Exception e) {
                return Conflict(new Retorno("Não foi possível editar o registro do sistem", e.Message));
            }

        }

        [HttpDelete("{id}")]
        public IActionResult DeletarEndereco(int id) {
            try {
                _enderecoService.Excluir(id);
                return Ok("Endereço excluído com sucesso.");
            } catch (Exception e) {
                return Conflict(new Retorno("Não foi possível excluir o registro do sistem", e.Message));
            }
        }

    }
}
