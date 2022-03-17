using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Builder;

namespace OnlineBookStore.Models
{
    public interface IBookStoreRepository
    {
        //class set up specifically for querying data, very efficient
        IQueryable<Book> Books { get; }

        //updated repository for creating, updating, and deleting books
        public void SaveBook(Book b);
        public void CreateBook(Book b);
        public void DeleteBook(Book b);
    }
}

//an interface is not a class, it's a template for a class
