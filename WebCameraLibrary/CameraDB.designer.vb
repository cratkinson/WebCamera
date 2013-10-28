﻿'------------------------------------------------------------------------------
' <auto-generated>
'     This code was generated by a tool.
'     Runtime Version:4.0.30319.18052
'
'     Changes to this file may cause incorrect behavior and will be lost if
'     the code is regenerated.
' </auto-generated>
'------------------------------------------------------------------------------

Option Strict On
Option Explicit On

Imports System
Imports System.Collections.Generic
Imports System.ComponentModel
Imports System.Data
Imports System.Data.Linq
Imports System.Data.Linq.Mapping
Imports System.Linq
Imports System.Linq.Expressions
Imports System.Reflection


<Global.System.Data.Linq.Mapping.DatabaseAttribute(Name:="Garden")>  _
Partial Public Class CameraDBDataContext
	Inherits System.Data.Linq.DataContext
	
	Private Shared mappingSource As System.Data.Linq.Mapping.MappingSource = New AttributeMappingSource()
	
  #Region "Extensibility Method Definitions"
  Partial Private Sub OnCreated()
  End Sub
  Partial Private Sub InserttblWebCamera_META(instance As tblWebCamera_META)
    End Sub
  Partial Private Sub UpdatetblWebCamera_META(instance As tblWebCamera_META)
    End Sub
  Partial Private Sub DeletetblWebCamera_META(instance As tblWebCamera_META)
    End Sub
  Partial Private Sub InserttblWebCamera_DATA(instance As tblWebCamera_DATA)
    End Sub
  Partial Private Sub UpdatetblWebCamera_DATA(instance As tblWebCamera_DATA)
    End Sub
  Partial Private Sub DeletetblWebCamera_DATA(instance As tblWebCamera_DATA)
    End Sub
  #End Region
	
	Public Sub New()
		MyBase.New(Global.WebCameraLibrary.My.MySettings.Default.GardenConnectionString, mappingSource)
		OnCreated
	End Sub
	
	Public Sub New(ByVal connection As String)
		MyBase.New(connection, mappingSource)
		OnCreated
	End Sub
	
	Public Sub New(ByVal connection As System.Data.IDbConnection)
		MyBase.New(connection, mappingSource)
		OnCreated
	End Sub
	
	Public Sub New(ByVal connection As String, ByVal mappingSource As System.Data.Linq.Mapping.MappingSource)
		MyBase.New(connection, mappingSource)
		OnCreated
	End Sub
	
	Public Sub New(ByVal connection As System.Data.IDbConnection, ByVal mappingSource As System.Data.Linq.Mapping.MappingSource)
		MyBase.New(connection, mappingSource)
		OnCreated
	End Sub
	
	Public ReadOnly Property tblWebCamera_METAs() As System.Data.Linq.Table(Of tblWebCamera_META)
		Get
			Return Me.GetTable(Of tblWebCamera_META)
		End Get
	End Property
	
	Public ReadOnly Property tblWebCamera_DATAs() As System.Data.Linq.Table(Of tblWebCamera_DATA)
		Get
			Return Me.GetTable(Of tblWebCamera_DATA)
		End Get
	End Property
End Class

