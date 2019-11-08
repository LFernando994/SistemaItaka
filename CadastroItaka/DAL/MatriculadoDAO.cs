using CadastroItaka.DataSource;
using CadastroItaka.Modelos.Matriculados;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;

namespace CadastroItaka.DAL
{
    public class MatriculadoDAO : IDataAccessObject<Matriculado>
    {
        private Contexto ItakaConnection;

        public MatriculadoDAO()
        {
            ItakaConnection = new Contexto();
        }

        public void Insert(Matriculado obj)
        {
            try
            {
                if (!ItakaConnection.Matriculados.Where(x => x.IdAluno == obj.IdAluno && x.IdTurma == obj.IdTurma).Any())
                {
                    ItakaConnection.Matriculados.Add(obj);
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

        public void Update(Matriculado obj)
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

        public void Delete(Matriculado obj)
        {
            try
            {
                obj.Matricula = GetMatricula(obj.IdAluno, obj.IdTurma);
                Matriculado matriculado = ItakaConnection.Matriculados.Find(obj.Matricula);
                //ItakaConnection.Entry(obj).State = EntityState.Deleted;
                ItakaConnection.Matriculados.Remove(matriculado);
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

        private int GetMatricula(int idAluno, int idTurma)
        {
            try
            {
                return ItakaConnection.Matriculados.Where(x => x.IdAluno == idAluno && x.IdTurma == idTurma).Select(y => y.Matricula).FirstOrDefault();
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
                return ItakaConnection.Matriculados.ToList();
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public DateTime GetDataMatricula(string rgAluno)
        {
            try
            {
                return ItakaConnection.Matriculados.Where(x => x.Aluno.Rg == rgAluno).Select(y => y.DataMatricula).FirstOrDefault();
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
    }
}
