'------------------------------------------------------------------------------
' <auto-generated>
'     This code was generated by a tool.
'     Runtime Version:4.0.30319.1
'
'     Changes to this file may cause incorrect behavior and will be lost if
'     the code is regenerated.
' </auto-generated>
'------------------------------------------------------------------------------

Option Compare Binary
Option Infer On
Option Strict On
Option Explicit On

Imports System
Imports System.Collections.Generic
Imports System.ComponentModel
Imports System.ComponentModel.DataAnnotations
Imports System.Linq
Imports System.Runtime.Serialization
Imports System.ServiceModel
Imports System.ServiceModel.DomainServices
Imports System.ServiceModel.DomainServices.Client
Imports System.ServiceModel.DomainServices.Client.ApplicationServices
Imports System.ServiceModel.Web

Namespace TestDomainServices
    
    'The following attributes were not generated:
    '
    '- An exception occurred generating the 'ThrowingServiceAttributeProperty' property on attribute of type 'TestDomainServices.ThrowingServiceAttribute'.
    '
    ''' <summary>
    ''' The DomainContext corresponding to the 'AttributeThrowingDomainService' DomainService.
    ''' </summary>
    Partial Public NotInheritable Class AttributeThrowingDomainContext
        Inherits DomainContext
        
        #Region "Extensibility Method Definitions"

        ''' <summary>
        ''' This method is invoked from the constructor once initialization is complete and
        ''' can be used for further object setup.
        ''' </summary>
        Private Partial Sub OnCreated()
        End Sub

        #End Region
        
        
        ''' <summary>
        ''' Initializes a new instance of the <see cref="AttributeThrowingDomainContext"/> class.
        ''' </summary>
        Public Sub New()
            Me.New(New WebDomainClient(Of IAttributeThrowingDomainServiceContract)(New Uri("TestDomainServices-AttributeThrowingDomainService.svc", UriKind.Relative)))
        End Sub
        
        ''' <summary>
        ''' Initializes a new instance of the <see cref="AttributeThrowingDomainContext"/> class with the specified service URI.
        ''' </summary>
        ''' <param name="serviceUri">The AttributeThrowingDomainService service URI.</param>
        Public Sub New(ByVal serviceUri As Uri)
            Me.New(New WebDomainClient(Of IAttributeThrowingDomainServiceContract)(serviceUri))
        End Sub
        
        ''' <summary>
        ''' Initializes a new instance of the <see cref="AttributeThrowingDomainContext"/> class with the specified <paramref name="domainClient"/>.
        ''' </summary>
        ''' <param name="domainClient">The DomainClient instance to use for this DomainContext.</param>
        Public Sub New(ByVal domainClient As DomainClient)
            MyBase.New(domainClient)
            Me.OnCreated
        End Sub
        
        ''' <summary>
        ''' Gets the set of <see cref="AttributeThrowingEntity"/> entity instances that have been loaded into this <see cref="AttributeThrowingDomainContext"/> instance.
        ''' </summary>
        Public ReadOnly Property AttributeThrowingEntities() As EntitySet(Of AttributeThrowingEntity)
            Get
                Return MyBase.EntityContainer.GetEntitySet(Of AttributeThrowingEntity)
            End Get
        End Property
        
        'The following attributes were not generated:
        '
        '- An exception occurred generating the 'ThrowingQueryMethodProperty' property on attribute of type 'TestDomainServices.ThrowingQueryMethodAttribute'.
        '
        'Unable to generate the following attributes for parameter 'throwingQueryParam' due to the following errors:
        '
        '- An exception occurred generating the 'ThrowingQueryMethodParameterProperty' property on attribute of type 'TestDomainServices.ThrowingQueryMethodParameterAttribute'.
        '
        ''' <summary>
        ''' Gets an EntityQuery instance that can be used to load <see cref="AttributeThrowingEntity"/> entity instances using the 'GetThrowing' query.
        ''' </summary>
        ''' <param name="throwingQueryParam">The value for the 'throwingQueryParam' parameter of the query.</param>
        ''' <returns>An EntityQuery that can be loaded to retrieve <see cref="AttributeThrowingEntity"/> entity instances.</returns>
        Public Function GetThrowingQuery(ByVal throwingQueryParam As Integer) As EntityQuery(Of AttributeThrowingEntity)
            Dim parameters As Dictionary(Of String, Object) = New Dictionary(Of String, Object)()
            parameters.Add("throwingQueryParam", throwingQueryParam)
            Me.ValidateMethod("GetThrowingQuery", parameters)
            Return MyBase.CreateQuery(Of AttributeThrowingEntity)("GetThrowing", parameters, false, true)
        End Function
        
        ''' <summary>
        ''' Invokes the 'UpdateThrowing' method of the specified <see cref="AttributeThrowingEntity"/> entity.
        ''' </summary>
        ''' <param name="toUpdate">The <see cref="AttributeThrowingEntity"/> entity instance.</param>
        ''' <param name="throwingUpdateParam">The value for the 'throwingUpdateParam' parameter for this action.</param>
        Public Sub UpdateThrowing(ByVal toUpdate As AttributeThrowingEntity, ByVal throwingUpdateParam As Integer)
            toUpdate.UpdateThrowing(throwingUpdateParam)
        End Sub
        
        'The following attributes were not generated:
        '
        '- An exception occurred generating the 'ThrowingInvokeMethodProperty' property on attribute of type 'TestDomainServices.ThrowingInvokeMethodAttribute'.
        '
        'Unable to generate the following attributes for parameter 'throwingInvokeParam' due to the following errors:
        '
        '- An exception occurred generating the 'ThrowingInvokeMethodParameterProperty' property on attribute of type 'TestDomainServices.ThrowingInvokeMethodParameterAttribute'.
        '
        ''' <summary>
        ''' Asynchronously invokes the 'InvokeThrowing' method of the DomainService.
        ''' </summary>
        ''' <param name="throwingInvokeParam">The value for the 'throwingInvokeParam' parameter of this action.</param>
        ''' <param name="callback">Callback to invoke when the operation completes.</param>
        ''' <param name="userState">Value to pass to the callback.  It can be <c>null</c>.</param>
        ''' <returns>An operation instance that can be used to manage the asynchronous request.</returns>
        Public Overloads Function InvokeThrowing(ByVal throwingInvokeParam As Integer, ByVal callback As Action(Of InvokeOperation(Of Boolean)), ByVal userState As Object) As InvokeOperation(Of Boolean)
            Dim parameters As Dictionary(Of String, Object) = New Dictionary(Of String, Object)()
            parameters.Add("throwingInvokeParam", throwingInvokeParam)
            Me.ValidateMethod("InvokeThrowing", parameters)
            Return CType(Me.InvokeOperation("InvokeThrowing", GetType(Boolean), parameters, true, callback, userState),InvokeOperation(Of Boolean))
        End Function
        
        'The following attributes were not generated:
        '
        '- An exception occurred generating the 'ThrowingInvokeMethodProperty' property on attribute of type 'TestDomainServices.ThrowingInvokeMethodAttribute'.
        '
        'Unable to generate the following attributes for parameter 'throwingInvokeParam' due to the following errors:
        '
        '- An exception occurred generating the 'ThrowingInvokeMethodParameterProperty' property on attribute of type 'TestDomainServices.ThrowingInvokeMethodParameterAttribute'.
        '
        ''' <summary>
        ''' Asynchronously invokes the 'InvokeThrowing' method of the DomainService.
        ''' </summary>
        ''' <param name="throwingInvokeParam">The value for the 'throwingInvokeParam' parameter of this action.</param>
        ''' <returns>An operation instance that can be used to manage the asynchronous request.</returns>
        Public Overloads Function InvokeThrowing(ByVal throwingInvokeParam As Integer) As InvokeOperation(Of Boolean)
            Dim parameters As Dictionary(Of String, Object) = New Dictionary(Of String, Object)()
            parameters.Add("throwingInvokeParam", throwingInvokeParam)
            Me.ValidateMethod("InvokeThrowing", parameters)
            Return CType(Me.InvokeOperation("InvokeThrowing", GetType(Boolean), parameters, true, Nothing, Nothing),InvokeOperation(Of Boolean))
        End Function
        
        ''' <summary>
        ''' Creates a new EntityContainer for this DomainContext's EntitySets.
        ''' </summary>
        ''' <returns>A new container instance.</returns>
        Protected Overrides Function CreateEntityContainer() As EntityContainer
            Return New AttributeThrowingDomainContextEntityContainer()
        End Function
        
        ''' <summary>
        ''' Service contract for the 'AttributeThrowingDomainService' DomainService.
        ''' </summary>
        <ServiceContract()>  _
        Public Interface IAttributeThrowingDomainServiceContract
            
            ''' <summary>
            ''' Asynchronously invokes the 'GetThrowing' operation.
            ''' </summary>
            ''' <param name="throwingQueryParam">The value for the 'throwingQueryParam' parameter of this action.</param>
            ''' <param name="callback">Callback to invoke on completion.</param>
            ''' <param name="asyncState">Optional state object.</param>
            ''' <returns>An IAsyncResult that can be used to monitor the request.</returns>
            <FaultContract(GetType(DomainServiceFault), Action:="http://tempuri.org/AttributeThrowingDomainService/GetThrowingDomainServiceFault", Name:="DomainServiceFault", [Namespace]:="DomainServices"),  _
             OperationContract(AsyncPattern:=true, Action:="http://tempuri.org/AttributeThrowingDomainService/GetThrowing", ReplyAction:="http://tempuri.org/AttributeThrowingDomainService/GetThrowingResponse"),  _
             WebGet()>  _
            Function BeginGetThrowing(ByVal throwingQueryParam As Integer, ByVal callback As AsyncCallback, ByVal asyncState As Object) As IAsyncResult
            
            ''' <summary>
            ''' Completes the asynchronous operation begun by 'BeginGetThrowing'.
            ''' </summary>
            ''' <param name="result">The IAsyncResult returned from 'BeginGetThrowing'.</param>
            ''' <returns>The 'QueryResult' returned from the 'GetThrowing' operation.</returns>
            Function EndGetThrowing(ByVal result As IAsyncResult) As QueryResult(Of AttributeThrowingEntity)
            
            ''' <summary>
            ''' Asynchronously invokes the 'InvokeThrowing' operation.
            ''' </summary>
            ''' <param name="throwingInvokeParam">The value for the 'throwingInvokeParam' parameter of this action.</param>
            ''' <param name="callback">Callback to invoke on completion.</param>
            ''' <param name="asyncState">Optional state object.</param>
            ''' <returns>An IAsyncResult that can be used to monitor the request.</returns>
            <FaultContract(GetType(DomainServiceFault), Action:="http://tempuri.org/AttributeThrowingDomainService/InvokeThrowingDomainServiceFaul"& _ 
                "t", Name:="DomainServiceFault", [Namespace]:="DomainServices"),  _
             OperationContract(AsyncPattern:=true, Action:="http://tempuri.org/AttributeThrowingDomainService/InvokeThrowing", ReplyAction:="http://tempuri.org/AttributeThrowingDomainService/InvokeThrowingResponse")>  _
            Function BeginInvokeThrowing(ByVal throwingInvokeParam As Integer, ByVal callback As AsyncCallback, ByVal asyncState As Object) As IAsyncResult
            
            ''' <summary>
            ''' Completes the asynchronous operation begun by 'BeginInvokeThrowing'.
            ''' </summary>
            ''' <param name="result">The IAsyncResult returned from 'BeginInvokeThrowing'.</param>
            ''' <returns>The 'Boolean' returned from the 'InvokeThrowing' operation.</returns>
            Function EndInvokeThrowing(ByVal result As IAsyncResult) As Boolean
            
            ''' <summary>
            ''' Asynchronously invokes the 'SubmitChanges' operation.
            ''' </summary>
            ''' <param name="changeSet">The change-set to submit.</param>
            ''' <param name="callback">Callback to invoke on completion.</param>
            ''' <param name="asyncState">Optional state object.</param>
            ''' <returns>An IAsyncResult that can be used to monitor the request.</returns>
            <FaultContract(GetType(DomainServiceFault), Action:="http://tempuri.org/AttributeThrowingDomainService/SubmitChangesDomainServiceFault"& _ 
                "", Name:="DomainServiceFault", [Namespace]:="DomainServices"),  _
             OperationContract(AsyncPattern:=true, Action:="http://tempuri.org/AttributeThrowingDomainService/SubmitChanges", ReplyAction:="http://tempuri.org/AttributeThrowingDomainService/SubmitChangesResponse")>  _
            Function BeginSubmitChanges(ByVal changeSet As IEnumerable(Of ChangeSetEntry), ByVal callback As AsyncCallback, ByVal asyncState As Object) As IAsyncResult
            
            ''' <summary>
            ''' Completes the asynchronous operation begun by 'BeginSubmitChanges'.
            ''' </summary>
            ''' <param name="result">The IAsyncResult returned from 'BeginSubmitChanges'.</param>
            ''' <returns>The collection of change-set entry elements returned from 'SubmitChanges'.</returns>
            Function EndSubmitChanges(ByVal result As IAsyncResult) As IEnumerable(Of ChangeSetEntry)
        End Interface
        
        Friend NotInheritable Class AttributeThrowingDomainContextEntityContainer
            Inherits EntityContainer
            
            Public Sub New()
                MyBase.New
                Me.CreateEntitySet(Of AttributeThrowingEntity)(EntitySetOperations.Edit)
            End Sub
        End Class
    End Class
    
    'The following attributes were not generated:
    '
    '- An exception occurred generating the 'ThrowingEntityAttributeProperty' property on attribute of type 'TestDomainServices.ThrowingEntityAttribute'.
    '
    ''' <summary>
    ''' The 'AttributeThrowingEntity' entity class.
    ''' </summary>
    <DataContract([Namespace]:="http://schemas.datacontract.org/2004/07/TestDomainServices")>  _
    Partial Public NotInheritable Class AttributeThrowingEntity
        Inherits Entity
        
        Private _nonThrowingProperty As String
        
        Private _throwingAssociation As EntityRef(Of AttributeThrowingEntity)
        
        Private _throwingAssociationCollection As EntityCollection(Of AttributeThrowingEntity)
        
        Private _throwingProperty As String
        
        #Region "Extensibility Method Definitions"

        ''' <summary>
        ''' This method is invoked from the constructor once initialization is complete and
        ''' can be used for further object setup.
        ''' </summary>
        Private Partial Sub OnCreated()
        End Sub
        Private Partial Sub OnNonThrowingPropertyChanging(ByVal value As String)
        End Sub
        Private Partial Sub OnNonThrowingPropertyChanged()
        End Sub
        Private Partial Sub OnThrowingPropertyChanging(ByVal value As String)
        End Sub
        Private Partial Sub OnThrowingPropertyChanged()
        End Sub
        Private Partial Sub OnUpdateThrowingInvoking(ByVal throwingUpdateParam As Integer)
        End Sub
        Private Partial Sub OnUpdateThrowingInvoked()
        End Sub

        #End Region
        
        
        ''' <summary>
        ''' Initializes a new instance of the <see cref="AttributeThrowingEntity"/> class.
        ''' </summary>
        Public Sub New()
            MyBase.New
            Me.OnCreated
        End Sub
        
        ''' <summary>
        ''' Gets or sets the 'NonThrowingProperty' value.
        ''' </summary>
        <DataMember(),  _
         Editable(false, AllowInitialValue:=true),  _
         Key(),  _
         RoundtripOriginal()>  _
        Public Property NonThrowingProperty() As String
            Get
                Return Me._nonThrowingProperty
            End Get
            Set
                If (String.Equals(Me._nonThrowingProperty, value) = false) Then
                    Me.OnNonThrowingPropertyChanging(value)
                    Me.ValidateProperty("NonThrowingProperty", value)
                    Me._nonThrowingProperty = value
                    Me.RaisePropertyChanged("NonThrowingProperty")
                    Me.OnNonThrowingPropertyChanged
                End If
            End Set
        End Property
        
        'The following attributes were not generated:
        '
        '- An exception occurred generating the 'ThrowingEntityAssociationAttributeProperty' property on attribute of type 'TestDomainServices.ThrowingEntityAssociationAttribute'.
        '
        ''' <summary>
        ''' Gets or sets the associated <see cref="AttributeThrowingEntity"/> entity.
        ''' </summary>
        <Association("Association", "ThrowingProperty", "NonThrowingProperty", IsForeignKey:=true)>  _
        Public Property ThrowingAssociation() As AttributeThrowingEntity
            Get
                If (Me._throwingAssociation Is Nothing) Then
                    Me._throwingAssociation = New EntityRef(Of AttributeThrowingEntity)(Me, "ThrowingAssociation", AddressOf Me.FilterThrowingAssociation)
                End If
                Return Me._throwingAssociation.Entity
            End Get
            Set
                Dim previous As AttributeThrowingEntity = Me.ThrowingAssociation
                If (Object.Equals(previous, value) = false) Then
                    Me.ValidateProperty("ThrowingAssociation", value)
                    If (Not (value) Is Nothing) Then
                        Me.ThrowingProperty = value.NonThrowingProperty
                    Else
                        Me.ThrowingProperty = CType(Nothing, String)
                    End If
                    Me._throwingAssociation.Entity = value
                    Me.RaisePropertyChanged("ThrowingAssociation")
                End If
            End Set
        End Property
        
        'The following attributes were not generated:
        '
        '- An exception occurred generating the 'ThrowingEntityAssociationCollectionAttributeProperty' property on attribute of type 'TestDomainServices.ThrowingEntityAssociationCollectionAttribute'.
        '
        ''' <summary>
        ''' Gets the collection of associated <see cref="AttributeThrowingEntity"/> entity instances.
        ''' </summary>
        <Association("AssociationCollection", "NonThrowingProperty", "ThrowingProperty")>  _
        Public ReadOnly Property ThrowingAssociationCollection() As EntityCollection(Of AttributeThrowingEntity)
            Get
                If (Me._throwingAssociationCollection Is Nothing) Then
                    Me._throwingAssociationCollection = New EntityCollection(Of AttributeThrowingEntity)(Me, "ThrowingAssociationCollection", AddressOf Me.FilterThrowingAssociationCollection)
                End If
                Return Me._throwingAssociationCollection
            End Get
        End Property
        
        'The following attributes were not generated:
        '
        '- An exception occurred generating the 'ThrowingEntityPropertyAttributeProperty' property on attribute of type 'TestDomainServices.ThrowingEntityPropertyAttribute'.
        '
        ''' <summary>
        ''' Gets or sets the 'ThrowingProperty' value.
        ''' </summary>
        <DataMember(),  _
         RoundtripOriginal()>  _
        Public Property ThrowingProperty() As String
            Get
                Return Me._throwingProperty
            End Get
            Set
                If (String.Equals(Me._throwingProperty, value) = false) Then
                    Me.OnThrowingPropertyChanging(value)
                    Me.RaiseDataMemberChanging("ThrowingProperty")
                    Me.ValidateProperty("ThrowingProperty", value)
                    Me._throwingProperty = value
                    Me.RaiseDataMemberChanged("ThrowingProperty")
                    Me.OnThrowingPropertyChanged
                End If
            End Set
        End Property
        
        ''' <summary>
        ''' Gets a value indicating whether the 'UpdateThrowing' action has been invoked on this entity.
        ''' </summary>
        <Display(AutoGenerateField:=false)>  _
        Public ReadOnly Property IsUpdateThrowingInvoked() As Boolean
            Get
                Return MyBase.IsActionInvoked("UpdateThrowing")
            End Get
        End Property
        
        ''' <summary>
        ''' Gets a value indicating whether the 'UpdateThrowing' method can be invoked on this entity.
        ''' </summary>
        <Display(AutoGenerateField:=false)>  _
        Public ReadOnly Property CanUpdateThrowing() As Boolean
            Get
                Return MyBase.CanInvokeAction("UpdateThrowing")
            End Get
        End Property
        
        Private Function FilterThrowingAssociation(ByVal entity As AttributeThrowingEntity) As Boolean
            Return Object.Equals(entity.NonThrowingProperty, Me.ThrowingProperty)
        End Function
        
        Private Function FilterThrowingAssociationCollection(ByVal entity As AttributeThrowingEntity) As Boolean
            Return Object.Equals(entity.ThrowingProperty, Me.NonThrowingProperty)
        End Function
        
        ''' <summary>
        ''' Computes a value from the key fields that uniquely identifies this entity instance.
        ''' </summary>
        ''' <returns>An object instance that uniquely identifies this entity instance.</returns>
        Public Overrides Function GetIdentity() As Object
            Return Me._nonThrowingProperty
        End Function
        
        'The following attributes were not generated:
        '
        '- An exception occurred generating the 'ThrowingUpdateMethodProperty' property on attribute of type 'TestDomainServices.ThrowingUpdateMethodAttribute'.
        '
        'Unable to generate the following attributes for parameter 'throwingUpdateParam' due to the following errors:
        '
        '- An exception occurred generating the 'ThrowingUpdateMethodParameterProperty' property on attribute of type 'TestDomainServices.ThrowingUpdateMethodParameterAttribute'.
        '
        ''' <summary>
        ''' Invokes the 'UpdateThrowing' action on this entity.
        ''' </summary>
        ''' <param name="throwingUpdateParam">The value to pass to the server method's 'throwingUpdateParam' parameter.</param>
        Public Sub UpdateThrowing(ByVal throwingUpdateParam As Integer)
            Me.OnUpdateThrowingInvoking(throwingUpdateParam)
            MyBase.InvokeAction("UpdateThrowing", throwingUpdateParam)
            Me.OnUpdateThrowingInvoked
        End Sub
        
        Protected Overrides Sub OnActionStateChanged()
            MyBase.UpdateActionState("UpdateThrowing", "CanUpdateThrowing", "IsUpdateThrowingInvoked")
        End Sub
    End Class
End Namespace
