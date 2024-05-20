namespace ClearCanvas.Enterprise.Core.Porting
{
    public class MessageQueue
    {
        private string path;
        private bool sharedModeDenyReceive;
        private bool enableCache;

        public string FormatName { get; private set; }

        public MessageQueue(string path, bool sharedModeDenyReceive, bool enableCache)
        {
            this.path = path;
            this.sharedModeDenyReceive = sharedModeDenyReceive;
            this.enableCache = enableCache;
        }

        public nint ReadHandle { get; internal set; }

        internal static void Create(string path)
        {
            throw new System.NotImplementedException();
        }

        internal static bool Exists(string path)
        {
            throw new System.NotImplementedException();
        }

        protected virtual void Dispose(bool disposing)
        {
            throw new System.NotImplementedException();
        }

        internal MessageEnumerator GetMessageEnumerator2()
        {
            throw new System.NotImplementedException();
        }
    }
}