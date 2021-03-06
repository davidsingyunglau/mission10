using System;
using System.Linq;

namespace WaterProject.Models
{
    public interface IBookstoreRepository
    {
        IQueryable<Books> Books { get; }

        public void SaveBook(Books b);

        public void CreateBook(Books b);

        public void DeleteBook(Books b);
    }
}
