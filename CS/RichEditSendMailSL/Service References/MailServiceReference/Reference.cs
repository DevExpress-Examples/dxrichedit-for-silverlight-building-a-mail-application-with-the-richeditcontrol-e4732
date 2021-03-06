﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.18033
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

// 
// This code was auto-generated by Microsoft.Silverlight.ServiceReference, version 4.0.60310.0
// 
namespace RichEditSendMailSL.MailServiceReference {
    using System.Runtime.Serialization;
    
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Runtime.Serialization", "4.0.0.0")]
    [System.Runtime.Serialization.DataContractAttribute(Name="AttachementInfo", Namespace="http://schemas.datacontract.org/2004/07/")]
    public partial class AttachementInfo : object, System.ComponentModel.INotifyPropertyChanged {
        
        private string ContentIdField;
        
        private byte[] DataField;
        
        private string MimeTypeField;
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string ContentId {
            get {
                return this.ContentIdField;
            }
            set {
                if ((object.ReferenceEquals(this.ContentIdField, value) != true)) {
                    this.ContentIdField = value;
                    this.RaisePropertyChanged("ContentId");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public byte[] Data {
            get {
                return this.DataField;
            }
            set {
                if ((object.ReferenceEquals(this.DataField, value) != true)) {
                    this.DataField = value;
                    this.RaisePropertyChanged("Data");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string MimeType {
            get {
                return this.MimeTypeField;
            }
            set {
                if ((object.ReferenceEquals(this.MimeTypeField, value) != true)) {
                    this.MimeTypeField = value;
                    this.RaisePropertyChanged("MimeType");
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
    [System.ServiceModel.ServiceContractAttribute(ConfigurationName="MailServiceReference.IMailService")]
    public interface IMailService {
        
        [System.ServiceModel.OperationContractAttribute(AsyncPattern=true, Action="http://tempuri.org/IMailService/SendMail", ReplyAction="http://tempuri.org/IMailService/SendMailResponse")]
        System.IAsyncResult BeginSendMail(string mailHost, string from, string to, string subject, string body, System.Collections.Generic.List<RichEditSendMailSL.MailServiceReference.AttachementInfo> attachments, System.AsyncCallback callback, object asyncState);
        
        void EndSendMail(System.IAsyncResult result);
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public interface IMailServiceChannel : RichEditSendMailSL.MailServiceReference.IMailService, System.ServiceModel.IClientChannel {
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public partial class MailServiceClient : System.ServiceModel.ClientBase<RichEditSendMailSL.MailServiceReference.IMailService>, RichEditSendMailSL.MailServiceReference.IMailService {
        
        private BeginOperationDelegate onBeginSendMailDelegate;
        
        private EndOperationDelegate onEndSendMailDelegate;
        
        private System.Threading.SendOrPostCallback onSendMailCompletedDelegate;
        
        private BeginOperationDelegate onBeginOpenDelegate;
        
        private EndOperationDelegate onEndOpenDelegate;
        
        private System.Threading.SendOrPostCallback onOpenCompletedDelegate;
        
        private BeginOperationDelegate onBeginCloseDelegate;
        
        private EndOperationDelegate onEndCloseDelegate;
        
        private System.Threading.SendOrPostCallback onCloseCompletedDelegate;
        
        public MailServiceClient() {
        }
        
        public MailServiceClient(string endpointConfigurationName) : 
                base(endpointConfigurationName) {
        }
        
        public MailServiceClient(string endpointConfigurationName, string remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public MailServiceClient(string endpointConfigurationName, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public MailServiceClient(System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) : 
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
        
        public event System.EventHandler<System.ComponentModel.AsyncCompletedEventArgs> SendMailCompleted;
        
        public event System.EventHandler<System.ComponentModel.AsyncCompletedEventArgs> OpenCompleted;
        
        public event System.EventHandler<System.ComponentModel.AsyncCompletedEventArgs> CloseCompleted;
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        System.IAsyncResult RichEditSendMailSL.MailServiceReference.IMailService.BeginSendMail(string mailHost, string from, string to, string subject, string body, System.Collections.Generic.List<RichEditSendMailSL.MailServiceReference.AttachementInfo> attachments, System.AsyncCallback callback, object asyncState) {
            return base.Channel.BeginSendMail(mailHost, from, to, subject, body, attachments, callback, asyncState);
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        void RichEditSendMailSL.MailServiceReference.IMailService.EndSendMail(System.IAsyncResult result) {
            base.Channel.EndSendMail(result);
        }
        
        private System.IAsyncResult OnBeginSendMail(object[] inValues, System.AsyncCallback callback, object asyncState) {
            string mailHost = ((string)(inValues[0]));
            string from = ((string)(inValues[1]));
            string to = ((string)(inValues[2]));
            string subject = ((string)(inValues[3]));
            string body = ((string)(inValues[4]));
            System.Collections.Generic.List<RichEditSendMailSL.MailServiceReference.AttachementInfo> attachments = ((System.Collections.Generic.List<RichEditSendMailSL.MailServiceReference.AttachementInfo>)(inValues[5]));
            return ((RichEditSendMailSL.MailServiceReference.IMailService)(this)).BeginSendMail(mailHost, from, to, subject, body, attachments, callback, asyncState);
        }
        
        private object[] OnEndSendMail(System.IAsyncResult result) {
            ((RichEditSendMailSL.MailServiceReference.IMailService)(this)).EndSendMail(result);
            return null;
        }
        
        private void OnSendMailCompleted(object state) {
            if ((this.SendMailCompleted != null)) {
                InvokeAsyncCompletedEventArgs e = ((InvokeAsyncCompletedEventArgs)(state));
                this.SendMailCompleted(this, new System.ComponentModel.AsyncCompletedEventArgs(e.Error, e.Cancelled, e.UserState));
            }
        }
        
        public void SendMailAsync(string mailHost, string from, string to, string subject, string body, System.Collections.Generic.List<RichEditSendMailSL.MailServiceReference.AttachementInfo> attachments) {
            this.SendMailAsync(mailHost, from, to, subject, body, attachments, null);
        }
        
        public void SendMailAsync(string mailHost, string from, string to, string subject, string body, System.Collections.Generic.List<RichEditSendMailSL.MailServiceReference.AttachementInfo> attachments, object userState) {
            if ((this.onBeginSendMailDelegate == null)) {
                this.onBeginSendMailDelegate = new BeginOperationDelegate(this.OnBeginSendMail);
            }
            if ((this.onEndSendMailDelegate == null)) {
                this.onEndSendMailDelegate = new EndOperationDelegate(this.OnEndSendMail);
            }
            if ((this.onSendMailCompletedDelegate == null)) {
                this.onSendMailCompletedDelegate = new System.Threading.SendOrPostCallback(this.OnSendMailCompleted);
            }
            base.InvokeAsync(this.onBeginSendMailDelegate, new object[] {
                        mailHost,
                        from,
                        to,
                        subject,
                        body,
                        attachments}, this.onEndSendMailDelegate, this.onSendMailCompletedDelegate, userState);
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
        
        protected override RichEditSendMailSL.MailServiceReference.IMailService CreateChannel() {
            return new MailServiceClientChannel(this);
        }
        
        private class MailServiceClientChannel : ChannelBase<RichEditSendMailSL.MailServiceReference.IMailService>, RichEditSendMailSL.MailServiceReference.IMailService {
            
            public MailServiceClientChannel(System.ServiceModel.ClientBase<RichEditSendMailSL.MailServiceReference.IMailService> client) : 
                    base(client) {
            }
            
            public System.IAsyncResult BeginSendMail(string mailHost, string from, string to, string subject, string body, System.Collections.Generic.List<RichEditSendMailSL.MailServiceReference.AttachementInfo> attachments, System.AsyncCallback callback, object asyncState) {
                object[] _args = new object[6];
                _args[0] = mailHost;
                _args[1] = from;
                _args[2] = to;
                _args[3] = subject;
                _args[4] = body;
                _args[5] = attachments;
                System.IAsyncResult _result = base.BeginInvoke("SendMail", _args, callback, asyncState);
                return _result;
            }
            
            public void EndSendMail(System.IAsyncResult result) {
                object[] _args = new object[0];
                base.EndInvoke("SendMail", _args, result);
            }
        }
    }
}
