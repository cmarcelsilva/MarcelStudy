using MarcelStudy.Models;
using MarcelStudy.Repository;
using MarcelStudy.Repository.Context;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MarcelStudy.Application
{

    public class ContatoApplication
    {
        private ContatoRepository _contatoRepository;
        public ContatoApplication(ContatoRepository contatoRepository)
        {
            _contatoRepository = contatoRepository;
        }
        //Buscar Por Lista
        public List<Contato> Listar()
        {          
            var contato = _contatoRepository.Listar();
            return contato;
        }
        //Buscar Por ID 
        public Contato BuscarPorId(int id)
        {
            var contatos = _contatoRepository.BuscarPorId(id);
            return contatos;
        }
        //Buscar por Nome
        public List<Contato> BuscarPorNome(string nome)
        {
            if (string.IsNullOrEmpty(nome))
            {
                throw new InvalidOperationException(" Esse campo não pode está vazio ");
            }

            var contatos = _contatoRepository.BuscarPorNome(nome);
            return contatos;
        }
        //Buscar por Idade
        public List<Contato> BuscarPorIdade(int idade)
        {
            var contatos = _contatoRepository.BuscarPorIdade(idade).ToList();
            return contatos;
        }
        //Buscar por DDD
        public List<Contato> BuscarPorDdd(int ddd)
        {
            var contatos = _contatoRepository.BuscarPorDdd(ddd);
            return contatos;
        }
        //Buscar por TELEFONE( Obs: se digitar apenas um numero não busca tem que digitrar por completo)>>
        public Contato BuscarPorTelefone(string telefone)
        {
            var contatos = _contatoRepository.BuscarPorTelefone(telefone);
            return contatos;
        }
        //Adiconar Novo Contato no Banco
        public Contato AdicionarContato(string nome, int idade, int ddd, string telefone)
        {
            var contatos = _contatoRepository.AdicionarContato(0,nome,idade,ddd,telefone);
            return contatos;
        }
        //Adiconar Contato,Por padrão precisa ser SP-Capital)
        public Contato AdicionarContatoPorDddFixo(string nome,int idade,string telefone)
        {            
            var contatos = _contatoRepository.AdicionarContato(0,nome,idade,11,telefone);         
            return contatos;
        }
        //Atualizar Contato Via Id DDD E TELEFONE
        public Contato AtualizarContato(int id,string nome,int idade,int ddd,string telefone)
        {
            var contatos = _contatoRepository.AtualizarContato(id,nome,idade,ddd,telefone);
            return contatos;
        }
        //Deletar Contato
        public Contato DeletarContato (int id)
        {
            var contato = _contatoRepository.DeletarContato(id);
            return contato;
        }

        

    }

}
    