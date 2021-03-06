﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace WebApplication.ServiceReference1 {
    using System.Runtime.Serialization;
    using System;
    
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Runtime.Serialization", "4.0.0.0")]
    [System.Runtime.Serialization.DataContractAttribute(Name="Product", Namespace="http://schemas.datacontract.org/2004/07/WcfService")]
    [System.SerializableAttribute()]
    public partial class Product : object, System.Runtime.Serialization.IExtensibleDataObject, System.ComponentModel.INotifyPropertyChanged {
        
        [System.NonSerializedAttribute()]
        private System.Runtime.Serialization.ExtensionDataObject extensionDataField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string DescriptionField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private int IdField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string NameField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private int PriceField;
        
        [global::System.ComponentModel.BrowsableAttribute(false)]
        public System.Runtime.Serialization.ExtensionDataObject ExtensionData {
            get {
                return this.extensionDataField;
            }
            set {
                this.extensionDataField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string Description {
            get {
                return this.DescriptionField;
            }
            set {
                if ((object.ReferenceEquals(this.DescriptionField, value) != true)) {
                    this.DescriptionField = value;
                    this.RaisePropertyChanged("Description");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public int Id {
            get {
                return this.IdField;
            }
            set {
                if ((this.IdField.Equals(value) != true)) {
                    this.IdField = value;
                    this.RaisePropertyChanged("Id");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string Name {
            get {
                return this.NameField;
            }
            set {
                if ((object.ReferenceEquals(this.NameField, value) != true)) {
                    this.NameField = value;
                    this.RaisePropertyChanged("Name");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public int Price {
            get {
                return this.PriceField;
            }
            set {
                if ((this.PriceField.Equals(value) != true)) {
                    this.PriceField = value;
                    this.RaisePropertyChanged("Price");
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
    [System.ServiceModel.ServiceContractAttribute(ConfigurationName="ServiceReference1.IService1")]
    public interface IService1 {
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/GetProducts", ReplyAction="http://tempuri.org/IService1/GetProductsResponse")]
        WebApplication.ServiceReference1.Product[] GetProducts();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/GetProducts", ReplyAction="http://tempuri.org/IService1/GetProductsResponse")]
        System.Threading.Tasks.Task<WebApplication.ServiceReference1.Product[]> GetProductsAsync();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/Remove", ReplyAction="http://tempuri.org/IService1/RemoveResponse")]
        void Remove(int id);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/Remove", ReplyAction="http://tempuri.org/IService1/RemoveResponse")]
        System.Threading.Tasks.Task RemoveAsync(int id);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/InsertProduct", ReplyAction="http://tempuri.org/IService1/InsertProductResponse")]
        void InsertProduct(WebApplication.ServiceReference1.Product pr);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/InsertProduct", ReplyAction="http://tempuri.org/IService1/InsertProductResponse")]
        System.Threading.Tasks.Task InsertProductAsync(WebApplication.ServiceReference1.Product pr);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/Update", ReplyAction="http://tempuri.org/IService1/UpdateResponse")]
        void Update(WebApplication.ServiceReference1.Product pr);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/Update", ReplyAction="http://tempuri.org/IService1/UpdateResponse")]
        System.Threading.Tasks.Task UpdateAsync(WebApplication.ServiceReference1.Product pr);
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public interface IService1Channel : WebApplication.ServiceReference1.IService1, System.ServiceModel.IClientChannel {
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public partial class Service1Client : System.ServiceModel.ClientBase<WebApplication.ServiceReference1.IService1>, WebApplication.ServiceReference1.IService1 {
        
        public Service1Client() {
        }
        
        public Service1Client(string endpointConfigurationName) : 
                base(endpointConfigurationName) {
        }
        
        public Service1Client(string endpointConfigurationName, string remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public Service1Client(string endpointConfigurationName, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public Service1Client(System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(binding, remoteAddress) {
        }
        
        public WebApplication.ServiceReference1.Product[] GetProducts() {
            return base.Channel.GetProducts();
        }
        
        public System.Threading.Tasks.Task<WebApplication.ServiceReference1.Product[]> GetProductsAsync() {
            return base.Channel.GetProductsAsync();
        }
        
        public void Remove(int id) {
            base.Channel.Remove(id);
        }
        
        public System.Threading.Tasks.Task RemoveAsync(int id) {
            return base.Channel.RemoveAsync(id);
        }
        
        public void InsertProduct(WebApplication.ServiceReference1.Product pr) {
            base.Channel.InsertProduct(pr);
        }
        
        public System.Threading.Tasks.Task InsertProductAsync(WebApplication.ServiceReference1.Product pr) {
            return base.Channel.InsertProductAsync(pr);
        }
        
        public void Update(WebApplication.ServiceReference1.Product pr) {
            base.Channel.Update(pr);
        }
        
        public System.Threading.Tasks.Task UpdateAsync(WebApplication.ServiceReference1.Product pr) {
            return base.Channel.UpdateAsync(pr);
        }
    }
}
