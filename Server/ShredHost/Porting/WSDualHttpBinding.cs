using CoreWCF.Channels;

namespace ClearCanvas.Server.ShredHost.Porting
{
    public class WSDualHttpBinding : Binding {
        private string configurationName;

        public WSDualHttpBinding() {
        }

        public WSDualHttpBinding(string configurationName) {
            this.configurationName = configurationName;
        }

        public override string Scheme => throw new System.NotImplementedException();

        public override BindingElementCollection CreateBindingElements() {
            throw new System.NotImplementedException();
        }
    }
}