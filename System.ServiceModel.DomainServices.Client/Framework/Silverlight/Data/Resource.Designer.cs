﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.1
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace System.ServiceModel.DomainServices.Client {
    using System;
    
    
    /// <summary>
    ///   A strongly-typed resource class, for looking up localized strings, etc.
    /// </summary>
    // This class was auto-generated by the StronglyTypedResourceBuilder
    // class via a tool like ResGen or Visual Studio.
    // To add or remove a member, edit your .ResX file then rerun ResGen
    // with the /str option, or rebuild your VS project.
    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Resources.Tools.StronglyTypedResourceBuilder", "4.0.0.0")]
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
    [global::System.Runtime.CompilerServices.CompilerGeneratedAttribute()]
    internal class Resource {
        
        private static global::System.Resources.ResourceManager resourceMan;
        
        private static global::System.Globalization.CultureInfo resourceCulture;
        
        [global::System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1811:AvoidUncalledPrivateCode")]
        internal Resource() {
        }
        
        /// <summary>
        ///   Returns the cached ResourceManager instance used by this class.
        /// </summary>
        [global::System.ComponentModel.EditorBrowsableAttribute(global::System.ComponentModel.EditorBrowsableState.Advanced)]
        internal static global::System.Resources.ResourceManager ResourceManager {
            get {
                if (object.ReferenceEquals(resourceMan, null)) {
                    global::System.Resources.ResourceManager temp = new global::System.Resources.ResourceManager("System.ServiceModel.DomainServices.Client.Data.Resource", typeof(Resource).Assembly);
                    resourceMan = temp;
                }
                return resourceMan;
            }
        }
        
        /// <summary>
        ///   Overrides the current thread's CurrentUICulture property for all
        ///   resource lookups using this strongly typed resource class.
        /// </summary>
        [global::System.ComponentModel.EditorBrowsableAttribute(global::System.ComponentModel.EditorBrowsableState.Advanced)]
        internal static global::System.Globalization.CultureInfo Culture {
            get {
                return resourceCulture;
            }
            set {
                resourceCulture = value;
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to ComplexObject instances cannot be shared..
        /// </summary>
        internal static string ComplexType_InstancesCannotBeShared {
            get {
                return ResourceManager.GetString("ComplexType_InstancesCannotBeShared", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Reference cycle detected. Entity or ComplexObject members cannot contain cyclic references..
        /// </summary>
        internal static string CyclicReferenceError {
            get {
                return ResourceManager.GetString("CyclicReferenceError", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to The DomainClient &apos;{0}&apos; does not support cancellation..
        /// </summary>
        internal static string DomainClient_CancellationNotSupported {
            get {
                return ResourceManager.GetString("DomainClient_CancellationNotSupported", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to The submitted change-set was empty..
        /// </summary>
        internal static string DomainClient_EmptyChangeSet {
            get {
                return ResourceManager.GetString("DomainClient_EmptyChangeSet", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to EntityTypes has already been initialized.
        /// </summary>
        internal static string DomainClient_EntityTypesAlreadyInitialized {
            get {
                return ResourceManager.GetString("DomainClient_EntityTypesAlreadyInitialized", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Custom method invocation name cannot be null or empty..
        /// </summary>
        internal static string DomainClient_InvocationNameCannotBeNullOrEmpty {
            get {
                return ResourceManager.GetString("DomainClient_InvocationNameCannotBeNullOrEmpty", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to The EntityContainer for a DomainContext cannot be null..
        /// </summary>
        internal static string DomainContext_EntityContainerCannotBeNull {
            get {
                return ResourceManager.GetString("DomainContext_EntityContainerCannotBeNull", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to The specified EntityQuery &apos;{0}&apos; cannot be loaded because it was not created by this DomainContext..
        /// </summary>
        internal static string DomainContext_InvalidEntityQueryDomainClient {
            get {
                return ResourceManager.GetString("DomainContext_InvalidEntityQueryDomainClient", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to The specified service URI is not correctly formatted..
        /// </summary>
        internal static string DomainContext_InvalidServiceUri {
            get {
                return ResourceManager.GetString("DomainContext_InvalidServiceUri", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Invoke operation &apos;{0}&apos; failed. {1}.
        /// </summary>
        internal static string DomainContext_InvokeOperationFailed {
            get {
                return ResourceManager.GetString("DomainContext_InvokeOperationFailed", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Invoke operation &apos;{0}&apos; failed validation.  Please inspect ValidationErrors on the operation for details..
        /// </summary>
        internal static string DomainContext_InvokeOperationFailed_Validation {
            get {
                return ResourceManager.GetString("DomainContext_InvokeOperationFailed_Validation", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Load operation failed for query &apos;{0}&apos;. {1}.
        /// </summary>
        internal static string DomainContext_LoadOperationFailed {
            get {
                return ResourceManager.GetString("DomainContext_LoadOperationFailed", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Load operation for query &apos;{0}&apos; failed validation.  Please inspect ValidationErrors on the operation for details..
        /// </summary>
        internal static string DomainContext_LoadOperationFailed_Validation {
            get {
                return ResourceManager.GetString("DomainContext_LoadOperationFailed_Validation", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to The custom update method &apos;{0}&apos; called on entity &apos;{1}&apos; was called through the &apos;{2}&apos; DomainContext, which is not the correct DomainContext. The method may be available through another DomainContext..
        /// </summary>
        internal static string DomainContext_NamedUpdateMethodDoesNotExist {
            get {
                return ResourceManager.GetString("DomainContext_NamedUpdateMethodDoesNotExist", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to A SubmitChanges operation is already in progress on this DomainContext..
        /// </summary>
        internal static string DomainContext_SubmitAlreadyInProgress {
            get {
                return ResourceManager.GetString("DomainContext_SubmitAlreadyInProgress", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Submit operation failed. {0}.
        /// </summary>
        internal static string DomainContext_SubmitOperationFailed {
            get {
                return ResourceManager.GetString("DomainContext_SubmitOperationFailed", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Submit operation failed due to conflicts. Please inspect Entity.EntityConflict for each entity in EntitiesInError for more information..
        /// </summary>
        internal static string DomainContext_SubmitOperationFailed_Conflicts {
            get {
                return ResourceManager.GetString("DomainContext_SubmitOperationFailed_Conflicts", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Submit operation failed validation. Please inspect Entity.ValidationErrors for each entity in EntitiesInError for more information..
        /// </summary>
        internal static string DomainContext_SubmitOperationFailed_Validation {
            get {
                return ResourceManager.GetString("DomainContext_SubmitOperationFailed_Validation", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Composed child entity &apos;{0}&apos; cannot be assigned to a new parent..
        /// </summary>
        internal static string Entity_CantReparentComposedChild {
            get {
                return ResourceManager.GetString("Entity_CantReparentComposedChild", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to A compositional association on an entity cannot contain the entity itself..
        /// </summary>
        internal static string Entity_ChildCannotBeItsParent {
            get {
                return ResourceManager.GetString("Entity_ChildCannotBeItsParent", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to A custom method cannot be invoked on an entity in a Deleted EntityState..
        /// </summary>
        internal static string Entity_InvokeOnDeletedEntity {
            get {
                return ResourceManager.GetString("Entity_InvokeOnDeletedEntity", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to A custom method cannot be invoked on a Detached entity..
        /// </summary>
        internal static string Entity_InvokeOnDetachedEntity {
            get {
                return ResourceManager.GetString("Entity_InvokeOnDetachedEntity", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to A custom method cannot be invoked on an entity that is part of a change-set that is in the process of being submitted..
        /// </summary>
        internal static string Entity_InvokeWhileSubmitting {
            get {
                return ResourceManager.GetString("Entity_InvokeWhileSubmitting", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to The value of key member &apos;{0}&apos; on an instance of an entity of type &apos;{1}&apos; has changed. Entity key members cannot be changed..
        /// </summary>
        internal static string Entity_KeyMembersCannotBeChanged {
            get {
                return ResourceManager.GetString("Entity_KeyMembersCannotBeChanged", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Only one pending custom method invocation is allowed per entity..
        /// </summary>
        internal static string Entity_MultipleCustomMethodInvocations {
            get {
                return ResourceManager.GetString("Entity_MultipleCustomMethodInvocations", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to The specified entity is not a member of this collection.
        /// </summary>
        internal static string Entity_Not_In_Collection {
            get {
                return ResourceManager.GetString("Entity_Not_In_Collection", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to The property &apos;{0}&apos; on entity type &apos;{1}&apos; is not a change tracked data member..
        /// </summary>
        internal static string Entity_Property_NotChangeTracked {
            get {
                return ResourceManager.GetString("Entity_Property_NotChangeTracked", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to This entity is currently read-only. One of the following conditions exist: a custom method has been invoked, a submit operation is in progress, or edit operations are not supported for the entity type..
        /// </summary>
        internal static string Entity_ReadOnly {
            get {
                return ResourceManager.GetString("Entity_ReadOnly", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Entity &apos;{0}&apos; is currently being edited and has uncommitted changes. A call to BeginEdit must be followed by a call to EndEdit or CancelEdit before changes can be submitted..
        /// </summary>
        internal static string Entity_UncommittedChanges {
            get {
                return ResourceManager.GetString("Entity_UncommittedChanges", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Modification of an EntityCollection whose source is external is not permitted..
        /// </summary>
        internal static string EntityCollection_ModificationNotAllowedForExternalReference {
            get {
                return ResourceManager.GetString("EntityCollection_ModificationNotAllowedForExternalReference", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Resolve cannot be called for delete conflicts..
        /// </summary>
        internal static string EntityConflict_CannotResolveDeleteConflict {
            get {
                return ResourceManager.GetString("EntityConflict_CannotResolveDeleteConflict", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to PropertyNames are not available for delete conflicts..
        /// </summary>
        internal static string EntityConflict_IsDeleteConflict {
            get {
                return ResourceManager.GetString("EntityConflict_IsDeleteConflict", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Cannot retrieve an EntitySet for the derived entity type &apos;{0}&apos;. Use EntityContainer.GetEntitySet(Type) to get the EntitySet for the base entity type &apos;{1}&apos;..
        /// </summary>
        internal static string EntityContainer_CannotRetrieveEntitySetForDerivedEntity {
            get {
                return ResourceManager.GetString("EntityContainer_CannotRetrieveEntitySetForDerivedEntity", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Entity &apos;{0}&apos; cannot be attached to this EntityContainer because it is already attached to another EntityContainer..
        /// </summary>
        internal static string EntityContainer_CrossContainerAttach {
            get {
                return ResourceManager.GetString("EntityContainer_CrossContainerAttach", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to The EntitySet for Entity &apos;{0}&apos; already exists in the EntityContainer..
        /// </summary>
        internal static string EntityContainer_EntitySetAlreadyExists {
            get {
                return ResourceManager.GetString("EntityContainer_EntitySetAlreadyExists", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to This EntityContainer does not contain an EntitySet of type &apos;{0}&apos;. If the type is external to this EntityContainer, please make sure you’ve called AddReference to establish the external link..
        /// </summary>
        internal static string EntityContainerDoesntContainEntityType {
            get {
                return ResourceManager.GetString("EntityContainerDoesntContainEntityType", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to An EntityKey value cannot be null.
        /// </summary>
        internal static string EntityKey_CannotBeNull {
            get {
                return ResourceManager.GetString("EntityKey_CannotBeNull", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to To create an EntityKey, you must specify at least one key value..
        /// </summary>
        internal static string EntityKey_EmptyKeyMembers {
            get {
                return ResourceManager.GetString("EntityKey_EmptyKeyMembers", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Entity &apos;{0}&apos; cannot be added to cache because it doesn&apos;t have a valid identity..
        /// </summary>
        internal static string EntityKey_NullIdentity {
            get {
                return ResourceManager.GetString("EntityKey_NullIdentity", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to EntityQuery for Type &apos;{0}&apos; targeting query operation &apos;{1}&apos; does not support query composition..
        /// </summary>
        internal static string EntityQuery_NotComposable {
            get {
                return ResourceManager.GetString("EntityQuery_NotComposable", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to An entity with the same identity already exists in this EntitySet..
        /// </summary>
        internal static string EntitySet_DuplicateIdentity {
            get {
                return ResourceManager.GetString("EntitySet_DuplicateIdentity", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to The entity being added is already attached..
        /// </summary>
        internal static string EntitySet_EntityAlreadyAttached {
            get {
                return ResourceManager.GetString("EntitySet_EntityAlreadyAttached", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to The specified entity is already contained in an EntitySet.
        /// </summary>
        internal static string EntitySet_EntityAlreadyInSet {
            get {
                return ResourceManager.GetString("EntitySet_EntityAlreadyInSet", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to The specified entity is not contained in this EntitySet..
        /// </summary>
        internal static string EntitySet_EntityNotInSet {
            get {
                return ResourceManager.GetString("EntitySet_EntityNotInSet", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to This EntitySet of Type &apos;{0}&apos; does not support the &apos;{1}&apos; operation..
        /// </summary>
        internal static string EntitySet_UnsupportedOperation {
            get {
                return ResourceManager.GetString("EntitySet_UnsupportedOperation", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to EntitySet of Type &apos;{0}&apos; cannot contain instances of Type &apos;{1}&apos;..
        /// </summary>
        internal static string EntitySet_Wrong_Type {
            get {
                return ResourceManager.GetString("EntitySet_Wrong_Type", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to &apos;{0}&apos; is not supported..
        /// </summary>
        internal static string IsNotSupported {
            get {
                return ResourceManager.GetString("IsNotSupported", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Member &apos;{0}&apos; must be marked with AssociationAttribute.
        /// </summary>
        internal static string MemberMustBeAssociation {
            get {
                return ResourceManager.GetString("MemberMustBeAssociation", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to &apos;{0}&apos; must be an Entity..
        /// </summary>
        internal static string MustBeAnEntity {
            get {
                return ResourceManager.GetString("MustBeAnEntity", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to MarkErrorAsHandled can only be called if HasError is true..
        /// </summary>
        internal static string Operation_HasErrorMustBeTrue {
            get {
                return ResourceManager.GetString("Operation_HasErrorMustBeTrue", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to The parameter &apos;{0}&apos; cannot be null or empty..
        /// </summary>
        internal static string Parameter_NullOrEmpty {
            get {
                return ResourceManager.GetString("Parameter_NullOrEmpty", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Type &apos;{0}&apos; does not contain a public property named &apos;{1}&apos;..
        /// </summary>
        internal static string Property_Does_Not_Exist {
            get {
                return ResourceManager.GetString("Property_Does_Not_Exist", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to The &apos;{0}&apos; property is read only..
        /// </summary>
        internal static string Property_Is_ReadOnly {
            get {
                return ResourceManager.GetString("Property_Is_ReadOnly", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Type &apos;{0}&apos; does not derive from Entity.
        /// </summary>
        internal static string Type_Not_Entity {
            get {
                return ResourceManager.GetString("Type_Not_Entity", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Ambiguous match for method &apos;{0}&apos;..
        /// </summary>
        internal static string ValidationUtilities_AmbiguousMatch {
            get {
                return ResourceManager.GetString("ValidationUtilities_AmbiguousMatch", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to ValidationContext.ObjectInstance cannot be null..
        /// </summary>
        internal static string ValidationUtilities_ContextInstance_CannotBeNull {
            get {
                return ResourceManager.GetString("ValidationUtilities_ContextInstance_CannotBeNull", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Method &apos;{0}.{1}({3})&apos; could not be found. Parameter count: {2}..
        /// </summary>
        internal static string ValidationUtilities_MethodNotFound {
            get {
                return ResourceManager.GetString("ValidationUtilities_MethodNotFound", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Method &apos;{0}.{1}&apos; accepting zero parameters could not be found..
        /// </summary>
        internal static string ValidationUtilities_MethodNotFound_ZeroParams {
            get {
                return ResourceManager.GetString("ValidationUtilities_MethodNotFound_ZeroParams", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Operation &apos;{0}&apos; does not exist..
        /// </summary>
        internal static string WebDomainClient_OperationDoesNotExist {
            get {
                return ResourceManager.GetString("WebDomainClient_OperationDoesNotExist", resourceCulture);
            }
        }
    }
}
