﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace MySecureZoneApp.Api.FrameworkService {
    using System.Runtime.Serialization;
    using System;
    
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Runtime.Serialization", "4.0.0.0")]
    [System.Runtime.Serialization.DataContractAttribute(Name="Lookup", Namespace="http://schemas.datacontract.org/2004/07/Citadel.Framework.Entity")]
    [System.SerializableAttribute()]
    public partial class Lookup : MySecureZoneApp.Api.FrameworkService.DbBase {
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string DescriptionField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private short IDField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private short LanguageField;
        
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
        public short ID {
            get {
                return this.IDField;
            }
            set {
                if ((this.IDField.Equals(value) != true)) {
                    this.IDField = value;
                    this.RaisePropertyChanged("ID");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public short Language {
            get {
                return this.LanguageField;
            }
            set {
                if ((this.LanguageField.Equals(value) != true)) {
                    this.LanguageField = value;
                    this.RaisePropertyChanged("Language");
                }
            }
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Runtime.Serialization", "4.0.0.0")]
    [System.Runtime.Serialization.DataContractAttribute(Name="DbBase", Namespace="http://schemas.datacontract.org/2004/07/Citadel.Framework.Entity")]
    [System.SerializableAttribute()]
    [System.Runtime.Serialization.KnownTypeAttribute(typeof(MySecureZoneApp.Api.FrameworkService.Lookup))]
    public partial class DbBase : object, System.Runtime.Serialization.IExtensibleDataObject, System.ComponentModel.INotifyPropertyChanged {
        
        [System.NonSerializedAttribute()]
        private System.Runtime.Serialization.ExtensionDataObject extensionDataField;
        
        [global::System.ComponentModel.BrowsableAttribute(false)]
        public System.Runtime.Serialization.ExtensionDataObject ExtensionData {
            get {
                return this.extensionDataField;
            }
            set {
                this.extensionDataField = value;
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
    [System.ServiceModel.ServiceContractAttribute(ConfigurationName="FrameworkService.IFrameworkService")]
    public interface IFrameworkService {
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IFrameworkService/GetLookupNames", ReplyAction="http://tempuri.org/IFrameworkService/GetLookupNamesResponse")]
        MySecureZoneApp.Api.FrameworkService.GetLookupNamesResponse GetLookupNames(MySecureZoneApp.Api.FrameworkService.GetLookupNamesRequest request);
        
        // CODEGEN: Generating message contract since the operation has multiple return values.
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IFrameworkService/GetLookupNames", ReplyAction="http://tempuri.org/IFrameworkService/GetLookupNamesResponse")]
        System.Threading.Tasks.Task<MySecureZoneApp.Api.FrameworkService.GetLookupNamesResponse> GetLookupNamesAsync(MySecureZoneApp.Api.FrameworkService.GetLookupNamesRequest request);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IFrameworkService/GetLookup", ReplyAction="http://tempuri.org/IFrameworkService/GetLookupResponse")]
        MySecureZoneApp.Api.FrameworkService.Lookup[] GetLookup(string lookupName);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IFrameworkService/GetLookup", ReplyAction="http://tempuri.org/IFrameworkService/GetLookupResponse")]
        System.Threading.Tasks.Task<MySecureZoneApp.Api.FrameworkService.Lookup[]> GetLookupAsync(string lookupName);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IFrameworkService/GetLookupSpecific", ReplyAction="http://tempuri.org/IFrameworkService/GetLookupSpecificResponse")]
        System.Data.DataSet GetLookupSpecific(string tableName, string columnNames, string where, string orderBy);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IFrameworkService/GetLookupSpecific", ReplyAction="http://tempuri.org/IFrameworkService/GetLookupSpecificResponse")]
        System.Threading.Tasks.Task<System.Data.DataSet> GetLookupSpecificAsync(string tableName, string columnNames, string where, string orderBy);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IFrameworkService/GetLinkedLookup", ReplyAction="http://tempuri.org/IFrameworkService/GetLinkedLookupResponse")]
        MySecureZoneApp.Api.FrameworkService.Lookup[] GetLinkedLookup(string lookupName);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IFrameworkService/GetLinkedLookup", ReplyAction="http://tempuri.org/IFrameworkService/GetLinkedLookupResponse")]
        System.Threading.Tasks.Task<MySecureZoneApp.Api.FrameworkService.Lookup[]> GetLinkedLookupAsync(string lookupName);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IFrameworkService/GetMasterOfHighCourtAddressList", ReplyAction="http://tempuri.org/IFrameworkService/GetMasterOfHighCourtAddressListResponse")]
        MySecureZoneApp.Api.FrameworkService.Lookup[] GetMasterOfHighCourtAddressList();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IFrameworkService/GetMasterOfHighCourtAddressList", ReplyAction="http://tempuri.org/IFrameworkService/GetMasterOfHighCourtAddressListResponse")]
        System.Threading.Tasks.Task<MySecureZoneApp.Api.FrameworkService.Lookup[]> GetMasterOfHighCourtAddressListAsync();
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ServiceModel.MessageContractAttribute(WrapperName="GetLookupNames", WrapperNamespace="http://tempuri.org/", IsWrapped=true)]
    public partial class GetLookupNamesRequest {
        
        public GetLookupNamesRequest() {
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ServiceModel.MessageContractAttribute(WrapperName="GetLookupNamesResponse", WrapperNamespace="http://tempuri.org/", IsWrapped=true)]
    public partial class GetLookupNamesResponse {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="http://tempuri.org/", Order=0)]
        public string[] GetLookupNamesResult;
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="http://tempuri.org/", Order=1)]
        public string[] errors;
        
        public GetLookupNamesResponse() {
        }
        
        public GetLookupNamesResponse(string[] GetLookupNamesResult, string[] errors) {
            this.GetLookupNamesResult = GetLookupNamesResult;
            this.errors = errors;
        }
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public interface IFrameworkServiceChannel : MySecureZoneApp.Api.FrameworkService.IFrameworkService, System.ServiceModel.IClientChannel {
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public partial class FrameworkServiceClient : System.ServiceModel.ClientBase<MySecureZoneApp.Api.FrameworkService.IFrameworkService>, MySecureZoneApp.Api.FrameworkService.IFrameworkService {
        
        public FrameworkServiceClient() {
        }
        
        public FrameworkServiceClient(string endpointConfigurationName) : 
                base(endpointConfigurationName) {
        }
        
        public FrameworkServiceClient(string endpointConfigurationName, string remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public FrameworkServiceClient(string endpointConfigurationName, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public FrameworkServiceClient(System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(binding, remoteAddress) {
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        MySecureZoneApp.Api.FrameworkService.GetLookupNamesResponse MySecureZoneApp.Api.FrameworkService.IFrameworkService.GetLookupNames(MySecureZoneApp.Api.FrameworkService.GetLookupNamesRequest request) {
            return base.Channel.GetLookupNames(request);
        }
        
        public string[] GetLookupNames(out string[] errors) {
            MySecureZoneApp.Api.FrameworkService.GetLookupNamesRequest inValue = new MySecureZoneApp.Api.FrameworkService.GetLookupNamesRequest();
            MySecureZoneApp.Api.FrameworkService.GetLookupNamesResponse retVal = ((MySecureZoneApp.Api.FrameworkService.IFrameworkService)(this)).GetLookupNames(inValue);
            errors = retVal.errors;
            return retVal.GetLookupNamesResult;
        }
        
        public System.Threading.Tasks.Task<MySecureZoneApp.Api.FrameworkService.GetLookupNamesResponse> GetLookupNamesAsync(MySecureZoneApp.Api.FrameworkService.GetLookupNamesRequest request) {
            return base.Channel.GetLookupNamesAsync(request);
        }
        
        public MySecureZoneApp.Api.FrameworkService.Lookup[] GetLookup(string lookupName) {
            return base.Channel.GetLookup(lookupName);
        }
        
        public System.Threading.Tasks.Task<MySecureZoneApp.Api.FrameworkService.Lookup[]> GetLookupAsync(string lookupName) {
            return base.Channel.GetLookupAsync(lookupName);
        }
        
        public System.Data.DataSet GetLookupSpecific(string tableName, string columnNames, string where, string orderBy) {
            return base.Channel.GetLookupSpecific(tableName, columnNames, where, orderBy);
        }
        
        public System.Threading.Tasks.Task<System.Data.DataSet> GetLookupSpecificAsync(string tableName, string columnNames, string where, string orderBy) {
            return base.Channel.GetLookupSpecificAsync(tableName, columnNames, where, orderBy);
        }
        
        public MySecureZoneApp.Api.FrameworkService.Lookup[] GetLinkedLookup(string lookupName) {
            return base.Channel.GetLinkedLookup(lookupName);
        }
        
        public System.Threading.Tasks.Task<MySecureZoneApp.Api.FrameworkService.Lookup[]> GetLinkedLookupAsync(string lookupName) {
            return base.Channel.GetLinkedLookupAsync(lookupName);
        }
        
        public MySecureZoneApp.Api.FrameworkService.Lookup[] GetMasterOfHighCourtAddressList() {
            return base.Channel.GetMasterOfHighCourtAddressList();
        }
        
        public System.Threading.Tasks.Task<MySecureZoneApp.Api.FrameworkService.Lookup[]> GetMasterOfHighCourtAddressListAsync() {
            return base.Channel.GetMasterOfHighCourtAddressListAsync();
        }
    }
}