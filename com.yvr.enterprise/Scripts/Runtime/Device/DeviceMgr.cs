#if USE_ANDROID_DEVICE_CORE
using UnityEngine;
using YVR.AndroidDevice.Core;

namespace YVR.Enterprise.Device
{
    public class DeviceMgr : AJCMgrSingleton<DeviceMgr, AJCMocker, DeviceElements>
    {
        protected override void OnInit()
        {
            base.OnInit();
            AndroidJavaObject playerActivity = AndroidUtils.unityPlayerActivity;
            ajcBase.CallJNIStatic(DeviceElements.init, playerActivity);
            var helperInstance = ajcBase.CallJNIStatic<AndroidJavaObject>(DeviceElements.getInstance);

            // The instance is the real android object for further use, so we create a new ajcBase with it.
            ajcBase = new AJCInvoker(helperInstance);
        }

        public string btMac => ajcBase.CallJNI<string>(DeviceElements.getBTMac);
        public string wifiMac => ajcBase.CallJNI<string>(DeviceElements.getWifiMac);
        public string deviceModel => ajcBase.CallJNI<string>(DeviceElements.getDeviceModel);
        public string deviceSn => ajcBase.CallJNI<string>(DeviceElements.getDeviceSn);
        public string osVersion => ajcBase.CallJNI<string>(DeviceElements.getOSVersion);

        public int volume
        {
            get => ajcBase.CallJNI<int>(DeviceElements.getVolume);
            set => ajcBase.CallJNI(DeviceElements.setVolume, value);
        }

        public int maxVolume => ajcBase.CallJNI<int>(DeviceElements.getMaxVolume);

        public bool volumeAdjustmentRestricted
        {
            get => ajcBase.CallJNI<bool>(DeviceElements.isVolumeAdjustmentRestricted);
            set => ajcBase.CallJNI(DeviceElements.restrictVolumeAdjustment, value);
        }

        public int brightness
        {
            get => ajcBase.CallJNI<int>(DeviceElements.getBrightness);
            set => ajcBase.CallJNI(DeviceElements.setBrightness, value);
        }

        public bool brightnessAdjustmentRestricted
        {
            get => ajcBase.CallJNI<bool>(DeviceElements.isBrightnessAdjustmentRestricted);
            set => ajcBase.CallJNI(DeviceElements.restrictBrightnessAdjustment, value);
        }
        public  void EnableIPDAutoAdjustment(bool enable){ DevicePlugin.Instance.SetIPDEnable(enable); }
        public  bool GetIPDEnable() { return DevicePlugin.Instance.GetIPDEnable();}
        public  void SetIPDValue(float value) { DevicePlugin.Instance.SetIPDValue(value);}
        public  float GetIPDVale() { return DevicePlugin.Instance.GetIPDVale();}
    }
}
#endif