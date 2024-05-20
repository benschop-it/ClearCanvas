using CoreWCF;
using CoreWCF.Channels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.ServiceModel;
using System.Text;
using System.Threading.Tasks;
using EndpointAddress = System.ServiceModel.EndpointAddress;

namespace ClearCanvas.Enterprise.Common.Porting {
    public class DuplexChannelFactory<TChannel> : ChannelFactory<TChannel> {
        public DuplexChannelFactory(Type callbackInstanceType) : this((object)callbackInstanceType) {
        }

        public DuplexChannelFactory(object callbackObject) : base(typeof(TChannel)) {
        }

        public DuplexChannelFactory(object callbackObject, Binding binding) : this(callbackObject, binding, (EndpointAddress)null) {
        }

        public DuplexChannelFactory(object callbackObject, Binding binding, EndpointAddress remoteAddress) : base(typeof(TChannel)) {
        }

        public DuplexChannelFactory(object callbackObject, Binding binding, string remoteAddress) : this(callbackObject, binding, new EndpointAddress(remoteAddress)) {
        }

        public DuplexChannelFactory(object callbackObject, string endpointConfigurationName) : this(callbackObject, endpointConfigurationName, (EndpointAddress)null) {
        }

        public DuplexChannelFactory(object callbackObject, string endpointConfigurationName, EndpointAddress remoteAddress) : base(typeof(TChannel)) {
        }

    }
}