<Global.System.Data.Linq.Mapping.TableAttribute(Name:="dbo.tblWebCamera_META")>  _
Partial Public Class tblWebCamera_META
	Implements System.ComponentModel.INotifyPropertyChanging, System.ComponentModel.INotifyPropertyChanged
	
	Private Shared emptyChangingEventArgs As PropertyChangingEventArgs = New PropertyChangingEventArgs(String.Empty)
	
	Private _ID As Integer
	
	Private _Description As String
	
	Private _Longitude As System.Nullable(Of Double)
	
	Private _Latitude As System.Nullable(Of Double)
	
	Private _Camera As String
	
	Private _tblWebCamera_DATAs As EntitySet(Of tblWebCamera_DATA)
	
    #Region "Extensibility Method Definitions"
    Partial Private Sub OnLoaded()
    End Sub
    Partial Private Sub OnValidate(action As System.Data.Linq.ChangeAction)
    End Sub
    Partial Private Sub OnCreated()
    End Sub
    Partial Private Sub OnIDChanging(value As Integer)
    End Sub
    Partial Private Sub OnIDChanged()
    End Sub
    Partial Private Sub OnDescriptionChanging(value As String)
    End Sub
    Partial Private Sub OnDescriptionChanged()
    End Sub
    Partial Private Sub OnLongitudeChanging(value As System.Nullable(Of Double))
    End Sub
    Partial Private Sub OnLongitudeChanged()
    End Sub
    Partial Private Sub OnLatitudeChanging(value As System.Nullable(Of Double))
    End Sub
    Partial Private Sub OnLatitudeChanged()
    End Sub
    Partial Private Sub OnCameraChanging(value As String)
    End Sub
    Partial Private Sub OnCameraChanged()
    End Sub
    #End Region
	
	Public Sub New()
		MyBase.New
		Me._tblWebCamera_DATAs = New EntitySet(Of tblWebCamera_DATA)(AddressOf Me.attach_tblWebCamera_DATAs, AddressOf Me.detach_tblWebCamera_DATAs)
		OnCreated
	End Sub
	
	<Global.System.Data.Linq.Mapping.ColumnAttribute(Storage:="_ID", AutoSync:=AutoSync.OnInsert, DbType:="Int NOT NULL IDENTITY", IsPrimaryKey:=true, IsDbGenerated:=true)>  _
	Public Property ID() As Integer
		Get
			Return Me._ID
		End Get
		Set
			If ((Me._ID = value)  _
						= false) Then
				Me.OnIDChanging(value)
				Me.SendPropertyChanging
				Me._ID = value
				Me.SendPropertyChanged("ID")
				Me.OnIDChanged
			End If
		End Set
	End Property
	
	<Global.System.Data.Linq.Mapping.ColumnAttribute(Storage:="_Description", DbType:="VarChar(50)")>  _
	Public Property Description() As String
		Get
			Return Me._Description
		End Get
		Set
			If (String.Equals(Me._Description, value) = false) Then
				Me.OnDescriptionChanging(value)
				Me.SendPropertyChanging
				Me._Description = value
				Me.SendPropertyChanged("Description")
				Me.OnDescriptionChanged
			End If
		End Set
	End Property
	
	<Global.System.Data.Linq.Mapping.ColumnAttribute(Storage:="_Longitude", DbType:="Float")>  _
	Public Property Longitude() As System.Nullable(Of Double)
		Get
			Return Me._Longitude
		End Get
		Set
			If (Me._Longitude.Equals(value) = false) Then
				Me.OnLongitudeChanging(value)
				Me.SendPropertyChanging
				Me._Longitude = value
				Me.SendPropertyChanged("Longitude")
				Me.OnLongitudeChanged
			End If
		End Set
	End Property
	
	<Global.System.Data.Linq.Mapping.ColumnAttribute(Storage:="_Latitude", DbType:="Float")>  _
	Public Property Latitude() As System.Nullable(Of Double)
		Get
			Return Me._Latitude
		End Get
		Set
			If (Me._Latitude.Equals(value) = false) Then
				Me.OnLatitudeChanging(value)
				Me.SendPropertyChanging
				Me._Latitude = value
				Me.SendPropertyChanged("Latitude")
				Me.OnLatitudeChanged
			End If
		End Set
	End Property
	
	<Global.System.Data.Linq.Mapping.ColumnAttribute(Storage:="_Camera", DbType:="VarChar(50)")>  _
	Public Property Camera() As String
		Get
			Return Me._Camera
		End Get
		Set
			If (String.Equals(Me._Camera, value) = false) Then
				Me.OnCameraChanging(value)
				Me.SendPropertyChanging
				Me._Camera = value
				Me.SendPropertyChanged("Camera")
				Me.OnCameraChanged
			End If
		End Set
	End Property
	
	<Global.System.Data.Linq.Mapping.AssociationAttribute(Name:="tblWebCamera_META_tblWebCamera_DATA", Storage:="_tblWebCamera_DATAs", ThisKey:="ID", OtherKey:="CameraID")>  _
	Public Property tblWebCamera_DATAs() As EntitySet(Of tblWebCamera_DATA)
		Get
			Return Me._tblWebCamera_DATAs
		End Get
		Set
			Me._tblWebCamera_DATAs.Assign(value)
		End Set
	End Property
	
	Public Event PropertyChanging As PropertyChangingEventHandler Implements System.ComponentModel.INotifyPropertyChanging.PropertyChanging
	
	Public Event PropertyChanged As PropertyChangedEventHandler Implements System.ComponentModel.INotifyPropertyChanged.PropertyChanged
	
	Protected Overridable Sub SendPropertyChanging()
		If ((Me.PropertyChangingEvent Is Nothing)  _
					= false) Then
			RaiseEvent PropertyChanging(Me, emptyChangingEventArgs)
		End If
	End Sub
	
	Protected Overridable Sub SendPropertyChanged(ByVal propertyName As [String])
		If ((Me.PropertyChangedEvent Is Nothing)  _
					= false) Then
			RaiseEvent PropertyChanged(Me, New PropertyChangedEventArgs(propertyName))
		End If
	End Sub
	
	Private Sub attach_tblWebCamera_DATAs(ByVal entity As tblWebCamera_DATA)
		Me.SendPropertyChanging
		entity.tblWebCamera_META = Me
	End Sub
	
	Private Sub detach_tblWebCamera_DATAs(ByVal entity As tblWebCamera_DATA)
		Me.SendPropertyChanging
		entity.tblWebCamera_META = Nothing
	End Sub
