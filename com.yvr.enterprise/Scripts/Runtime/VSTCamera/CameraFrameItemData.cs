using System;
using System.Runtime.InteropServices;

namespace YVR.Enterprise
{
    [StructLayout(LayoutKind.Sequential)]
    public struct CameraFrameItemData
    {
        public int frameNumber;
        public int width;
        public int height;
        public int format;
        public int exposureDuration;
        public long soeTimestamp;
        public long soeTimestampq;
        public int  gain;
        public int dataSize;
        [MarshalAs(UnmanagedType.ByValArray, SizeConst = 2)]
        public IntPtr[] data;

        public override string ToString()
        {
            return $"frameNumber:{frameNumber},width:{width},height:{height},format:{format}," +
                   $"exposureDuration:{exposureDuration},soeTimestamp:{soeTimestamp},soeTimestampq:{soeTimestampq}," +
                   $"gain:{gain},dataSize:{dataSize}";
        }
    }
}