
using onlineLibraryManagementSystem;

namespace LibraryManagementSystem
{


    internal class Program
    {
        private static void Main()
        {
            var emailService = new EmailNotificationService();
            var smsService = new SMSNotificationService();

            var libraryWithEmail = new Library(emailService);
            var libraryWithSMS = new Library(smsService);
            try
            {
                var user1 = new User("Alice", new DateTime(2023, 1, 1));
                var user2 = new User("Bob", new DateTime(2023, 2, 1));
                var user3 = new User("Charlie", new DateTime(2023, 3, 1));
                var user4 = new User("David", new DateTime(2023, 4, 1));
                var user5 = new User("Eve", new DateTime(2024, 5, 1));
                var user6 = new User("Julia");

                libraryWithEmail.AddUser(user1);
                libraryWithEmail.AddUser(user2);
                libraryWithEmail.AddUser(user3);
                libraryWithSMS.AddUser(user4);
                libraryWithSMS.AddUser(user5);
                libraryWithSMS.AddUser(user6);
              //  libraryWithSMS.AddUser(user6);


                var book1 = new Book("The Great Gatsby", new DateTime(2023, 1, 1));
                var book2 = new Book("1984", new DateTime(2023, 2, 1));
                var book3 = new Book("To Kill a Mockingbird", new DateTime(2023, 3, 1));
                var book4 = new Book("The Divine Comedy", new DateTime(2024, 3, 1));
                var book5 = new Book("Crime and Punishment", new DateTime(2024, 4, 1));
                var book6 = new Book("The Iliad");

                libraryWithEmail.AddBook(book1);
                libraryWithEmail.AddBook(book2);
                libraryWithEmail.AddBook(book3);
                libraryWithSMS.AddBook(book4);
                libraryWithSMS.AddBook(book5);
                libraryWithSMS.AddBook(book6);
              // libraryWithSMS.AddBook(book6);


                Console.WriteLine("\n Users in the library with EMAIL:");

                foreach (var user in libraryWithEmail.GetAllUsers(1, 10))
                {
                    Console.WriteLine($"Name: {user.Name}, Joined: {user.CreatedDate}");
                }

                Console.WriteLine("\n Books in the library with EMAIL:");
                foreach (var book in libraryWithEmail.GetAllBooks(1, 7))
                {
                    Console.WriteLine($"Title: {book.Title}, Created: {book.CreatedDate}");
                }

                Console.WriteLine("\n Users in the library with SMS:");

                foreach (var user in libraryWithSMS.GetAllUsers(1, 10))
                {
                    Console.WriteLine($"Name: {user.Name}, Joined: {user.CreatedDate}");
                }

                Console.WriteLine("\n Books in the library with SMS:");
                foreach (var book in libraryWithSMS.GetAllBooks(1, 7))
                {
                    Console.WriteLine($"Title: {book.Title}, Created: {book.CreatedDate}");
                }

                var userToFind = "Alice";
                var foundUser = libraryWithEmail.FindUsersByName(userToFind);
                Console.WriteLine($"\nFound User: Name: {foundUser.Name}, Joined: {foundUser.CreatedDate}");

                var bookToFind = "1984";
                var foundBook = libraryWithEmail.FindBooksByTitle(bookToFind);
                Console.WriteLine($"Found Book: Title: {foundBook.Title}, Created: {foundBook.CreatedDate}\n");

                var userIdToDelete = user6.Id;
                libraryWithSMS.DeleteUser(userIdToDelete);


                var bookIdToDelete = book5.Id;
                libraryWithSMS.DeleteBook(bookIdToDelete);
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