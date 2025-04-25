using System.Runtime.InteropServices;

namespace YVR.Enterprise.Camera
{
    [StructLayout(LayoutKind.Sequential)]
    public struct VSTCameraIntrinsicExtrinsicData
    {
        public float fx;
        public float fy;
        public float cx;
        public float cy;

        public double x;
        public double y;
        public double z;
        public double rw;
        public double rx;
        public double ry;
        public double rz;

        public override string ToString()
        {
            return $"Intrinsic: fx:{fx}, fy:{fy}, cx:{cx}, cy:{cy}\n" +
                   $"Extrinsic: Position(x:{x}, y:{y}, z:{z})\n" +
                   $"Rotation(w:{rw}, x:{rx}, y:{ry}, z:{rz})";
        }
    }
}