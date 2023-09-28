﻿//------------------------------------------------------------------------------
// <auto-generated>
//    Este código se generó a partir de una plantilla.
//
//    Los cambios manuales en este archivo pueden causar un comportamiento inesperado de la aplicación.
//    Los cambios manuales en este archivo se sobrescribirán si se regenera el código.
// </auto-generated>
//------------------------------------------------------------------------------

using System;
using System.ComponentModel;
using System.Data.EntityClient;
using System.Data.Objects;
using System.Data.Objects.DataClasses;
using System.Linq;
using System.Runtime.Serialization;
using System.Xml.Serialization;

[assembly: EdmSchemaAttribute()]
namespace Car.DataAccessLayer
{
    #region Contextos
    
    /// <summary>
    /// No hay documentación de metadatos disponible.
    /// </summary>
    public partial class MCECarEntities : ObjectContext
    {
        #region Constructores
    
        /// <summary>
        /// Inicializa un nuevo objeto MCECarEntities usando la cadena de conexión encontrada en la sección 'MCECarEntities' del archivo de configuración de la aplicación.
        /// </summary>
        public MCECarEntities() : base("name=MCECarEntities", "MCECarEntities")
        {
            this.ContextOptions.LazyLoadingEnabled = true;
            OnContextCreated();
        }
    
        /// <summary>
        /// Inicializar un nuevo objeto MCECarEntities.
        /// </summary>
        public MCECarEntities(string connectionString) : base(connectionString, "MCECarEntities")
        {
            this.ContextOptions.LazyLoadingEnabled = true;
            OnContextCreated();
        }
    
        /// <summary>
        /// Inicializar un nuevo objeto MCECarEntities.
        /// </summary>
        public MCECarEntities(EntityConnection connection) : base(connection, "MCECarEntities")
        {
            this.ContextOptions.LazyLoadingEnabled = true;
            OnContextCreated();
        }
    
        #endregion
    
        #region Métodos parciales
    
        partial void OnContextCreated();
    
        #endregion
    
        #region Propiedades de ObjectSet
    
        /// <summary>
        /// No hay documentación de metadatos disponible.
        /// </summary>
        public ObjectSet<tblCar> tblCars
        {
            get
            {
                if ((_tblCars == null))
                {
                    _tblCars = base.CreateObjectSet<tblCar>("tblCars");
                }
                return _tblCars;
            }
        }
        private ObjectSet<tblCar> _tblCars;

        #endregion

        #region Métodos AddTo
    
        /// <summary>
        /// Método desusado para agregar un nuevo objeto al EntitySet tblCars. Considere la posibilidad de usar el método .Add de la propiedad ObjectSet&lt;T&gt; asociada.
        /// </summary>
        public void AddTotblCars(tblCar tblCar)
        {
            base.AddObject("tblCars", tblCar);
        }

        #endregion

        #region Importaciones de funciones
    
        /// <summary>
        /// No hay documentación de metadatos disponible.
        /// </summary>
        public ObjectResult<tblCar> GetCars()
        {
            return base.ExecuteFunction<tblCar>("GetCars");
        }
        /// <summary>
        /// No hay documentación de metadatos disponible.
        /// </summary>
        /// <param name="mergeOption"></param>
        public ObjectResult<tblCar> GetCars(MergeOption mergeOption)
        {
            return base.ExecuteFunction<tblCar>("GetCars", mergeOption);
        }

        #endregion

    }

    #endregion

    #region Entidades
    
    /// <summary>
    /// No hay documentación de metadatos disponible.
    /// </summary>
    [EdmEntityTypeAttribute(NamespaceName="MCECarModel", Name="tblCar")]
    [Serializable()]
    [DataContractAttribute(IsReference=true)]
    public partial class tblCar : EntityObject
    {
        #region Método de generador
    
