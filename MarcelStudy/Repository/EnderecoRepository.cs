using MarcelStudy.Models;
using MarcelStudy.Application;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MarcelStudy.Repository.Context
{
    public class EnderecoRepository
    {
        private StudyContext _contexto;
        private readonly object endereco;

        public EnderecoRepository(StudyContext contexto)
        {
            _contexto = contexto;
        }

        public List<Endereco> ListarEndereco()
        {
            var endereco = _contexto.Endereco.ToList();
            return endereco;
        }
        public Endereco PesquisarPorId(int id)
        {
            var endereco = _contexto.Endereco.Where(i => i.Id == id).FirstOrDefault();
            return endereco;
        }
        
        public List<Endereco> PesquisarIdcontato(int contatoid)
        {
            var endereco = _contexto.Endereco.Where(ic => ic.ContatoId == contatoid).ToList();
            return endereco;

        }
        public Endereco PesquisarCep(string cep)
        {
            var endereco = _contexto.Endereco.Where(cepp => cepp.Cep == cep).FirstOrDefault();
            return endereco;
        }
        public List<Endereco> PesquisarCidade(string cidade)
        {
            var endereco = _contexto.Endereco.Where(n => n.Cidade == cidade).ToList();
            return endereco;
        }
        public List<Endereco> PesquisarBairro(string bairro)
        {
            var endereco = _contexto.Endereco.Where(b => b.Bairro == bairro).ToList();
            return endereco;
        }
        public Endereco AtualizarEndereco(int id,string end_endereco,string cidade,string bairro,string cep)
        {
            var endereco = PesquisarPorId(id);
            endereco.EnderecoEnd = end_endereco;
            endereco.Cidade = cidade;
            endereco.Bairro = bairro;
            endereco.Cep = cep;         
                                  
            _contexto.Endereco.Update(endereco);
            _contexto.SaveChanges();
            return endereco;
        }
        public Endereco AdicionarEndereco(string end_endereco,string cidade,string bairro,string cep)
        {
            var endereco = new Endereco();
            
            endereco.EnderecoEnd = end_endereco;
            endereco.Cidade = cidade;
            endereco.Bairro = bairro;
            endereco.Cep = cep;

            _contexto.Endereco.Add(endereco);
            _contexto.SaveChanges();
            return endereco;
        }
        public Endereco DeletarEndereco(int id)
        {
            var endereco = PesquisarPorId(id);
            _contexto.Endereco.Remove(endereco);
            _contexto.SaveChanges();
            return endereco;
        }

    }
}
