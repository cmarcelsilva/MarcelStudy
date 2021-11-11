using MarcelStudy.Contratos.Repository;
using MarcelStudy.Models;
using MarcelStudy.Repository.Context;
using System;
using System.Collections.Generic;
using System.Linq;

namespace MarcelStudy.Repository
{
    public class ContatoRepository : IContatoRepository
    {
        private StudyContext _contexto;      

        public ContatoRepository(StudyContext contexto)
        {
            _contexto = contexto;
        }
        //Buscar por Lista
        public List<Contato> Listar()
        {
            var contatos = _contexto.Contato.ToList();
            return contatos;
        }
        //Busca por ID
        public Contato BuscarPorId(int id)
        {
            var contato = _contexto.Contato.Where(i => i.Id == id).FirstOrDefault();//primeiro ou padrão
            return contato;
        }
        //Buscar por Nome
        public List<Contato> BuscarPorNome(string nome)
        {
            var nomeLower = nome.ToLower();
            var contatos = _contexto.Contato.Where(a => a.Nome.ToLower().Contains(nomeLower)).ToList();
            //.Where(a => a.Nome == nome)
            //.Where(a => a.Nome.StartsWith(nome))
            //.Where(a => a.Nome.EndsWith(nome))
            return contatos;
        }
        //Buscar por Idade
        public List<Contato> BuscarPorIdade(int idade)
        {
            var contatos = _contexto.Contato.Where(i => i.Idade == idade).ToList();
            return contatos;
        }
        //Buscar por DDD        
        public List<Contato> BuscarPorDdd(int ddd)
        {
            var contatos = _contexto.Contato.Where(p => p.Ddd == ddd).ToList();
            return contatos;
        }
        //Buscar por TELEFONE
        public Contato BuscarPorTelefone(string telefone)
        {
            var contatos = _contexto.Contato.Where(t => t.Telefone == telefone).FirstOrDefault();
            return contatos;
        }
        //Adiconar Novo Contato no Banco
        public Contato AdicionarContato(int id, string nome, int idade, int ddd, string telefone)//contrato
        {
            Contato cont = new Contato();
            cont.Nome = nome;
            cont.Idade = idade;
            cont.Ddd = ddd;            
            cont.Telefone = telefone;               
         
            _contexto.Contato.Add(cont);
            _contexto.SaveChanges();
            return cont;                     
        }
        //Atualizar Contato 
        public Contato AtualizarContato(int id,string nome,int idade,int ddd,string telefone)
        {

            var contato = BuscarPorId(id);
            contato.Nome = nome;
            contato.Idade = idade;
            contato.Ddd = ddd;
            contato.Telefone = telefone;

            _contexto.Contato.Update(contato);
            _contexto.SaveChanges();
            return contato;

        }
        //Deletar po id
        public Contato DeletarContato(int id)
        {
            var contato = BuscarPorId(id);        

            _contexto.Contato.Remove(contato);
            _contexto.SaveChanges();
            return contato;
        }
       
       

        
    }
}
