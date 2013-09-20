﻿[assembly: System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Design", "CA1024:UsePropertiesWhereAppropriate", Scope = "member", Target = "System.ServiceModel.DomainServices.Client.DomainServiceFault.#GetValidationErrors()", Justification = "This method is too expensive to make it a property")]
[assembly: System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Maintainability", "CA1502:AvoidExcessiveComplexity", Scope = "member", Target = "System.ServiceModel.DomainServices.Client.ExpressionVisitor.#Visit(System.Linq.Expressions.Expression)")]
[assembly: System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2201:DoNotRaiseReservedExceptionTypes", Scope = "member", Target = "System.ServiceModel.DomainServices.Client.ExpressionVisitor.#Visit(System.Linq.Expressions.Expression)")]
[assembly: System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2201:DoNotRaiseReservedExceptionTypes", Scope = "member", Target = "System.ServiceModel.DomainServices.Client.ExpressionVisitor.#VisitBinding(System.Linq.Expressions.MemberBinding)")]
[assembly: System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Maintainability", "CA1502:AvoidExcessiveComplexity", Scope = "member", Target = "System.ServiceModel.DomainServices.Client.QuerySerializer+Visitor.#VisitBinary(System.Linq.Expressions.BinaryExpression)")]
[assembly: System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Globalization", "CA1308:NormalizeStringsToUppercase", Scope = "member", Target = "System.ServiceModel.DomainServices.Client.QuerySerializer+Visitor.#VisitMethodCall(System.Linq.Expressions.MethodCallExpression)", Justification = "Return-value is used internally only.")]
[assembly: System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Design", "CA2210:AssembliesShouldHaveValidStrongNames", Justification = "Assemblies are delay-signed.")]
[assembly: System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Design", "CA1030:UseEventsWhereAppropriate", Scope = "member", Target = "System.ServiceModel.DomainServices.Client.ApplicationServices.WebContextBase.#RaisePropertyChanged(System.String)", Justification = "There is an event that corresponds to this method.")]
[assembly: System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Design", "CA1033:InterfaceMethodsShouldBeCallableByChildTypes", Scope = "member", Target = "System.ServiceModel.DomainServices.Client.ApplicationServices.WebContextBase.#System.ComponentModel.INotifyPropertyChanged.PropertyChanged", Justification = "The hiding is intentional.")]
[assembly: System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Design", "CA1033:InterfaceMethodsShouldBeCallableByChildTypes", Scope = "member", Target = "System.ServiceModel.DomainServices.Client.ApplicationServices.WebContextBase.#System.ComponentModel.INotifyPropertyChanged.PropertyChanged", Justification = "The hiding is intentional.")]
[assembly: System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Reliability", "CA2000:Dispose objects before losing scope", Scope = "member", Target = "System.ServiceModel.DomainServices.Client.PoxBinaryMessageEncodingBindingElement+PoxBinaryMessageEncoder.#ReadMessage(System.ArraySegment`1<System.Byte>,System.ServiceModel.Channels.BufferManager,System.String)", Justification = "Disposing reader will prevent the message from being read correctly.")]
[assembly: System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Reliability", "CA2000:Dispose objects before losing scope", Scope = "member", Target = "System.ServiceModel.DomainServices.Client.PoxBinaryMessageEncodingBindingElement+PoxBinaryMessageEncoder.#ReadMessage(System.IO.Stream,System.Int32,System.String)", Justification = "Disposing reader will prevent the message from being read correctly.")]
[assembly: System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2202:Do not dispose objects multiple times", Scope = "member", Target = "System.ServiceModel.DomainServices.Client.PoxBinaryMessageEncodingBindingElement+PoxBinaryMessageEncoder.#WriteMessage(System.ServiceModel.Channels.Message,System.Int32,System.ServiceModel.Channels.BufferManager,System.Int32)", Justification = "The MemoryStream will not be disposed by the XmlDictionaryWriter")]
[assembly: System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Reliability", "CA2000:Dispose objects before losing scope", Scope = "member", Target = "System.ServiceModel.DomainServices.Client.MessageUtility.#AddMessageQueryOptions(System.ServiceModel.Channels.Message&,System.Collections.Generic.IList`1<System.Collections.Generic.KeyValuePair`2<System.String,System.String>>)", Justification = "Disposing the MemoryStream will prevent the generated message from being read properly.")]
[assembly: System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Reliability", "CA2000:Dispose objects before losing scope", Scope = "member", Target = "System.ServiceModel.DomainServices.Client.MessageUtility+QueryOptionsBodyWriter.#OnCreateBufferedCopy(System.Int32)", Justification = "The writer will dispose memory stream.")]
[assembly: System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Reliability", "CA2000:Dispose objects before losing scope", Scope = "member", Target = "System.ServiceModel.DomainServices.Client.PoxBinaryMessageEncodingBindingElement+PoxBinaryMessageEncoder+PoxBinaryBufferedMessage+PoxBinaryBufferedMessageBuffer.#CreateMessage()", Justification = "The message is passed to the user. The user is responsible for disposal.")]
[assembly: System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Reliability", "CA2000:Dispose objects before losing scope", Scope = "member", Target = "System.ServiceModel.DomainServices.Client.PoxBinaryMessageEncodingBindingElement+PoxBinaryMessageEncoder+PoxBinaryBufferedMessageData.#TakeReader()", Justification = "The reader is passed to the user. The user is responsible for disposal.")]