        /// <summary>
        /// Crear un nuevo objeto tblCar.
        /// </summary>
        /// <param name="carId">Valor inicial de la propiedad CarId.</param>
        public static tblCar CreatetblCar(global::System.Int32 carId)
        {
            tblCar tblCar = new tblCar();
            tblCar.CarId = carId;
            return tblCar;
        }

        #endregion

        #region Propiedades primitivas
    
        /// <summary>
        /// No hay documentación de metadatos disponible.
        /// </summary>
        [EdmScalarPropertyAttribute(EntityKeyProperty=true, IsNullable=false)]
        [DataMemberAttribute()]
        public global::System.Int32 CarId
        {
            get
            {
                return _CarId;
            }
            set
            {
                if (_CarId != value)
                {
                    OnCarIdChanging(value);
                    ReportPropertyChanging("CarId");
                    _CarId = StructuralObject.SetValidValue(value);
                    ReportPropertyChanged("CarId");
                    OnCarIdChanged();
                }
            }
        }
        private global::System.Int32 _CarId;
        partial void OnCarIdChanging(global::System.Int32 value);
        partial void OnCarIdChanged();
    
        /// <summary>
        /// No hay documentación de metadatos disponible.
        /// </summary>
        [EdmScalarPropertyAttribute(EntityKeyProperty=false, IsNullable=true)]
        [DataMemberAttribute()]
        public global::System.String CarName
        {
            get
            {
                return _CarName;
            }
            set
            {
                OnCarNameChanging(value);
                ReportPropertyChanging("CarName");
                _CarName = StructuralObject.SetValidValue(value, true);
                ReportPropertyChanged("CarName");
                OnCarNameChanged();
            }
        }
        private global::System.String _CarName;
        partial void OnCarNameChanging(global::System.String value);
        partial void OnCarNameChanged();
    
        /// <summary>
        /// No hay documentación de metadatos disponible.
        /// </summary>
        [EdmScalarPropertyAttribute(EntityKeyProperty=false, IsNullable=true)]
        [DataMemberAttribute()]
        public Nullable<global::System.Int32> CarModel
        {
            get
            {
                return _CarModel;
            }
            set
            {
                OnCarModelChanging(value);
                ReportPropertyChanging("CarModel");
                _CarModel = StructuralObject.SetValidValue(value);
                ReportPropertyChanged("CarModel");
                OnCarModelChanged();
            }
        }
        private Nullable<global::System.Int32> _CarModel;
        partial void OnCarModelChanging(Nullable<global::System.Int32> value);
        partial void OnCarModelChanged();
    
        /// <summary>
        /// No hay documentación de metadatos disponible.
        /// </summary>
        [EdmScalarPropertyAttribute(EntityKeyProperty=false, IsNullable=true)]
        [DataMemberAttribute()]
        public global::System.String Feartures
        {
            get
            {
                return _Feartures;
            }
            set
            {
                OnFearturesChanging(value);
                ReportPropertyChanging("Feartures");
                _Feartures = StructuralObject.SetValidValue(value, true);
                ReportPropertyChanged("Feartures");
                OnFearturesChanged();
            }
        }
        private global::System.String _Feartures;
        partial void OnFearturesChanging(global::System.String value);
        partial void OnFearturesChanged();
    
        /// <summary>
        /// No hay documentación de metadatos disponible.
        /// </summary>
        [EdmScalarPropertyAttribute(EntityKeyProperty=false, IsNullable=true)]
        [DataMemberAttribute()]
        public global::System.String Comments
        {
            get
            {
                return _Comments;
            }
            set
            {
                OnCommentsChanging(value);
                ReportPropertyChanging("Comments");
                _Comments = StructuralObject.SetValidValue(value, true);
                ReportPropertyChanged("Comments");
                OnCommentsChanged();
            }
        }
        private global::System.String _Comments;
        partial void OnCommentsChanging(global::System.String value);
        partial void OnCommentsChanged();

        #endregion

    
    }

    #endregion

    
}