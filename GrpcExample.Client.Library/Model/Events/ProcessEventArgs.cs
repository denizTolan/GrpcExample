using System;

namespace GrpcExample.Client.Library.Model.Events
{
    public class ProcessEventArgs : EventArgs
    {
        public bool IsSuccessful { get; set; }
        public DateTime CompletionTime { get; set; }
    }
}