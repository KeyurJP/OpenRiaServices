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


''' <summary>
''' Context for the RIA application.
''' </summary>
''' <remarks>
''' This context extends the base to make application services and types available
''' for consumption from code and xaml.
''' </remarks>
Partial Public NotInheritable Class WebContext
    Inherits WebContextBase
    
    #Region "Extensibility Method Definitions"

    ''' <summary>
    ''' This method is invoked from the constructor once initialization is complete and
    ''' can be used for further object setup.
    ''' </summary>
    Private Partial Sub OnCreated()
    End Sub

    #End Region
    
    
    ''' <summary>
    ''' Initializes a new instance of the WebContext class.
    ''' </summary>
    Public Sub New()
        MyBase.New
        Me.OnCreated
    End Sub
    
    ''' <summary>
    ''' Gets the context that is registered as a lifetime object with the current application.
    ''' </summary>
    ''' <exception cref="InvalidOperationException"> is thrown if there is no current application,
    ''' no contexts have been added, or more than one context has been added.
    ''' </exception>
    ''' <seealso cref="System.Windows.Application.ApplicationLifetimeObjects"/>
    Public Shadows Shared ReadOnly Property Current() As WebContext
        Get
            Return CType(WebContextBase.Current,WebContext)
        End Get
    End Property
End Class

Namespace TestNamespace
    
    ''' <summary>
    ''' The DomainContext corresponding to the 'AuthenticationService1' DomainService.
    ''' </summary>
    Partial Public NotInheritable Class AuthenticationService1
        Inherits Global.System.ServiceModel.DomainServices.Client.ApplicationServices.AuthenticationDomainContextBase
        
        #Region "Extensibility Method Definitions"

        ''' <summary>
        ''' This method is invoked from the constructor once initialization is complete and
        ''' can be used for further object setup.
        ''' </summary>
        Private Partial Sub OnCreated()
        End Sub

        #End Region
        
        
        ''' <summary>
        ''' Initializes a new instance of the <see cref="AuthenticationService1"/> class.
        ''' </summary>
        Public Sub New()
            Me.New(New WebDomainClient(Of IAuthenticationService1Contract)(New Uri("RootNamespace-TestNamespace-AuthenticationService1.svc", UriKind.Relative)))
        End Sub
        
        ''' <summary>
        ''' Initializes a new instance of the <see cref="AuthenticationService1"/> class with the specified service URI.
        ''' </summary>
        ''' <param name="serviceUri">The AuthenticationService1 service URI.</param>
        Public Sub New(ByVal serviceUri As Uri)
            Me.New(New WebDomainClient(Of IAuthenticationService1Contract)(serviceUri))
        End Sub
        
        ''' <summary>
        ''' Initializes a new instance of the <see cref="AuthenticationService1"/> class with the specified <paramref name="domainClient"/>.
        ''' </summary>
        ''' <param name="domainClient">The DomainClient instance to use for this DomainContext.</param>
        Public Sub New(ByVal domainClient As DomainClient)
            MyBase.New(domainClient)
            Me.OnCreated
        End Sub
        
        ''' <summary>
        ''' Gets the set of <see cref="User1"/> entity instances that have been loaded into this <see cref="AuthenticationService1"/> instance.
        ''' </summary>
        Public ReadOnly Property User1s() As EntitySet(Of User1)
            Get
                Return MyBase.EntityContainer.GetEntitySet(Of User1)
            End Get
        End Property
        
        ''' <summary>
        ''' Gets an EntityQuery instance that can be used to load <see cref="User1"/> entity instances using the 'GetUser' query.
        ''' </summary>
        ''' <returns>An EntityQuery that can be loaded to retrieve <see cref="User1"/> entity instances.</returns>
        Public Function GetUserQuery() As EntityQuery(Of User1)
            Me.ValidateMethod("GetUserQuery", Nothing)
            Return MyBase.CreateQuery(Of User1)("GetUser", Nothing, false, false)
        End Function
        
        ''' <summary>
        ''' Gets an EntityQuery instance that can be used to load <see cref="User1"/> entity instances using the 'Login' query.
        ''' </summary>
        ''' <param name="userName">The value for the 'userName' parameter of the query.</param>
        ''' <param name="password">The value for the 'password' parameter of the query.</param>
        ''' <param name="isPersistent">The value for the 'isPersistent' parameter of the query.</param>
        ''' <param name="customData">The value for the 'customData' parameter of the query.</param>
        ''' <returns>An EntityQuery that can be loaded to retrieve <see cref="User1"/> entity instances.</returns>
        Public Function LoginQuery(ByVal userName As String, ByVal password As String, ByVal isPersistent As Boolean, ByVal customData As String) As EntityQuery(Of User1)
            Dim parameters As Dictionary(Of String, Object) = New Dictionary(Of String, Object)()
            parameters.Add("userName", userName)
            parameters.Add("password", password)
            parameters.Add("isPersistent", isPersistent)
            parameters.Add("customData", customData)
            Me.ValidateMethod("LoginQuery", parameters)
            Return MyBase.CreateQuery(Of User1)("Login", parameters, true, false)
        End Function
        
        ''' <summary>
        ''' Gets an EntityQuery instance that can be used to load <see cref="User1"/> entity instances using the 'Logout' query.
        ''' </summary>
        ''' <returns>An EntityQuery that can be loaded to retrieve <see cref="User1"/> entity instances.</returns>
        Public Function LogoutQuery() As EntityQuery(Of User1)
            Me.ValidateMethod("LogoutQuery", Nothing)
            Return MyBase.CreateQuery(Of User1)("Logout", Nothing, true, false)
        End Function
        
        ''' <summary>
        ''' Creates a new EntityContainer for this DomainContext's EntitySets.
        ''' </summary>
        ''' <returns>A new container instance.</returns>
        Protected Overrides Function CreateEntityContainer() As EntityContainer
            Return New AuthenticationService1EntityContainer()
        End Function
        
        ''' <summary>
        ''' Service contract for the 'AuthenticationService1' DomainService.
        ''' </summary>
        <ServiceContract()>  _
        Public Interface IAuthenticationService1Contract
            
            ''' <summary>
            ''' Asynchronously invokes the 'GetUser' operation.
            ''' </summary>
            ''' <param name="callback">Callback to invoke on completion.</param>
            ''' <param name="asyncState">Optional state object.</param>
            ''' <returns>An IAsyncResult that can be used to monitor the request.</returns>
            <FaultContract(GetType(DomainServiceFault), Action:="http://tempuri.org/AuthenticationService1/GetUserDomainServiceFault", Name:="DomainServiceFault", [Namespace]:="DomainServices"),  _
             OperationContract(AsyncPattern:=true, Action:="http://tempuri.org/AuthenticationService1/GetUser", ReplyAction:="http://tempuri.org/AuthenticationService1/GetUserResponse"),  _
             WebGet()>  _
            Function BeginGetUser(ByVal callback As AsyncCallback, ByVal asyncState As Object) As IAsyncResult
            
            ''' <summary>
            ''' Completes the asynchronous operation begun by 'BeginGetUser'.
            ''' </summary>
            ''' <param name="result">The IAsyncResult returned from 'BeginGetUser'.</param>
            ''' <returns>The 'QueryResult' returned from the 'GetUser' operation.</returns>
            Function EndGetUser(ByVal result As IAsyncResult) As QueryResult(Of User1)
            
            ''' <summary>
            ''' Asynchronously invokes the 'Login' operation.
            ''' </summary>
            ''' <param name="userName">The value for the 'userName' parameter of this action.</param>
            ''' <param name="password">The value for the 'password' parameter of this action.</param>
            ''' <param name="isPersistent">The value for the 'isPersistent' parameter of this action.</param>
            ''' <param name="customData">The value for the 'customData' parameter of this action.</param>
            ''' <param name="callback">Callback to invoke on completion.</param>
            ''' <param name="asyncState">Optional state object.</param>
            ''' <returns>An IAsyncResult that can be used to monitor the request.</returns>
            <FaultContract(GetType(DomainServiceFault), Action:="http://tempuri.org/AuthenticationService1/LoginDomainServiceFault", Name:="DomainServiceFault", [Namespace]:="DomainServices"),  _
             OperationContract(AsyncPattern:=true, Action:="http://tempuri.org/AuthenticationService1/Login", ReplyAction:="http://tempuri.org/AuthenticationService1/LoginResponse")>  _
            Function BeginLogin(ByVal userName As String, ByVal password As String, ByVal isPersistent As Boolean, ByVal customData As String, ByVal callback As AsyncCallback, ByVal asyncState As Object) As IAsyncResult
            
            ''' <summary>
            ''' Completes the asynchronous operation begun by 'BeginLogin'.
            ''' </summary>
            ''' <param name="result">The IAsyncResult returned from 'BeginLogin'.</param>
            ''' <returns>The 'QueryResult' returned from the 'Login' operation.</returns>
            Function EndLogin(ByVal result As IAsyncResult) As QueryResult(Of User1)
            
            ''' <summary>
            ''' Asynchronously invokes the 'Logout' operation.
            ''' </summary>
            ''' <param name="callback">Callback to invoke on completion.</param>
            ''' <param name="asyncState">Optional state object.</param>
            ''' <returns>An IAsyncResult that can be used to monitor the request.</returns>
            <FaultContract(GetType(DomainServiceFault), Action:="http://tempuri.org/AuthenticationService1/LogoutDomainServiceFault", Name:="DomainServiceFault", [Namespace]:="DomainServices"),  _
             OperationContract(AsyncPattern:=true, Action:="http://tempuri.org/AuthenticationService1/Logout", ReplyAction:="http://tempuri.org/AuthenticationService1/LogoutResponse")>  _
            Function BeginLogout(ByVal callback As AsyncCallback, ByVal asyncState As Object) As IAsyncResult
            
            ''' <summary>
            ''' Completes the asynchronous operation begun by 'BeginLogout'.
            ''' </summary>
            ''' <param name="result">The IAsyncResult returned from 'BeginLogout'.</param>
            ''' <returns>The 'QueryResult' returned from the 'Logout' operation.</returns>
            Function EndLogout(ByVal result As IAsyncResult) As QueryResult(Of User1)
            
            ''' <summary>
            ''' Asynchronously invokes the 'SubmitChanges' operation.
            ''' </summary>
            ''' <param name="changeSet">The change-set to submit.</param>
            ''' <param name="callback">Callback to invoke on completion.</param>
            ''' <param name="asyncState">Optional state object.</param>
            ''' <returns>An IAsyncResult that can be used to monitor the request.</returns>
            <FaultContract(GetType(DomainServiceFault), Action:="http://tempuri.org/AuthenticationService1/SubmitChangesDomainServiceFault", Name:="DomainServiceFault", [Namespace]:="DomainServices"),  _
             OperationContract(AsyncPattern:=true, Action:="http://tempuri.org/AuthenticationService1/SubmitChanges", ReplyAction:="http://tempuri.org/AuthenticationService1/SubmitChangesResponse")>  _
            Function BeginSubmitChanges(ByVal changeSet As IEnumerable(Of ChangeSetEntry), ByVal callback As AsyncCallback, ByVal asyncState As Object) As IAsyncResult
            
            ''' <summary>
            ''' Completes the asynchronous operation begun by 'BeginSubmitChanges'.
            ''' </summary>
            ''' <param name="result">The IAsyncResult returned from 'BeginSubmitChanges'.</param>
            ''' <returns>The collection of change-set entry elements returned from 'SubmitChanges'.</returns>
            Function EndSubmitChanges(ByVal result As IAsyncResult) As IEnumerable(Of ChangeSetEntry)
        End Interface
        
        Friend NotInheritable Class AuthenticationService1EntityContainer
            Inherits EntityContainer
            
            Public Sub New()
                MyBase.New
                Me.CreateEntitySet(Of User1)(EntitySetOperations.Edit)
            End Sub
        End Class
    End Class
    
    ''' <summary>
    ''' The DomainContext corresponding to the 'AuthenticationService2' DomainService.
    ''' </summary>
    Partial Public NotInheritable Class AuthenticationService2
        Inherits Global.System.ServiceModel.DomainServices.Client.ApplicationServices.AuthenticationDomainContextBase
        
        #Region "Extensibility Method Definitions"

        ''' <summary>
        ''' This method is invoked from the constructor once initialization is complete and
        ''' can be used for further object setup.
        ''' </summary>
        Private Partial Sub OnCreated()
        End Sub

        #End Region
        
        
        ''' <summary>
        ''' Initializes a new instance of the <see cref="AuthenticationService2"/> class.
        ''' </summary>
        Public Sub New()
            Me.New(New WebDomainClient(Of IAuthenticationService2Contract)(New Uri("RootNamespace-TestNamespace-AuthenticationService2.svc", UriKind.Relative)))
        End Sub
        
        ''' <summary>
        ''' Initializes a new instance of the <see cref="AuthenticationService2"/> class with the specified service URI.
        ''' </summary>
        ''' <param name="serviceUri">The AuthenticationService2 service URI.</param>
        Public Sub New(ByVal serviceUri As Uri)
            Me.New(New WebDomainClient(Of IAuthenticationService2Contract)(serviceUri))
        End Sub
        
        ''' <summary>
        ''' Initializes a new instance of the <see cref="AuthenticationService2"/> class with the specified <paramref name="domainClient"/>.
        ''' </summary>
        ''' <param name="domainClient">The DomainClient instance to use for this DomainContext.</param>
        Public Sub New(ByVal domainClient As DomainClient)
            MyBase.New(domainClient)
            Me.OnCreated
        End Sub
        
        ''' <summary>
        ''' Gets the set of <see cref="User2"/> entity instances that have been loaded into this <see cref="AuthenticationService2"/> instance.
        ''' </summary>
        Public ReadOnly Property User2s() As EntitySet(Of User2)
            Get
                Return MyBase.EntityContainer.GetEntitySet(Of User2)
            End Get
        End Property
        
        ''' <summary>
        ''' Gets an EntityQuery instance that can be used to load <see cref="User2"/> entity instances using the 'GetUser' query.
        ''' </summary>
        ''' <returns>An EntityQuery that can be loaded to retrieve <see cref="User2"/> entity instances.</returns>
        Public Function GetUserQuery() As EntityQuery(Of User2)
            Me.ValidateMethod("GetUserQuery", Nothing)
            Return MyBase.CreateQuery(Of User2)("GetUser", Nothing, false, false)
        End Function
        
        ''' <summary>
        ''' Gets an EntityQuery instance that can be used to load <see cref="User2"/> entity instances using the 'Login' query.
        ''' </summary>
        ''' <param name="userName">The value for the 'userName' parameter of the query.</param>
        ''' <param name="password">The value for the 'password' parameter of the query.</param>
        ''' <param name="isPersistent">The value for the 'isPersistent' parameter of the query.</param>
        ''' <param name="customData">The value for the 'customData' parameter of the query.</param>
        ''' <returns>An EntityQuery that can be loaded to retrieve <see cref="User2"/> entity instances.</returns>
        Public Function LoginQuery(ByVal userName As String, ByVal password As String, ByVal isPersistent As Boolean, ByVal customData As String) As EntityQuery(Of User2)
            Dim parameters As Dictionary(Of String, Object) = New Dictionary(Of String, Object)()
            parameters.Add("userName", userName)
            parameters.Add("password", password)
            parameters.Add("isPersistent", isPersistent)
            parameters.Add("customData", customData)
            Me.ValidateMethod("LoginQuery", parameters)
            Return MyBase.CreateQuery(Of User2)("Login", parameters, true, false)
        End Function
        
        ''' <summary>
        ''' Gets an EntityQuery instance that can be used to load <see cref="User2"/> entity instances using the 'Logout' query.
        ''' </summary>
        ''' <returns>An EntityQuery that can be loaded to retrieve <see cref="User2"/> entity instances.</returns>
        Public Function LogoutQuery() As EntityQuery(Of User2)
            Me.ValidateMethod("LogoutQuery", Nothing)
            Return MyBase.CreateQuery(Of User2)("Logout", Nothing, true, false)
        End Function
        
        ''' <summary>
        ''' Creates a new EntityContainer for this DomainContext's EntitySets.
        ''' </summary>
        ''' <returns>A new container instance.</returns>
        Protected Overrides Function CreateEntityContainer() As EntityContainer
            Return New AuthenticationService2EntityContainer()
        End Function
        
        ''' <summary>
        ''' Service contract for the 'AuthenticationService2' DomainService.
        ''' </summary>
        <ServiceContract()>  _
        Public Interface IAuthenticationService2Contract
            
            ''' <summary>
            ''' Asynchronously invokes the 'GetUser' operation.
            ''' </summary>
            ''' <param name="callback">Callback to invoke on completion.</param>
            ''' <param name="asyncState">Optional state object.</param>
            ''' <returns>An IAsyncResult that can be used to monitor the request.</returns>
            <FaultContract(GetType(DomainServiceFault), Action:="http://tempuri.org/AuthenticationService2/GetUserDomainServiceFault", Name:="DomainServiceFault", [Namespace]:="DomainServices"),  _
             OperationContract(AsyncPattern:=true, Action:="http://tempuri.org/AuthenticationService2/GetUser", ReplyAction:="http://tempuri.org/AuthenticationService2/GetUserResponse"),  _
             WebGet()>  _
            Function BeginGetUser(ByVal callback As AsyncCallback, ByVal asyncState As Object) As IAsyncResult
            
            ''' <summary>
            ''' Completes the asynchronous operation begun by 'BeginGetUser'.
            ''' </summary>
            ''' <param name="result">The IAsyncResult returned from 'BeginGetUser'.</param>
            ''' <returns>The 'QueryResult' returned from the 'GetUser' operation.</returns>
            Function EndGetUser(ByVal result As IAsyncResult) As QueryResult(Of User2)
            
            ''' <summary>
            ''' Asynchronously invokes the 'Login' operation.
            ''' </summary>
            ''' <param name="userName">The value for the 'userName' parameter of this action.</param>
            ''' <param name="password">The value for the 'password' parameter of this action.</param>
            ''' <param name="isPersistent">The value for the 'isPersistent' parameter of this action.</param>
            ''' <param name="customData">The value for the 'customData' parameter of this action.</param>
            ''' <param name="callback">Callback to invoke on completion.</param>
            ''' <param name="asyncState">Optional state object.</param>
            ''' <returns>An IAsyncResult that can be used to monitor the request.</returns>
            <FaultContract(GetType(DomainServiceFault), Action:="http://tempuri.org/AuthenticationService2/LoginDomainServiceFault", Name:="DomainServiceFault", [Namespace]:="DomainServices"),  _
             OperationContract(AsyncPattern:=true, Action:="http://tempuri.org/AuthenticationService2/Login", ReplyAction:="http://tempuri.org/AuthenticationService2/LoginResponse")>  _
            Function BeginLogin(ByVal userName As String, ByVal password As String, ByVal isPersistent As Boolean, ByVal customData As String, ByVal callback As AsyncCallback, ByVal asyncState As Object) As IAsyncResult
            
            ''' <summary>
            ''' Completes the asynchronous operation begun by 'BeginLogin'.
            ''' </summary>
            ''' <param name="result">The IAsyncResult returned from 'BeginLogin'.</param>
            ''' <returns>The 'QueryResult' returned from the 'Login' operation.</returns>
            Function EndLogin(ByVal result As IAsyncResult) As QueryResult(Of User2)
            
            ''' <summary>
            ''' Asynchronously invokes the 'Logout' operation.
            ''' </summary>
            ''' <param name="callback">Callback to invoke on completion.</param>
            ''' <param name="asyncState">Optional state object.</param>
            ''' <returns>An IAsyncResult that can be used to monitor the request.</returns>
            <FaultContract(GetType(DomainServiceFault), Action:="http://tempuri.org/AuthenticationService2/LogoutDomainServiceFault", Name:="DomainServiceFault", [Namespace]:="DomainServices"),  _
             OperationContract(AsyncPattern:=true, Action:="http://tempuri.org/AuthenticationService2/Logout", ReplyAction:="http://tempuri.org/AuthenticationService2/LogoutResponse")>  _
            Function BeginLogout(ByVal callback As AsyncCallback, ByVal asyncState As Object) As IAsyncResult
            
            ''' <summary>
            ''' Completes the asynchronous operation begun by 'BeginLogout'.
            ''' </summary>
            ''' <param name="result">The IAsyncResult returned from 'BeginLogout'.</param>
            ''' <returns>The 'QueryResult' returned from the 'Logout' operation.</returns>
            Function EndLogout(ByVal result As IAsyncResult) As QueryResult(Of User2)
            
            ''' <summary>
            ''' Asynchronously invokes the 'SubmitChanges' operation.
            ''' </summary>
            ''' <param name="changeSet">The change-set to submit.</param>
            ''' <param name="callback">Callback to invoke on completion.</param>
            ''' <param name="asyncState">Optional state object.</param>
            ''' <returns>An IAsyncResult that can be used to monitor the request.</returns>
            <FaultContract(GetType(DomainServiceFault), Action:="http://tempuri.org/AuthenticationService2/SubmitChangesDomainServiceFault", Name:="DomainServiceFault", [Namespace]:="DomainServices"),  _
             OperationContract(AsyncPattern:=true, Action:="http://tempuri.org/AuthenticationService2/SubmitChanges", ReplyAction:="http://tempuri.org/AuthenticationService2/SubmitChangesResponse")>  _
            Function BeginSubmitChanges(ByVal changeSet As IEnumerable(Of ChangeSetEntry), ByVal callback As AsyncCallback, ByVal asyncState As Object) As IAsyncResult
            
            ''' <summary>
            ''' Completes the asynchronous operation begun by 'BeginSubmitChanges'.
            ''' </summary>
            ''' <param name="result">The IAsyncResult returned from 'BeginSubmitChanges'.</param>
            ''' <returns>The collection of change-set entry elements returned from 'SubmitChanges'.</returns>
            Function EndSubmitChanges(ByVal result As IAsyncResult) As IEnumerable(Of ChangeSetEntry)
        End Interface
        
        Friend NotInheritable Class AuthenticationService2EntityContainer
            Inherits EntityContainer
            
            Public Sub New()
                MyBase.New
                Me.CreateEntitySet(Of User2)(EntitySetOperations.Edit)
            End Sub
        End Class
    End Class
    
    ''' <summary>
    ''' The 'User1' entity class.
    ''' </summary>
    <DataContract([Namespace]:="http://schemas.datacontract.org/2004/07/RootNamespace.TestNamespace")>  _
    Partial Public NotInheritable Class User1
        Inherits Entity
        Implements Global.System.Security.Principal.IIdentity, Global.System.Security.Principal.IPrincipal
        
        Private _name As String = String.Empty
        
        Private _roles As IEnumerable(Of String)
        
        #Region "Extensibility Method Definitions"

        ''' <summary>
        ''' This method is invoked from the constructor once initialization is complete and
        ''' can be used for further object setup.
        ''' </summary>
        Private Partial Sub OnCreated()
        End Sub
        Private Partial Sub OnNameChanging(ByVal value As String)
        End Sub
        Private Partial Sub OnNameChanged()
        End Sub
        Private Partial Sub OnRolesChanging(ByVal value As IEnumerable(Of String))
        End Sub
        Private Partial Sub OnRolesChanged()
        End Sub

        #End Region
        
        
        ''' <summary>
        ''' Initializes a new instance of the <see cref="User1"/> class.
        ''' </summary>
        Public Sub New()
            MyBase.New
            Me.OnCreated
        End Sub
        
        ''' <summary>
        ''' Gets or sets the 'Name' value.
        ''' </summary>
        <DataMember(),  _
         Editable(false, AllowInitialValue:=true),  _
         Key(),  _
         RoundtripOriginal()>  _
        Public Property Name() As String
            Get
                Return Me._name
            End Get
            Set
                If (String.Equals(Me._name, value) = false) Then
                    Me.OnNameChanging(value)
                    Me.ValidateProperty("Name", value)
                    Me._name = value
                    Me.RaisePropertyChanged("Name")
                    Me.OnNameChanged
                    Me.RaisePropertyChanged("IsAuthenticated")
                End If
            End Set
        End Property
        
        ''' <summary>
        ''' Gets or sets the 'Roles' value.
        ''' </summary>
        <DataMember(),  _
         Editable(false)>  _
        Public Property Roles() As IEnumerable(Of String)
            Get
                Return Me._roles
            End Get
            Set
                If (Object.Equals(Me._roles, value) = false) Then
                    Me.OnRolesChanging(value)
                    Me.ValidateProperty("Roles", value)
                    Me._roles = value
                    Me.RaisePropertyChanged("Roles")
                    Me.OnRolesChanged
                End If
            End Set
        End Property
        
        ReadOnly Property Global_System_Security_Principal_IIdentity_AuthenticationType() As String Implements Global.System.Security.Principal.IIdentity.AuthenticationType
            Get
                Return String.Empty
            End Get
        End Property
        
        '''<summary>
        '''Gets a value indicating whether the identity is authenticated.
        '''</summary>
        '''<remarks>
        '''This value is <c>true</c> if <see cref="Name"/> is not <c>null</c> or empty.
        '''</remarks>
        Public ReadOnly Property IsAuthenticated() As Boolean Implements Global.System.Security.Principal.IIdentity.IsAuthenticated
            Get
                Return (true <> String.IsNullOrEmpty(Me.Name))
            End Get
        End Property
        
        ReadOnly Property Global_System_Security_Principal_IIdentity_Name() As String Implements Global.System.Security.Principal.IIdentity.Name
            Get
                Return Me.Name
            End Get
        End Property
        
        ReadOnly Property Global_System_Security_Principal_IPrincipal_Identity() As Global.System.Security.Principal.IIdentity Implements Global.System.Security.Principal.IPrincipal.Identity
            Get
                Return Me
            End Get
        End Property
        
        ''' <summary>
        ''' Computes a value from the key fields that uniquely identifies this entity instance.
        ''' </summary>
        ''' <returns>An object instance that uniquely identifies this entity instance.</returns>
        Public Overrides Function GetIdentity() As Object
            Return Me._name
        End Function
        
        '''<summary>
        '''Return whether the principal is in the role.
        '''</summary>
        '''<remarks>
        '''Returns whether the specified role is contained in the roles.
        '''This implementation is case sensitive.
        '''</remarks>
        '''<param name="role">The name of the role for which to check membership.</param>
        '''<returns>Whether the principal is in the role.</returns>
        Public Function IsInRole(ByVal role As String) As Boolean Implements Global.System.Security.Principal.IPrincipal.IsInRole
            If (Me.Roles Is Nothing) Then
                Return false
            End If
            Return Global.System.Linq.Enumerable.Contains(Me.Roles, role)
        End Function
    End Class
    
    ''' <summary>
    ''' The 'User2' entity class.
    ''' </summary>
    <DataContract([Namespace]:="http://schemas.datacontract.org/2004/07/RootNamespace.TestNamespace")>  _
    Partial Public NotInheritable Class User2
        Inherits Entity
        Implements Global.System.Security.Principal.IIdentity, Global.System.Security.Principal.IPrincipal
        
        Private _name As String = String.Empty
        
        Private _roles As IEnumerable(Of String)
        
        #Region "Extensibility Method Definitions"

        ''' <summary>
        ''' This method is invoked from the constructor once initialization is complete and
        ''' can be used for further object setup.
        ''' </summary>
        Private Partial Sub OnCreated()
        End Sub
        Private Partial Sub OnNameChanging(ByVal value As String)
        End Sub
        Private Partial Sub OnNameChanged()
        End Sub
        Private Partial Sub OnRolesChanging(ByVal value As IEnumerable(Of String))
        End Sub
        Private Partial Sub OnRolesChanged()
        End Sub

        #End Region
        
        
        ''' <summary>
        ''' Initializes a new instance of the <see cref="User2"/> class.
        ''' </summary>
        Public Sub New()
            MyBase.New
            Me.OnCreated
        End Sub
        
        ''' <summary>
        ''' Gets or sets the 'Name' value.
        ''' </summary>
        <DataMember(),  _
         Editable(false, AllowInitialValue:=true),  _
         Key(),  _
         RoundtripOriginal()>  _
        Public Property Name() As String
            Get
                Return Me._name
            End Get
            Set
                If (String.Equals(Me._name, value) = false) Then
                    Me.OnNameChanging(value)
                    Me.ValidateProperty("Name", value)
                    Me._name = value
                    Me.RaisePropertyChanged("Name")
                    Me.OnNameChanged
                    Me.RaisePropertyChanged("IsAuthenticated")
                End If
            End Set
        End Property
        
        ''' <summary>
        ''' Gets or sets the 'Roles' value.
        ''' </summary>
        <DataMember(),  _
         Editable(false)>  _
        Public Property Roles() As IEnumerable(Of String)
            Get
                Return Me._roles
            End Get
            Set
                If (Object.Equals(Me._roles, value) = false) Then
                    Me.OnRolesChanging(value)
                    Me.ValidateProperty("Roles", value)
                    Me._roles = value
                    Me.RaisePropertyChanged("Roles")
                    Me.OnRolesChanged
                End If
            End Set
        End Property
        
        ReadOnly Property Global_System_Security_Principal_IIdentity_AuthenticationType() As String Implements Global.System.Security.Principal.IIdentity.AuthenticationType
            Get
                Return String.Empty
            End Get
        End Property
        
        '''<summary>
        '''Gets a value indicating whether the identity is authenticated.
        '''</summary>
        '''<remarks>
        '''This value is <c>true</c> if <see cref="Name"/> is not <c>null</c> or empty.
        '''</remarks>
        Public ReadOnly Property IsAuthenticated() As Boolean Implements Global.System.Security.Principal.IIdentity.IsAuthenticated
            Get
                Return (true <> String.IsNullOrEmpty(Me.Name))
            End Get
        End Property
        
        ReadOnly Property Global_System_Security_Principal_IIdentity_Name() As String Implements Global.System.Security.Principal.IIdentity.Name
            Get
                Return Me.Name
            End Get
        End Property
        
        ReadOnly Property Global_System_Security_Principal_IPrincipal_Identity() As Global.System.Security.Principal.IIdentity Implements Global.System.Security.Principal.IPrincipal.Identity
            Get
                Return Me
            End Get
        End Property
        
        ''' <summary>
        ''' Computes a value from the key fields that uniquely identifies this entity instance.
        ''' </summary>
        ''' <returns>An object instance that uniquely identifies this entity instance.</returns>
        Public Overrides Function GetIdentity() As Object
            Return Me._name
        End Function
        
        '''<summary>
        '''Return whether the principal is in the role.
        '''</summary>
        '''<remarks>
        '''Returns whether the specified role is contained in the roles.
        '''This implementation is case sensitive.
        '''</remarks>
        '''<param name="role">The name of the role for which to check membership.</param>
        '''<returns>Whether the principal is in the role.</returns>
        Public Function IsInRole(ByVal role As String) As Boolean Implements Global.System.Security.Principal.IPrincipal.IsInRole
            If (Me.Roles Is Nothing) Then
                Return false
            End If
            Return Global.System.Linq.Enumerable.Contains(Me.Roles, role)
        End Function
    End Class
End Namespace
