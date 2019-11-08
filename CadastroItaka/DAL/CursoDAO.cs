using CadastroItaka.DataSource;
using CadastroItaka.Modelos.Matriculados;
using System;
using System.Data.Entity;
using System.Linq;

namespace CadastroItaka.DAL
{
    public class CursoDAO : IDataAccessObject<Curso>
    {
        private Contexto ItakaConnection;

        public CursoDAO()
        {
            ItakaConnection = new Contexto();
        }

        public void Insert(Curso obj)
        {
            try
            {
                ItakaConnection.Cursos.Add(obj);
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

        public void Update(Curso obj)
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

        public void Delete(Curso obj)
        {
            try
            {
                ItakaConnection.Entry(obj).State = EntityState.Deleted;
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

        public int GetId(string atividade)
        {
            try
            {
                return ItakaConnection.Cursos.Where(x => x.Atividade == atividade).Select(y => y.Id).FirstOrDefault();
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public Curso GetCurso(int idCurso)
        {
            try
            {
                return ItakaConnection.Cursos.Find(idCurso);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public IQueryable<Curso> GetCursos()
        {
            try
            {
                return ItakaConnection.Cursos;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
    }
}
