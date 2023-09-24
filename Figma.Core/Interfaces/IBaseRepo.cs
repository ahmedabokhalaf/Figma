namespace Figma.Core.Interfaces
{
    public interface IBaseRepo<T> where T : class
    {
        T Get(int id);
        void Create(T item);
        void Update(T item);
        void Delete(T item);
    }
}
