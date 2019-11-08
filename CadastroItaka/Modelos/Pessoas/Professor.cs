using CadastroItaka.DAL;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;

namespace CadastroItaka.Modelos.Pessoas
{
    [Table("Professores")]
    public class Professor : Pessoa
    {
        [Column("Formacao")]
        public string Formacao { get => formacao; set => formacao = value; }
        private string formacao;

        private ProfessorDAO professorDAO;

        public Professor(string nome, string cpf, string rg, string email, string sexo, DateTime dataNascimento, DateTime dataCadastro, string telContato, string telCelular, string formacao)
            : base(nome, cpf, rg, email, sexo, dataNascimento, dataCadastro, telContato, telCelular)
        {
            this.professorDAO = new ProfessorDAO();
            this.formacao = formacao;
        }

        public Professor()
        {
            this.professorDAO = new ProfessorDAO();
        }
	
		public bool Cadastrar()
        {
            try
            {
                //if (CPF.ValidarCPF(this.Cpf))
                this.professorDAO.Insert(this);

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
                this.professorDAO.Update(this);

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
                this.professorDAO.Delete(this);

                return true;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public List<Professor> GetProfessores()
        {
            try
            {
                return this.professorDAO.GetProfessores();
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        //public List<Professor> GetDadosProfessores()
        //{
        //    try
        //    {
        //        return this.professorDAO.GetDadosProfessores();
        //    }
        //    catch (Exception ex)
        //    {
        //        throw ex;
        //    }
        //}

        public List<int> GetIdProfessores(int idCurso)
        {
            return this.professorDAO.GetIdProfessores(idCurso);
        }

        public int GetId(string cpfProfessor)
        {
            return this.professorDAO.GetId(cpfProfessor);
        }

        //public int GetId(string nomeProfessor)
        //{
        //    return this.professorDAO.GetId(nomeProfessor);
        //}

        public string GetNome(int idProfessor)
        {
            return this.professorDAO.GetNome(idProfessor);
        }
    }
}
