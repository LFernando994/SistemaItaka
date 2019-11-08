using CadastroItaka.DAL;
using CadastroItaka.Modelos.Pessoas;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;

namespace CadastroItaka.Modelos.Matriculados
{
    [Table("Matriculados")]
    public class Matriculado
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        [Column("Matricula")]
        public int Matricula { get => matricula; set => matricula = value; }

        [ForeignKey("Aluno")]
        [Column("IdAlunoMatriculado")]
        public int IdAluno { get => idAluno; set => idAluno = value; }

        [ForeignKey("Turma")]
        [Column("IdTurmaMatriculado")]
        public int IdTurma { get => idTurma; set => idTurma = value; }

        [Column("DataMatricula")]
        public DateTime DataMatricula { get => dataMatricula; set => dataMatricula = value; }

        [Column("Falta")]
        public int Falta { get => falta; set => falta = value; }

        [Column("Frequencia")]
        public double Frequencia { get => frequencia; set => frequencia = value; }

        public Aluno Aluno { get => aluno; set => aluno = value; }

        public Turma Turma { get => turma; set => turma = value; }

        public List<bool> Ausencia { get => ausencia; set => ausencia = value; }

        private int matricula;
        private int falta;
        private double frequencia;

        private DateTime dataMatricula;
        private int idAluno;
        private int idTurma;
        private Aluno aluno;

        private Turma turma;
        private List<bool> ausencia = new List<bool>();

        private MatriculadoDAO matriculadoDAO;

		public Matriculado()
        {
            this.matriculadoDAO = new MatriculadoDAO();
        }

        public Matriculado(int idAluno, DateTime dataMatricula)
        {
            this.matriculadoDAO = new MatriculadoDAO();
            this.dataMatricula = dataMatricula;
            this.idAluno = idAluno;
            this.frequencia = 100;
        }

        /// <summary>
        /// Metódo que registra a ausência do aluno
        /// Considerado que o mesmo possui 100% de presença no início do curso
        /// </summary>
        /// <returns></returns>
        public void RegistrarAusencia()
        {
            ausencia.Add(true);
        }

        public double RetornaAusencia()
        {
            int falta = this.Falta++;

            return falta;
        }

        public bool Cadastrar()
        {
            try
            {
                this.matriculadoDAO.Insert(this);

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
                this.matriculadoDAO.Update(this);

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
                this.matriculadoDAO.Delete(this);

                return true;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public List<Matriculado> GetMatriculados()
		{
			try
			{
				return this.matriculadoDAO.GetMatriculados();
			}
			catch (Exception)
			{

				throw;
			}
		}

        public DateTime GetDataMatricula(string rgAluno)
        {
            return this.matriculadoDAO.GetDataMatricula(rgAluno);
        }
       
    }
}
