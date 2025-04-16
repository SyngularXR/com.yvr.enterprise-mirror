using System.Runtime.InteropServices;

namespace YVR.Enterprise.Device
{
    public class DeviceAndroidPlugin:DevicePlugin
    {
        [DllImport("yvrplugin")]
        private static extern void YVRSetIPDEnable(bool enable);
        [DllImport("yvrplugin")]
        private static extern bool YVRGetIPDEnable();
        [DllImport("yvrplugin")]
        private static extern void YVRSetIPDValue(float value);
        [DllImport("yvrplugin")]
        private static extern float YVRGetIPDVale();
        
        public static DeviceAndroidPlugin Create(){ return new DeviceAndroidPlugin();}
        
        public override void SetIPDEnable(bool enable){ YVRSetIPDEnable(enable); }
        public override bool GetIPDEnable() { return YVRGetIPDEnable();}
        public override void SetIPDValue(float value) { YVRSetIPDValue(value);}
        public override float GetIPDVale() { return YVRGetIPDVale(); }
    }
}