using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using LibraryManagementSystem;

namespace onlineLibraryManagementSystem
{
    public class SMSNotificationService : INotificationService
    {
        public void SendNotificationOnFailure(string title)
        {
            Console.WriteLine($"Error adding User '{title}'. Please email support@library.com.");

        }

        public void SendNotificationOnSuccess(string title)
        {
            Console.WriteLine($"Book '{title}' added to Library. Thank you!");

        }
    }
}