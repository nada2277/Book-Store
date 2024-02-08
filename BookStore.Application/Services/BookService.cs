using BookStore.Application.Contracts;
using BookStore.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookStore.Application.Services
{
  public class BookService : IBookService
  {
    IBookRepository _BookRepository { get; set; }
    public BookService(IBookRepository bookRepository) =>
     _BookRepository = bookRepository;

    public List<Book> GetAllPagination(int num, int pageIndex) =>
      _BookRepository.GetAll().Skip(num * pageIndex - 1).Take(num).ToList(); 
    public List<Book> GetBooksByName(string name) =>
      _BookRepository.GetAll().Where(b=>b.Name.Contains(name)).ToList();
    public Book GetBookById(int id) => _BookRepository.GetById(id);
    public bool AddBook(Book book)
    {
      bool isAdded = _BookRepository.Create(book);
      if (isAdded)
        _BookRepository.Save();
      return isAdded;
    }
    public bool DeleteBook(int id)
    {
      bool isDeleted = _BookRepository.Delete(id);
      if (isDeleted)
        _BookRepository.Save();
      return isDeleted;
    }
    public bool UpdateBook(Book book)
    {
      bool isUpdated = _BookRepository.Update(book);
      if (isUpdated)
        _BookRepository.Save();
      return isUpdated;

    }
    public List<Book> GetByCategoryName(string name) =>
      _BookRepository.GetByCategory(name).ToList();

  }
}
