using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClearCanvas.Enterprise.Common.Porting {
    public interface IOnlineStatus {
        //
        // Summary:
        //     Gets whether the instance has network connectivity and is connected to a resource.
        //
        //
        // Returns:
        //     True if the current instance is available on the network; false if it is not.
        bool IsOnline { get; }

        //
        // Summary:
        //     Signals that the instance has disconnected from a network resource.
        event EventHandler Offline;

        //
        // Summary:
        //     Signals that the instance has connected to a network resource.
        event EventHandler Online;
    }
}