End Class

<Global.System.Data.Linq.Mapping.TableAttribute(Name:="dbo.tblWebCamera_DATA")>  _
Partial Public Class tblWebCamera_DATA
	Implements System.ComponentModel.INotifyPropertyChanging, System.ComponentModel.INotifyPropertyChanged
	
	Private Shared emptyChangingEventArgs As PropertyChangingEventArgs = New PropertyChangingEventArgs(String.Empty)
	
	Private _ID As Integer
	
	Private _CameraID As Integer
	
	Private _Date As System.Nullable(Of Date)
	
	Private _Photo As System.Data.Linq.Binary
	
	Private _tblWebCamera_META As EntityRef(Of tblWebCamera_META)
	
    #Region "Extensibility Method Definitions"
    Partial Private Sub OnLoaded()
    End Sub
    Partial Private Sub OnValidate(action As System.Data.Linq.ChangeAction)
    End Sub
    Partial Private Sub OnCreated()
    End Sub
    Partial Private Sub OnIDChanging(value As Integer)
    End Sub
    Partial Private Sub OnIDChanged()
    End Sub
    Partial Private Sub OnCameraIDChanging(value As Integer)
    End Sub
    Partial Private Sub OnCameraIDChanged()
    End Sub
    Partial Private Sub OnDateChanging(value As System.Nullable(Of Date))
    End Sub
    Partial Private Sub OnDateChanged()
    End Sub
    Partial Private Sub OnPhotoChanging(value As System.Data.Linq.Binary)
    End Sub
    Partial Private Sub OnPhotoChanged()
    End Sub
    #End Region
	
	Public Sub New()
		MyBase.New
		Me._tblWebCamera_META = CType(Nothing, EntityRef(Of tblWebCamera_META))
		OnCreated
	End Sub
	
	<Global.System.Data.Linq.Mapping.ColumnAttribute(Storage:="_ID", AutoSync:=AutoSync.OnInsert, DbType:="Int NOT NULL IDENTITY", IsPrimaryKey:=true, IsDbGenerated:=true)>  _
	Public Property ID() As Integer
		Get
			Return Me._ID
		End Get
		Set
			If ((Me._ID = value)  _
						= false) Then
				Me.OnIDChanging(value)
				Me.SendPropertyChanging
				Me._ID = value
				Me.SendPropertyChanged("ID")
				Me.OnIDChanged
			End If
		End Set
	End Property
	
	<Global.System.Data.Linq.Mapping.ColumnAttribute(Storage:="_CameraID", DbType:="Int NOT NULL", IsPrimaryKey:=true)>  _
	Public Property CameraID() As Integer
		Get
			Return Me._CameraID
		End Get
		Set
			If ((Me._CameraID = value)  _
						= false) Then
				If Me._tblWebCamera_META.HasLoadedOrAssignedValue Then
					Throw New System.Data.Linq.ForeignKeyReferenceAlreadyHasValueException()
				End If
				Me.OnCameraIDChanging(value)
				Me.SendPropertyChanging
				Me._CameraID = value
				Me.SendPropertyChanged("CameraID")
				Me.OnCameraIDChanged
			End If
		End Set
	End Property
	
	<Global.System.Data.Linq.Mapping.ColumnAttribute(Name:="Date", Storage:="_Date", DbType:="DateTime")>  _
	Public Property [Date]() As System.Nullable(Of Date)
		Get
			Return Me._Date
		End Get
		Set
			If (Me._Date.Equals(value) = false) Then
				Me.OnDateChanging(value)
				Me.SendPropertyChanging
				Me._Date = value
				Me.SendPropertyChanged("[Date]")
				Me.OnDateChanged
			End If
		End Set
	End Property
	
	<Global.System.Data.Linq.Mapping.ColumnAttribute(Storage:="_Photo", DbType:="Image", UpdateCheck:=UpdateCheck.Never)>  _
	Public Property Photo() As System.Data.Linq.Binary
		Get
			Return Me._Photo
		End Get
		Set
			If (Object.Equals(Me._Photo, value) = false) Then
				Me.OnPhotoChanging(value)
				Me.SendPropertyChanging
				Me._Photo = value
				Me.SendPropertyChanged("Photo")
				Me.OnPhotoChanged
			End If
		End Set
	End Property
	
	<Global.System.Data.Linq.Mapping.AssociationAttribute(Name:="tblWebCamera_META_tblWebCamera_DATA", Storage:="_tblWebCamera_META", ThisKey:="CameraID", OtherKey:="ID", IsForeignKey:=true)>  _
	Public Property tblWebCamera_META() As tblWebCamera_META
		Get
			Return Me._tblWebCamera_META.Entity
		End Get
		Set
			Dim previousValue As tblWebCamera_META = Me._tblWebCamera_META.Entity
			If ((Object.Equals(previousValue, value) = false)  _
						OrElse (Me._tblWebCamera_META.HasLoadedOrAssignedValue = false)) Then
				Me.SendPropertyChanging
				If ((previousValue Is Nothing)  _
							= false) Then
					Me._tblWebCamera_META.Entity = Nothing
					previousValue.tblWebCamera_DATAs.Remove(Me)
				End If
				Me._tblWebCamera_META.Entity = value
				If ((value Is Nothing)  _
							= false) Then
					value.tblWebCamera_DATAs.Add(Me)
					Me._CameraID = value.ID
				Else
					Me._CameraID = CType(Nothing, Integer)
				End If
				Me.SendPropertyChanged("tblWebCamera_META")
			End If
		End Set
	End Property
	
	Public Event PropertyChanging As PropertyChangingEventHandler Implements System.ComponentModel.INotifyPropertyChanging.PropertyChanging
	
	Public Event PropertyChanged As PropertyChangedEventHandler Implements System.ComponentModel.INotifyPropertyChanged.PropertyChanged
	
	Protected Overridable Sub SendPropertyChanging()
		If ((Me.PropertyChangingEvent Is Nothing)  _
					= false) Then
			RaiseEvent PropertyChanging(Me, emptyChangingEventArgs)
		End If
	End Sub
	
	Protected Overridable Sub SendPropertyChanged(ByVal propertyName As [String])
		If ((Me.PropertyChangedEvent Is Nothing)  _
					= false) Then
			RaiseEvent PropertyChanged(Me, New PropertyChangedEventArgs(propertyName))
		End If
	End Sub
End Class
