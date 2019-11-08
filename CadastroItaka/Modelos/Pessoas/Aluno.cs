using CadastroItaka.DAL;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;

namespace CadastroItaka.Modelos.Pessoas
{
    [Table("Alunos")]
    public class Aluno : Pessoa
    {
        [ForeignKey("Responsavel")]
        [Column("IdResponsavelAluno")]
        public int IdResponsavel { get => idResponsavel; set => idResponsavel = value; }

        [Column("StatusAluno")]
        public bool Status { get => status; set => status = value; }

        [Column("Aprovacao")]
        public bool Aprovacao { get => aprovacao; set => aprovacao = value; }

        [InverseProperty("Alunos")]
        public Responsavel Responsavel { get => responsavel; set => responsavel = value; }

        private Responsavel responsavel;
        private int idResponsavel;
        private bool status;
        private bool aprovacao;

        private AlunoDAO alunoDAO;

        public Aluno(string nome, string cpf, string rg, string email, string sexo, DateTime dataNascimento, DateTime dataCadastro, string telContato, string telCelular, bool status, bool aprovacao)
                    : base(nome, cpf, rg, email, sexo, dataNascimento, dataCadastro, telContato, telCelular)
        {
            this.alunoDAO = new AlunoDAO();
            this.status = status;
            this.aprovacao = aprovacao;
        }

        public Aluno()
        {
            this.alunoDAO = new AlunoDAO();
        }

        public bool Cadastrar()
        {
            try
            {
                //if (CPF.ValidarCPF(this.Cpf))
                this.alunoDAO.Insert(this);

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
                this.alunoDAO.Update(this);

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
                this.alunoDAO.Delete(this);

                return true;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
		public List<Aluno> GetAlunos()
		{
			try
			{
				return alunoDAO.GetAlunos();
			}
			catch (Exception)
			{

				throw;
			}
		}

        public int GetId(string rg)
        {
            return this.alunoDAO.GetId(rg);
        }

    }
}

