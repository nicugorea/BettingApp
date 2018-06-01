﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace BettingAppWeb.AccountService {
    using System.Runtime.Serialization;
    using System;
    
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Runtime.Serialization", "4.0.0.0")]
    [System.Runtime.Serialization.DataContractAttribute(Name="User", Namespace="http://schemas.datacontract.org/2004/07/BettingAppWcf.Models")]
    [System.SerializableAttribute()]
    public partial class User : object, System.Runtime.Serialization.IExtensibleDataObject, System.ComponentModel.INotifyPropertyChanged {
        
        [System.NonSerializedAttribute()]
        private System.Runtime.Serialization.ExtensionDataObject extensionDataField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private int ID_UserField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string PasswordField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string RoleField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string UsernameField;
        
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
        public int ID_User {
            get {
                return this.ID_UserField;
            }
            set {
                if ((this.ID_UserField.Equals(value) != true)) {
                    this.ID_UserField = value;
                    this.RaisePropertyChanged("ID_User");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string Password {
            get {
                return this.PasswordField;
            }
            set {
                if ((object.ReferenceEquals(this.PasswordField, value) != true)) {
                    this.PasswordField = value;
                    this.RaisePropertyChanged("Password");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string Role {
            get {
                return this.RoleField;
            }
            set {
                if ((object.ReferenceEquals(this.RoleField, value) != true)) {
                    this.RoleField = value;
                    this.RaisePropertyChanged("Role");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string Username {
            get {
                return this.UsernameField;
            }
            set {
                if ((object.ReferenceEquals(this.UsernameField, value) != true)) {
                    this.UsernameField = value;
                    this.RaisePropertyChanged("Username");
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
    [System.ServiceModel.ServiceContractAttribute(ConfigurationName="AccountService.IAccountService")]
    public interface IAccountService {
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IAccountService/GetUserByUsername", ReplyAction="http://tempuri.org/IAccountService/GetUserByUsernameResponse")]
        BettingAppWeb.AccountService.User GetUserByUsername(string username);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IAccountService/GetUserByUsername", ReplyAction="http://tempuri.org/IAccountService/GetUserByUsernameResponse")]
        System.Threading.Tasks.Task<BettingAppWeb.AccountService.User> GetUserByUsernameAsync(string username);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IAccountService/GetUserById", ReplyAction="http://tempuri.org/IAccountService/GetUserByIdResponse")]
        BettingAppWeb.AccountService.User GetUserById(int id);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IAccountService/GetUserById", ReplyAction="http://tempuri.org/IAccountService/GetUserByIdResponse")]
        System.Threading.Tasks.Task<BettingAppWeb.AccountService.User> GetUserByIdAsync(int id);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IAccountService/RegisterResult", ReplyAction="http://tempuri.org/IAccountService/RegisterResultResponse")]
        bool RegisterResult(string username, string password);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IAccountService/RegisterResult", ReplyAction="http://tempuri.org/IAccountService/RegisterResultResponse")]
        System.Threading.Tasks.Task<bool> RegisterResultAsync(string username, string password);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IAccountService/LoginResult", ReplyAction="http://tempuri.org/IAccountService/LoginResultResponse")]
        bool LoginResult(string username, string password);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IAccountService/LoginResult", ReplyAction="http://tempuri.org/IAccountService/LoginResultResponse")]
        System.Threading.Tasks.Task<bool> LoginResultAsync(string username, string password);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IAccountService/IsUser", ReplyAction="http://tempuri.org/IAccountService/IsUserResponse")]
        bool IsUser(int id);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IAccountService/IsUser", ReplyAction="http://tempuri.org/IAccountService/IsUserResponse")]
        System.Threading.Tasks.Task<bool> IsUserAsync(int id);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IAccountService/IsAdmin", ReplyAction="http://tempuri.org/IAccountService/IsAdminResponse")]
        bool IsAdmin(int id);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IAccountService/IsAdmin", ReplyAction="http://tempuri.org/IAccountService/IsAdminResponse")]
        System.Threading.Tasks.Task<bool> IsAdminAsync(int id);
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public interface IAccountServiceChannel : BettingAppWeb.AccountService.IAccountService, System.ServiceModel.IClientChannel {
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public partial class AccountServiceClient : System.ServiceModel.ClientBase<BettingAppWeb.AccountService.IAccountService>, BettingAppWeb.AccountService.IAccountService {
        
        public AccountServiceClient() {
        }
        
        public AccountServiceClient(string endpointConfigurationName) : 
                base(endpointConfigurationName) {
        }
        
        public AccountServiceClient(string endpointConfigurationName, string remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public AccountServiceClient(string endpointConfigurationName, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public AccountServiceClient(System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(binding, remoteAddress) {
        }
        
        public BettingAppWeb.AccountService.User GetUserByUsername(string username) {
            return base.Channel.GetUserByUsername(username);
        }
        
        public System.Threading.Tasks.Task<BettingAppWeb.AccountService.User> GetUserByUsernameAsync(string username) {
            return base.Channel.GetUserByUsernameAsync(username);
        }
        
        public BettingAppWeb.AccountService.User GetUserById(int id) {
            return base.Channel.GetUserById(id);
        }
        
        public System.Threading.Tasks.Task<BettingAppWeb.AccountService.User> GetUserByIdAsync(int id) {
            return base.Channel.GetUserByIdAsync(id);
        }
        
        public bool RegisterResult(string username, string password) {
            return base.Channel.RegisterResult(username, password);
        }
        
        public System.Threading.Tasks.Task<bool> RegisterResultAsync(string username, string password) {
            return base.Channel.RegisterResultAsync(username, password);
        }
        
        public bool LoginResult(string username, string password) {
            return base.Channel.LoginResult(username, password);
        }
        
        public System.Threading.Tasks.Task<bool> LoginResultAsync(string username, string password) {
            return base.Channel.LoginResultAsync(username, password);
        }
        
        public bool IsUser(int id) {
            return base.Channel.IsUser(id);
        }
        
        public System.Threading.Tasks.Task<bool> IsUserAsync(int id) {
            return base.Channel.IsUserAsync(id);
        }
        
        public bool IsAdmin(int id) {
            return base.Channel.IsAdmin(id);
        }
        
        public System.Threading.Tasks.Task<bool> IsAdminAsync(int id) {
            return base.Channel.IsAdminAsync(id);
        }
    }
}
