using System;
using System.Linq;

namespace WaterProject.Models
{
    public interface IBookstoreRepository
    {
        IQueryable<Books> Books { get; }
    }
}
