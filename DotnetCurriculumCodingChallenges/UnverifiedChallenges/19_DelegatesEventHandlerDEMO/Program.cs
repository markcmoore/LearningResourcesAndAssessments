using System;

namespace _19_DelegatesEventHandlerDEMO
{
    class Program
    {
        static void Main(string[] args)
        {
            //Console.WriteLine("Hello World!");

            var file = new File() { Title = "File 1" };

            // objects to subscribe to the event.
            var downloadHelper = new DownloadHelper();//this is the publisher of the event
            var unpackService = new UnpackService(); // this is the receiver of the file.
            var notificationService = new NotificationService();

            //subscribe methods from the objects above to be called whent he event is triggered. 
            // They are now listeners
            downloadHelper.FileDownloaded += unpackService.OnFileDownloaded;//add the method as a pointer by not using the ()
            downloadHelper.FileDownloaded += notificationService.OnFileDownloaded;
            //send the sample file object to the method to trigger the event
            downloadHelper.Download(file);

        }
    }
}
