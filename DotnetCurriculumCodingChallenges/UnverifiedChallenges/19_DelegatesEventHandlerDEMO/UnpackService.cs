using System;

namespace _19_DelegatesEventHandlerDEMO
{
    public class UnpackService
    {
        public void OnFileDownloaded(object source, FileEventArgs eventArgs)
        {
            System.Console.WriteLine($"UnpackerService: Unpacking the file... Its title is => '{eventArgs.File.Title}'");
        }
    }
}