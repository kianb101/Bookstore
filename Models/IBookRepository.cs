namespace Mission_11_Bangerter.Models
{
    public interface IBookRepository
    {
        public IQueryable<Book> Books { get; }
    }
}
