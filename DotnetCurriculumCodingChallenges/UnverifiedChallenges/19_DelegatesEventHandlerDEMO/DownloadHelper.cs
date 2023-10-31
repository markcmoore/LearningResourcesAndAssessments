using System;
using System.Threading;

namespace _19_DelegatesEventHandlerDEMO
{
    public class DownloadHelper
    {
        // // Step 1 - create a delegate (this is a custome one below there is the .NEt provided one.)
        // public delegate void FileDownloadedEventHandler(object source, FileEventArgs args); // FileEventArgs is our custom EvenetArgs.
       
        // // Step 2 - Create an event of the Delegate Type.
        // public event FileDownloadedEventHandler FileDownloaded;

        //Steps 1 and 2 (Thank you .NET) - The below replaces the two above steps.
        public event EventHandler<FileEventArgs> FileDownloaded;

        //Step 3 - Raise the event with a method
        protected virtual void OnFileDownloaded(File file)
        {
            //check if there are subscribers. The event is null till someone subscribes
            if(FileDownloaded != null)
            {
                //'this' means the object itself. Here that's this DownloaHelper Class.
                FileDownloaded(this, new FileEventArgs() {File = file});
            }
        }


        public void Download(File file)
        {
            System.Console.WriteLine("downloading the file....");
            Thread.Sleep(4000);

            //Step 3.1 - Raise (Trigger) the event
            OnFileDownloaded(file);


        }

        
        
    }
}