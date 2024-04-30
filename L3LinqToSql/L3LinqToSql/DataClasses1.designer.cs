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

namespace L3LinqToSql
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
	
	
	[global::System.Data.Linq.Mapping.DatabaseAttribute(Name="Database1")]
	public partial class DataClasses1DataContext : System.Data.Linq.DataContext
	{
		
		private static System.Data.Linq.Mapping.MappingSource mappingSource = new AttributeMappingSource();
		
    #region Extensibility Method Definitions
    partial void OnCreated();
    partial void InsertFacultati(Facultati instance);
    partial void UpdateFacultati(Facultati instance);
    partial void DeleteFacultati(Facultati instance);
    partial void InsertUniversitati(Universitati instance);
    partial void UpdateUniversitati(Universitati instance);
    partial void DeleteUniversitati(Universitati instance);
    #endregion
		
		public DataClasses1DataContext() : 
				base(global::L3LinqToSql.Properties.Settings.Default.Database1ConnectionString, mappingSource)
		{
			OnCreated();
		}
		
		public DataClasses1DataContext(string connection) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public DataClasses1DataContext(System.Data.IDbConnection connection) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public DataClasses1DataContext(string connection, System.Data.Linq.Mapping.MappingSource mappingSource) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public DataClasses1DataContext(System.Data.IDbConnection connection, System.Data.Linq.Mapping.MappingSource mappingSource) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public System.Data.Linq.Table<Facultati> Facultatis
		{
			get
			{
				return this.GetTable<Facultati>();
			}
		}
		
		public System.Data.Linq.Table<Universitati> Universitatis
		{
			get
			{
				return this.GetTable<Universitati>();
			}
		}
	}
	
	[global::System.Data.Linq.Mapping.TableAttribute(Name="dbo.Facultati")]
	public partial class Facultati : INotifyPropertyChanging, INotifyPropertyChanged
	{
		
		private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(String.Empty);
		
		private int _Id;
		
		private int _Code;
		
		private string _NameFac;
		
		private EntityRef<Universitati> _Universitati;
		
    #region Extensibility Method Definitions
    partial void OnLoaded();
    partial void OnValidate(System.Data.Linq.ChangeAction action);
    partial void OnCreated();
    partial void OnIdChanging(int value);
    partial void OnIdChanged();
    partial void OnCodeChanging(int value);
    partial void OnCodeChanged();
    partial void OnNameFacChanging(string value);
    partial void OnNameFacChanged();
    #endregion
		
		public Facultati()
		{
			this._Universitati = default(EntityRef<Universitati>);
			OnCreated();
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Id", AutoSync=AutoSync.OnInsert, DbType="Int NOT NULL IDENTITY", IsPrimaryKey=true, IsDbGenerated=true)]
		public int Id
		{
			get
			{
				return this._Id;
			}
			set
			{
				if ((this._Id != value))
				{
					this.OnIdChanging(value);
					this.SendPropertyChanging();
					this._Id = value;
					this.SendPropertyChanged("Id");
					this.OnIdChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Code", DbType="Int NOT NULL")]
		public int Code
		{
			get
			{
				return this._Code;
			}
			set
			{
				if ((this._Code != value))
				{
					if (this._Universitati.HasLoadedOrAssignedValue)
					{
						throw new System.Data.Linq.ForeignKeyReferenceAlreadyHasValueException();
					}
					this.OnCodeChanging(value);
					this.SendPropertyChanging();
					this._Code = value;
					this.SendPropertyChanged("Code");
					this.OnCodeChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_NameFac", DbType="Text NOT NULL", CanBeNull=false, UpdateCheck=UpdateCheck.Never)]
		public string NameFac
		{
			get
			{
				return this._NameFac;
			}
			set
			{
				if ((this._NameFac != value))
				{
					this.OnNameFacChanging(value);
					this.SendPropertyChanging();
					this._NameFac = value;
					this.SendPropertyChanged("NameFac");
					this.OnNameFacChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.AssociationAttribute(Name="Universitati_Facultati", Storage="_Universitati", ThisKey="Code", OtherKey="Code", IsForeignKey=true)]
		public Universitati Universitati
		{
			get
			{
				return this._Universitati.Entity;
			}
			set
			{
				Universitati previousValue = this._Universitati.Entity;
				if (((previousValue != value) 
							|| (this._Universitati.HasLoadedOrAssignedValue == false)))
				{
					this.SendPropertyChanging();
					if ((previousValue != null))
					{
						this._Universitati.Entity = null;
						previousValue.Facultatis.Remove(this);
					}
					this._Universitati.Entity = value;
					if ((value != null))
					{
						value.Facultatis.Add(this);
						this._Code = value.Code;
					}
					else
					{
						this._Code = default(int);
					}
					this.SendPropertyChanged("Universitati");
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
	
	[global::System.Data.Linq.Mapping.TableAttribute(Name="dbo.Universitati")]
	public partial class Universitati : INotifyPropertyChanging, INotifyPropertyChanged
	{
		
		private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(String.Empty);
		
		private int _Id;
		
		private string _NameUniv;
		
		private string _City;
		
		private int _Code;
		
		private EntitySet<Facultati> _Facultatis;
		
    #region Extensibility Method Definitions
    partial void OnLoaded();
    partial void OnValidate(System.Data.Linq.ChangeAction action);
    partial void OnCreated();
    partial void OnIdChanging(int value);
    partial void OnIdChanged();
    partial void OnNameUnivChanging(string value);
    partial void OnNameUnivChanged();
    partial void OnCityChanging(string value);
    partial void OnCityChanged();
    partial void OnCodeChanging(int value);
    partial void OnCodeChanged();
    #endregion
		
		public Universitati()
		{
			this._Facultatis = new EntitySet<Facultati>(new Action<Facultati>(this.attach_Facultatis), new Action<Facultati>(this.detach_Facultatis));
			OnCreated();
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Id", DbType="Int NOT NULL")]
		public int Id
		{
			get
			{
				return this._Id;
			}
			set
			{
				if ((this._Id != value))
				{
					this.OnIdChanging(value);
					this.SendPropertyChanging();
					this._Id = value;
					this.SendPropertyChanged("Id");
					this.OnIdChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_NameUniv", DbType="Text NOT NULL", CanBeNull=false, UpdateCheck=UpdateCheck.Never)]
		public string NameUniv
		{
			get
			{
				return this._NameUniv;
			}
			set
			{
				if ((this._NameUniv != value))
				{
					this.OnNameUnivChanging(value);
					this.SendPropertyChanging();
					this._NameUniv = value;
					this.SendPropertyChanged("NameUniv");
					this.OnNameUnivChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_City", DbType="Text NOT NULL", CanBeNull=false, UpdateCheck=UpdateCheck.Never)]
		public string City
		{
			get
			{
				return this._City;
			}
			set
			{
				if ((this._City != value))
				{
					this.OnCityChanging(value);
					this.SendPropertyChanging();
					this._City = value;
					this.SendPropertyChanged("City");
					this.OnCityChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Code", AutoSync=AutoSync.OnInsert, DbType="Int NOT NULL IDENTITY", IsPrimaryKey=true, IsDbGenerated=true)]
		public int Code
		{
			get
			{
				return this._Code;
			}
			set
			{
				if ((this._Code != value))
				{
					this.OnCodeChanging(value);
					this.SendPropertyChanging();
					this._Code = value;
					this.SendPropertyChanged("Code");
					this.OnCodeChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.AssociationAttribute(Name="Universitati_Facultati", Storage="_Facultatis", ThisKey="Code", OtherKey="Code")]
		public EntitySet<Facultati> Facultatis
		{
			get
			{
				return this._Facultatis;
			}
			set
			{
				this._Facultatis.Assign(value);
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
		
		private void attach_Facultatis(Facultati entity)
		{
			this.SendPropertyChanging();
			entity.Universitati = this;
		}
		
		private void detach_Facultatis(Facultati entity)
		{
			this.SendPropertyChanging();
			entity.Universitati = null;
		}
	}
}
#pragma warning restore 1591
