// This file is used by Code Analysis to maintain SuppressMessage
// attributes that are applied to this project.
// Project-level suppressions either have no target or are given
// a specific target and scoped to a namespace, type, member, etc.

using System.Diagnostics.CodeAnalysis;

[assembly: SuppressMessage("Usage", "CA2235:Mark all non-serializable fields", Justification = "<挂起>", Scope = "member", Target = "~P:NetowlsStudio.Dep.Messaging.Header.GroupId")]
[assembly: SuppressMessage("Usage", "CA2235:Mark all non-serializable fields", Justification = "<挂起>", Scope = "member", Target = "~P:NetowlsStudio.Dep.Messaging.Header.PublishTime")]
[assembly: SuppressMessage("Usage", "CA2235:Mark all non-serializable fields", Justification = "<挂起>", Scope = "member", Target = "~P:NetowlsStudio.Dep.Messaging.Message.Body")]
[assembly: SuppressMessage("Microsoft.Design", "UnhandledExceptions:Unhandled exception(s)", Justification = "<挂起>", Scope = "member", Target = "~M:NetowlsStudio.Dep.Messaging.Handlers.MessagePublisher.Publish(NetowlsStudio.Dep.Messaging.IMessage)")]
