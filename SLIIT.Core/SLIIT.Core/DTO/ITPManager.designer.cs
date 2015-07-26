﻿#pragma warning disable 1591
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.34209
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace SLIIT.Core.DTO
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
	
	
	[global::System.Data.Linq.Mapping.DatabaseAttribute(Name="SLIIT.ITP")]
	public partial class ITPManagerDataContext : System.Data.Linq.DataContext
	{
		
		private static System.Data.Linq.Mapping.MappingSource mappingSource = new AttributeMappingSource();
		
    #region Extensibility Method Definitions
    partial void OnCreated();
    partial void InsertTB_Menu(TB_Menu instance);
    partial void UpdateTB_Menu(TB_Menu instance);
    partial void DeleteTB_Menu(TB_Menu instance);
    partial void InsertTB_UserRole(TB_UserRole instance);
    partial void UpdateTB_UserRole(TB_UserRole instance);
    partial void DeleteTB_UserRole(TB_UserRole instance);
    partial void InsertTB_MenuRole(TB_MenuRole instance);
    partial void UpdateTB_MenuRole(TB_MenuRole instance);
    partial void DeleteTB_MenuRole(TB_MenuRole instance);
    partial void InsertTB_Role(TB_Role instance);
    partial void UpdateTB_Role(TB_Role instance);
    partial void DeleteTB_Role(TB_Role instance);
    partial void InsertTB_User(TB_User instance);
    partial void UpdateTB_User(TB_User instance);
    partial void DeleteTB_User(TB_User instance);
    #endregion
		
		public ITPManagerDataContext() : 
				base(global::SLIIT.Core.Properties.Settings.Default.SLIIT_ITPConnectionString, mappingSource)
		{
			OnCreated();
		}
		
		public ITPManagerDataContext(string connection) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public ITPManagerDataContext(System.Data.IDbConnection connection) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public ITPManagerDataContext(string connection, System.Data.Linq.Mapping.MappingSource mappingSource) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public ITPManagerDataContext(System.Data.IDbConnection connection, System.Data.Linq.Mapping.MappingSource mappingSource) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public System.Data.Linq.Table<TB_Menu> TB_Menus
		{
			get
			{
				return this.GetTable<TB_Menu>();
			}
		}
		
		public System.Data.Linq.Table<TB_UserRole> TB_UserRoles
		{
			get
			{
				return this.GetTable<TB_UserRole>();
			}
		}
		
		public System.Data.Linq.Table<TB_MenuRole> TB_MenuRoles
		{
			get
			{
				return this.GetTable<TB_MenuRole>();
			}
		}
		
		public System.Data.Linq.Table<TB_Role> TB_Roles
		{
			get
			{
				return this.GetTable<TB_Role>();
			}
		}
		
		public System.Data.Linq.Table<TB_User> TB_Users
		{
			get
			{
				return this.GetTable<TB_User>();
			}
		}
	}
	
	[global::System.Data.Linq.Mapping.TableAttribute(Name="dbo.TB_Menu")]
	public partial class TB_Menu : INotifyPropertyChanging, INotifyPropertyChanged
	{
		
		private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(String.Empty);
		
		private int _RnMenu;
		
		private string _MenuName;
		
		private string _MenuImage;
		
		private string _MenuPath;
		
		private string _MenuColorStyle;
		
		private System.Nullable<int> _MenuOrder;
		
		private EntitySet<TB_MenuRole> _TB_MenuRoles;
		
    #region Extensibility Method Definitions
    partial void OnLoaded();
    partial void OnValidate(System.Data.Linq.ChangeAction action);
    partial void OnCreated();
    partial void OnRnMenuChanging(int value);
    partial void OnRnMenuChanged();
    partial void OnMenuNameChanging(string value);
    partial void OnMenuNameChanged();
    partial void OnMenuImageChanging(string value);
    partial void OnMenuImageChanged();
    partial void OnMenuPathChanging(string value);
    partial void OnMenuPathChanged();
    partial void OnMenuColorStyleChanging(string value);
    partial void OnMenuColorStyleChanged();
    partial void OnMenuOrderChanging(System.Nullable<int> value);
    partial void OnMenuOrderChanged();
    #endregion
		
		public TB_Menu()
		{
			this._TB_MenuRoles = new EntitySet<TB_MenuRole>(new Action<TB_MenuRole>(this.attach_TB_MenuRoles), new Action<TB_MenuRole>(this.detach_TB_MenuRoles));
			OnCreated();
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_RnMenu", AutoSync=AutoSync.OnInsert, DbType="Int NOT NULL IDENTITY", IsPrimaryKey=true, IsDbGenerated=true)]
		public int RnMenu
		{
			get
			{
				return this._RnMenu;
			}
			set
			{
				if ((this._RnMenu != value))
				{
					this.OnRnMenuChanging(value);
					this.SendPropertyChanging();
					this._RnMenu = value;
					this.SendPropertyChanged("RnMenu");
					this.OnRnMenuChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_MenuName", DbType="VarChar(MAX)")]
		public string MenuName
		{
			get
			{
				return this._MenuName;
			}
			set
			{
				if ((this._MenuName != value))
				{
					this.OnMenuNameChanging(value);
					this.SendPropertyChanging();
					this._MenuName = value;
					this.SendPropertyChanged("MenuName");
					this.OnMenuNameChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_MenuImage", DbType="VarChar(MAX)")]
		public string MenuImage
		{
			get
			{
				return this._MenuImage;
			}
			set
			{
				if ((this._MenuImage != value))
				{
					this.OnMenuImageChanging(value);
					this.SendPropertyChanging();
					this._MenuImage = value;
					this.SendPropertyChanged("MenuImage");
					this.OnMenuImageChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_MenuPath", DbType="VarChar(MAX)")]
		public string MenuPath
		{
			get
			{
				return this._MenuPath;
			}
			set
			{
				if ((this._MenuPath != value))
				{
					this.OnMenuPathChanging(value);
					this.SendPropertyChanging();
					this._MenuPath = value;
					this.SendPropertyChanged("MenuPath");
					this.OnMenuPathChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_MenuColorStyle", DbType="VarChar(MAX)")]
		public string MenuColorStyle
		{
			get
			{
				return this._MenuColorStyle;
			}
			set
			{
				if ((this._MenuColorStyle != value))
				{
					this.OnMenuColorStyleChanging(value);
					this.SendPropertyChanging();
					this._MenuColorStyle = value;
					this.SendPropertyChanged("MenuColorStyle");
					this.OnMenuColorStyleChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_MenuOrder", DbType="Int")]
		public System.Nullable<int> MenuOrder
		{
			get
			{
				return this._MenuOrder;
			}
			set
			{
				if ((this._MenuOrder != value))
				{
					this.OnMenuOrderChanging(value);
					this.SendPropertyChanging();
					this._MenuOrder = value;
					this.SendPropertyChanged("MenuOrder");
					this.OnMenuOrderChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.AssociationAttribute(Name="TB_Menu_TB_MenuRole", Storage="_TB_MenuRoles", ThisKey="RnMenu", OtherKey="MenuID")]
		public EntitySet<TB_MenuRole> TB_MenuRoles
		{
			get
			{
				return this._TB_MenuRoles;
			}
			set
			{
				this._TB_MenuRoles.Assign(value);
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
		
		private void attach_TB_MenuRoles(TB_MenuRole entity)
		{
			this.SendPropertyChanging();
			entity.TB_Menu = this;
		}
		
		private void detach_TB_MenuRoles(TB_MenuRole entity)
		{
			this.SendPropertyChanging();
			entity.TB_Menu = null;
		}
	}
	
	[global::System.Data.Linq.Mapping.TableAttribute(Name="dbo.TB_UserRole")]
	public partial class TB_UserRole : INotifyPropertyChanging, INotifyPropertyChanged
	{
		
		private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(String.Empty);
		
		private int _RnUserRoleID;
		
		private System.Nullable<int> _RoleID;
		
		private System.Nullable<int> _UserID;
		
		private EntityRef<TB_Role> _TB_Role;
		
		private EntityRef<TB_User> _TB_User;
		
    #region Extensibility Method Definitions
    partial void OnLoaded();
    partial void OnValidate(System.Data.Linq.ChangeAction action);
    partial void OnCreated();
    partial void OnRnUserRoleIDChanging(int value);
    partial void OnRnUserRoleIDChanged();
    partial void OnRoleIDChanging(System.Nullable<int> value);
    partial void OnRoleIDChanged();
    partial void OnUserIDChanging(System.Nullable<int> value);
    partial void OnUserIDChanged();
    #endregion
		
		public TB_UserRole()
		{
			this._TB_Role = default(EntityRef<TB_Role>);
			this._TB_User = default(EntityRef<TB_User>);
			OnCreated();
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_RnUserRoleID", AutoSync=AutoSync.OnInsert, DbType="Int NOT NULL IDENTITY", IsPrimaryKey=true, IsDbGenerated=true)]
		public int RnUserRoleID
		{
			get
			{
				return this._RnUserRoleID;
			}
			set
			{
				if ((this._RnUserRoleID != value))
				{
					this.OnRnUserRoleIDChanging(value);
					this.SendPropertyChanging();
					this._RnUserRoleID = value;
					this.SendPropertyChanged("RnUserRoleID");
					this.OnRnUserRoleIDChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_RoleID", DbType="Int")]
		public System.Nullable<int> RoleID
		{
			get
			{
				return this._RoleID;
			}
			set
			{
				if ((this._RoleID != value))
				{
					if (this._TB_Role.HasLoadedOrAssignedValue)
					{
						throw new System.Data.Linq.ForeignKeyReferenceAlreadyHasValueException();
					}
					this.OnRoleIDChanging(value);
					this.SendPropertyChanging();
					this._RoleID = value;
					this.SendPropertyChanged("RoleID");
					this.OnRoleIDChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_UserID", DbType="Int")]
		public System.Nullable<int> UserID
		{
			get
			{
				return this._UserID;
			}
			set
			{
				if ((this._UserID != value))
				{
					if (this._TB_User.HasLoadedOrAssignedValue)
					{
						throw new System.Data.Linq.ForeignKeyReferenceAlreadyHasValueException();
					}
					this.OnUserIDChanging(value);
					this.SendPropertyChanging();
					this._UserID = value;
					this.SendPropertyChanged("UserID");
					this.OnUserIDChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.AssociationAttribute(Name="TB_Role_TB_UserRole", Storage="_TB_Role", ThisKey="RoleID", OtherKey="RnRoleID", IsForeignKey=true)]
		public TB_Role TB_Role
		{
			get
			{
				return this._TB_Role.Entity;
			}
			set
			{
				TB_Role previousValue = this._TB_Role.Entity;
				if (((previousValue != value) 
							|| (this._TB_Role.HasLoadedOrAssignedValue == false)))
				{
					this.SendPropertyChanging();
					if ((previousValue != null))
					{
						this._TB_Role.Entity = null;
						previousValue.TB_UserRoles.Remove(this);
					}
					this._TB_Role.Entity = value;
					if ((value != null))
					{
						value.TB_UserRoles.Add(this);
						this._RoleID = value.RnRoleID;
					}
					else
					{
						this._RoleID = default(Nullable<int>);
					}
					this.SendPropertyChanged("TB_Role");
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.AssociationAttribute(Name="TB_User_TB_UserRole", Storage="_TB_User", ThisKey="UserID", OtherKey="RnUserID", IsForeignKey=true)]
		public TB_User TB_User
		{
			get
			{
				return this._TB_User.Entity;
			}
			set
			{
				TB_User previousValue = this._TB_User.Entity;
				if (((previousValue != value) 
							|| (this._TB_User.HasLoadedOrAssignedValue == false)))
				{
					this.SendPropertyChanging();
					if ((previousValue != null))
					{
						this._TB_User.Entity = null;
						previousValue.TB_UserRoles.Remove(this);
					}
					this._TB_User.Entity = value;
					if ((value != null))
					{
						value.TB_UserRoles.Add(this);
						this._UserID = value.RnUserID;
					}
					else
					{
						this._UserID = default(Nullable<int>);
					}
					this.SendPropertyChanged("TB_User");
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
	
	[global::System.Data.Linq.Mapping.TableAttribute(Name="dbo.TB_MenuRole")]
	public partial class TB_MenuRole : INotifyPropertyChanging, INotifyPropertyChanged
	{
		
		private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(String.Empty);
		
		private int _RnMenuRoleID;
		
		private System.Nullable<int> _MenuID;
		
		private System.Nullable<int> _RoleID;
		
		private EntityRef<TB_Menu> _TB_Menu;
		
		private EntityRef<TB_Role> _TB_Role;
		
    #region Extensibility Method Definitions
    partial void OnLoaded();
    partial void OnValidate(System.Data.Linq.ChangeAction action);
    partial void OnCreated();
    partial void OnRnMenuRoleIDChanging(int value);
    partial void OnRnMenuRoleIDChanged();
    partial void OnMenuIDChanging(System.Nullable<int> value);
    partial void OnMenuIDChanged();
    partial void OnRoleIDChanging(System.Nullable<int> value);
    partial void OnRoleIDChanged();
    #endregion
		
		public TB_MenuRole()
		{
			this._TB_Menu = default(EntityRef<TB_Menu>);
			this._TB_Role = default(EntityRef<TB_Role>);
			OnCreated();
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_RnMenuRoleID", AutoSync=AutoSync.OnInsert, DbType="Int NOT NULL IDENTITY", IsPrimaryKey=true, IsDbGenerated=true)]
		public int RnMenuRoleID
		{
			get
			{
				return this._RnMenuRoleID;
			}
			set
			{
				if ((this._RnMenuRoleID != value))
				{
					this.OnRnMenuRoleIDChanging(value);
					this.SendPropertyChanging();
					this._RnMenuRoleID = value;
					this.SendPropertyChanged("RnMenuRoleID");
					this.OnRnMenuRoleIDChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_MenuID", DbType="Int")]
		public System.Nullable<int> MenuID
		{
			get
			{
				return this._MenuID;
			}
			set
			{
				if ((this._MenuID != value))
				{
					if (this._TB_Menu.HasLoadedOrAssignedValue)
					{
						throw new System.Data.Linq.ForeignKeyReferenceAlreadyHasValueException();
					}
					this.OnMenuIDChanging(value);
					this.SendPropertyChanging();
					this._MenuID = value;
					this.SendPropertyChanged("MenuID");
					this.OnMenuIDChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_RoleID", DbType="Int")]
		public System.Nullable<int> RoleID
		{
			get
			{
				return this._RoleID;
			}
			set
			{
				if ((this._RoleID != value))
				{
					if (this._TB_Role.HasLoadedOrAssignedValue)
					{
						throw new System.Data.Linq.ForeignKeyReferenceAlreadyHasValueException();
					}
					this.OnRoleIDChanging(value);
					this.SendPropertyChanging();
					this._RoleID = value;
					this.SendPropertyChanged("RoleID");
					this.OnRoleIDChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.AssociationAttribute(Name="TB_Menu_TB_MenuRole", Storage="_TB_Menu", ThisKey="MenuID", OtherKey="RnMenu", IsForeignKey=true)]
		public TB_Menu TB_Menu
		{
			get
			{
				return this._TB_Menu.Entity;
			}
			set
			{
				TB_Menu previousValue = this._TB_Menu.Entity;
				if (((previousValue != value) 
							|| (this._TB_Menu.HasLoadedOrAssignedValue == false)))
				{
					this.SendPropertyChanging();
					if ((previousValue != null))
					{
						this._TB_Menu.Entity = null;
						previousValue.TB_MenuRoles.Remove(this);
					}
					this._TB_Menu.Entity = value;
					if ((value != null))
					{
						value.TB_MenuRoles.Add(this);
						this._MenuID = value.RnMenu;
					}
					else
					{
						this._MenuID = default(Nullable<int>);
					}
					this.SendPropertyChanged("TB_Menu");
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.AssociationAttribute(Name="TB_Role_TB_MenuRole", Storage="_TB_Role", ThisKey="RoleID", OtherKey="RnRoleID", IsForeignKey=true)]
		public TB_Role TB_Role
		{
			get
			{
				return this._TB_Role.Entity;
			}
			set
			{
				TB_Role previousValue = this._TB_Role.Entity;
				if (((previousValue != value) 
							|| (this._TB_Role.HasLoadedOrAssignedValue == false)))
				{
					this.SendPropertyChanging();
					if ((previousValue != null))
					{
						this._TB_Role.Entity = null;
						previousValue.TB_MenuRoles.Remove(this);
					}
					this._TB_Role.Entity = value;
					if ((value != null))
					{
						value.TB_MenuRoles.Add(this);
						this._RoleID = value.RnRoleID;
					}
					else
					{
						this._RoleID = default(Nullable<int>);
					}
					this.SendPropertyChanged("TB_Role");
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
	
	[global::System.Data.Linq.Mapping.TableAttribute(Name="dbo.TB_Role")]
	public partial class TB_Role : INotifyPropertyChanging, INotifyPropertyChanged
	{
		
		private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(String.Empty);
		
		private int _RnRoleID;
		
		private string _RoleName;
		
		private string _RoleIcon;
		
		private EntitySet<TB_UserRole> _TB_UserRoles;
		
		private EntitySet<TB_MenuRole> _TB_MenuRoles;
		
    #region Extensibility Method Definitions
    partial void OnLoaded();
    partial void OnValidate(System.Data.Linq.ChangeAction action);
    partial void OnCreated();
    partial void OnRnRoleIDChanging(int value);
    partial void OnRnRoleIDChanged();
    partial void OnRoleNameChanging(string value);
    partial void OnRoleNameChanged();
    partial void OnRoleIconChanging(string value);
    partial void OnRoleIconChanged();
    #endregion
		
		public TB_Role()
		{
			this._TB_UserRoles = new EntitySet<TB_UserRole>(new Action<TB_UserRole>(this.attach_TB_UserRoles), new Action<TB_UserRole>(this.detach_TB_UserRoles));
			this._TB_MenuRoles = new EntitySet<TB_MenuRole>(new Action<TB_MenuRole>(this.attach_TB_MenuRoles), new Action<TB_MenuRole>(this.detach_TB_MenuRoles));
			OnCreated();
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_RnRoleID", AutoSync=AutoSync.OnInsert, DbType="Int NOT NULL IDENTITY", IsPrimaryKey=true, IsDbGenerated=true)]
		public int RnRoleID
		{
			get
			{
				return this._RnRoleID;
			}
			set
			{
				if ((this._RnRoleID != value))
				{
					this.OnRnRoleIDChanging(value);
					this.SendPropertyChanging();
					this._RnRoleID = value;
					this.SendPropertyChanged("RnRoleID");
					this.OnRnRoleIDChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_RoleName", DbType="VarChar(MAX)")]
		public string RoleName
		{
			get
			{
				return this._RoleName;
			}
			set
			{
				if ((this._RoleName != value))
				{
					this.OnRoleNameChanging(value);
					this.SendPropertyChanging();
					this._RoleName = value;
					this.SendPropertyChanged("RoleName");
					this.OnRoleNameChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_RoleIcon", DbType="VarChar(MAX)")]
		public string RoleIcon
		{
			get
			{
				return this._RoleIcon;
			}
			set
			{
				if ((this._RoleIcon != value))
				{
					this.OnRoleIconChanging(value);
					this.SendPropertyChanging();
					this._RoleIcon = value;
					this.SendPropertyChanged("RoleIcon");
					this.OnRoleIconChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.AssociationAttribute(Name="TB_Role_TB_UserRole", Storage="_TB_UserRoles", ThisKey="RnRoleID", OtherKey="RoleID")]
		public EntitySet<TB_UserRole> TB_UserRoles
		{
			get
			{
				return this._TB_UserRoles;
			}
			set
			{
				this._TB_UserRoles.Assign(value);
			}
		}
		
		[global::System.Data.Linq.Mapping.AssociationAttribute(Name="TB_Role_TB_MenuRole", Storage="_TB_MenuRoles", ThisKey="RnRoleID", OtherKey="RoleID")]
		public EntitySet<TB_MenuRole> TB_MenuRoles
		{
			get
			{
				return this._TB_MenuRoles;
			}
			set
			{
				this._TB_MenuRoles.Assign(value);
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
		
		private void attach_TB_UserRoles(TB_UserRole entity)
		{
			this.SendPropertyChanging();
			entity.TB_Role = this;
		}
		
		private void detach_TB_UserRoles(TB_UserRole entity)
		{
			this.SendPropertyChanging();
			entity.TB_Role = null;
		}
		
		private void attach_TB_MenuRoles(TB_MenuRole entity)
		{
			this.SendPropertyChanging();
			entity.TB_Role = this;
		}
		
		private void detach_TB_MenuRoles(TB_MenuRole entity)
		{
			this.SendPropertyChanging();
			entity.TB_Role = null;
		}
	}
	
	[global::System.Data.Linq.Mapping.TableAttribute(Name="dbo.TB_User")]
	public partial class TB_User : INotifyPropertyChanging, INotifyPropertyChanged
	{
		
		private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(String.Empty);
		
		private int _RnUserID;
		
		private string _UserName;
		
		private string _Password;
		
		private string _FirstName;
		
		private string _LastName;
		
		private string _ProfilePic;
		
		private EntitySet<TB_UserRole> _TB_UserRoles;
		
    #region Extensibility Method Definitions
    partial void OnLoaded();
    partial void OnValidate(System.Data.Linq.ChangeAction action);
    partial void OnCreated();
    partial void OnRnUserIDChanging(int value);
    partial void OnRnUserIDChanged();
    partial void OnUserNameChanging(string value);
    partial void OnUserNameChanged();
    partial void OnPasswordChanging(string value);
    partial void OnPasswordChanged();
    partial void OnFirstNameChanging(string value);
    partial void OnFirstNameChanged();
    partial void OnLastNameChanging(string value);
    partial void OnLastNameChanged();
    partial void OnProfilePicChanging(string value);
    partial void OnProfilePicChanged();
    #endregion
		
		public TB_User()
		{
			this._TB_UserRoles = new EntitySet<TB_UserRole>(new Action<TB_UserRole>(this.attach_TB_UserRoles), new Action<TB_UserRole>(this.detach_TB_UserRoles));
			OnCreated();
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_RnUserID", AutoSync=AutoSync.OnInsert, DbType="Int NOT NULL IDENTITY", IsPrimaryKey=true, IsDbGenerated=true)]
		public int RnUserID
		{
			get
			{
				return this._RnUserID;
			}
			set
			{
				if ((this._RnUserID != value))
				{
					this.OnRnUserIDChanging(value);
					this.SendPropertyChanging();
					this._RnUserID = value;
					this.SendPropertyChanged("RnUserID");
					this.OnRnUserIDChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_UserName", DbType="VarChar(MAX) NOT NULL", CanBeNull=false)]
		public string UserName
		{
			get
			{
				return this._UserName;
			}
			set
			{
				if ((this._UserName != value))
				{
					this.OnUserNameChanging(value);
					this.SendPropertyChanging();
					this._UserName = value;
					this.SendPropertyChanged("UserName");
					this.OnUserNameChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Password", DbType="VarChar(MAX) NOT NULL", CanBeNull=false)]
		public string Password
		{
			get
			{
				return this._Password;
			}
			set
			{
				if ((this._Password != value))
				{
					this.OnPasswordChanging(value);
					this.SendPropertyChanging();
					this._Password = value;
					this.SendPropertyChanged("Password");
					this.OnPasswordChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_FirstName", DbType="VarChar(MAX)")]
		public string FirstName
		{
			get
			{
				return this._FirstName;
			}
			set
			{
				if ((this._FirstName != value))
				{
					this.OnFirstNameChanging(value);
					this.SendPropertyChanging();
					this._FirstName = value;
					this.SendPropertyChanged("FirstName");
					this.OnFirstNameChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_LastName", DbType="VarChar(MAX)")]
		public string LastName
		{
			get
			{
				return this._LastName;
			}
			set
			{
				if ((this._LastName != value))
				{
					this.OnLastNameChanging(value);
					this.SendPropertyChanging();
					this._LastName = value;
					this.SendPropertyChanged("LastName");
					this.OnLastNameChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_ProfilePic", DbType="VarChar(MAX)")]
		public string ProfilePic
		{
			get
			{
				return this._ProfilePic;
			}
			set
			{
				if ((this._ProfilePic != value))
				{
					this.OnProfilePicChanging(value);
					this.SendPropertyChanging();
					this._ProfilePic = value;
					this.SendPropertyChanged("ProfilePic");
					this.OnProfilePicChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.AssociationAttribute(Name="TB_User_TB_UserRole", Storage="_TB_UserRoles", ThisKey="RnUserID", OtherKey="UserID")]
		public EntitySet<TB_UserRole> TB_UserRoles
		{
			get
			{
				return this._TB_UserRoles;
			}
			set
			{
				this._TB_UserRoles.Assign(value);
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
		
		private void attach_TB_UserRoles(TB_UserRole entity)
		{
			this.SendPropertyChanging();
			entity.TB_User = this;
		}
		
		private void detach_TB_UserRoles(TB_UserRole entity)
		{
			this.SendPropertyChanging();
			entity.TB_User = null;
		}
	}
}
#pragma warning restore 1591
