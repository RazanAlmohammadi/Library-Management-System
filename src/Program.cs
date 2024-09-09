
namespace LibraryManagementSystem
{


    internal class Program
    {
        private static void Main()
        {
            Library library = new Library();
            try
            {
                var user1 = new User("Alice", new DateTime(2023, 1, 1));
                var user2 = new User("Bob", new DateTime(2023, 2, 1));
                var user3 = new User("Charlie", new DateTime(2023, 3, 1));
                var user4 = new User("David", new DateTime(2023, 4, 1));
                var user5 = new User("Eve", new DateTime(2024, 5, 1));
                var user6 = new User("Fiona", new DateTime(2024, 6, 1));
                var user7 = new User("George", new DateTime(2024, 7, 1));
                var user8 = new User("Hannah", new DateTime(2024, 8, 1));
                var user9 = new User("Ian");
                var user10 = new User("Julia");

                library.AddUser(user1);
                library.AddUser(user2);
                library.AddUser(user3);
                library.AddUser(user4);
                library.AddUser(user5);
                library.AddUser(user6);
                library.AddUser(user7);
                library.AddUser(user8);
                library.AddUser(user9);
                library.AddUser(user10);

                var book1 = new Book("The Great Gatsby", new DateTime(2023, 1, 1));
                var book2 = new Book("1984", new DateTime(2023, 2, 1));
                var book3 = new Book("To Kill a Mockingbird", new DateTime(2023, 3, 1));
                var book4 = new Book("The Divine Comedy", new DateTime(2024, 3, 1));
                var book5 = new Book("Crime and Punishment", new DateTime(2024, 4, 1));
                var book6 = new Book("The Brothers Karamazov", new DateTime(2024, 5, 1));
                var book7 = new Book("Don Quixote", new DateTime(2024, 6, 1));
                var book8 = new Book("The Iliad");
                var book9 = new Book("Anna Karenina");

                library.AddBook(book1);
                library.AddBook(book2);
                library.AddBook(book3);
                library.AddBook(book4);
                library.AddBook(book5);
                library.AddBook(book6);
                library.AddBook(book7);
                library.AddBook(book8);
                library.AddBook(book9);

                Console.WriteLine("Users in the library:");

                foreach (var user in library.GetAllUsers(1, 5))
                {
                    Console.WriteLine($"Name: {user.Name}, Joined: {user.CreatedDate}");
                }

                Console.WriteLine("Books in the library:");
                foreach (var book in library.GetAllBooks(1, 7))
                {
                    Console.WriteLine($"Title: {book.Title}, Created: {book.CreatedDate}");
                }
                var userToFind = "Alice";
                var foundUser = library.FindUsersByName(userToFind);
                Console.WriteLine($"\nFound User: Name: {foundUser.Name}, Joined: {foundUser.CreatedDate}");

                var bookToFind = "1984";
                var foundBook = library.FindBooksByTitle(bookToFind);
                Console.WriteLine($"\nFound Book: Title: {foundBook.Title}, Created: {foundBook.CreatedDate}");

                var userIdToDelete = user9.Id;
                library.DeleteUser(userIdToDelete);


                var bookIdToDelete = book8.Id;
                library.DeleteBook(bookIdToDelete);
            }

            catch (ArgumentException ex)
            {
                Console.WriteLine($"Error : {ex.Message}");

            }
            catch (KeyNotFoundException ex)
            {
                Console.WriteLine($"Error : {ex.Message}");
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error : {ex.Message}");
            }
        }
    }
}