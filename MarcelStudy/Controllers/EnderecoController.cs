using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using MarcelStudy.Application;
using RouteAttribute = Microsoft.AspNetCore.Mvc.RouteAttribute;

namespace MarcelStudy.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class EnderecoController : ControllerBase
    {
        private EnderecoApplication _enderecoApplication;
        public EnderecoController(EnderecoApplication enderecoApplication)
        {
            _enderecoApplication = enderecoApplication;
        }

        [HttpGet("ListarEndereco")]
        public async Task<IActionResult> ListarEndereco()
        {
            try
            {
                var endereco = _enderecoApplication.ListarEndereco();
                return Ok(endereco);
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }

        [HttpGet("PesquisarPorId")]
        public async Task<IActionResult> PesquisarPorId(int id)
        {
            try
            {
                var endereco = _enderecoApplication.PesquisarPorId(id);
                return Ok(endereco);
            }
            catch(Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }

        [HttpGet("LocalizarPorId_Contato")]
        public async Task<IActionResult> PesquisarIdContato(int contatoid)
        {
            try
            {
                var endereco = _enderecoApplication.PesquisarIdcontato(contatoid);
                return Ok(endereco);
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }

        [HttpGet("LocalizarPorCep")]
        public async Task<IActionResult> PesquisarCep(string cep)
        {
            try
            {
                var endereco = _enderecoApplication.PesquisarCep(cep);
                return Ok(endereco);
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }

        [HttpGet("LocalizarPorCidade")]
        public async Task<IActionResult> PesquisarCidade(string cidade)
        {
            try
            {
                var endereco = _enderecoApplication.PesquisarCidade(cidade);
                return Ok(endereco);
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }

        [HttpGet("LocalizarPorBairro")]
        public async Task<IActionResult> PesquisarBairro(string bairro)
        {
            try
            {
                var endereco = _enderecoApplication.PesquisarBairro(bairro);
                return Ok(endereco);
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }

        [HttpPut("AtualizarEndereco")]
        public async Task<IActionResult> AtualizarEndereco(int id,string end_endereco,string cidade,string bairro,string cep)
        {
            try
            {
                var endereco = _enderecoApplication.AtualizarEndereco(id, end_endereco, cidade, bairro, cep);
                return Ok(endereco);
            }
            catch(Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }
        [HttpPost("AdicionarEndereco")]
        public async Task<IActionResult> AdicionarEndereco(int id,string end_endereco,string cidade,string bairro,string cep)
        {
            try
            {
                var endereco = _enderecoApplication.AdicionarEndereco(id, end_endereco, cidade, bairro, cep);
                return Ok(endereco);
            }
            catch(Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }
        [HttpDelete("DeleteEndereco")]
        public async Task<IActionResult> DeletarEndereco(int id)
        {
            try
            {
                var endereco = _enderecoApplication.DeletarEndereco(id);
                return Ok(endereco);
            }
            catch(Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }
    }

}

