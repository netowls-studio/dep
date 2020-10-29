// This file is used by Code Analysis to maintain SuppressMessage
// attributes that are applied to this project.
// Project-level suppressions either have no target or are given
// a specific target and scoped to a namespace, type, member, etc.

using System.Diagnostics.CodeAnalysis;

[assembly: SuppressMessage("Usage", "CA2235:Mark all non-serializable fields", Justification = "<挂起>", Scope = "member", Target = "~P:NetowlsStudio.Dep.Messaging.UriMessage.Uri")]
[assembly: SuppressMessage("Microsoft.Design", "InterfaceViolations:Exception(s) thrown but not declared in interface", Justification = "<挂起>", Scope = "member", Target = "~M:NetowlsStudio.Dep.Messaging.IO.StreamSlicer.Split(System.IO.Stream)~System.Collections.Generic.IEnumerable{NetowlsStudio.Dep.Messaging.IO.StreamFragmentInfo}")]
[assembly: SuppressMessage("Usage", "CA2235:Mark all non-serializable fields", Justification = "<挂起>", Scope = "member", Target = "~P:NetowlsStudio.Dep.Messaging.IO.FileStreamFragmentInfo.FileName")]
[assembly: SuppressMessage("Usage", "CA2235:Mark all non-serializable fields", Justification = "<挂起>", Scope = "member", Target = "~P:NetowlsStudio.Dep.Messaging.IO.FileStreamFragmentInfo.Path")]
[assembly: SuppressMessage("Microsoft.Design", "BaseMethodViolations:Exception(s) thrown but not declared in base method", Justification = "<挂起>", Scope = "member", Target = "~M:NetowlsStudio.Dep.Messaging.IO.FileStreamSlicer.InternalSplit(System.IO.FileInfo)~System.Collections.Generic.IEnumerable{NetowlsStudio.Dep.Messaging.IO.FileStreamFragmentInfo}")]
[assembly: SuppressMessage("Microsoft.Design", "BaseMethodViolations:Exception(s) thrown but not declared in base method", Justification = "<挂起>", Scope = "member", Target = "~M:NetowlsStudio.Dep.Messaging.IO.FileStreamSlicer.Split(System.IO.FileInfo)~System.Collections.Generic.IEnumerable{NetowlsStudio.Dep.Messaging.IO.FileStreamFragmentInfo}")]
