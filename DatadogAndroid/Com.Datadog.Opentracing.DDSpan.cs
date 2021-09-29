using System;
using System.Collections.Generic;
using Android.Runtime;
using IO.Opentracing;
using Java.Interop;

namespace Com.Datadog.Opentracing {

	public partial class DDSpan : global::Java.Lang.Object, global::Com.Datadog.Trace.Api.Interceptor.IMutableSpan, global::IO.Opentracing.ISpan {

		global::Com.Datadog.Trace.Api.Interceptor.IMutableSpan global::Com.Datadog.Trace.Api.Interceptor.IMutableSpan.SetOperationName(string operationName)
		{
			return SetOperationName(operationName);
		}

		global::IO.Opentracing.ISpan global::IO.Opentracing.ISpan.SetOperationName(string operationName)
		{
			return SetOperationName(operationName);
		}

		global::Com.Datadog.Trace.Api.Interceptor.IMutableSpan global::Com.Datadog.Trace.Api.Interceptor.IMutableSpan.SetError(bool error)
		{
			return SetError(error);
		}

		global::Com.Datadog.Trace.Api.Interceptor.IMutableSpan global::Com.Datadog.Trace.Api.Interceptor.IMutableSpan.SetResourceName(string resourceName)
		{
			return SetResourceName(resourceName);
		}

		global::Com.Datadog.Trace.Api.Interceptor.IMutableSpan global::Com.Datadog.Trace.Api.Interceptor.IMutableSpan.SetSamplingPriority(int priority)
		{
			return SetSamplingPriority(priority);
		}

		global::Com.Datadog.Trace.Api.Interceptor.IMutableSpan global::Com.Datadog.Trace.Api.Interceptor.IMutableSpan.SetServiceName(string serviceName)
		{
			return SetServiceName(serviceName);
		}

		global::Com.Datadog.Trace.Api.Interceptor.IMutableSpan global::Com.Datadog.Trace.Api.Interceptor.IMutableSpan.SetSpanType(string type)
		{
			return SetSpanType(type);
		}

		global::Com.Datadog.Trace.Api.Interceptor.IMutableSpan global::Com.Datadog.Trace.Api.Interceptor.IMutableSpan.SetTag(string tag, bool value)
		{
			return SetTag(tag, value);
		}

		global::Com.Datadog.Trace.Api.Interceptor.IMutableSpan global::Com.Datadog.Trace.Api.Interceptor.IMutableSpan.SetTag(string tag, string value)
		{
			return SetTag(tag, value);
		}

		global::Com.Datadog.Trace.Api.Interceptor.IMutableSpan global::Com.Datadog.Trace.Api.Interceptor.IMutableSpan.SetTag(string tag, Java.Lang.Number value)
		{
			return SetTag(tag, value);
		}

		ISpanContext ISpan.Context()
		{
			return Context();
		}

		ISpan ISpan.Log(string p0)
		{
			return Log(p0);
		}

		ISpan ISpan.Log(IDictionary<string, object> p0)
		{
			return Log(p0);
		}

		ISpan ISpan.Log(long p0, string p1)
		{
			return Log(p0, p1);
		}

		ISpan ISpan.Log(long p0, IDictionary<string, object> p1)
		{
			return Log(p0, p1);
		}

		ISpan ISpan.SetBaggageItem(string p0, string p1)
		{
			return SetBaggageItem(p0, p1);
		}

		ISpan ISpan.SetTag(string p0, bool p1)
		{
			return SetTag(p0, p1);
		}

		ISpan ISpan.SetTag(string p0, Java.Lang.Number p1)
		{
			return SetTag(p0, p1);
		}

		ISpan ISpan.SetTag(string p0, string p1)
		{
			return SetTag(p0, p1);
		}
	}
}
