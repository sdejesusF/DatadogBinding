using System;
using IO.Opentracing;
using IO.Opentracing.Tag;

namespace Com.Datadog.Opentracing
{
    public partial class DDTracer : global::Java.Lang.Object, global::Com.Datadog.Trace.Api.ITracer, global::IO.Opentracing.ITracer, global::Java.IO.ICloseable
    {
        public partial class DDSpanBuilder : global::Java.Lang.Object, global::IO.Opentracing.ITracerSpanBuilder
        {

            IO.Opentracing.ITracerSpanBuilder IO.Opentracing.ITracerSpanBuilder.AddReference(string p0, IO.Opentracing.ISpanContext p1)
            {
                return AddReference(p0, p1);
            }

            IO.Opentracing.ITracerSpanBuilder IO.Opentracing.ITracerSpanBuilder.AsChildOf(IO.Opentracing.ISpan p0)
            {
                return AsChildOf(p0);
            }

            IO.Opentracing.ITracerSpanBuilder IO.Opentracing.ITracerSpanBuilder.AsChildOf(IO.Opentracing.ISpanContext p0)
            {
                return AsChildOf(p0);
            }

            IO.Opentracing.ITracerSpanBuilder IO.Opentracing.ITracerSpanBuilder.WithStartTimestamp(long p0)
            {
                return WithStartTimestamp(p0);
            }

            IO.Opentracing.ITracerSpanBuilder IO.Opentracing.ITracerSpanBuilder.WithTag(string p0, bool p1)
            {
                return WithTag(p0, p1);
            }

            IO.Opentracing.ITracerSpanBuilder IO.Opentracing.ITracerSpanBuilder.WithTag(string p0, Java.Lang.Number p1)
            {
                return WithTag(p0, p1);
            }

            IO.Opentracing.ITracerSpanBuilder IO.Opentracing.ITracerSpanBuilder.WithTag(string p0, string p1)
            {
                return WithTag(p0, p1);
            }
        }
    }
}