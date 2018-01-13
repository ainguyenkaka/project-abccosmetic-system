﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace ABCosmetic_app.StoreService {
    using System.Runtime.Serialization;
    using System;
    
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Runtime.Serialization", "4.0.0.0")]
    [System.Runtime.Serialization.DataContractAttribute(Name="Store", Namespace="http://tempuri.org/")]
    [System.SerializableAttribute()]
    public partial class Store : ABCosmetic_app.StoreService.AbstractEntity {
        
        private int CountryIDField;
        
        [System.Runtime.Serialization.DataMemberAttribute(IsRequired=true)]
        public int CountryID {
            get {
                return this.CountryIDField;
            }
            set {
                if ((this.CountryIDField.Equals(value) != true)) {
                    this.CountryIDField = value;
                    this.RaisePropertyChanged("CountryID");
                }
            }
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Runtime.Serialization", "4.0.0.0")]
    [System.Runtime.Serialization.DataContractAttribute(Name="AbstractEntity", Namespace="http://tempuri.org/")]
    [System.SerializableAttribute()]
    [System.Runtime.Serialization.KnownTypeAttribute(typeof(ABCosmetic_app.StoreService.Store))]
    public partial class AbstractEntity : object, System.Runtime.Serialization.IExtensibleDataObject, System.ComponentModel.INotifyPropertyChanged {
        
        [System.NonSerializedAttribute()]
        private System.Runtime.Serialization.ExtensionDataObject extensionDataField;
        
        private int idField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string nameField;
        
        [global::System.ComponentModel.BrowsableAttribute(false)]
        public System.Runtime.Serialization.ExtensionDataObject ExtensionData {
            get {
                return this.extensionDataField;
            }
            set {
                this.extensionDataField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute(IsRequired=true)]
        public int id {
            get {
                return this.idField;
            }
            set {
                if ((this.idField.Equals(value) != true)) {
                    this.idField = value;
                    this.RaisePropertyChanged("id");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue=false)]
        public string name {
            get {
                return this.nameField;
            }
            set {
                if ((object.ReferenceEquals(this.nameField, value) != true)) {
                    this.nameField = value;
                    this.RaisePropertyChanged("name");
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
    [System.ServiceModel.ServiceContractAttribute(ConfigurationName="StoreService.StoreServiceSoap")]
    public interface StoreServiceSoap {
        
        // CODEGEN: Generating message contract since element name HelloWorldResult from namespace http://tempuri.org/ is not marked nillable
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/HelloWorld", ReplyAction="*")]
        ABCosmetic_app.StoreService.HelloWorldResponse HelloWorld(ABCosmetic_app.StoreService.HelloWorldRequest request);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/HelloWorld", ReplyAction="*")]
        System.Threading.Tasks.Task<ABCosmetic_app.StoreService.HelloWorldResponse> HelloWorldAsync(ABCosmetic_app.StoreService.HelloWorldRequest request);
        
        // CODEGEN: Generating message contract since element name AllResult from namespace http://tempuri.org/ is not marked nillable
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/All", ReplyAction="*")]
        ABCosmetic_app.StoreService.AllResponse All(ABCosmetic_app.StoreService.AllRequest request);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/All", ReplyAction="*")]
        System.Threading.Tasks.Task<ABCosmetic_app.StoreService.AllResponse> AllAsync(ABCosmetic_app.StoreService.AllRequest request);
        
        // CODEGEN: Generating message contract since element name GetByIDResult from namespace http://tempuri.org/ is not marked nillable
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/GetByID", ReplyAction="*")]
        ABCosmetic_app.StoreService.GetByIDResponse GetByID(ABCosmetic_app.StoreService.GetByIDRequest request);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/GetByID", ReplyAction="*")]
        System.Threading.Tasks.Task<ABCosmetic_app.StoreService.GetByIDResponse> GetByIDAsync(ABCosmetic_app.StoreService.GetByIDRequest request);
        
        // CODEGEN: Generating message contract since element name text from namespace http://tempuri.org/ is not marked nillable
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/SearchByName", ReplyAction="*")]
        ABCosmetic_app.StoreService.SearchByNameResponse SearchByName(ABCosmetic_app.StoreService.SearchByNameRequest request);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/SearchByName", ReplyAction="*")]
        System.Threading.Tasks.Task<ABCosmetic_app.StoreService.SearchByNameResponse> SearchByNameAsync(ABCosmetic_app.StoreService.SearchByNameRequest request);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/Delete", ReplyAction="*")]
        bool Delete(int id);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/Delete", ReplyAction="*")]
        System.Threading.Tasks.Task<bool> DeleteAsync(int id);
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(IsWrapped=false)]
    public partial class HelloWorldRequest {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Name="HelloWorld", Namespace="http://tempuri.org/", Order=0)]
        public ABCosmetic_app.StoreService.HelloWorldRequestBody Body;
        
        public HelloWorldRequest() {
        }
        
        public HelloWorldRequest(ABCosmetic_app.StoreService.HelloWorldRequestBody Body) {
            this.Body = Body;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.Runtime.Serialization.DataContractAttribute()]
    public partial class HelloWorldRequestBody {
        
        public HelloWorldRequestBody() {
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(IsWrapped=false)]
    public partial class HelloWorldResponse {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Name="HelloWorldResponse", Namespace="http://tempuri.org/", Order=0)]
        public ABCosmetic_app.StoreService.HelloWorldResponseBody Body;
        
        public HelloWorldResponse() {
        }
        
        public HelloWorldResponse(ABCosmetic_app.StoreService.HelloWorldResponseBody Body) {
            this.Body = Body;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.Runtime.Serialization.DataContractAttribute(Namespace="http://tempuri.org/")]
    public partial class HelloWorldResponseBody {
        
        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue=false, Order=0)]
        public string HelloWorldResult;
        
        public HelloWorldResponseBody() {
        }
        
        public HelloWorldResponseBody(string HelloWorldResult) {
            this.HelloWorldResult = HelloWorldResult;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(IsWrapped=false)]
    public partial class AllRequest {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Name="All", Namespace="http://tempuri.org/", Order=0)]
        public ABCosmetic_app.StoreService.AllRequestBody Body;
        
        public AllRequest() {
        }
        
        public AllRequest(ABCosmetic_app.StoreService.AllRequestBody Body) {
            this.Body = Body;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.Runtime.Serialization.DataContractAttribute()]
    public partial class AllRequestBody {
        
        public AllRequestBody() {
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(IsWrapped=false)]
    public partial class AllResponse {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Name="AllResponse", Namespace="http://tempuri.org/", Order=0)]
        public ABCosmetic_app.StoreService.AllResponseBody Body;
        
        public AllResponse() {
        }
        
        public AllResponse(ABCosmetic_app.StoreService.AllResponseBody Body) {
            this.Body = Body;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.Runtime.Serialization.DataContractAttribute(Namespace="http://tempuri.org/")]
    public partial class AllResponseBody {
        
        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue=false, Order=0)]
        public System.Collections.Generic.List<ABCosmetic_app.StoreService.Store> AllResult;
        
        public AllResponseBody() {
        }
        
        public AllResponseBody(System.Collections.Generic.List<ABCosmetic_app.StoreService.Store> AllResult) {
            this.AllResult = AllResult;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(IsWrapped=false)]
    public partial class GetByIDRequest {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Name="GetByID", Namespace="http://tempuri.org/", Order=0)]
        public ABCosmetic_app.StoreService.GetByIDRequestBody Body;
        
        public GetByIDRequest() {
        }
        
        public GetByIDRequest(ABCosmetic_app.StoreService.GetByIDRequestBody Body) {
            this.Body = Body;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.Runtime.Serialization.DataContractAttribute(Namespace="http://tempuri.org/")]
    public partial class GetByIDRequestBody {
        
        [System.Runtime.Serialization.DataMemberAttribute(Order=0)]
        public int id;
        
        public GetByIDRequestBody() {
        }
        
        public GetByIDRequestBody(int id) {
            this.id = id;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(IsWrapped=false)]
    public partial class GetByIDResponse {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Name="GetByIDResponse", Namespace="http://tempuri.org/", Order=0)]
        public ABCosmetic_app.StoreService.GetByIDResponseBody Body;
        
        public GetByIDResponse() {
        }
        
        public GetByIDResponse(ABCosmetic_app.StoreService.GetByIDResponseBody Body) {
            this.Body = Body;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.Runtime.Serialization.DataContractAttribute(Namespace="http://tempuri.org/")]
    public partial class GetByIDResponseBody {
        
        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue=false, Order=0)]
        public ABCosmetic_app.StoreService.Store GetByIDResult;
        
        public GetByIDResponseBody() {
        }
        
        public GetByIDResponseBody(ABCosmetic_app.StoreService.Store GetByIDResult) {
            this.GetByIDResult = GetByIDResult;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(IsWrapped=false)]
    public partial class SearchByNameRequest {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Name="SearchByName", Namespace="http://tempuri.org/", Order=0)]
        public ABCosmetic_app.StoreService.SearchByNameRequestBody Body;
        
        public SearchByNameRequest() {
        }
        
        public SearchByNameRequest(ABCosmetic_app.StoreService.SearchByNameRequestBody Body) {
            this.Body = Body;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.Runtime.Serialization.DataContractAttribute(Namespace="http://tempuri.org/")]
    public partial class SearchByNameRequestBody {
        
        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue=false, Order=0)]
        public string text;
        
        public SearchByNameRequestBody() {
        }
        
        public SearchByNameRequestBody(string text) {
            this.text = text;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(IsWrapped=false)]
    public partial class SearchByNameResponse {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Name="SearchByNameResponse", Namespace="http://tempuri.org/", Order=0)]
        public ABCosmetic_app.StoreService.SearchByNameResponseBody Body;
        
        public SearchByNameResponse() {
        }
        
        public SearchByNameResponse(ABCosmetic_app.StoreService.SearchByNameResponseBody Body) {
            this.Body = Body;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.Runtime.Serialization.DataContractAttribute(Namespace="http://tempuri.org/")]
    public partial class SearchByNameResponseBody {
        
        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue=false, Order=0)]
        public System.Collections.Generic.List<ABCosmetic_app.StoreService.Store> SearchByNameResult;
        
        public SearchByNameResponseBody() {
        }
        
        public SearchByNameResponseBody(System.Collections.Generic.List<ABCosmetic_app.StoreService.Store> SearchByNameResult) {
            this.SearchByNameResult = SearchByNameResult;
        }
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public interface StoreServiceSoapChannel : ABCosmetic_app.StoreService.StoreServiceSoap, System.ServiceModel.IClientChannel {
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public partial class StoreServiceSoapClient : System.ServiceModel.ClientBase<ABCosmetic_app.StoreService.StoreServiceSoap>, ABCosmetic_app.StoreService.StoreServiceSoap {
        
        public StoreServiceSoapClient() {
        }
        
        public StoreServiceSoapClient(string endpointConfigurationName) : 
                base(endpointConfigurationName) {
        }
        
        public StoreServiceSoapClient(string endpointConfigurationName, string remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public StoreServiceSoapClient(string endpointConfigurationName, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public StoreServiceSoapClient(System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(binding, remoteAddress) {
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        ABCosmetic_app.StoreService.HelloWorldResponse ABCosmetic_app.StoreService.StoreServiceSoap.HelloWorld(ABCosmetic_app.StoreService.HelloWorldRequest request) {
            return base.Channel.HelloWorld(request);
        }
        
        public string HelloWorld() {
            ABCosmetic_app.StoreService.HelloWorldRequest inValue = new ABCosmetic_app.StoreService.HelloWorldRequest();
            inValue.Body = new ABCosmetic_app.StoreService.HelloWorldRequestBody();
            ABCosmetic_app.StoreService.HelloWorldResponse retVal = ((ABCosmetic_app.StoreService.StoreServiceSoap)(this)).HelloWorld(inValue);
            return retVal.Body.HelloWorldResult;
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        System.Threading.Tasks.Task<ABCosmetic_app.StoreService.HelloWorldResponse> ABCosmetic_app.StoreService.StoreServiceSoap.HelloWorldAsync(ABCosmetic_app.StoreService.HelloWorldRequest request) {
            return base.Channel.HelloWorldAsync(request);
        }
        
        public System.Threading.Tasks.Task<ABCosmetic_app.StoreService.HelloWorldResponse> HelloWorldAsync() {
            ABCosmetic_app.StoreService.HelloWorldRequest inValue = new ABCosmetic_app.StoreService.HelloWorldRequest();
            inValue.Body = new ABCosmetic_app.StoreService.HelloWorldRequestBody();
            return ((ABCosmetic_app.StoreService.StoreServiceSoap)(this)).HelloWorldAsync(inValue);
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        ABCosmetic_app.StoreService.AllResponse ABCosmetic_app.StoreService.StoreServiceSoap.All(ABCosmetic_app.StoreService.AllRequest request) {
            return base.Channel.All(request);
        }
        
        public System.Collections.Generic.List<ABCosmetic_app.StoreService.Store> All() {
            ABCosmetic_app.StoreService.AllRequest inValue = new ABCosmetic_app.StoreService.AllRequest();
            inValue.Body = new ABCosmetic_app.StoreService.AllRequestBody();
            ABCosmetic_app.StoreService.AllResponse retVal = ((ABCosmetic_app.StoreService.StoreServiceSoap)(this)).All(inValue);
            return retVal.Body.AllResult;
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        System.Threading.Tasks.Task<ABCosmetic_app.StoreService.AllResponse> ABCosmetic_app.StoreService.StoreServiceSoap.AllAsync(ABCosmetic_app.StoreService.AllRequest request) {
            return base.Channel.AllAsync(request);
        }
        
        public System.Threading.Tasks.Task<ABCosmetic_app.StoreService.AllResponse> AllAsync() {
            ABCosmetic_app.StoreService.AllRequest inValue = new ABCosmetic_app.StoreService.AllRequest();
            inValue.Body = new ABCosmetic_app.StoreService.AllRequestBody();
            return ((ABCosmetic_app.StoreService.StoreServiceSoap)(this)).AllAsync(inValue);
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        ABCosmetic_app.StoreService.GetByIDResponse ABCosmetic_app.StoreService.StoreServiceSoap.GetByID(ABCosmetic_app.StoreService.GetByIDRequest request) {
            return base.Channel.GetByID(request);
        }
        
        public ABCosmetic_app.StoreService.Store GetByID(int id) {
            ABCosmetic_app.StoreService.GetByIDRequest inValue = new ABCosmetic_app.StoreService.GetByIDRequest();
            inValue.Body = new ABCosmetic_app.StoreService.GetByIDRequestBody();
            inValue.Body.id = id;
            ABCosmetic_app.StoreService.GetByIDResponse retVal = ((ABCosmetic_app.StoreService.StoreServiceSoap)(this)).GetByID(inValue);
            return retVal.Body.GetByIDResult;
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        System.Threading.Tasks.Task<ABCosmetic_app.StoreService.GetByIDResponse> ABCosmetic_app.StoreService.StoreServiceSoap.GetByIDAsync(ABCosmetic_app.StoreService.GetByIDRequest request) {
            return base.Channel.GetByIDAsync(request);
        }
        
        public System.Threading.Tasks.Task<ABCosmetic_app.StoreService.GetByIDResponse> GetByIDAsync(int id) {
            ABCosmetic_app.StoreService.GetByIDRequest inValue = new ABCosmetic_app.StoreService.GetByIDRequest();
            inValue.Body = new ABCosmetic_app.StoreService.GetByIDRequestBody();
            inValue.Body.id = id;
            return ((ABCosmetic_app.StoreService.StoreServiceSoap)(this)).GetByIDAsync(inValue);
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        ABCosmetic_app.StoreService.SearchByNameResponse ABCosmetic_app.StoreService.StoreServiceSoap.SearchByName(ABCosmetic_app.StoreService.SearchByNameRequest request) {
            return base.Channel.SearchByName(request);
        }
        
        public System.Collections.Generic.List<ABCosmetic_app.StoreService.Store> SearchByName(string text) {
            ABCosmetic_app.StoreService.SearchByNameRequest inValue = new ABCosmetic_app.StoreService.SearchByNameRequest();
            inValue.Body = new ABCosmetic_app.StoreService.SearchByNameRequestBody();
            inValue.Body.text = text;
            ABCosmetic_app.StoreService.SearchByNameResponse retVal = ((ABCosmetic_app.StoreService.StoreServiceSoap)(this)).SearchByName(inValue);
            return retVal.Body.SearchByNameResult;
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        System.Threading.Tasks.Task<ABCosmetic_app.StoreService.SearchByNameResponse> ABCosmetic_app.StoreService.StoreServiceSoap.SearchByNameAsync(ABCosmetic_app.StoreService.SearchByNameRequest request) {
            return base.Channel.SearchByNameAsync(request);
        }
        
        public System.Threading.Tasks.Task<ABCosmetic_app.StoreService.SearchByNameResponse> SearchByNameAsync(string text) {
            ABCosmetic_app.StoreService.SearchByNameRequest inValue = new ABCosmetic_app.StoreService.SearchByNameRequest();
            inValue.Body = new ABCosmetic_app.StoreService.SearchByNameRequestBody();
            inValue.Body.text = text;
            return ((ABCosmetic_app.StoreService.StoreServiceSoap)(this)).SearchByNameAsync(inValue);
        }
        
        public bool Delete(int id) {
            return base.Channel.Delete(id);
        }
        
        public System.Threading.Tasks.Task<bool> DeleteAsync(int id) {
            return base.Channel.DeleteAsync(id);
        }
    }
}