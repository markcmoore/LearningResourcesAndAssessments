using System;

namespace _19_DelegatesEventHandlerDEMO
{
    // This class inherits EventArgs so that we can have a customs EventArgs to send.
    //It will have more information that we can use in the program
    public class FileEventArgs : EventArgs
    {
        public File File { get; set; }
    }
}