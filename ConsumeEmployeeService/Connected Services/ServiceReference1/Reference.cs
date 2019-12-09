﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace ConsumeEmployeeService.ServiceReference1 {
    using System.Runtime.Serialization;
    using System;
    
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Runtime.Serialization", "4.0.0.0")]
    [System.Runtime.Serialization.DataContractAttribute(Name="Employee", Namespace="http://schemas.datacontract.org/2004/07/EmployeeServiceRepository")]
    [System.SerializableAttribute()]
    public partial class Employee : object, System.Runtime.Serialization.IExtensibleDataObject, System.ComponentModel.INotifyPropertyChanged {
        
        [System.NonSerializedAttribute()]
        private System.Runtime.Serialization.ExtensionDataObject extensionDataField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string FirstNameField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private int IdField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string LastNameField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private decimal SalaryField;
        
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
        public string FirstName {
            get {
                return this.FirstNameField;
            }
            set {
                if ((object.ReferenceEquals(this.FirstNameField, value) != true)) {
                    this.FirstNameField = value;
                    this.RaisePropertyChanged("FirstName");
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
        public string LastName {
            get {
                return this.LastNameField;
            }
            set {
                if ((object.ReferenceEquals(this.LastNameField, value) != true)) {
                    this.LastNameField = value;
                    this.RaisePropertyChanged("LastName");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public decimal Salary {
            get {
                return this.SalaryField;
            }
            set {
                if ((this.SalaryField.Equals(value) != true)) {
                    this.SalaryField = value;
                    this.RaisePropertyChanged("Salary");
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
    [System.ServiceModel.ServiceContractAttribute(ConfigurationName="ServiceReference1.IEmployeeRepository")]
    public interface IEmployeeRepository {
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IEmployeeRepository/GetEmployees", ReplyAction="http://tempuri.org/IEmployeeRepository/GetEmployeesResponse")]
        ConsumeEmployeeService.ServiceReference1.Employee[] GetEmployees();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IEmployeeRepository/GetEmployees", ReplyAction="http://tempuri.org/IEmployeeRepository/GetEmployeesResponse")]
        System.Threading.Tasks.Task<ConsumeEmployeeService.ServiceReference1.Employee[]> GetEmployeesAsync();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IEmployeeRepository/GetEmployee", ReplyAction="http://tempuri.org/IEmployeeRepository/GetEmployeeResponse")]
        ConsumeEmployeeService.ServiceReference1.Employee GetEmployee(int id);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IEmployeeRepository/GetEmployee", ReplyAction="http://tempuri.org/IEmployeeRepository/GetEmployeeResponse")]
        System.Threading.Tasks.Task<ConsumeEmployeeService.ServiceReference1.Employee> GetEmployeeAsync(int id);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IEmployeeRepository/CreateEmployees", ReplyAction="http://tempuri.org/IEmployeeRepository/CreateEmployeesResponse")]
        ConsumeEmployeeService.ServiceReference1.Employee CreateEmployees(ConsumeEmployeeService.ServiceReference1.Employee employee);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IEmployeeRepository/CreateEmployees", ReplyAction="http://tempuri.org/IEmployeeRepository/CreateEmployeesResponse")]
        System.Threading.Tasks.Task<ConsumeEmployeeService.ServiceReference1.Employee> CreateEmployeesAsync(ConsumeEmployeeService.ServiceReference1.Employee employee);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IEmployeeRepository/UpdateEmployees", ReplyAction="http://tempuri.org/IEmployeeRepository/UpdateEmployeesResponse")]
        ConsumeEmployeeService.ServiceReference1.Employee UpdateEmployees(ConsumeEmployeeService.ServiceReference1.Employee employee);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IEmployeeRepository/UpdateEmployees", ReplyAction="http://tempuri.org/IEmployeeRepository/UpdateEmployeesResponse")]
        System.Threading.Tasks.Task<ConsumeEmployeeService.ServiceReference1.Employee> UpdateEmployeesAsync(ConsumeEmployeeService.ServiceReference1.Employee employee);
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public interface IEmployeeRepositoryChannel : ConsumeEmployeeService.ServiceReference1.IEmployeeRepository, System.ServiceModel.IClientChannel {
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public partial class EmployeeRepositoryClient : System.ServiceModel.ClientBase<ConsumeEmployeeService.ServiceReference1.IEmployeeRepository>, ConsumeEmployeeService.ServiceReference1.IEmployeeRepository {
        
        public EmployeeRepositoryClient() {
        }
        
        public EmployeeRepositoryClient(string endpointConfigurationName) : 
                base(endpointConfigurationName) {
        }
        
        public EmployeeRepositoryClient(string endpointConfigurationName, string remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public EmployeeRepositoryClient(string endpointConfigurationName, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public EmployeeRepositoryClient(System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(binding, remoteAddress) {
        }
        
        public ConsumeEmployeeService.ServiceReference1.Employee[] GetEmployees() {
            return base.Channel.GetEmployees();
        }
        
        public System.Threading.Tasks.Task<ConsumeEmployeeService.ServiceReference1.Employee[]> GetEmployeesAsync() {
            return base.Channel.GetEmployeesAsync();
        }
        
        public ConsumeEmployeeService.ServiceReference1.Employee GetEmployee(int id) {
            return base.Channel.GetEmployee(id);
        }
        
        public System.Threading.Tasks.Task<ConsumeEmployeeService.ServiceReference1.Employee> GetEmployeeAsync(int id) {
            return base.Channel.GetEmployeeAsync(id);
        }
        
        public ConsumeEmployeeService.ServiceReference1.Employee CreateEmployees(ConsumeEmployeeService.ServiceReference1.Employee employee) {
            return base.Channel.CreateEmployees(employee);
        }
        
        public System.Threading.Tasks.Task<ConsumeEmployeeService.ServiceReference1.Employee> CreateEmployeesAsync(ConsumeEmployeeService.ServiceReference1.Employee employee) {
            return base.Channel.CreateEmployeesAsync(employee);
        }
        
        public ConsumeEmployeeService.ServiceReference1.Employee UpdateEmployees(ConsumeEmployeeService.ServiceReference1.Employee employee) {
            return base.Channel.UpdateEmployees(employee);
        }
        
        public System.Threading.Tasks.Task<ConsumeEmployeeService.ServiceReference1.Employee> UpdateEmployeesAsync(ConsumeEmployeeService.ServiceReference1.Employee employee) {
            return base.Channel.UpdateEmployeesAsync(employee);
        }
    }
}
