using System;
using System.Collections.Generic;
using Android.Runtime;
using Java.Interop;

namespace Com.Datadog.Opentracing.Scopemanager {

	public partial class ContinuableScope : global::Java.Lang.Object, global::Com.Datadog.Trace.Context.ITraceScope {

		public partial class Continuation : global::Java.Lang.Object, global::Com.Datadog.Trace.Context.ITraceScopeContinuation, global::Java.IO.ICloseable {

			global::Com.Datadog.Trace.Context.ITraceScope global::Com.Datadog.Trace.Context.ITraceScopeContinuation.Activate()
			{
				return Activate();
			}
		}

		global::Com.Datadog.Trace.Context.ITraceScopeContinuation global::Com.Datadog.Trace.Context.ITraceScope.Capture()
		{
			return Capture();
		}
	}
}
