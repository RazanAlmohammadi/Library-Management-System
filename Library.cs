using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace LibraryManagementSystem
{
    public class Library
    {
        private List<Book> books = new List<Book>();
        private List<User> users = new List<User>();

        public List<Book> GetAllBooks(int pageNumber, int pageSize)
        {
            if (pageNumber <= 0 || pageSize <= 0)
            {
                throw new ArgumentException("Error: Both pageNumber and pageSize must be positive integers.");
            }

            var booksToSkip = (pageNumber - 1) * pageSize;
            return books
                .OrderBy(book => book.CreatedDate)
                .Skip(booksToSkip)
                .Take(pageSize)
                .ToList();
        }
        public List<User> GetAllUsers(int pageNumber, int pageSize)
        {

            if (pageNumber <= 0 || pageSize <= 0)
            {
                throw new ArgumentException("Error: Both pageNumber and pageSize must be positive integers.");
            }
            var usersToSkip = (pageNumber - 1) * pageSize;
            return users
                .OrderBy(user => user.CreatedDate)
                .Skip(usersToSkip)
                .Take(pageSize)
                .ToList();
        }

        public Book? FindBooksByTitle(string title)
        {
            if (string.IsNullOrEmpty(title))
            {
                throw new ArgumentException("Title can not be empty ");
            }
            return books.SingleOrDefault(i => i.Title == title);
        }

        public User? FindUsersByName(string name)
        {
            if (string.IsNullOrEmpty(name))
            {
                throw new ArgumentException("Name can not be empty ");
            }
            return users.SingleOrDefault(i => i.Name == name);

        }
        public void AddBook(Book book)
        {
            if (books.Any(i => i.Title == book.Title))
            {
                throw new Exception("A Book with the same name already exists in the library");
            }

            books.Add(book);
        }

        public void AddUser(User user)
        {
            if (users.Any(i => i.Name == user.Name))
            {
                throw new Exception("A User with the same name already exists in the library");
            }

            users.Add(user);
        }

        public void DeleteBook(Guid id)
        {
            int index = books.FindIndex(b => b.Id == id);

            if (index >= 0)
            {

                books.RemoveAt(index);
                Console.WriteLine($"Book with '{id}' ID deleted successfully");
            }
            else
            {
                throw new KeyNotFoundException($"Book with '{id}' ID not found");
            }
        }

        public void DeleteUser(Guid id)
        {
            int index = users.FindIndex(u => u.Id == id);

            if (index >= 0)
            {

                users.RemoveAt(index);
                Console.WriteLine($"User with '{id}' ID deleted successfully");
            }
            else
            {
                throw new KeyNotFoundException($"User with '{id}' ID not found");
            }
        }

    }

}
