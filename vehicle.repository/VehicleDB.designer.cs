﻿#pragma warning disable 1591
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace vehicle.repository
{
	using System.Data.Linq;
	using System.Data.Linq.Mapping;
	using System.Data;
	using System.Collections.Generic;
	using System.Reflection;
	using System.Linq;
	using System.Linq.Expressions;
	using System.ComponentModel;
	using System;
	
	
	[global::System.Data.Linq.Mapping.DatabaseAttribute(Name="VehicleDB")]
	public partial class VehicleDBDataContext : System.Data.Linq.DataContext
	{
		
		private static System.Data.Linq.Mapping.MappingSource mappingSource = new AttributeMappingSource();
		
    #region Extensibility Method Definitions
    partial void OnCreated();
    partial void InsertMaintenance(Maintenance instance);
    partial void UpdateMaintenance(Maintenance instance);
    partial void DeleteMaintenance(Maintenance instance);
    partial void InsertVehicleRegister(VehicleRegister instance);
    partial void UpdateVehicleRegister(VehicleRegister instance);
    partial void DeleteVehicleRegister(VehicleRegister instance);
    #endregion
		
		public VehicleDBDataContext() : 
				base(global::vehicle.repository.Properties.Settings.Default.VehicleDBConnectionString, mappingSource)
		{
			OnCreated();
		}
		
		public VehicleDBDataContext(string connection) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public VehicleDBDataContext(System.Data.IDbConnection connection) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public VehicleDBDataContext(string connection, System.Data.Linq.Mapping.MappingSource mappingSource) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public VehicleDBDataContext(System.Data.IDbConnection connection, System.Data.Linq.Mapping.MappingSource mappingSource) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public System.Data.Linq.Table<Maintenance> Maintenances
		{
			get
			{
				return this.GetTable<Maintenance>();
			}
		}
		
		public System.Data.Linq.Table<VehicleRegister> VehicleRegisters
		{
			get
			{
				return this.GetTable<VehicleRegister>();
			}
		}
	}
	
	[global::System.Data.Linq.Mapping.TableAttribute(Name="dbo.Maintenance")]
	public partial class Maintenance : INotifyPropertyChanging, INotifyPropertyChanged
	{
		
		private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(String.Empty);
		
		private int _MaintenanceID;
		
		private string _Description;
		
		private System.Nullable<double> _Cost;
		
		private System.Nullable<int> _VehicleID;
		
		private System.Nullable<int> _IsCompleted;
		
		private System.Nullable<System.DateTime> _DateTimeOfService;
		
		private string _PlateNo;
		
    #region Extensibility Method Definitions
    partial void OnLoaded();
    partial void OnValidate(System.Data.Linq.ChangeAction action);
    partial void OnCreated();
    partial void OnMaintenanceIDChanging(int value);
    partial void OnMaintenanceIDChanged();
    partial void OnDescriptionChanging(string value);
    partial void OnDescriptionChanged();
    partial void OnCostChanging(System.Nullable<double> value);
    partial void OnCostChanged();
    partial void OnVehicleIDChanging(System.Nullable<int> value);
    partial void OnVehicleIDChanged();
    partial void OnIsCompletedChanging(System.Nullable<int> value);
    partial void OnIsCompletedChanged();
    partial void OnDateTimeOfServiceChanging(System.Nullable<System.DateTime> value);
    partial void OnDateTimeOfServiceChanged();
    partial void OnPlateNoChanging(string value);
    partial void OnPlateNoChanged();
    #endregion
		
		public Maintenance()
		{
			OnCreated();
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_MaintenanceID", AutoSync=AutoSync.OnInsert, DbType="Int NOT NULL IDENTITY", IsPrimaryKey=true, IsDbGenerated=true)]
		public int MaintenanceID
		{
			get
			{
				return this._MaintenanceID;
			}
			set
			{
				if ((this._MaintenanceID != value))
				{
					this.OnMaintenanceIDChanging(value);
					this.SendPropertyChanging();
					this._MaintenanceID = value;
					this.SendPropertyChanged("MaintenanceID");
					this.OnMaintenanceIDChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Description", DbType="NVarChar(255)")]
		public string Description
		{
			get
			{
				return this._Description;
			}
			set
			{
				if ((this._Description != value))
				{
					this.OnDescriptionChanging(value);
					this.SendPropertyChanging();
					this._Description = value;
					this.SendPropertyChanged("Description");
					this.OnDescriptionChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Cost", DbType="Float")]
		public System.Nullable<double> Cost
		{
			get
			{
				return this._Cost;
			}
			set
			{
				if ((this._Cost != value))
				{
					this.OnCostChanging(value);
					this.SendPropertyChanging();
					this._Cost = value;
					this.SendPropertyChanged("Cost");
					this.OnCostChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_VehicleID", DbType="Int")]
		public System.Nullable<int> VehicleID
		{
			get
			{
				return this._VehicleID;
			}
			set
			{
				if ((this._VehicleID != value))
				{
					this.OnVehicleIDChanging(value);
					this.SendPropertyChanging();
					this._VehicleID = value;
					this.SendPropertyChanged("VehicleID");
					this.OnVehicleIDChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_IsCompleted", DbType="Int")]
		public System.Nullable<int> IsCompleted
		{
			get
			{
				return this._IsCompleted;
			}
			set
			{
				if ((this._IsCompleted != value))
				{
					this.OnIsCompletedChanging(value);
					this.SendPropertyChanging();
					this._IsCompleted = value;
					this.SendPropertyChanged("IsCompleted");
					this.OnIsCompletedChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_DateTimeOfService", DbType="DateTime")]
		public System.Nullable<System.DateTime> DateTimeOfService
		{
			get
			{
				return this._DateTimeOfService;
			}
			set
			{
				if ((this._DateTimeOfService != value))
				{
					this.OnDateTimeOfServiceChanging(value);
					this.SendPropertyChanging();
					this._DateTimeOfService = value;
					this.SendPropertyChanged("DateTimeOfService");
					this.OnDateTimeOfServiceChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_PlateNo", DbType="NVarChar(50)")]
		public string PlateNo
		{
			get
			{
				return this._PlateNo;
			}
			set
			{
				if ((this._PlateNo != value))
				{
					this.OnPlateNoChanging(value);
					this.SendPropertyChanging();
					this._PlateNo = value;
					this.SendPropertyChanged("PlateNo");
					this.OnPlateNoChanged();
				}
			}
		}
		
		public event PropertyChangingEventHandler PropertyChanging;
		
		public event PropertyChangedEventHandler PropertyChanged;
		
		protected virtual void SendPropertyChanging()
		{
			if ((this.PropertyChanging != null))
			{
				this.PropertyChanging(this, emptyChangingEventArgs);
			}
		}
		
		protected virtual void SendPropertyChanged(String propertyName)
		{
			if ((this.PropertyChanged != null))
			{
				this.PropertyChanged(this, new PropertyChangedEventArgs(propertyName));
			}
		}
	}
	
	[global::System.Data.Linq.Mapping.TableAttribute(Name="dbo.VehicleRegister")]
	public partial class VehicleRegister : INotifyPropertyChanging, INotifyPropertyChanged
	{
		
		private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(String.Empty);
		
		private int _VehicleID;
		
		private string _PlateNo;
		
		private string _Model;
		
		private string _Brand;
		
		private string _VehicleType;
		
		private double _ServiceWeight;
		
		private System.DateTime _DateInTrafficFirstTime;
		
		private int _ServiceIsBooked;
		
		private double _YearlyFee;
		
    #region Extensibility Method Definitions
    partial void OnLoaded();
    partial void OnValidate(System.Data.Linq.ChangeAction action);
    partial void OnCreated();
    partial void OnVehicleIDChanging(int value);
    partial void OnVehicleIDChanged();
    partial void OnPlateNoChanging(string value);
    partial void OnPlateNoChanged();
    partial void OnModelChanging(string value);
    partial void OnModelChanged();
    partial void OnBrandChanging(string value);
    partial void OnBrandChanged();
    partial void OnVehicleTypeChanging(string value);
    partial void OnVehicleTypeChanged();
    partial void OnServiceWeightChanging(double value);
    partial void OnServiceWeightChanged();
    partial void OnDateInTrafficFirstTimeChanging(System.DateTime value);
    partial void OnDateInTrafficFirstTimeChanged();
    partial void OnServiceIsBookedChanging(int value);
    partial void OnServiceIsBookedChanged();
    partial void OnYearlyFeeChanging(double value);
    partial void OnYearlyFeeChanged();
    #endregion
		
		public VehicleRegister()
		{
			OnCreated();
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_VehicleID", AutoSync=AutoSync.OnInsert, DbType="Int NOT NULL IDENTITY", IsPrimaryKey=true, IsDbGenerated=true)]
		public int VehicleID
		{
			get
			{
				return this._VehicleID;
			}
			set
			{
				if ((this._VehicleID != value))
				{
					this.OnVehicleIDChanging(value);
					this.SendPropertyChanging();
					this._VehicleID = value;
					this.SendPropertyChanged("VehicleID");
					this.OnVehicleIDChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_PlateNo", DbType="NVarChar(50) NOT NULL", CanBeNull=false)]
		public string PlateNo
		{
			get
			{
				return this._PlateNo;
			}
			set
			{
				if ((this._PlateNo != value))
				{
					this.OnPlateNoChanging(value);
					this.SendPropertyChanging();
					this._PlateNo = value;
					this.SendPropertyChanged("PlateNo");
					this.OnPlateNoChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Model", DbType="NVarChar(50) NOT NULL", CanBeNull=false)]
		public string Model
		{
			get
			{
				return this._Model;
			}
			set
			{
				if ((this._Model != value))
				{
					this.OnModelChanging(value);
					this.SendPropertyChanging();
					this._Model = value;
					this.SendPropertyChanged("Model");
					this.OnModelChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Brand", DbType="NVarChar(50) NOT NULL", CanBeNull=false)]
		public string Brand
		{
			get
			{
				return this._Brand;
			}
			set
			{
				if ((this._Brand != value))
				{
					this.OnBrandChanging(value);
					this.SendPropertyChanging();
					this._Brand = value;
					this.SendPropertyChanged("Brand");
					this.OnBrandChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_VehicleType", DbType="NVarChar(50) NOT NULL", CanBeNull=false)]
		public string VehicleType
		{
			get
			{
				return this._VehicleType;
			}
			set
			{
				if ((this._VehicleType != value))
				{
					this.OnVehicleTypeChanging(value);
					this.SendPropertyChanging();
					this._VehicleType = value;
					this.SendPropertyChanged("VehicleType");
					this.OnVehicleTypeChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_ServiceWeight", DbType="Float NOT NULL")]
		public double ServiceWeight
		{
			get
			{
				return this._ServiceWeight;
			}
			set
			{
				if ((this._ServiceWeight != value))
				{
					this.OnServiceWeightChanging(value);
					this.SendPropertyChanging();
					this._ServiceWeight = value;
					this.SendPropertyChanged("ServiceWeight");
					this.OnServiceWeightChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_DateInTrafficFirstTime", DbType="DateTime NOT NULL")]
		public System.DateTime DateInTrafficFirstTime
		{
			get
			{
				return this._DateInTrafficFirstTime;
			}
			set
			{
				if ((this._DateInTrafficFirstTime != value))
				{
					this.OnDateInTrafficFirstTimeChanging(value);
					this.SendPropertyChanging();
					this._DateInTrafficFirstTime = value;
					this.SendPropertyChanged("DateInTrafficFirstTime");
					this.OnDateInTrafficFirstTimeChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_ServiceIsBooked", DbType="Int NOT NULL")]
		public int ServiceIsBooked
		{
			get
			{
				return this._ServiceIsBooked;
			}
			set
			{
				if ((this._ServiceIsBooked != value))
				{
					this.OnServiceIsBookedChanging(value);
					this.SendPropertyChanging();
					this._ServiceIsBooked = value;
					this.SendPropertyChanged("ServiceIsBooked");
					this.OnServiceIsBookedChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_YearlyFee", DbType="Float NOT NULL")]
		public double YearlyFee
		{
			get
			{
				return this._YearlyFee;
			}
			set
			{
				if ((this._YearlyFee != value))
				{
					this.OnYearlyFeeChanging(value);
					this.SendPropertyChanging();
					this._YearlyFee = value;
					this.SendPropertyChanged("YearlyFee");
					this.OnYearlyFeeChanged();
				}
			}
		}
		
		public event PropertyChangingEventHandler PropertyChanging;
		
		public event PropertyChangedEventHandler PropertyChanged;
		
		protected virtual void SendPropertyChanging()
		{
			if ((this.PropertyChanging != null))
			{
				this.PropertyChanging(this, emptyChangingEventArgs);
			}
		}
		
		protected virtual void SendPropertyChanged(String propertyName)
		{
			if ((this.PropertyChanged != null))
			{
				this.PropertyChanged(this, new PropertyChangedEventArgs(propertyName));
			}
		}
	}
}
#pragma warning restore 1591
