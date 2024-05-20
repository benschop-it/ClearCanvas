using System;
using System.Collections.Generic;
using System.Linq;
using System.ServiceModel.Channels;
using System.ServiceModel.Description;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Web.Services.Description;

namespace ClearCanvas.Enterprise.Common.Porting {
    public class ServiceHost : CoreWCF.ServiceHostBase {

        public ServiceHost(Type type, Uri uri) {
        }

        public ServiceEndpoint AddServiceEndpoint(Type implementedContract, System.ServiceModel.Channels.Binding binding, string address) {
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
    }
}
