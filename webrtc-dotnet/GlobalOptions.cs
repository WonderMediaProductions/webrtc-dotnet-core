﻿using System.Diagnostics;

namespace WonderMediaProductions.WebRtc
{
    public class GlobalOptions
    {
        public bool UseSignalingThread = true;
        public bool UseWorkerThread = true;
        public bool ForceSoftwareVideoEncoder = false;
        public bool AutoShutdown = true;

        public bool UseFakeEncoders = false;
        public bool UseFakeDecoders = false;

        public TraceLevel MinimumLogLevel = TraceLevel.Verbose;
        public bool LogToStandardError = true;
        public bool LogToDebugOutput = false;

        public int StartBitrate = 0;

        public bool IsSingleThreaded
        {
            set => UseSignalingThread = UseWorkerThread = value;
        }
    }
}