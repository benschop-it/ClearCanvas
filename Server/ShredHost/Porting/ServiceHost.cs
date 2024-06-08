using CoreWCF.Channels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.ServiceModel.Description;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace ClearCanvas.Server.ShredHost.Porting {
    public class ServiceHost : CoreWCF.ServiceHostBase {
        private Type type;

        public ServiceHost(Type type) {
            this.type = type;
        }

        public ServiceHost(Type type, Uri uri) {
        }

        public ServiceEndpoint AddServiceEndpoint(Type implementedContract, Binding binding, string address) {
            return AddServiceEndpoint(implementedContract, binding, address);
        }

        protected override CoreWCF.Description.ServiceDescription CreateDescription(out IDictionary<string, CoreWCF.Description.ContractDescription> implementedContracts) {
            throw new NotImplementedException();
        }

        protected override void OnAbort() {
            throw new NotImplementedException();
        }

        protected override Task OnCloseAsync(CancellationToken token) {
            throw new NotImplementedException();
        }

        protected override Task OnOpenAsync(CancellationToken token) {
            throw new NotImplementedException();
        }

        internal void Close() {
            throw new NotImplementedException();
        }

        internal void Open() {
            throw new NotImplementedException();
        }
    }
}
