﻿#pragma warning disable 1591
//------------------------------------------------------------------------------
// <auto-generated>
//     此代码由工具生成。
//     运行时版本:4.0.30319.1
//
//     对此文件的更改可能会导致不正确的行为，并且如果
//     重新生成代码，这些更改将会丢失。
// </auto-generated>
//------------------------------------------------------------------------------

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Linq;
using System.Data.Linq.Mapping;
using System.Linq;
using System.Linq.Expressions;
using System.Reflection;



[global::System.Data.Linq.Mapping.DatabaseAttribute(Name="HeRun")]
public partial class linqGongZiDataContext : System.Data.Linq.DataContext
{
	
	private static System.Data.Linq.Mapping.MappingSource mappingSource = new AttributeMappingSource();
	
  #region 可扩展性方法定义
  partial void OnCreated();
  partial void InsertGongZi(GongZi instance);
  partial void UpdateGongZi(GongZi instance);
  partial void DeleteGongZi(GongZi instance);
  #endregion
	
	public linqGongZiDataContext() : 
			base(global::System.Configuration.ConfigurationManager.ConnectionStrings["HeRunConnectionString"].ConnectionString, mappingSource)
	{
		OnCreated();
	}
	
	public linqGongZiDataContext(string connection) : 
			base(connection, mappingSource)
	{
		OnCreated();
	}
	
	public linqGongZiDataContext(System.Data.IDbConnection connection) : 
			base(connection, mappingSource)
	{
		OnCreated();
	}
	
	public linqGongZiDataContext(string connection, System.Data.Linq.Mapping.MappingSource mappingSource) : 
			base(connection, mappingSource)
	{
		OnCreated();
	}
	
	public linqGongZiDataContext(System.Data.IDbConnection connection, System.Data.Linq.Mapping.MappingSource mappingSource) : 
			base(connection, mappingSource)
	{
		OnCreated();
	}
	
	public System.Data.Linq.Table<GongZi> GongZi
	{
		get
		{
			return this.GetTable<GongZi>();
		}
	}
}

[global::System.Data.Linq.Mapping.TableAttribute(Name="dbo.GongZi")]
public partial class GongZi : INotifyPropertyChanging, INotifyPropertyChanged
{
	
	private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(String.Empty);
	
	private int _Gz_Id;
	
	private int _Gz_JiBie;
	
	private int _Gz_GongZi;
	
    #region 可扩展性方法定义
    partial void OnLoaded();
    partial void OnValidate(System.Data.Linq.ChangeAction action);
    partial void OnCreated();
    partial void OnGz_IdChanging(int value);
    partial void OnGz_IdChanged();
    partial void OnGz_JiBieChanging(int value);
    partial void OnGz_JiBieChanged();
    partial void OnGz_GongZiChanging(int value);
    partial void OnGz_GongZiChanged();
    #endregion
	
	public GongZi()
	{
		OnCreated();
	}
	
	[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Gz_Id", AutoSync=AutoSync.OnInsert, DbType="Int NOT NULL IDENTITY", IsPrimaryKey=true, IsDbGenerated=true)]
	public int Gz_Id
	{
		get
		{
			return this._Gz_Id;
		}
		set
		{
			if ((this._Gz_Id != value))
			{
				this.OnGz_IdChanging(value);
				this.SendPropertyChanging();
				this._Gz_Id = value;
				this.SendPropertyChanged("Gz_Id");
				this.OnGz_IdChanged();
			}
		}
	}
	
	[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Gz_JiBie", DbType="Int NOT NULL")]
	public int Gz_JiBie
	{
		get
		{
			return this._Gz_JiBie;
		}
		set
		{
			if ((this._Gz_JiBie != value))
			{
				this.OnGz_JiBieChanging(value);
				this.SendPropertyChanging();
				this._Gz_JiBie = value;
				this.SendPropertyChanged("Gz_JiBie");
				this.OnGz_JiBieChanged();
			}
		}
	}
	
	[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Gz_GongZi", DbType="Int NOT NULL")]
	public int Gz_GongZi
	{
		get
		{
			return this._Gz_GongZi;
		}
		set
		{
			if ((this._Gz_GongZi != value))
			{
				this.OnGz_GongZiChanging(value);
				this.SendPropertyChanging();
				this._Gz_GongZi = value;
				this.SendPropertyChanged("Gz_GongZi");
				this.OnGz_GongZiChanged();
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
#pragma warning restore 1591