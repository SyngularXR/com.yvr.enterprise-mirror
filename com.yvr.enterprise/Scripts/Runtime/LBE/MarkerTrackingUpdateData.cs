using System.Runtime.InteropServices;
using UnityEngine;
using YVR.Core;

namespace YVR.Enterprise.LBE
{
    [StructLayout(LayoutKind.Sequential)]
    public struct MarkerTrackingUpdateData
    {
        public long markerId;
        public int markerType;

        [MarshalAs(UnmanagedType.ByValArray, SizeConst = LBEPlugin.spaceUuidMaxSize)]
        public Vector3[] region;

        public XRPose markerPose; // marker origin pose
        public float confidence;
    }
}