using CadastroItaka.DAL;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;

namespace CadastroItaka.Modelos.Pessoas
{
    [Table("Responsaveis")]
    public class Responsavel : Pessoa
    {
        [Column("GrauParentescoResponsavel")]
        public string GrauParentesco { get => grauParentesco; set => grauParentesco = value; }

        [Column("OcupacaoResponsavel")]
        public string Ocupacao { get => ocupacao; set => ocupacao = value; }

        [Column("RendaResponsavel")]
        public double Renda { get => renda; set => renda = value; }

        [Column("NomeContatoResponsavel")]
        public string NomeContato { get => nomeContato; set => nomeContato = value; }

        public List<Aluno> Alunos { get => alunos; set => alunos = value; }

        private string grauParentesco;
        private string ocupacao;
        private double renda;
        private string nomeContato;
        private List<Aluno> alunos;

        private ResponsavelDAO responsavelDAO;
        
        public Responsavel(string nome, string cpf, string rg, string email, string sexo, DateTime dataNascimento, DateTime dataCadastro, string telContato, string telCelular,
                           string grauParentesco, string ocupacao, double renda, string nomeContato)
                           : base(nome, cpf, rg, email, sexo, dataNascimento, dataCadastro, telContato, telCelular)
        {
            this.responsavelDAO = new ResponsavelDAO();

            this.nome = nome;
            this.cpf = cpf;
            this.rg = rg;
            this.email = email;
            this.sexo = sexo;
            this.dataNascimento = dataNascimento;
            this.dataCadastro = dataCadastro;
            this.idade = DateTime.Now.Year - dataNascimento.Year;
            this.telCelular = telCelular;
            this.telContato = telContato;
            this.grauParentesco = grauParentesco;
            this.ocupacao = ocupacao;
            this.renda = renda;
            this.nomeContato = nomeContato;
        }

        public Responsavel()
        {
            this.responsavelDAO = new ResponsavelDAO();
        }

        public bool Cadastrar()
        {
            try
            {
                if (CPF.ValidarCPF(this.Cpf))
                    this.responsavelDAO.Insert(this);

                return true;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public bool Editar()
        {
            try
            {
                this.responsavelDAO.Update(this);

                return true;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public bool Excluir()
        {
            try
            {
                this.responsavelDAO.Delete(this);

                return true;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
		public List<Responsavel> GetResponsaveis()
		{
			try
			{
				return responsavelDAO.GetResponsaveis();
			}
			catch (Exception)
			{

				throw;
			}
		}
    }
}