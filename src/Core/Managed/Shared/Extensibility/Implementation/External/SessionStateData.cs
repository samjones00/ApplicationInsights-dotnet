﻿namespace Microsoft.ApplicationInsights.Extensibility.Implementation.External
{
#if NET45
    // .Net 4.5 has a custom implementation of RichPayloadEventSource
#else
    /// <summary>
    /// Partial class to add the EventData attribute and any additional customizations to the generated type.
    /// </summary>
#if NET40
    [Microsoft.Diagnostics.Tracing.EventData(Name = "PartB_SessionStateData")]
#else
    [System.Diagnostics.Tracing.EventData(Name = "PartB_SessionStateData")]
#endif
    internal partial class SessionStateData
    {
    }
#endif
}