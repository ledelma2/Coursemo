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

namespace CoursemoAPP
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
	
	
	[global::System.Data.Linq.Mapping.DatabaseAttribute(Name="Coursemo")]
	public partial class CoursemoDataContext : System.Data.Linq.DataContext
	{
		
		private static System.Data.Linq.Mapping.MappingSource mappingSource = new AttributeMappingSource();
		
    #region Extensibility Method Definitions
    partial void OnCreated();
    partial void InsertCourse(Course instance);
    partial void UpdateCourse(Course instance);
    partial void DeleteCourse(Course instance);
    partial void InsertEnrolled(Enrolled instance);
    partial void UpdateEnrolled(Enrolled instance);
    partial void DeleteEnrolled(Enrolled instance);
    partial void InsertStudent(Student instance);
    partial void UpdateStudent(Student instance);
    partial void DeleteStudent(Student instance);
    partial void InsertWaitlist(Waitlist instance);
    partial void UpdateWaitlist(Waitlist instance);
    partial void DeleteWaitlist(Waitlist instance);
    #endregion
		
		public CoursemoDataContext() : 
				base(global::CoursemoAPP.Properties.Settings.Default.CoursemoConnectionString, mappingSource)
		{
			OnCreated();
		}
		
		public CoursemoDataContext(string connection) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public CoursemoDataContext(System.Data.IDbConnection connection) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public CoursemoDataContext(string connection, System.Data.Linq.Mapping.MappingSource mappingSource) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public CoursemoDataContext(System.Data.IDbConnection connection, System.Data.Linq.Mapping.MappingSource mappingSource) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public System.Data.Linq.Table<Course> Courses
		{
			get
			{
				return this.GetTable<Course>();
			}
		}
		
		public System.Data.Linq.Table<Enrolled> Enrolleds
		{
			get
			{
				return this.GetTable<Enrolled>();
			}
		}
		
		public System.Data.Linq.Table<Student> Students
		{
			get
			{
				return this.GetTable<Student>();
			}
		}
		
		public System.Data.Linq.Table<Waitlist> Waitlists
		{
			get
			{
				return this.GetTable<Waitlist>();
			}
		}

        public Student GetStudent(string netid)
        {
            foreach(Student s in this.GetTable<Student>())
            {
                if (s.Netid == netid)
                    return s;
            }
            return null;
        }

        public Course GetCourse(int crn)
        {
            foreach (Course c in this.GetTable<Course>())
            {
                if (c.CRN == crn)
                    return c;
            }
            return null;
        }
    }
	
	[global::System.Data.Linq.Mapping.TableAttribute(Name="dbo.Courses")]
	public partial class Course : INotifyPropertyChanging, INotifyPropertyChanged
	{
		
		private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(String.Empty);
		
		private int _CRN;
		
		private string _Department;
		
		private string _Number;
		
		private string @__Type;
		
		private string @__Year;
		
		private string @__Semester;
		
		private string @__Day;
		
		private string @__Time;
		
		private int _Size;
		
		private int _Available;
		
		private EntitySet<Enrolled> _Enrolleds;
		
		private EntitySet<Waitlist> _Waitlists;
		
    #region Extensibility Method Definitions
    partial void OnLoaded();
    partial void OnValidate(System.Data.Linq.ChangeAction action);
    partial void OnCreated();
    partial void OnCRNChanging(int value);
    partial void OnCRNChanged();
    partial void OnDepartmentChanging(string value);
    partial void OnDepartmentChanged();
    partial void OnNumberChanging(string value);
    partial void OnNumberChanged();
    partial void On_TypeChanging(string value);
    partial void On_TypeChanged();
    partial void On_YearChanging(string value);
    partial void On_YearChanged();
    partial void On_SemesterChanging(string value);
    partial void On_SemesterChanged();
    partial void On_DayChanging(string value);
    partial void On_DayChanged();
    partial void On_TimeChanging(string value);
    partial void On_TimeChanged();
    partial void OnSizeChanging(int value);
    partial void OnSizeChanged();
    partial void OnAvailableChanging(int value);
    partial void OnAvailableChanged();
    #endregion
		
		public Course()
		{
			this._Enrolleds = new EntitySet<Enrolled>(new Action<Enrolled>(this.attach_Enrolleds), new Action<Enrolled>(this.detach_Enrolleds));
			this._Waitlists = new EntitySet<Waitlist>(new Action<Waitlist>(this.attach_Waitlists), new Action<Waitlist>(this.detach_Waitlists));
			OnCreated();
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_CRN", DbType="Int NOT NULL", IsPrimaryKey=true)]
		public int CRN
		{
			get
			{
				return this._CRN;
			}
			set
			{
				if ((this._CRN != value))
				{
					this.OnCRNChanging(value);
					this.SendPropertyChanging();
					this._CRN = value;
					this.SendPropertyChanged("CRN");
					this.OnCRNChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Department", DbType="NVarChar(12) NOT NULL", CanBeNull=false)]
		public string Department
		{
			get
			{
				return this._Department;
			}
			set
			{
				if ((this._Department != value))
				{
					this.OnDepartmentChanging(value);
					this.SendPropertyChanging();
					this._Department = value;
					this.SendPropertyChanged("Department");
					this.OnDepartmentChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Number", DbType="NVarChar(12) NOT NULL", CanBeNull=false)]
		public string Number
		{
			get
			{
				return this._Number;
			}
			set
			{
				if ((this._Number != value))
				{
					this.OnNumberChanging(value);
					this.SendPropertyChanging();
					this._Number = value;
					this.SendPropertyChanged("Number");
					this.OnNumberChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Name="[_Type]", Storage="__Type", DbType="NVarChar(12) NOT NULL", CanBeNull=false)]
		public string _Type
		{
			get
			{
				return this.@__Type;
			}
			set
			{
				if ((this.@__Type != value))
				{
					this.On_TypeChanging(value);
					this.SendPropertyChanging();
					this.@__Type = value;
					this.SendPropertyChanged("_Type");
					this.On_TypeChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Name="[_Year]", Storage="__Year", DbType="NVarChar(12) NOT NULL", CanBeNull=false)]
		public string _Year
		{
			get
			{
				return this.@__Year;
			}
			set
			{
				if ((this.@__Year != value))
				{
					this.On_YearChanging(value);
					this.SendPropertyChanging();
					this.@__Year = value;
					this.SendPropertyChanged("_Year");
					this.On_YearChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Name="[_Semester]", Storage="__Semester", DbType="NVarChar(12) NOT NULL", CanBeNull=false)]
		public string _Semester
		{
			get
			{
				return this.@__Semester;
			}
			set
			{
				if ((this.@__Semester != value))
				{
					this.On_SemesterChanging(value);
					this.SendPropertyChanging();
					this.@__Semester = value;
					this.SendPropertyChanged("_Semester");
					this.On_SemesterChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Name="[_Day]", Storage="__Day", DbType="NVarChar(12) NOT NULL", CanBeNull=false)]
		public string _Day
		{
			get
			{
				return this.@__Day;
			}
			set
			{
				if ((this.@__Day != value))
				{
					this.On_DayChanging(value);
					this.SendPropertyChanging();
					this.@__Day = value;
					this.SendPropertyChanged("_Day");
					this.On_DayChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Name="[_Time]", Storage="__Time", DbType="NVarChar(12) NOT NULL", CanBeNull=false)]
		public string _Time
		{
			get
			{
				return this.@__Time;
			}
			set
			{
				if ((this.@__Time != value))
				{
					this.On_TimeChanging(value);
					this.SendPropertyChanging();
					this.@__Time = value;
					this.SendPropertyChanged("_Time");
					this.On_TimeChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Size", DbType="Int NOT NULL")]
		public int Size
		{
			get
			{
				return this._Size;
			}
			set
			{
				if ((this._Size != value))
				{
					this.OnSizeChanging(value);
					this.SendPropertyChanging();
					this._Size = value;
					this.SendPropertyChanged("Size");
					this.OnSizeChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Available", DbType="Int NOT NULL")]
		public int Available
		{
			get
			{
				return this._Available;
			}
			set
			{
				if ((this._Available != value))
				{
					this.OnAvailableChanging(value);
					this.SendPropertyChanging();
					this._Available = value;
					this.SendPropertyChanged("Available");
					this.OnAvailableChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.AssociationAttribute(Name="Course_Enrolled", Storage="_Enrolleds", ThisKey="CRN", OtherKey="CRN")]
		public EntitySet<Enrolled> Enrolleds
		{
			get
			{
				return this._Enrolleds;
			}
			set
			{
				this._Enrolleds.Assign(value);
			}
		}
		
		[global::System.Data.Linq.Mapping.AssociationAttribute(Name="Course_Waitlist", Storage="_Waitlists", ThisKey="CRN", OtherKey="CRN")]
		public EntitySet<Waitlist> Waitlists
		{
			get
			{
				return this._Waitlists;
			}
			set
			{
				this._Waitlists.Assign(value);
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
		
		private void attach_Enrolleds(Enrolled entity)
		{
			this.SendPropertyChanging();
			entity.Course = this;
		}
		
		private void detach_Enrolleds(Enrolled entity)
		{
			this.SendPropertyChanging();
			entity.Course = null;
		}
		
		private void attach_Waitlists(Waitlist entity)
		{
			this.SendPropertyChanging();
			entity.Course = this;
		}
		
		private void detach_Waitlists(Waitlist entity)
		{
			this.SendPropertyChanging();
			entity.Course = null;
		}
	}
	
	[global::System.Data.Linq.Mapping.TableAttribute(Name="dbo.Enrolled")]
	public partial class Enrolled : INotifyPropertyChanging, INotifyPropertyChanged
	{
		
		private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(String.Empty);
		
		private int _ELID;
		
		private int _ID;
		
		private int _CRN;
		
		private EntityRef<Course> _Course;
		
		private EntityRef<Student> _Student;
		
    #region Extensibility Method Definitions
    partial void OnLoaded();
    partial void OnValidate(System.Data.Linq.ChangeAction action);
    partial void OnCreated();
    partial void OnELIDChanging(int value);
    partial void OnELIDChanged();
    partial void OnIDChanging(int value);
    partial void OnIDChanged();
    partial void OnCRNChanging(int value);
    partial void OnCRNChanged();
    #endregion
		
		public Enrolled()
		{
			this._Course = default(EntityRef<Course>);
			this._Student = default(EntityRef<Student>);
			OnCreated();
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_ELID", AutoSync=AutoSync.OnInsert, DbType="Int NOT NULL IDENTITY", IsPrimaryKey=true, IsDbGenerated=true)]
		public int ELID
		{
			get
			{
				return this._ELID;
			}
			set
			{
				if ((this._ELID != value))
				{
					this.OnELIDChanging(value);
					this.SendPropertyChanging();
					this._ELID = value;
					this.SendPropertyChanged("ELID");
					this.OnELIDChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_ID", DbType="Int NOT NULL")]
		public int ID
		{
			get
			{
				return this._ID;
			}
			set
			{
				if ((this._ID != value))
				{
					if (this._Student.HasLoadedOrAssignedValue)
					{
						throw new System.Data.Linq.ForeignKeyReferenceAlreadyHasValueException();
					}
					this.OnIDChanging(value);
					this.SendPropertyChanging();
					this._ID = value;
					this.SendPropertyChanged("ID");
					this.OnIDChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_CRN", DbType="Int NOT NULL")]
		public int CRN
		{
			get
			{
				return this._CRN;
			}
			set
			{
				if ((this._CRN != value))
				{
					if (this._Course.HasLoadedOrAssignedValue)
					{
						throw new System.Data.Linq.ForeignKeyReferenceAlreadyHasValueException();
					}
					this.OnCRNChanging(value);
					this.SendPropertyChanging();
					this._CRN = value;
					this.SendPropertyChanged("CRN");
					this.OnCRNChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.AssociationAttribute(Name="Course_Enrolled", Storage="_Course", ThisKey="CRN", OtherKey="CRN", IsForeignKey=true)]
		public Course Course
		{
			get
			{
				return this._Course.Entity;
			}
			set
			{
				Course previousValue = this._Course.Entity;
				if (((previousValue != value) 
							|| (this._Course.HasLoadedOrAssignedValue == false)))
				{
					this.SendPropertyChanging();
					if ((previousValue != null))
					{
						this._Course.Entity = null;
						previousValue.Enrolleds.Remove(this);
					}
					this._Course.Entity = value;
					if ((value != null))
					{
						value.Enrolleds.Add(this);
						this._CRN = value.CRN;
					}
					else
					{
						this._CRN = default(int);
					}
					this.SendPropertyChanged("Course");
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.AssociationAttribute(Name="Student_Enrolled", Storage="_Student", ThisKey="ID", OtherKey="ID", IsForeignKey=true)]
		public Student Student
		{
			get
			{
				return this._Student.Entity;
			}
			set
			{
				Student previousValue = this._Student.Entity;
				if (((previousValue != value) 
							|| (this._Student.HasLoadedOrAssignedValue == false)))
				{
					this.SendPropertyChanging();
					if ((previousValue != null))
					{
						this._Student.Entity = null;
						previousValue.Enrolleds.Remove(this);
					}
					this._Student.Entity = value;
					if ((value != null))
					{
						value.Enrolleds.Add(this);
						this._ID = value.ID;
					}
					else
					{
						this._ID = default(int);
					}
					this.SendPropertyChanged("Student");
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
	
	[global::System.Data.Linq.Mapping.TableAttribute(Name="dbo.Students")]
	public partial class Student : INotifyPropertyChanging, INotifyPropertyChanged
	{
		
		private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(String.Empty);
		
		private int _ID;
		
		private string _FirstName;
		
		private string _LastName;
		
		private string _Netid;
		
		private EntitySet<Enrolled> _Enrolleds;
		
		private EntitySet<Waitlist> _Waitlists;
		
    #region Extensibility Method Definitions
    partial void OnLoaded();
    partial void OnValidate(System.Data.Linq.ChangeAction action);
    partial void OnCreated();
    partial void OnIDChanging(int value);
    partial void OnIDChanged();
    partial void OnFirstNameChanging(string value);
    partial void OnFirstNameChanged();
    partial void OnLastNameChanging(string value);
    partial void OnLastNameChanged();
    partial void OnNetidChanging(string value);
    partial void OnNetidChanged();
    #endregion
		
		public Student()
		{
			this._Enrolleds = new EntitySet<Enrolled>(new Action<Enrolled>(this.attach_Enrolleds), new Action<Enrolled>(this.detach_Enrolleds));
			this._Waitlists = new EntitySet<Waitlist>(new Action<Waitlist>(this.attach_Waitlists), new Action<Waitlist>(this.detach_Waitlists));
			OnCreated();
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_ID", AutoSync=AutoSync.OnInsert, DbType="Int NOT NULL IDENTITY", IsPrimaryKey=true, IsDbGenerated=true)]
		public int ID
		{
			get
			{
				return this._ID;
			}
			set
			{
				if ((this._ID != value))
				{
					this.OnIDChanging(value);
					this.SendPropertyChanging();
					this._ID = value;
					this.SendPropertyChanged("ID");
					this.OnIDChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_FirstName", DbType="NVarChar(128) NOT NULL", CanBeNull=false)]
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
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_LastName", DbType="NVarChar(128) NOT NULL", CanBeNull=false)]
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
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Netid", DbType="NVarChar(128) NOT NULL", CanBeNull=false)]
		public string Netid
		{
			get
			{
				return this._Netid;
			}
			set
			{
				if ((this._Netid != value))
				{
					this.OnNetidChanging(value);
					this.SendPropertyChanging();
					this._Netid = value;
					this.SendPropertyChanged("Netid");
					this.OnNetidChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.AssociationAttribute(Name="Student_Enrolled", Storage="_Enrolleds", ThisKey="ID", OtherKey="ID")]
		public EntitySet<Enrolled> Enrolleds
		{
			get
			{
				return this._Enrolleds;
			}
			set
			{
				this._Enrolleds.Assign(value);
			}
		}
		
		[global::System.Data.Linq.Mapping.AssociationAttribute(Name="Student_Waitlist", Storage="_Waitlists", ThisKey="ID", OtherKey="ID")]
		public EntitySet<Waitlist> Waitlists
		{
			get
			{
				return this._Waitlists;
			}
			set
			{
				this._Waitlists.Assign(value);
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
		
		private void attach_Enrolleds(Enrolled entity)
		{
			this.SendPropertyChanging();
			entity.Student = this;
		}
		
		private void detach_Enrolleds(Enrolled entity)
		{
			this.SendPropertyChanging();
			entity.Student = null;
		}
		
		private void attach_Waitlists(Waitlist entity)
		{
			this.SendPropertyChanging();
			entity.Student = this;
		}
		
		private void detach_Waitlists(Waitlist entity)
		{
			this.SendPropertyChanging();
			entity.Student = null;
		}
	}
	
	[global::System.Data.Linq.Mapping.TableAttribute(Name="dbo.Waitlist")]
	public partial class Waitlist : INotifyPropertyChanging, INotifyPropertyChanged
	{
		
		private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(String.Empty);
		
		private int _WLID;
		
		private int _ID;
		
		private int _CRN;
		
		private EntityRef<Course> _Course;
		
		private EntityRef<Student> _Student;
		
    #region Extensibility Method Definitions
    partial void OnLoaded();
    partial void OnValidate(System.Data.Linq.ChangeAction action);
    partial void OnCreated();
    partial void OnWLIDChanging(int value);
    partial void OnWLIDChanged();
    partial void OnIDChanging(int value);
    partial void OnIDChanged();
    partial void OnCRNChanging(int value);
    partial void OnCRNChanged();
    #endregion
		
		public Waitlist()
		{
			this._Course = default(EntityRef<Course>);
			this._Student = default(EntityRef<Student>);
			OnCreated();
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_WLID", AutoSync=AutoSync.OnInsert, DbType="Int NOT NULL IDENTITY", IsPrimaryKey=true, IsDbGenerated=true)]
		public int WLID
		{
			get
			{
				return this._WLID;
			}
			set
			{
				if ((this._WLID != value))
				{
					this.OnWLIDChanging(value);
					this.SendPropertyChanging();
					this._WLID = value;
					this.SendPropertyChanged("WLID");
					this.OnWLIDChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_ID", DbType="Int NOT NULL")]
		public int ID
		{
			get
			{
				return this._ID;
			}
			set
			{
				if ((this._ID != value))
				{
					if (this._Student.HasLoadedOrAssignedValue)
					{
						throw new System.Data.Linq.ForeignKeyReferenceAlreadyHasValueException();
					}
					this.OnIDChanging(value);
					this.SendPropertyChanging();
					this._ID = value;
					this.SendPropertyChanged("ID");
					this.OnIDChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_CRN", DbType="Int NOT NULL")]
		public int CRN
		{
			get
			{
				return this._CRN;
			}
			set
			{
				if ((this._CRN != value))
				{
					if (this._Course.HasLoadedOrAssignedValue)
					{
						throw new System.Data.Linq.ForeignKeyReferenceAlreadyHasValueException();
					}
					this.OnCRNChanging(value);
					this.SendPropertyChanging();
					this._CRN = value;
					this.SendPropertyChanged("CRN");
					this.OnCRNChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.AssociationAttribute(Name="Course_Waitlist", Storage="_Course", ThisKey="CRN", OtherKey="CRN", IsForeignKey=true)]
		public Course Course
		{
			get
			{
				return this._Course.Entity;
			}
			set
			{
				Course previousValue = this._Course.Entity;
				if (((previousValue != value) 
							|| (this._Course.HasLoadedOrAssignedValue == false)))
				{
					this.SendPropertyChanging();
					if ((previousValue != null))
					{
						this._Course.Entity = null;
						previousValue.Waitlists.Remove(this);
					}
					this._Course.Entity = value;
					if ((value != null))
					{
						value.Waitlists.Add(this);
						this._CRN = value.CRN;
					}
					else
					{
						this._CRN = default(int);
					}
					this.SendPropertyChanged("Course");
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.AssociationAttribute(Name="Student_Waitlist", Storage="_Student", ThisKey="ID", OtherKey="ID", IsForeignKey=true)]
		public Student Student
		{
			get
			{
				return this._Student.Entity;
			}
			set
			{
				Student previousValue = this._Student.Entity;
				if (((previousValue != value) 
							|| (this._Student.HasLoadedOrAssignedValue == false)))
				{
					this.SendPropertyChanging();
					if ((previousValue != null))
					{
						this._Student.Entity = null;
						previousValue.Waitlists.Remove(this);
					}
					this._Student.Entity = value;
					if ((value != null))
					{
						value.Waitlists.Add(this);
						this._ID = value.ID;
					}
					else
					{
						this._ID = default(int);
					}
					this.SendPropertyChanged("Student");
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
