namespace YVR.Enterprise.Device
{
    public class DeviceEditorPlugin:DevicePlugin
    {

        private static void YVRSetIPDEnable(bool enable) { }

        private static bool YVRGetIPDEnable() { return false;}

        private static void YVRSetIPDValue(float value) { }

        private static float YVRGetIPDVale() { return -1; }
        
        public static DeviceEditorPlugin Create(){ return new DeviceEditorPlugin();;}
        
        public override void SetIPDEnable(bool enable){ YVRSetIPDEnable(enable); }
        public override bool GetIPDEnable() { return YVRGetIPDEnable();}
        public override void SetIPDValue(float value) { YVRSetIPDValue(value);}
        public override float GetIPDVale() { return YVRGetIPDVale(); }
    }
}