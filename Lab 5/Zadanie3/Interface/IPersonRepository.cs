using Lab5.Zadanie3.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace Lab5.Zadanie3.Interface
{
    public interface IPersonRepository : IBaseRepository<Person, long>
    {
        List<Book> GetBorrowedBook(long id);
        void BorrowBook(long id, Book book);
    }
}