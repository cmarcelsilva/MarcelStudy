using MarcelStudy.Models;
using MarcelStudy.Repository.Context;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MarcelStudy.Application
{
    public class EnderecoApplication
    {
        private EnderecoRepository _enderecoRepository;
        public EnderecoApplication(EnderecoRepository enderecoRepository)
        {
            _enderecoRepository = enderecoRepository;
        }        
        public List<Endereco> ListarEndereco()
        {
            var endereco = _enderecoRepository.ListarEndereco();
            return endereco;
        }
        public Endereco PesquisarPorId(int id)
        {
            var endereco = _enderecoRepository.PesquisarPorId(id);
            return endereco;
        }
       public List<Endereco> PesquisarIdcontato(int contatoid)
        {
            var endereco = _enderecoRepository.PesquisarIdcontato(contatoid);
            return endereco;
        }       
        public Endereco PesquisarCep(string cep)
        {
            var endereco = _enderecoRepository.PesquisarCep(cep);
            return endereco;
        }
        public List<Endereco> PesquisarCidade(string cidade)
        {
            var endereco = _enderecoRepository.PesquisarCidade(cidade);
            return endereco;
        }
        public List<Endereco> PesquisarBairro(string bairro)
        {
            var endereco = _enderecoRepository.PesquisarBairro(bairro);
            return endereco;
        }
        public Endereco AtualizarEndereco(int id,string end_endereco,string cidade,string bairro,string cep)
        {
            var endereco = _enderecoRepository.AtualizarEndereco(id,end_endereco,cidade,bairro,cep);
            return endereco;
        }
        public Endereco AdicionarEndereco(int id,string end_endereco,string cidade,string bairro,string cep)
        {
            var endereco = _enderecoRepository.AdicionarEndereco(end_endereco, cidade, bairro, cep);
            return endereco;
        }
        public Endereco DeletarEndereco (int id)
        {
            var Endereco = _enderecoRepository.DeletarEndereco(id);
            return Endereco;
        }

    }
}
