﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.1
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

// 
// This code was auto-generated by Microsoft.Silverlight.ServiceReference, version 4.0.50401.0
// 
namespace SilverlightValidationDemo.ValidationService {
    
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ServiceModel.ServiceContractAttribute(Namespace="", ConfigurationName="ValidationService.ValidationService")]
    public interface ValidationService {
        
        [System.ServiceModel.OperationContractAttribute(AsyncPattern=true, Action="urn:ValidationService/ValidationUserName", ReplyAction="urn:ValidationService/ValidationUserNameResponse")]
        System.IAsyncResult BeginValidationUserName(string username, System.AsyncCallback callback, object asyncState);
        
        bool EndValidationUserName(System.IAsyncResult result);
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public interface ValidationServiceChannel : SilverlightValidationDemo.ValidationService.ValidationService, System.ServiceModel.IClientChannel {
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public partial class ValidationUserNameCompletedEventArgs : System.ComponentModel.AsyncCompletedEventArgs {
        
        private object[] results;
        
        public ValidationUserNameCompletedEventArgs(object[] results, System.Exception exception, bool cancelled, object userState) : 
                base(exception, cancelled, userState) {
            this.results = results;
        }
        
        public bool Result {
            get {
                base.RaiseExceptionIfNecessary();
                return ((bool)(this.results[0]));
            }
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public partial class ValidationServiceClient : System.ServiceModel.ClientBase<SilverlightValidationDemo.ValidationService.ValidationService>, SilverlightValidationDemo.ValidationService.ValidationService {
        
        private BeginOperationDelegate onBeginValidationUserNameDelegate;
        
        private EndOperationDelegate onEndValidationUserNameDelegate;
        
        private System.Threading.SendOrPostCallback onValidationUserNameCompletedDelegate;
        
        private BeginOperationDelegate onBeginOpenDelegate;
        
        private EndOperationDelegate onEndOpenDelegate;
        
        private System.Threading.SendOrPostCallback onOpenCompletedDelegate;
        
        private BeginOperationDelegate onBeginCloseDelegate;
        
        private EndOperationDelegate onEndCloseDelegate;
        
        private System.Threading.SendOrPostCallback onCloseCompletedDelegate;
        
        public ValidationServiceClient() {
        }
        
        public ValidationServiceClient(string endpointConfigurationName) : 
                base(endpointConfigurationName) {
        }
        
        public ValidationServiceClient(string endpointConfigurationName, string remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public ValidationServiceClient(string endpointConfigurationName, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public ValidationServiceClient(System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) : 
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
        
        public event System.EventHandler<ValidationUserNameCompletedEventArgs> ValidationUserNameCompleted;
        
        public event System.EventHandler<System.ComponentModel.AsyncCompletedEventArgs> OpenCompleted;
        
        public event System.EventHandler<System.ComponentModel.AsyncCompletedEventArgs> CloseCompleted;
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        System.IAsyncResult SilverlightValidationDemo.ValidationService.ValidationService.BeginValidationUserName(string username, System.AsyncCallback callback, object asyncState) {
            return base.Channel.BeginValidationUserName(username, callback, asyncState);
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        bool SilverlightValidationDemo.ValidationService.ValidationService.EndValidationUserName(System.IAsyncResult result) {
            return base.Channel.EndValidationUserName(result);
        }
        
        private System.IAsyncResult OnBeginValidationUserName(object[] inValues, System.AsyncCallback callback, object asyncState) {
            string username = ((string)(inValues[0]));
            return ((SilverlightValidationDemo.ValidationService.ValidationService)(this)).BeginValidationUserName(username, callback, asyncState);
        }
        
        private object[] OnEndValidationUserName(System.IAsyncResult result) {
            bool retVal = ((SilverlightValidationDemo.ValidationService.ValidationService)(this)).EndValidationUserName(result);
            return new object[] {
                    retVal};
        }
        
        private void OnValidationUserNameCompleted(object state) {
            if ((this.ValidationUserNameCompleted != null)) {
                InvokeAsyncCompletedEventArgs e = ((InvokeAsyncCompletedEventArgs)(state));
                this.ValidationUserNameCompleted(this, new ValidationUserNameCompletedEventArgs(e.Results, e.Error, e.Cancelled, e.UserState));
            }
        }
        
        public void ValidationUserNameAsync(string username) {
            this.ValidationUserNameAsync(username, null);
        }
        
        public void ValidationUserNameAsync(string username, object userState) {
            if ((this.onBeginValidationUserNameDelegate == null)) {
                this.onBeginValidationUserNameDelegate = new BeginOperationDelegate(this.OnBeginValidationUserName);
            }
            if ((this.onEndValidationUserNameDelegate == null)) {
                this.onEndValidationUserNameDelegate = new EndOperationDelegate(this.OnEndValidationUserName);
            }
            if ((this.onValidationUserNameCompletedDelegate == null)) {
                this.onValidationUserNameCompletedDelegate = new System.Threading.SendOrPostCallback(this.OnValidationUserNameCompleted);
            }
            base.InvokeAsync(this.onBeginValidationUserNameDelegate, new object[] {
                        username}, this.onEndValidationUserNameDelegate, this.onValidationUserNameCompletedDelegate, userState);
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
        
        protected override SilverlightValidationDemo.ValidationService.ValidationService CreateChannel() {
            return new ValidationServiceClientChannel(this);
        }
        
        private class ValidationServiceClientChannel : ChannelBase<SilverlightValidationDemo.ValidationService.ValidationService>, SilverlightValidationDemo.ValidationService.ValidationService {
            
            public ValidationServiceClientChannel(System.ServiceModel.ClientBase<SilverlightValidationDemo.ValidationService.ValidationService> client) : 
                    base(client) {
            }
            
            public System.IAsyncResult BeginValidationUserName(string username, System.AsyncCallback callback, object asyncState) {
                object[] _args = new object[1];
                _args[0] = username;
                System.IAsyncResult _result = base.BeginInvoke("ValidationUserName", _args, callback, asyncState);
                return _result;
            }
            
            public bool EndValidationUserName(System.IAsyncResult result) {
                object[] _args = new object[0];
                bool _result = ((bool)(base.EndInvoke("ValidationUserName", _args, result)));
                return _result;
            }
        }
    }
}