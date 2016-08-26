// Copyright (c) Microsoft. All rights reserved.

namespace Microsoft.VisualStudio.TestPlatform.MSTestAdapter.PlatformServices
{
    using System;

    using Microsoft.VisualStudio.TestPlatform.MSTestAdapter.PlatformServices.Interface;

    /// <summary>
    /// The trace logger for .Net Core.
    /// </summary>
    public class AdapterTraceLogger : IAdapterTraceLogger
    {
        /// <summary>
        /// Log an error in a given format.
        /// </summary>
        /// <param name="format"> The format. </param>
        /// <param name="args"> The args. </param>
        /// <exception cref="NotImplementedException"> This is currently not implemented. </exception>
        public void LogError(string format, params object[] args)
        {
            // Do Nothing.
        }

        /// <summary>
        /// Log a warning in a given format.
        /// </summary>
        /// <param name="format"> The format. </param>
        /// <param name="args"> The args. </param>
        /// <exception cref="NotImplementedException"> This is currently not implemented. </exception>
        public void LogWarning(string format, params object[] args)
        {
            // Do Nothing.
        }

        /// <summary>
        /// Log an information message in a given format.
        /// </summary>
        /// <param name="format"> The format. </param>
        /// <param name="args"> The args. </param>
        /// <exception cref="NotImplementedException"> This is currently not implemented. </exception>
        public void LogInfo(string format, params object[] args)
        {
            // Do Nothing.
        }
    }
}