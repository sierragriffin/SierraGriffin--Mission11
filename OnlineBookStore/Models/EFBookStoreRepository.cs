using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Builder;

namespace OnlineBookStore.Models
{
    public class EFBookStoreRepository : IBookStoreRepository
    {
        private BookstoreContext context { get; set; }

        public EFBookStoreRepository(BookstoreContext temp)
        {
            context = temp;
        }

        public IQueryable<Book> Books => context.Books;


        //updated repository for creating, updating, and deleting books
        public void SaveBook(Book b)
        {
            context.SaveChanges();
        }

        public void CreateBook(Book b)
        {
            context.Add(b);
            context.SaveChanges();
        }

        public void DeleteBook(Book b)
        {
            context.Remove(b);
            context.SaveChanges();
        }
    }
}

//implementation of interface that we implemented in "IBookStoreRepository.cs"