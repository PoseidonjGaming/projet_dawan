namespace SerieDLL.Interface
{
    public interface IDAOBase<T>
    {
        void Add(T obj);
        void Update(T obj);
        void Delete(int id);
        List<T> GetAll();
        T GetById(int id);
    }
}
