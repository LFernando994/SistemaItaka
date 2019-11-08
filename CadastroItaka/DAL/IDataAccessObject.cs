namespace CadastroItaka.DAL
{
    public interface IDataAccessObject<T>
    {
        void Insert(T obj);
        void Update(T obj);
        void Delete(T obj);

    }
}
