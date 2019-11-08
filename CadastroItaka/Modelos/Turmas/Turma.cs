using CadastroItaka.DAL;
using CadastroItaka.Modelos.Pessoas;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace CadastroItaka.Modelos.Matriculados
{
    [Table("Turmas")]
    public class Turma
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        [Column("IdTurma")]
        public int Id { get => id; set => id = value; }

        [Column("Turma")]
        public string IDTurma { get => IdTurma; set => IdTurma = value; }

        //[ForeignKey("Curso")]
        [Column("Curso")]
		public string Atividade { get => atividade; set => atividade = value; }

        //[ForeignKey("Professor")]
        [Column("Professor")]
		public string Docente { get => docente; set => docente = value; }

		[Column("Turno")]
        public string Turno { get => turno; set => turno = value; }

        [Column("DataInicial")]
        public DateTime DataInicial { get => dataInicial; set => dataInicial = value; }

        [Column("DataFinal")]
        public DateTime DataFinal { get => dataFinal; set => dataFinal = value; }

        [Column("HoraInicial")]
        public TimeSpan HoraInicial { get => horaInicial; set => horaInicial = value; }

        [Column("HoraFinal")]
        public TimeSpan HoraFinal { get => horaFinal; set => horaFinal = value; }

        public List<Matriculado> Matriculados { get => matriculados; set => matriculados = value; }

        //public virtual Curso Curso { get => curso; set => curso = value; }
        //public virtual Professor Professor { get => professor; set => professor = value; }

        private int id;
        private string IdTurma;
        private string turno;
        private string atividade;
        private string docente;
        //private Curso curso;
        //private Professor professor;

        private DateTime dataInicial;
        private DateTime dataFinal;
        private TimeSpan horaInicial;
        private TimeSpan horaFinal;
        private List<Matriculado> matriculados;

        private TurmaDAO turmaDAO;

        public Turma(string IdTurma, string atividade, string docente, string turno, DateTime dataInicial, DateTime dataFinal, TimeSpan horaInicial, TimeSpan horaFinal)
        {
            this.turmaDAO = new TurmaDAO();
            this.IdTurma = IdTurma;
            this.turno = turno;
            this.atividade = atividade;
            this.docente = docente;
            this.dataInicial = dataInicial;
            this.dataFinal = dataFinal;
            this.horaInicial = horaInicial;
            this.horaFinal = horaFinal;
        }

        public Turma()
        {
            this.turmaDAO = new TurmaDAO();
        }

        public List<Turma> GetTurmas()
        {
            return this.turmaDAO.GetTurmas();
        }

        public List<Turma> GetTurmas(string curso)
        {
            return this.turmaDAO.GetTurmas(curso);
        }

		public string GetAtividade(int matricula)
		{
			return this.turmaDAO.GetAtividade(matricula);
		}

		public string GetTurno(int matricula)
		{
			return this.turmaDAO.GetTurno(matricula);
		}

		public string GetProfessor(int matricula)
		{
			return this.turmaDAO.GetProfessor(matricula);
		}

		public DateTime GetDataInicial(int matricula)
		{
			return this.turmaDAO.GetDataInicial(matricula);
		}

		public DateTime GetDataFinal(int matricula)
		{
			return this.turmaDAO.GetDataFinal(matricula);
		}

		public TimeSpan GetHoraInicial(int matricula)
		{
			return this.turmaDAO.GetHoraInicial(matricula);
		}

		public TimeSpan GetHoraFinal(int matricula)
		{
			return this.turmaDAO.GetHoraFinal(matricula);
		}

		public TimeSpan GetHoraAula()
        {
            TimeSpan HoraAula = horaInicial.Subtract(horaFinal);
            return HoraAula;
        }

        public bool Cadastrar()
		{
            try
            {
                this.turmaDAO.Insert(this);

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
                this.turmaDAO.Update(this);

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
                this.turmaDAO.Delete(this);

                return true;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public int GetId(string turmaId)
        {
            return this.turmaDAO.GetId(turmaId);
        }
    }
}
