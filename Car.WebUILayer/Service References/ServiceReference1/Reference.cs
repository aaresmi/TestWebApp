﻿//------------------------------------------------------------------------------
// <auto-generated>
//     Este código fue generado por una herramienta.
//     Versión de runtime:4.0.30319.42000
//
//     Los cambios en este archivo podrían causar un comportamiento incorrecto y se perderán si
//     se vuelve a generar el código.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Car.WebUILayer.ServiceReference1 {
    using System.Runtime.Serialization;
    using System;
    
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Runtime.Serialization", "4.0.0.0")]
    [System.Runtime.Serialization.DataContractAttribute(Name="CarServiceError", Namespace="http://schemas.datacontract.org/2004/07/Car.ServiceLayer")]
    [System.SerializableAttribute()]
    public partial class CarServiceError : object, System.Runtime.Serialization.IExtensibleDataObject, System.ComponentModel.INotifyPropertyChanged {
        
        [System.NonSerializedAttribute()]
        private System.Runtime.Serialization.ExtensionDataObject extensionDataField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string errorMessageField;
        
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
        public string errorMessage {
            get {
                return this.errorMessageField;
            }
            set {
                if ((object.ReferenceEquals(this.errorMessageField, value) != true)) {
                    this.errorMessageField = value;
                    this.RaisePropertyChanged("errorMessage");
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
    [System.ServiceModel.ServiceContractAttribute(ConfigurationName="ServiceReference1.ICarService")]
    public interface ICarService {
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ICarService/RetrieveAllCars", ReplyAction="http://tempuri.org/ICarService/RetrieveAllCarsResponse")]
        [System.ServiceModel.FaultContractAttribute(typeof(Car.WebUILayer.ServiceReference1.CarServiceError), Action="http://tempuri.org/ICarService/RetrieveAllCarsCarServiceErrorFault", Name="CarServiceError", Namespace="http://schemas.datacontract.org/2004/07/Car.ServiceLayer")]
        Car.Entities.Car[] RetrieveAllCars();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ICarService/RetrieveAllCarsDetails", ReplyAction="http://tempuri.org/ICarService/RetrieveAllCarsDetailsResponse")]
        [System.ServiceModel.FaultContractAttribute(typeof(Car.WebUILayer.ServiceReference1.CarServiceError), Action="http://tempuri.org/ICarService/RetrieveAllCarsDetailsCarServiceErrorFault", Name="CarServiceError", Namespace="http://schemas.datacontract.org/2004/07/Car.ServiceLayer")]
        Car.Entities.Car[] RetrieveAllCarsDetails(int CarId);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ICarService/AddACar", ReplyAction="http://tempuri.org/ICarService/AddACarResponse")]
        [System.ServiceModel.FaultContractAttribute(typeof(Car.WebUILayer.ServiceReference1.CarServiceError), Action="http://tempuri.org/ICarService/AddACarCarServiceErrorFault", Name="CarServiceError", Namespace="http://schemas.datacontract.org/2004/07/Car.ServiceLayer")]
        bool AddACar(Car.Entities.Car car);
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public interface ICarServiceChannel : Car.WebUILayer.ServiceReference1.ICarService, System.ServiceModel.IClientChannel {
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public partial class CarServiceClient : System.ServiceModel.ClientBase<Car.WebUILayer.ServiceReference1.ICarService>, Car.WebUILayer.ServiceReference1.ICarService {
        
        public CarServiceClient() {
        }
        
        public CarServiceClient(string endpointConfigurationName) : 
                base(endpointConfigurationName) {
        }
        
        public CarServiceClient(string endpointConfigurationName, string remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public CarServiceClient(string endpointConfigurationName, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public CarServiceClient(System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(binding, remoteAddress) {
        }
        
        public Car.Entities.Car[] RetrieveAllCars() {
            return base.Channel.RetrieveAllCars();
        }
        
        public Car.Entities.Car[] RetrieveAllCarsDetails(int CarId) {
            return base.Channel.RetrieveAllCarsDetails(CarId);
        }
        
        public bool AddACar(Car.Entities.Car car) {
            return base.Channel.AddACar(car);
        }
    }
}
