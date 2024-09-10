using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace LibraryManagementSystem
{
    public interface INotificationService
    {
        void SendNotificationOnSuccess(string title);
        void SendNotificationOnFailure(string title);
    }
}