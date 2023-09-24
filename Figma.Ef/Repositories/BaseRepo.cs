namespace Figma.Ef.Repositories
{
    public class BaseRepo<T> : IBaseRepo<T> where T : class
    {
        public readonly ApplicationDbContext context;

        public BaseRepo(ApplicationDbContext _context)
        {
            context = _context;
        }

        public void Create(T item)
        {
            context.Set<T>().Add(item);
        }

        public void Delete(T item)
        {
            context.Set<T>().Remove(item);
        }

        public T Get(int id)
        {
            return context.Set<T>().Find(id)!;
        }

        public void Update(T item)
        {
            context.Set<T>().Update(item);
        }
    }
}
