using CoreWCF.Channels;

namespace ClearCanvas.Server.ShredHost.Porting
{
    public class NetNamedPipeBinding : Binding {
        private string configurationName;

        public NetNamedPipeBinding() {
        }

        public NetNamedPipeBinding(string configurationName) {
            this.configurationName = configurationName;
        }

        public override string Scheme => throw new System.NotImplementedException();

        public override BindingElementCollection CreateBindingElements() {
            throw new System.NotImplementedException();
        }
    }
}