using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using LibraryManagementSystem;

namespace onlineLibraryManagementSystem
{
    public class SMSNotificationService : INotificationService
    {
        public void SendNotificationOnFailure(string message)
        {
            Console.WriteLine($"\n SMS error notification Error adding '{message}'. Please email support@library.com.");

        }

        public void SendNotificationOnSuccess(string message)
        {
            Console.WriteLine($"\n SMS notification'{message}'added to Library. Thank you!");

        }
    }
}