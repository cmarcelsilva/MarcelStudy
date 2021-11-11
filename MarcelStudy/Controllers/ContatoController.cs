using MarcelStudy.Application;
using MarcelStudy.Models;
using MarcelStudy.Repository.Context;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MarcelStudy.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ContatoController : ControllerBase 
    {
        private ContatoApplication _contatoApplication;
        public ContatoController(ContatoApplication contatoApplication)
        {
            _contatoApplication = contatoApplication;
        }

        //Buscar por Lista
        [HttpGet("Listar")]
        public async Task<IActionResult> Listar()
        {
            try
            {
                var contatos = _contatoApplication.Listar();
                return Ok(contatos);
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }
        //Buscar por ID
        [HttpGet("BuscarPorId")]
        public async Task<IActionResult> BuscarPorId(int id)
        {
            try
            {
                var contatos = _contatoApplication.BuscarPorId(id);
                return Ok(contatos);
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }
        //Buscar por Nome
        [HttpGet("BuscarPorNome")]
        public async Task<IActionResult> BuscarPorNome(string nome)
        {
            try
            {
                var contatos = _contatoApplication.BuscarPorNome(nome);
                return Ok(contatos);
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }
        //Buscar por IDADE
        [HttpGet("BuscarPorIdade")]
        public async Task<IActionResult> BuscarPorIdade(int idade)
        {
            try
            {
                var contatos = _contatoApplication.BuscarPorIdade(idade);
                return Ok(contatos);
            }
            catch(Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }
        //Buscar Por DDD
        [HttpGet("BuscarPorDdd")]
        public async Task<IActionResult> BuscarPorDdd(int ddd)
        {
            try
            {
                var contatos = _contatoApplication.BuscarPorDdd(ddd);
                return Ok(contatos);
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }

        }
        //Buscar Por TELEFONE
        [HttpGet("BuscarPorTelefone")]
        public async Task<IActionResult> BuscarPorTelefone(string telefone)
        {
            try
            {
                var contatos = _contatoApplication.BuscarPorTelefone(telefone);
                    return Ok(contatos);
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }
        //Adiconar Novo Contato no Banco.
        [HttpPost("AdicionarContato")]
        public async Task<IActionResult> AdicionarContato(string nome, int idade, int ddd, string telefone)
        {
            try
            {
                var contatos = _contatoApplication.AdicionarContato(nome,idade,ddd,telefone);
                return Ok(contatos);
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }           
        }
        //Adiconar Contato,Por padrão precisa ser SP-Capital)
        [HttpPost("AdicionarContatoPorDddFixo")]
        public async Task<IActionResult> AdicionarContatoPorDddFixo(string nome,int idade,string telefone)
        {
            try
            {                
                var contatos = _contatoApplication.AdicionarContatoPorDddFixo(nome,idade,telefone);
                return Ok(contatos);
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        } 
        //Atualizar Contato Via ID,Nome(sempre usar id existe e passar ex campo senha ou nome )
        [HttpPut("AtualizarContato")]
        public IActionResult AtualizarContato(int id,string nome,int idade,int ddd,string telefone)
        {
            try
            {
                var contatos = _contatoApplication.AtualizarContato(id,nome,idade,ddd,telefone);
                return Ok(contatos);
            }
            catch(Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }
        //Deletar Contato
        [HttpDelete("DeletarContato")]
        public IActionResult DeletarContato(int id)
        {
            try
            {
                var contato = _contatoApplication.DeletarContato(id);
                return Ok(contato);
            }
            catch(Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }      

       
    }
}
