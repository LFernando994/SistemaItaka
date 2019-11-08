using CadastroItaka.DAL;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;

namespace CadastroItaka.Modelos.Matriculados
{
    [Table("Cursos")]
    public class Curso
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        [Column("Id")]
        public int Id { get => id; set => id = value; }

        [Column("CargaHoraria")]
        public int CargaHoraria { get => cargaHoraria; set => cargaHoraria = value; }

        [Column("Atividade")]
        public string Atividade { get => atividade; set => atividade = value; }

        private int id;
        private string atividade;
        private int cargaHoraria;

        private CursoDAO cursoDAO;

        public Curso(string atividade, int cargaHoraria)
        {
            this.cursoDAO = new CursoDAO();
            this.atividade = atividade;
            this.cargaHoraria = cargaHoraria;
        }

        public Curso()
        {
            this.cursoDAO = new CursoDAO();
        }

        public Curso GetCurso(int idCurso)
        {
            try
            {
                return this.cursoDAO.GetCurso(idCurso);
            }
            catch (Exception)
            {
                throw;
            }
        }

        public List<Curso> GetCursos()
        {
            try
            {
                return this.cursoDAO.GetCursos().ToList();
            }
            catch (Exception)
            {
                throw;
            }
        }

        public List<string> GetAtividades()
        {
            try
            {
                return this.cursoDAO.GetCursos().Select(c => c.Atividade).ToList();
            }
            catch (Exception)
            {
                throw;
            }
        }

        public bool Cadastrar()
        {
            try
            {
                this.cursoDAO.Insert(this);

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
                this.cursoDAO.Update(this);

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
                this.cursoDAO.Delete(this);

                return true;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public int GetId(string atividade)
        {
            return this.cursoDAO.GetId(atividade);
        }

    }
}
