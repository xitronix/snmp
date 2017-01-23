﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace App.ServiceReference {
    using System.Runtime.Serialization;
    
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Runtime.Serialization", "4.0.0.0")]
    [System.Runtime.Serialization.DataContractAttribute(Name="SnmpTypeObject", Namespace="http://schemas.datacontract.org/2004/07/SnmpService")]
    public partial class SnmpTypeObject : object, System.ComponentModel.INotifyPropertyChanged {
        
        private string OidField;
        
        private string TypeField;
        
        private string ValueField;
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string Oid {
            get {
                return this.OidField;
            }
            set {
                if ((object.ReferenceEquals(this.OidField, value) != true)) {
                    this.OidField = value;
                    this.RaisePropertyChanged("Oid");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string Type {
            get {
                return this.TypeField;
            }
            set {
                if ((object.ReferenceEquals(this.TypeField, value) != true)) {
                    this.TypeField = value;
                    this.RaisePropertyChanged("Type");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string Value {
            get {
                return this.ValueField;
            }
            set {
                if ((object.ReferenceEquals(this.ValueField, value) != true)) {
                    this.ValueField = value;
                    this.RaisePropertyChanged("Value");
                }
            }
        }
        
        public event System.ComponentModel.PropertyChangedEventHandler PropertyChanged;
        
        protected void RaisePropertyChanged(string propertyName) {
            System.ComponentModel.PropertyChangedEventHandler propertyChanged = this.PropertyChanged;
            if ((propertyChanged != null)) {
                propertyChanged(this, new System.ComponentModel.PropertyChangedEventArgs(propertyName));
            }
        }
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ServiceModel.ServiceContractAttribute(ConfigurationName="ServiceReference.ISnmpService")]
    public interface ISnmpService {
        
        [System.ServiceModel.OperationContractAttribute(AsyncPattern=true, Action="http://tempuri.org/ISnmpService/Get", ReplyAction="http://tempuri.org/ISnmpService/GetResponse")]
        System.IAsyncResult BeginGet(App.ServiceReference.SnmpTypeObject snmpObject, System.AsyncCallback callback, object asyncState);
        
        App.ServiceReference.SnmpTypeObject EndGet(System.IAsyncResult result);
        
        [System.ServiceModel.OperationContractAttribute(AsyncPattern=true, Action="http://tempuri.org/ISnmpService/GetString", ReplyAction="http://tempuri.org/ISnmpService/GetStringResponse")]
        System.IAsyncResult BeginGetString(string jakisString, System.AsyncCallback callback, object asyncState);
        
        string EndGetString(System.IAsyncResult result);
        
        [System.ServiceModel.OperationContractAttribute(AsyncPattern=true, Action="http://tempuri.org/ISnmpService/GetDataUsingDataContract", ReplyAction="http://tempuri.org/ISnmpService/GetDataUsingDataContractResponse")]
        System.IAsyncResult BeginGetDataUsingDataContract(App.ServiceReference.SnmpTypeObject snmp, System.AsyncCallback callback, object asyncState);
        
        App.ServiceReference.SnmpTypeObject EndGetDataUsingDataContract(System.IAsyncResult result);
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public interface ISnmpServiceChannel : App.ServiceReference.ISnmpService, System.ServiceModel.IClientChannel {
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public partial class GetCompletedEventArgs : System.ComponentModel.AsyncCompletedEventArgs {
        
        private object[] results;
        
        public GetCompletedEventArgs(object[] results, System.Exception exception, bool cancelled, object userState) : 
                base(exception, cancelled, userState) {
            this.results = results;
        }
        
        public App.ServiceReference.SnmpTypeObject Result {
            get {
                base.RaiseExceptionIfNecessary();
                return ((App.ServiceReference.SnmpTypeObject)(this.results[0]));
            }
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public partial class GetStringCompletedEventArgs : System.ComponentModel.AsyncCompletedEventArgs {
        
        private object[] results;
        
        public GetStringCompletedEventArgs(object[] results, System.Exception exception, bool cancelled, object userState) : 
                base(exception, cancelled, userState) {
            this.results = results;
        }
        
        public string Result {
            get {
                base.RaiseExceptionIfNecessary();
                return ((string)(this.results[0]));
            }
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public partial class GetDataUsingDataContractCompletedEventArgs : System.ComponentModel.AsyncCompletedEventArgs {
        
        private object[] results;
        
        public GetDataUsingDataContractCompletedEventArgs(object[] results, System.Exception exception, bool cancelled, object userState) : 
                base(exception, cancelled, userState) {
            this.results = results;
        }
        
        public App.ServiceReference.SnmpTypeObject Result {
            get {
                base.RaiseExceptionIfNecessary();
                return ((App.ServiceReference.SnmpTypeObject)(this.results[0]));
            }
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public partial class SnmpServiceClient : System.ServiceModel.ClientBase<App.ServiceReference.ISnmpService>, App.ServiceReference.ISnmpService {
        
        private BeginOperationDelegate onBeginGetDelegate;
        
        private EndOperationDelegate onEndGetDelegate;
        
        private System.Threading.SendOrPostCallback onGetCompletedDelegate;
        
        private BeginOperationDelegate onBeginGetStringDelegate;
        
        private EndOperationDelegate onEndGetStringDelegate;
        
        private System.Threading.SendOrPostCallback onGetStringCompletedDelegate;
        
        private BeginOperationDelegate onBeginGetDataUsingDataContractDelegate;
        
        private EndOperationDelegate onEndGetDataUsingDataContractDelegate;
        
        private System.Threading.SendOrPostCallback onGetDataUsingDataContractCompletedDelegate;
        
        private BeginOperationDelegate onBeginOpenDelegate;
        
        private EndOperationDelegate onEndOpenDelegate;
        
        private System.Threading.SendOrPostCallback onOpenCompletedDelegate;
        
        private BeginOperationDelegate onBeginCloseDelegate;
        
        private EndOperationDelegate onEndCloseDelegate;
        
        private System.Threading.SendOrPostCallback onCloseCompletedDelegate;
        
        public SnmpServiceClient() : 
                base(SnmpServiceClient.GetDefaultBinding(), SnmpServiceClient.GetDefaultEndpointAddress()) {
        }
        
        public SnmpServiceClient(EndpointConfiguration endpointConfiguration) : 
                base(SnmpServiceClient.GetBindingForEndpoint(endpointConfiguration), SnmpServiceClient.GetEndpointAddress(endpointConfiguration)) {
        }
        
        public SnmpServiceClient(EndpointConfiguration endpointConfiguration, string remoteAddress) : 
                base(SnmpServiceClient.GetBindingForEndpoint(endpointConfiguration), new System.ServiceModel.EndpointAddress(remoteAddress)) {
        }
        
        public SnmpServiceClient(EndpointConfiguration endpointConfiguration, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(SnmpServiceClient.GetBindingForEndpoint(endpointConfiguration), remoteAddress) {
        }
        
        public SnmpServiceClient(System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(binding, remoteAddress) {
        }
        
        public System.Net.CookieContainer CookieContainer {
            get {
                System.ServiceModel.Channels.IHttpCookieContainerManager httpCookieContainerManager = this.InnerChannel.GetProperty<System.ServiceModel.Channels.IHttpCookieContainerManager>();
                if ((httpCookieContainerManager != null)) {
                    return httpCookieContainerManager.CookieContainer;
                }
                else {
                    return null;
                }
            }
            set {
                System.ServiceModel.Channels.IHttpCookieContainerManager httpCookieContainerManager = this.InnerChannel.GetProperty<System.ServiceModel.Channels.IHttpCookieContainerManager>();
                if ((httpCookieContainerManager != null)) {
                    httpCookieContainerManager.CookieContainer = value;
                }
                else {
                    throw new System.InvalidOperationException("Unable to set the CookieContainer. Please make sure the binding contains an HttpC" +
                            "ookieContainerBindingElement.");
                }
            }
        }
        
        public event System.EventHandler<GetCompletedEventArgs> GetCompleted;
        
        public event System.EventHandler<GetStringCompletedEventArgs> GetStringCompleted;
        
        public event System.EventHandler<GetDataUsingDataContractCompletedEventArgs> GetDataUsingDataContractCompleted;
        
        public event System.EventHandler<System.ComponentModel.AsyncCompletedEventArgs> OpenCompleted;
        
        public event System.EventHandler<System.ComponentModel.AsyncCompletedEventArgs> CloseCompleted;
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        System.IAsyncResult App.ServiceReference.ISnmpService.BeginGet(App.ServiceReference.SnmpTypeObject snmpObject, System.AsyncCallback callback, object asyncState) {
            return base.Channel.BeginGet(snmpObject, callback, asyncState);
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        App.ServiceReference.SnmpTypeObject App.ServiceReference.ISnmpService.EndGet(System.IAsyncResult result) {
            return base.Channel.EndGet(result);
        }
        
        private System.IAsyncResult OnBeginGet(object[] inValues, System.AsyncCallback callback, object asyncState) {
            App.ServiceReference.SnmpTypeObject snmpObject = ((App.ServiceReference.SnmpTypeObject)(inValues[0]));
            return ((App.ServiceReference.ISnmpService)(this)).BeginGet(snmpObject, callback, asyncState);
        }
        
        private object[] OnEndGet(System.IAsyncResult result) {
            App.ServiceReference.SnmpTypeObject retVal = ((App.ServiceReference.ISnmpService)(this)).EndGet(result);
            return new object[] {
                    retVal};
        }
        
        private void OnGetCompleted(object state) {
            if ((this.GetCompleted != null)) {
                InvokeAsyncCompletedEventArgs e = ((InvokeAsyncCompletedEventArgs)(state));
                this.GetCompleted(this, new GetCompletedEventArgs(e.Results, e.Error, e.Cancelled, e.UserState));
            }
        }
        
        public void GetAsync(App.ServiceReference.SnmpTypeObject snmpObject) {
            this.GetAsync(snmpObject, null);
        }
        
        public void GetAsync(App.ServiceReference.SnmpTypeObject snmpObject, object userState) {
            if ((this.onBeginGetDelegate == null)) {
                this.onBeginGetDelegate = new BeginOperationDelegate(this.OnBeginGet);
            }
            if ((this.onEndGetDelegate == null)) {
                this.onEndGetDelegate = new EndOperationDelegate(this.OnEndGet);
            }
            if ((this.onGetCompletedDelegate == null)) {
                this.onGetCompletedDelegate = new System.Threading.SendOrPostCallback(this.OnGetCompleted);
            }
            base.InvokeAsync(this.onBeginGetDelegate, new object[] {
                        snmpObject}, this.onEndGetDelegate, this.onGetCompletedDelegate, userState);
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        System.IAsyncResult App.ServiceReference.ISnmpService.BeginGetString(string jakisString, System.AsyncCallback callback, object asyncState) {
            return base.Channel.BeginGetString(jakisString, callback, asyncState);
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        string App.ServiceReference.ISnmpService.EndGetString(System.IAsyncResult result) {
            return base.Channel.EndGetString(result);
        }
        
        private System.IAsyncResult OnBeginGetString(object[] inValues, System.AsyncCallback callback, object asyncState) {
            string jakisString = ((string)(inValues[0]));
            return ((App.ServiceReference.ISnmpService)(this)).BeginGetString(jakisString, callback, asyncState);
        }
        
        private object[] OnEndGetString(System.IAsyncResult result) {
            string retVal = ((App.ServiceReference.ISnmpService)(this)).EndGetString(result);
            return new object[] {
                    retVal};
        }
        
        private void OnGetStringCompleted(object state) {
            if ((this.GetStringCompleted != null)) {
                InvokeAsyncCompletedEventArgs e = ((InvokeAsyncCompletedEventArgs)(state));
                this.GetStringCompleted(this, new GetStringCompletedEventArgs(e.Results, e.Error, e.Cancelled, e.UserState));
            }
        }
        
        public void GetStringAsync(string jakisString) {
            this.GetStringAsync(jakisString, null);
        }
        
        public void GetStringAsync(string jakisString, object userState) {
            if ((this.onBeginGetStringDelegate == null)) {
                this.onBeginGetStringDelegate = new BeginOperationDelegate(this.OnBeginGetString);
            }
            if ((this.onEndGetStringDelegate == null)) {
                this.onEndGetStringDelegate = new EndOperationDelegate(this.OnEndGetString);
            }
            if ((this.onGetStringCompletedDelegate == null)) {
                this.onGetStringCompletedDelegate = new System.Threading.SendOrPostCallback(this.OnGetStringCompleted);
            }
            base.InvokeAsync(this.onBeginGetStringDelegate, new object[] {
                        jakisString}, this.onEndGetStringDelegate, this.onGetStringCompletedDelegate, userState);
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        System.IAsyncResult App.ServiceReference.ISnmpService.BeginGetDataUsingDataContract(App.ServiceReference.SnmpTypeObject snmp, System.AsyncCallback callback, object asyncState) {
            return base.Channel.BeginGetDataUsingDataContract(snmp, callback, asyncState);
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        App.ServiceReference.SnmpTypeObject App.ServiceReference.ISnmpService.EndGetDataUsingDataContract(System.IAsyncResult result) {
            return base.Channel.EndGetDataUsingDataContract(result);
        }
        
        private System.IAsyncResult OnBeginGetDataUsingDataContract(object[] inValues, System.AsyncCallback callback, object asyncState) {
            App.ServiceReference.SnmpTypeObject snmp = ((App.ServiceReference.SnmpTypeObject)(inValues[0]));
            return ((App.ServiceReference.ISnmpService)(this)).BeginGetDataUsingDataContract(snmp, callback, asyncState);
        }
        
        private object[] OnEndGetDataUsingDataContract(System.IAsyncResult result) {
            App.ServiceReference.SnmpTypeObject retVal = ((App.ServiceReference.ISnmpService)(this)).EndGetDataUsingDataContract(result);
            return new object[] {
                    retVal};
        }
        
        private void OnGetDataUsingDataContractCompleted(object state) {
            if ((this.GetDataUsingDataContractCompleted != null)) {
                InvokeAsyncCompletedEventArgs e = ((InvokeAsyncCompletedEventArgs)(state));
                this.GetDataUsingDataContractCompleted(this, new GetDataUsingDataContractCompletedEventArgs(e.Results, e.Error, e.Cancelled, e.UserState));
            }
        }
        
        public void GetDataUsingDataContractAsync(App.ServiceReference.SnmpTypeObject snmp) {
            this.GetDataUsingDataContractAsync(snmp, null);
        }
        
        public void GetDataUsingDataContractAsync(App.ServiceReference.SnmpTypeObject snmp, object userState) {
            if ((this.onBeginGetDataUsingDataContractDelegate == null)) {
                this.onBeginGetDataUsingDataContractDelegate = new BeginOperationDelegate(this.OnBeginGetDataUsingDataContract);
            }
            if ((this.onEndGetDataUsingDataContractDelegate == null)) {
                this.onEndGetDataUsingDataContractDelegate = new EndOperationDelegate(this.OnEndGetDataUsingDataContract);
            }
            if ((this.onGetDataUsingDataContractCompletedDelegate == null)) {
                this.onGetDataUsingDataContractCompletedDelegate = new System.Threading.SendOrPostCallback(this.OnGetDataUsingDataContractCompleted);
            }
            base.InvokeAsync(this.onBeginGetDataUsingDataContractDelegate, new object[] {
                        snmp}, this.onEndGetDataUsingDataContractDelegate, this.onGetDataUsingDataContractCompletedDelegate, userState);
        }
        
        private System.IAsyncResult OnBeginOpen(object[] inValues, System.AsyncCallback callback, object asyncState) {
            return ((System.ServiceModel.ICommunicationObject)(this)).BeginOpen(callback, asyncState);
        }
        
        private object[] OnEndOpen(System.IAsyncResult result) {
            ((System.ServiceModel.ICommunicationObject)(this)).EndOpen(result);
            return null;
        }
        
        private void OnOpenCompleted(object state) {
            if ((this.OpenCompleted != null)) {
                InvokeAsyncCompletedEventArgs e = ((InvokeAsyncCompletedEventArgs)(state));
                this.OpenCompleted(this, new System.ComponentModel.AsyncCompletedEventArgs(e.Error, e.Cancelled, e.UserState));
            }
        }
        
        public void OpenAsync() {
            this.OpenAsync(null);
        }
        
        public void OpenAsync(object userState) {
            if ((this.onBeginOpenDelegate == null)) {
                this.onBeginOpenDelegate = new BeginOperationDelegate(this.OnBeginOpen);
            }
            if ((this.onEndOpenDelegate == null)) {
                this.onEndOpenDelegate = new EndOperationDelegate(this.OnEndOpen);
            }
            if ((this.onOpenCompletedDelegate == null)) {
                this.onOpenCompletedDelegate = new System.Threading.SendOrPostCallback(this.OnOpenCompleted);
            }
            base.InvokeAsync(this.onBeginOpenDelegate, null, this.onEndOpenDelegate, this.onOpenCompletedDelegate, userState);
        }
        
        private System.IAsyncResult OnBeginClose(object[] inValues, System.AsyncCallback callback, object asyncState) {
            return ((System.ServiceModel.ICommunicationObject)(this)).BeginClose(callback, asyncState);
        }
        
        private object[] OnEndClose(System.IAsyncResult result) {
            ((System.ServiceModel.ICommunicationObject)(this)).EndClose(result);
            return null;
        }
        
        private void OnCloseCompleted(object state) {
            if ((this.CloseCompleted != null)) {
                InvokeAsyncCompletedEventArgs e = ((InvokeAsyncCompletedEventArgs)(state));
                this.CloseCompleted(this, new System.ComponentModel.AsyncCompletedEventArgs(e.Error, e.Cancelled, e.UserState));
            }
        }
        
        public void CloseAsync() {
            this.CloseAsync(null);
        }
        
        public void CloseAsync(object userState) {
            if ((this.onBeginCloseDelegate == null)) {
                this.onBeginCloseDelegate = new BeginOperationDelegate(this.OnBeginClose);
            }
            if ((this.onEndCloseDelegate == null)) {
                this.onEndCloseDelegate = new EndOperationDelegate(this.OnEndClose);
            }
            if ((this.onCloseCompletedDelegate == null)) {
                this.onCloseCompletedDelegate = new System.Threading.SendOrPostCallback(this.OnCloseCompleted);
            }
            base.InvokeAsync(this.onBeginCloseDelegate, null, this.onEndCloseDelegate, this.onCloseCompletedDelegate, userState);
        }
        
        protected override App.ServiceReference.ISnmpService CreateChannel() {
            return new SnmpServiceClientChannel(this);
        }
        
        private static System.ServiceModel.Channels.Binding GetBindingForEndpoint(EndpointConfiguration endpointConfiguration) {
            if ((endpointConfiguration == EndpointConfiguration.BasicHttpBinding_ISnmpService)) {
                System.ServiceModel.BasicHttpBinding result = new System.ServiceModel.BasicHttpBinding();
                result.MaxBufferSize = int.MaxValue;
                result.MaxReceivedMessageSize = int.MaxValue;
                return result;
            }
            throw new System.InvalidOperationException(string.Format("Could not find endpoint with name \'{0}\'.", endpointConfiguration));
        }
        
        private static System.ServiceModel.EndpointAddress GetEndpointAddress(EndpointConfiguration endpointConfiguration) {
            if ((endpointConfiguration == EndpointConfiguration.BasicHttpBinding_ISnmpService)) {
                return new System.ServiceModel.EndpointAddress("http://localhost:54002/SnmpService.svc");
            }
            throw new System.InvalidOperationException(string.Format("Could not find endpoint with name \'{0}\'.", endpointConfiguration));
        }
        
        private static System.ServiceModel.Channels.Binding GetDefaultBinding() {
            return SnmpServiceClient.GetBindingForEndpoint(EndpointConfiguration.BasicHttpBinding_ISnmpService);
        }
        
        private static System.ServiceModel.EndpointAddress GetDefaultEndpointAddress() {
            return SnmpServiceClient.GetEndpointAddress(EndpointConfiguration.BasicHttpBinding_ISnmpService);
        }
        
        private class SnmpServiceClientChannel : ChannelBase<App.ServiceReference.ISnmpService>, App.ServiceReference.ISnmpService {
            
            public SnmpServiceClientChannel(System.ServiceModel.ClientBase<App.ServiceReference.ISnmpService> client) : 
                    base(client) {
            }
            
            public System.IAsyncResult BeginGet(App.ServiceReference.SnmpTypeObject snmpObject, System.AsyncCallback callback, object asyncState) {
                object[] _args = new object[1];
                _args[0] = snmpObject;
                System.IAsyncResult _result = base.BeginInvoke("Get", _args, callback, asyncState);
                return _result;
            }
            
            public App.ServiceReference.SnmpTypeObject EndGet(System.IAsyncResult result) {
                object[] _args = new object[0];
                App.ServiceReference.SnmpTypeObject _result = ((App.ServiceReference.SnmpTypeObject)(base.EndInvoke("Get", _args, result)));
                return _result;
            }
            
            public System.IAsyncResult BeginGetString(string jakisString, System.AsyncCallback callback, object asyncState) {
                object[] _args = new object[1];
                _args[0] = jakisString;
                System.IAsyncResult _result = base.BeginInvoke("GetString", _args, callback, asyncState);
                return _result;
            }
            
            public string EndGetString(System.IAsyncResult result) {
                object[] _args = new object[0];
                string _result = ((string)(base.EndInvoke("GetString", _args, result)));
                return _result;
            }
            
            public System.IAsyncResult BeginGetDataUsingDataContract(App.ServiceReference.SnmpTypeObject snmp, System.AsyncCallback callback, object asyncState) {
                object[] _args = new object[1];
                _args[0] = snmp;
                System.IAsyncResult _result = base.BeginInvoke("GetDataUsingDataContract", _args, callback, asyncState);
                return _result;
            }
            
            public App.ServiceReference.SnmpTypeObject EndGetDataUsingDataContract(System.IAsyncResult result) {
                object[] _args = new object[0];
                App.ServiceReference.SnmpTypeObject _result = ((App.ServiceReference.SnmpTypeObject)(base.EndInvoke("GetDataUsingDataContract", _args, result)));
                return _result;
            }
        }
        
        public enum EndpointConfiguration {
            
            BasicHttpBinding_ISnmpService,
        }
    }
}