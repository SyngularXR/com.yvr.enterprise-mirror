using UnityEngine;

namespace YVR.Enterprise.Device
{
    public abstract class DevicePlugin
    {
        private static DevicePlugin s_Instance;

        public static DevicePlugin Instance
        {
            get
            {
                if (s_Instance == null)
                {
                    if (!Application.isEditor && Application.platform == RuntimePlatform.Android)
                        s_Instance = DeviceAndroidPlugin.Create();
                    else
                        s_Instance = DeviceEditorPlugin.Create();
                }

                return s_Instance;
            }
        }
        public virtual void SetIPDEnable(bool enable){}
        public virtual bool GetIPDEnable() { return false;}
        public virtual void SetIPDValue(float value){}
        public virtual float GetIPDVale() { return -1; }

    }
}