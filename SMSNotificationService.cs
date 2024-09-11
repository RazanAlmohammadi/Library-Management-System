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
            Console.WriteLine($"SMS error notification  '{message}'. Please email support@library.com.");

        }

        public void SendNotificationOnSuccess(string message)
        {
            Console.WriteLine($"SMS notification '{message}'. Thank you!");

        }
    }
}