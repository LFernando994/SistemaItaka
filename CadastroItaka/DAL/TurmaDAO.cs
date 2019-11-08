using CadastroItaka.DataSource;
using CadastroItaka.Modelos.Matriculados;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;

namespace CadastroItaka.DAL
{
    public class TurmaDAO : IDataAccessObject<Turma>
    {
        private Contexto ItakaConnection;

        public TurmaDAO()
        {
            ItakaConnection = new Contexto();
        }

        public void Insert(Turma obj)
        {
            try
            {
                if (!ItakaConnection.Turmas.Where(x => x.IDTurma == obj.IDTurma).Any())
                {
                    ItakaConnection.Turmas.Add(obj);
                    ItakaConnection.SaveChanges();
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
                ItakaConnection.Dispose();
            }
        }

        public void Update(Turma obj)
        {
            try
            {
                ItakaConnection.Entry(obj).State = EntityState.Modified;
                ItakaConnection.SaveChanges();
            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
                ItakaConnection.Dispose();
            }
        }

        public void Delete(Turma obj)
        {
            try
            {
                //MatriculadoDAO matriculadoDAO = new MatriculadoDAO();
                //matriculadoDAO.GetMatriculados().Where(m => m.IdTurma == obj.Matricula).ToList().ForEach(m => m.Excluir());

                Turma turma = ItakaConnection.Turmas.Find(obj.Id);
                ItakaConnection.Turmas.Remove(turma);
                ItakaConnection.SaveChanges();
            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
                ItakaConnection.Dispose();
            }
        }

        /// <summary>
        /// Busca turmas cadastrados no sistema.
        /// </summary>
        public List<Turma> GetTurmas()
        {
            return ItakaConnection.Turmas.ToList();
        }

        /// <summary>
        /// Busca turmas de um determinado curso
        /// </summary>
        /// <param name="curso">Nome do curso (atividade).</param>
        public List<Turma> GetTurmas(string curso)
        {
            return ItakaConnection.Turmas.Where(t => t.Atividade == curso).ToList();
        }

        public int GetId(string turmaId)
        {
            try
            {
                return ItakaConnection.Turmas.Where(x => x.IDTurma == turmaId).Select(y => y.Id).FirstOrDefault();
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public string GetAtividade(int matricula)
        {
            try
            {
                return ItakaConnection.Turmas.Where(x => x.Id == matricula).Select(y => y.Atividade).FirstOrDefault();
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public string GetTurno(int matricula)
        {
            return ItakaConnection.Turmas.Where(x => x.Id == matricula).Select(y => y.Turno).FirstOrDefault();
        }

        public string GetProfessor(int matricula)
        {
            try
            {
                return ItakaConnection.Turmas.Where(x => x.Id == matricula).Select(y => y.Docente).FirstOrDefault();
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public DateTime GetDataInicial(int matricula)
        {
            try
            {
                return ItakaConnection.Turmas.Where(x => x.Id == matricula).Select(y => y.DataInicial).FirstOrDefault();
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public DateTime GetDataFinal(int matricula)
        {
            try
            {
                return ItakaConnection.Turmas.Where(x => x.Id == matricula).Select(y => y.DataFinal).FirstOrDefault();
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public TimeSpan GetHoraInicial(int matricula)
        {
            try
            {
                return ItakaConnection.Turmas.Where(x => x.Id == matricula).Select(y => y.HoraInicial).FirstOrDefault();
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public TimeSpan GetHoraFinal(int matricula)
        {
            try
            {
                return ItakaConnection.Turmas.Where(x => x.Id == matricula).Select(y => y.HoraFinal).FirstOrDefault();
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        
    }
}
