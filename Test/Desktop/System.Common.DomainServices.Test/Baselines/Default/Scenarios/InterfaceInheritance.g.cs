//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.1
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace TestDomainServices
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel;
    using System.ComponentModel.DataAnnotations;
    using System.Linq;
    using System.Runtime.Serialization;
    using System.ServiceModel;
    using System.ServiceModel.DomainServices;
    using System.ServiceModel.DomainServices.Client;
    using System.ServiceModel.DomainServices.Client.ApplicationServices;
    using System.ServiceModel.Web;
    using System.Xml.Linq;
    
    
    /// <summary>
    /// The 'EntityWithXElement' entity class.
    /// </summary>
    [DataContract(Namespace="http://schemas.datacontract.org/2004/07/TestDomainServices")]
    public sealed partial class EntityWithXElement : Entity
    {
        
        private int _id;
        
        private XElement _xElem;
        
        #region Extensibility Method Definitions

        /// <summary>
        /// This method is invoked from the constructor once initialization is complete and
        /// can be used for further object setup.
        /// </summary>
        partial void OnCreated();
        partial void OnIDChanging(int value);
        partial void OnIDChanged();
        partial void OnXElemChanging(XElement value);
        partial void OnXElemChanged();
        partial void OnEntityWithXElement_Custom_AttributeAggregationInvoking();
        partial void OnEntityWithXElement_Custom_AttributeAggregationInvoked();
        partial void OnEntityWithXElement_Custom_AttributeOverridesInvoking();
        partial void OnEntityWithXElement_Custom_AttributeOverridesInvoked();

        #endregion
        
        
        /// <summary>
        /// Initializes a new instance of the <see cref="EntityWithXElement"/> class.
        /// </summary>
        public EntityWithXElement()
        {
            this.OnCreated();
        }
        
        /// <summary>
        /// Gets or sets the 'ID' value.
        /// </summary>
        [DataMember()]
        [Editable(false, AllowInitialValue=true)]
        [Key()]
        [RoundtripOriginal()]
        public int ID
        {
            get
            {
                return this._id;
            }
            set
            {
                if ((this._id != value))
                {
                    this.OnIDChanging(value);
                    this.ValidateProperty("ID", value);
                    this._id = value;
                    this.RaisePropertyChanged("ID");
                    this.OnIDChanged();
                }
            }
        }
        
        /// <summary>
        /// Gets or sets the 'XElem' value.
        /// </summary>
        [DataMember()]
        public XElement XElem
        {
            get
            {
                return this._xElem;
            }
            set
            {
                if ((this._xElem != value))
                {
                    this.OnXElemChanging(value);
                    this.RaiseDataMemberChanging("XElem");
                    this.ValidateProperty("XElem", value);
                    this._xElem = value;
                    this.RaiseDataMemberChanged("XElem");
                    this.OnXElemChanged();
                }
            }
        }
        
        /// <summary>
        /// Gets a value indicating whether the 'EntityWithXElement_Custom_AttributeAggregation' action has been invoked on this entity.
        /// </summary>
        [Display(AutoGenerateField=false)]
        public bool IsEntityWithXElement_Custom_AttributeAggregationInvoked
        {
            get
            {
                return base.IsActionInvoked("EntityWithXElement_Custom_AttributeAggregation");
            }
        }
        
        /// <summary>
        /// Gets a value indicating whether the 'EntityWithXElement_Custom_AttributeAggregation' method can be invoked on this entity.
        /// </summary>
        [Display(AutoGenerateField=false)]
        public bool CanEntityWithXElement_Custom_AttributeAggregation
        {
            get
            {
                return base.CanInvokeAction("EntityWithXElement_Custom_AttributeAggregation");
            }
        }
        
        /// <summary>
        /// Gets a value indicating whether the 'EntityWithXElement_Custom_AttributeOverrides' action has been invoked on this entity.
        /// </summary>
        [Display(AutoGenerateField=false)]
        public bool IsEntityWithXElement_Custom_AttributeOverridesInvoked
        {
            get
            {
                return base.IsActionInvoked("EntityWithXElement_Custom_AttributeOverrides");
            }
        }
        
        /// <summary>
        /// Gets a value indicating whether the 'EntityWithXElement_Custom_AttributeOverrides' method can be invoked on this entity.
        /// </summary>
        [Display(AutoGenerateField=false)]
        public bool CanEntityWithXElement_Custom_AttributeOverrides
        {
            get
            {
                return base.CanInvokeAction("EntityWithXElement_Custom_AttributeOverrides");
            }
        }
        
        /// <summary>
        /// Computes a value from the key fields that uniquely identifies this entity instance.
        /// </summary>
        /// <returns>An object instance that uniquely identifies this entity instance.</returns>
        public override object GetIdentity()
        {
            return this._id;
        }
        
        /// <summary>
        /// Invokes the 'EntityWithXElement_Custom_AttributeAggregation' action on this entity.
        /// </summary>
        [MockAttributeAllowMultiple("Class")]
        [MockAttributeAllowMultiple("Class")]
        [MockAttributeAllowMultiple("Class")]
        [MockAttributeAllowMultiple("Interface")]
        [MockAttributeAllowMultiple("Interface")]
        [MockAttributeAllowMultiple("Interface")]
        public void EntityWithXElement_Custom_AttributeAggregation()
        {
            this.OnEntityWithXElement_Custom_AttributeAggregationInvoking();
            base.InvokeAction("EntityWithXElement_Custom_AttributeAggregation");
            this.OnEntityWithXElement_Custom_AttributeAggregationInvoked();
        }
        
        /// <summary>
        /// Invokes the 'EntityWithXElement_Custom_AttributeOverrides' action on this entity.
        /// </summary>
        [MockAttributeAllowOnce_AppliedToInterfaceOnly("Interface")]
        [MockAttributeAllowOnce("Class")]
        public void EntityWithXElement_Custom_AttributeOverrides()
        {
            this.OnEntityWithXElement_Custom_AttributeOverridesInvoking();
            base.InvokeAction("EntityWithXElement_Custom_AttributeOverrides");
            this.OnEntityWithXElement_Custom_AttributeOverridesInvoked();
        }
        
        protected override void OnActionStateChanged()
        {
            base.UpdateActionState("EntityWithXElement_Custom_AttributeAggregation", "CanEntityWithXElement_Custom_AttributeAggregation", "IsEntityWithXElement_Custom_AttributeAggregationInvoked");
            base.UpdateActionState("EntityWithXElement_Custom_AttributeOverrides", "CanEntityWithXElement_Custom_AttributeOverrides", "IsEntityWithXElement_Custom_AttributeOverridesInvoked");
        }
    }
    
    /// <summary>
    /// The DomainContext corresponding to the 'InterfaceInheritanceDomainService' DomainService.
    /// </summary>
    [MockAttributeAllowMultiple("Class")]
    [MockAttributeAllowMultiple("Class")]
    [MockAttributeAllowMultiple("Class")]
    [MockAttributeAllowMultiple("Interface")]
    [MockAttributeAllowMultiple("Interface")]
    [MockAttributeAllowMultiple("Interface")]
    [MockAttributeAllowOnce_AppliedToInterfaceOnly("Interface")]
    [MockAttributeAllowOnce("Class")]
    public sealed partial class InterfaceInheritanceDomainContext : DomainContext
    {
        
        #region Extensibility Method Definitions

        /// <summary>
        /// This method is invoked from the constructor once initialization is complete and
        /// can be used for further object setup.
        /// </summary>
        partial void OnCreated();

        #endregion
        
        
        /// <summary>
        /// Initializes a new instance of the <see cref="InterfaceInheritanceDomainContext"/> class.
        /// </summary>
        public InterfaceInheritanceDomainContext() : 
                this(new WebDomainClient<IInterfaceInheritanceDomainServiceContract>(new Uri("TestDomainServices-InterfaceInheritanceDomainService.svc", UriKind.Relative)))
        {
        }
        
        /// <summary>
        /// Initializes a new instance of the <see cref="InterfaceInheritanceDomainContext"/> class with the specified service URI.
        /// </summary>
        /// <param name="serviceUri">The InterfaceInheritanceDomainService service URI.</param>
        public InterfaceInheritanceDomainContext(Uri serviceUri) : 
                this(new WebDomainClient<IInterfaceInheritanceDomainServiceContract>(serviceUri))
        {
        }
        
        /// <summary>
        /// Initializes a new instance of the <see cref="InterfaceInheritanceDomainContext"/> class with the specified <paramref name="domainClient"/>.
        /// </summary>
        /// <param name="domainClient">The DomainClient instance to use for this DomainContext.</param>
        public InterfaceInheritanceDomainContext(DomainClient domainClient) : 
                base(domainClient)
        {
            this.OnCreated();
        }
        
        /// <summary>
        /// Gets the set of <see cref="EntityWithXElement"/> entity instances that have been loaded into this <see cref="InterfaceInheritanceDomainContext"/> instance.
        /// </summary>
        public EntitySet<EntityWithXElement> EntityWithXElements
        {
            get
            {
                return base.EntityContainer.GetEntitySet<EntityWithXElement>();
            }
        }
        
        /// <summary>
        /// Gets an EntityQuery instance that can be used to load <see cref="EntityWithXElement"/> entity instances using the 'EntityWithXElement_Get' query.
        /// </summary>
        /// <returns>An EntityQuery that can be loaded to retrieve <see cref="EntityWithXElement"/> entity instances.</returns>
        public EntityQuery<EntityWithXElement> EntityWithXElement_GetQuery()
        {
            this.ValidateMethod("EntityWithXElement_GetQuery", null);
            return base.CreateQuery<EntityWithXElement>("EntityWithXElement_Get", null, false, true);
        }
        
        /// <summary>
        /// Invokes the 'EntityWithXElement_Custom_AttributeOverrides' method of the specified <see cref="EntityWithXElement"/> entity.
        /// </summary>
        /// <param name="entity">The <see cref="EntityWithXElement"/> entity instance.</param>
        public void EntityWithXElement_Custom_AttributeOverrides(EntityWithXElement entity)
        {
            entity.EntityWithXElement_Custom_AttributeOverrides();
        }
        
        /// <summary>
        /// Invokes the 'EntityWithXElement_Custom_AttributeAggregation' method of the specified <see cref="EntityWithXElement"/> entity.
        /// </summary>
        /// <param name="entity">The <see cref="EntityWithXElement"/> entity instance.</param>
        public void EntityWithXElement_Custom_AttributeAggregation(EntityWithXElement entity)
        {
            entity.EntityWithXElement_Custom_AttributeAggregation();
        }
        
        /// <summary>
        /// Creates a new EntityContainer for this DomainContext's EntitySets.
        /// </summary>
        /// <returns>A new container instance.</returns>
        protected override EntityContainer CreateEntityContainer()
        {
            return new InterfaceInheritanceDomainContextEntityContainer();
        }
        
        /// <summary>
        /// Service contract for the 'InterfaceInheritanceDomainService' DomainService.
        /// </summary>
        [ServiceContract()]
        public interface IInterfaceInheritanceDomainServiceContract
        {
            
            /// <summary>
            /// Asynchronously invokes the 'EntityWithXElement_Get' operation.
            /// </summary>
            /// <param name="callback">Callback to invoke on completion.</param>
            /// <param name="asyncState">Optional state object.</param>
            /// <returns>An IAsyncResult that can be used to monitor the request.</returns>
            [FaultContract(typeof(DomainServiceFault), Action="http://tempuri.org/InterfaceInheritanceDomainService/EntityWithXElement_GetDomain" +
                "ServiceFault", Name="DomainServiceFault", Namespace="DomainServices")]
            [OperationContract(AsyncPattern=true, Action="http://tempuri.org/InterfaceInheritanceDomainService/EntityWithXElement_Get", ReplyAction="http://tempuri.org/InterfaceInheritanceDomainService/EntityWithXElement_GetRespon" +
                "se")]
            [WebGet()]
            IAsyncResult BeginEntityWithXElement_Get(AsyncCallback callback, object asyncState);
            
            /// <summary>
            /// Completes the asynchronous operation begun by 'BeginEntityWithXElement_Get'.
            /// </summary>
            /// <param name="result">The IAsyncResult returned from 'BeginEntityWithXElement_Get'.</param>
            /// <returns>The 'QueryResult' returned from the 'EntityWithXElement_Get' operation.</returns>
            QueryResult<EntityWithXElement> EndEntityWithXElement_Get(IAsyncResult result);
            
            /// <summary>
            /// Asynchronously invokes the 'SubmitChanges' operation.
            /// </summary>
            /// <param name="changeSet">The change-set to submit.</param>
            /// <param name="callback">Callback to invoke on completion.</param>
            /// <param name="asyncState">Optional state object.</param>
            /// <returns>An IAsyncResult that can be used to monitor the request.</returns>
            [FaultContract(typeof(DomainServiceFault), Action="http://tempuri.org/InterfaceInheritanceDomainService/SubmitChangesDomainServiceFa" +
                "ult", Name="DomainServiceFault", Namespace="DomainServices")]
            [OperationContract(AsyncPattern=true, Action="http://tempuri.org/InterfaceInheritanceDomainService/SubmitChanges", ReplyAction="http://tempuri.org/InterfaceInheritanceDomainService/SubmitChangesResponse")]
            IAsyncResult BeginSubmitChanges(IEnumerable<ChangeSetEntry> changeSet, AsyncCallback callback, object asyncState);
            
            /// <summary>
            /// Completes the asynchronous operation begun by 'BeginSubmitChanges'.
            /// </summary>
            /// <param name="result">The IAsyncResult returned from 'BeginSubmitChanges'.</param>
            /// <returns>The collection of change-set entry elements returned from 'SubmitChanges'.</returns>
            IEnumerable<ChangeSetEntry> EndSubmitChanges(IAsyncResult result);
        }
        
        internal sealed class InterfaceInheritanceDomainContextEntityContainer : EntityContainer
        {
            
            public InterfaceInheritanceDomainContextEntityContainer()
            {
                this.CreateEntitySet<EntityWithXElement>(EntitySetOperations.All);
            }
        }
    }
}
