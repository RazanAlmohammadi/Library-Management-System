using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using LibraryManagementSystem;

namespace onlineLibraryManagementSystem
{
    public class EmailNotificationService : INotificationService
    {
        public void SendNotificationOnFailure(string title)
        {
            Console.WriteLine($"Hello, a new book titled '{title}' has been successfully added to the Library." +
            "If you have any queries or feedback, please contact our support team at support@library.com.");

        }

        public void SendNotificationOnSuccess(string title)
        {
            Console.WriteLine($"We encountered an issue adding 'ABC'." +
            "Please review the input data. For more help, visit our FAQ at library.com/faq.");

        }
    }
}