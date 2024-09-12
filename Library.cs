using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using onlineLibraryManagementSystem;

namespace LibraryManagementSystem
{
    public class Library
    {
        private List<Book> _books = new List<Book>();
        private List<User> _users = new List<User>();
        private INotificationService _notificationService;

        public Library(INotificationService notificationService)
        {
            _notificationService = notificationService;
        }



        public List<Book> GetAllBooks(int pageNumber, int pageSize)
        {
            if (pageNumber <= 0 || pageSize <= 0)
            {
                throw new ArgumentException("Error: Both pageNumber and pageSize must be positive integers.");
            }

            var booksToSkip = (pageNumber - 1) * pageSize;
            return _books
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
            return _users
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
            return _books.SingleOrDefault(i => i.Title == title);
        }

        public User? FindUsersByName(string name)
        {
            if (string.IsNullOrEmpty(name))
            {
                throw new ArgumentException("Name can not be empty ");
            }
            return _users.SingleOrDefault(i => i.Name == name);

        }
        public void AddBook(Book book)
        {
            if (_books.Any(i => i.Title == book.Title))
            {
                _notificationService.SendNotificationOnFailure($"{book.Title}");
                throw new Exception("A Book with the same name already exists in the library");

            }

            _books.Add(book);
            _notificationService.SendNotificationOnSuccess($"{book.Title}");
        }

        public void AddUser(User user)
        {
            if (_users.Any(i => i.Name == user.Name))
            {
                _notificationService.SendNotificationOnFailure($"{user.Name}");
                throw new Exception("A User with the same name already exists in the library");

            }

            _users.Add(user);
            _notificationService.SendNotificationOnSuccess($"'{user.Name}'");

        }

        public void DeleteBook(Guid id)
        {
            int index = _books.FindIndex(b => b.Id == id);

            if (index >= 0)
            {

                _books.RemoveAt(index);
                Console.WriteLine($" Book with '{id}' ID deleted successfully");
            }
            else
            {
                throw new KeyNotFoundException($"Book with '{id}' ID not found");
            }
        }

        public void DeleteUser(Guid id)
        {
            int index = _users.FindIndex(u => u.Id == id);

            if (index >= 0)
            {

                _users.RemoveAt(index);
                Console.WriteLine($"User with '{id}' ID deleted successfully");
            }
            else
            {
                throw new KeyNotFoundException($"User with '{id}' ID not found");
            }
        }
        public void BorrowBook(Guid bookId, Guid userId,int days )
        {
            var book = _books.SingleOrDefault(b => b.Id == bookId);
            var user = _users.SingleOrDefault(u => u.Id == userId);
           var curentDate= DateTime.Now;
           var returnDate=curentDate.AddDays(days);
            if (user == null)
            {
                throw new Exception("the user not found");
            }
            if(book == null)
            {
                throw new Exception("the book not found");
            }
            if (book.IsBorrowed)
            {
                throw new Exception($"The book '{book.Title}' is already borrowed by '{book.BorrowedBy}'.");
            }
            book.Borrow(user.Name);  
            Console.WriteLine($"Book '{book.Title}' has been borrowed by '{user.Name}'on '{curentDate}. Due Date is '{returnDate}");
            
            
        }

    }

}


