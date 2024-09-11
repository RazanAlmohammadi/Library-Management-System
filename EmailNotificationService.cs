using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using LibraryManagementSystem;

namespace onlineLibraryManagementSystem
{
    public class EmailNotificationService : INotificationService
    {
        public void SendNotificationOnFailure(string message)
        {
            Console.WriteLine($"\n ERORR email notification : We encountered an issue adding'{message}'."+
             "For more help, visit our FAQ at library.com/faq");
        }

        public void SendNotificationOnSuccess(string message)
        {
            Console.WriteLine($"\n Email notification : Hello,'{message}' has been successfully added to the Library" +
             "If you have any queries or feedback, please contact our support team at support@library.com.");
        }
        }
}