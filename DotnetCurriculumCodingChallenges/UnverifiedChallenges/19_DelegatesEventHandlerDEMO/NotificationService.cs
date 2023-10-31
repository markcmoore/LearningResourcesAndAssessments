using System;

namespace _19_DelegatesEventHandlerDEMO
{
    public class NotificationService
    {
        public void OnFileDownloaded(object source, FileEventArgs e)
        {
            System.Console.WriteLine($"NotificationService is notifying...title is => '{e.File.Title}'");
        }
    }
}