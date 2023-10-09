﻿//------------------------------------------------------------------------------
// <auto-generated>
//     Este código fue generado por una herramienta.
//     Versión de runtime:4.0.30319.42000
//
//     Los cambios en este archivo podrían causar un comportamiento incorrecto y se perderán si
//     se vuelve a generar el código.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Client.ServiceReference1 {
    
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ServiceModel.ServiceContractAttribute(ConfigurationName="ServiceReference1.IDatabaseService")]
    public interface IDatabaseService {
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IDatabaseService/AddUserAccountToDatabase", ReplyAction="http://tempuri.org/IDatabaseService/AddUserAccountToDatabaseResponse")]
        void AddUserAccountToDatabase(string nickname, string email, string password);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IDatabaseService/AddUserAccountToDatabase", ReplyAction="http://tempuri.org/IDatabaseService/AddUserAccountToDatabaseResponse")]
        System.Threading.Tasks.Task AddUserAccountToDatabaseAsync(string nickname, string email, string password);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IDatabaseService/ShowUsersAccounts", ReplyAction="http://tempuri.org/IDatabaseService/ShowUsersAccountsResponse")]
        void ShowUsersAccounts();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IDatabaseService/ShowUsersAccounts", ReplyAction="http://tempuri.org/IDatabaseService/ShowUsersAccountsResponse")]
        System.Threading.Tasks.Task ShowUsersAccountsAsync();
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public interface IDatabaseServiceChannel : Client.ServiceReference1.IDatabaseService, System.ServiceModel.IClientChannel {
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public partial class DatabaseServiceClient : System.ServiceModel.ClientBase<Client.ServiceReference1.IDatabaseService>, Client.ServiceReference1.IDatabaseService {
        
        public DatabaseServiceClient() {
        }
        
        public DatabaseServiceClient(string endpointConfigurationName) : 
                base(endpointConfigurationName) {
        }
        
        public DatabaseServiceClient(string endpointConfigurationName, string remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public DatabaseServiceClient(string endpointConfigurationName, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public DatabaseServiceClient(System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(binding, remoteAddress) {
        }
        
        public void AddUserAccountToDatabase(string nickname, string email, string password) {
            base.Channel.AddUserAccountToDatabase(nickname, email, password);
        }
        
        public System.Threading.Tasks.Task AddUserAccountToDatabaseAsync(string nickname, string email, string password) {
            return base.Channel.AddUserAccountToDatabaseAsync(nickname, email, password);
        }
        
        public void ShowUsersAccounts() {
            base.Channel.ShowUsersAccounts();
        }
        
        public System.Threading.Tasks.Task ShowUsersAccountsAsync() {
            return base.Channel.ShowUsersAccountsAsync();
        }
    }
}
