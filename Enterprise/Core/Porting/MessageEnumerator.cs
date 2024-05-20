using System;
using System.Collections;

namespace ClearCanvas.Enterprise.Core.Porting
{
    internal class MessageEnumerator : MarshalByRefObject, IEnumerator, IDisposable
    {
        public Message Current => throw new NotImplementedException();

        object IEnumerator.Current => throw new NotImplementedException();

        public void Dispose()
        {
            throw new NotImplementedException();
        }

        public bool MoveNext()
        {
            throw new NotImplementedException();
        }

        public void Reset()
        {
            throw new NotImplementedException();
        }
    }
}