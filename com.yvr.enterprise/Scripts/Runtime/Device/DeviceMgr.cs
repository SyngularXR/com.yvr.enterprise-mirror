#if USE_ANDROID_DEVICE_CORE
using UnityEngine;
using YVR.AndroidDevice.Core;

namespace YVR.Enterprise.Device
{
    /// <summary>
    /// Provides enterprise users with the ability to modify/view device information.
    /// </summary>
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

        /// <summary>
        /// Bluetooth MAC address
        /// </summary>
        public string btMac => ajcBase.CallJNI<string>(DeviceElements.getBTMac);

        /// <summary>
        /// Wi-Fi MAC address
        /// </summary>
        public string wifiMac => ajcBase.CallJNI<string>(DeviceElements.getWifiMac);

        /// <summary>
        /// Device model
        /// </summary>
        public string deviceModel => ajcBase.CallJNI<string>(DeviceElements.getDeviceModel);

        /// <summary>
        /// Device serial number
        /// </summary>
        public string deviceSn => ajcBase.CallJNI<string>(DeviceElements.getDeviceSn);

        /// <summary>
        /// Operating system version
        /// </summary>
        public string osVersion => ajcBase.CallJNI<string>(DeviceElements.getOSVersion);

        /// <summary>
        /// System volume
        /// </summary>
        public int volume
        {
            get => ajcBase.CallJNI<int>(DeviceElements.getVolume);
            set => ajcBase.CallJNI(DeviceElements.setVolume, value);
        }

        /// <summary>
        /// Max volume
        /// </summary>
        public int maxVolume => ajcBase.CallJNI<int>(DeviceElements.getMaxVolume);

        /// <summary>
        /// Is the volume adjustment restricted
        /// </summary>
        public bool volumeAdjustmentRestricted
        {
            get => ajcBase.CallJNI<bool>(DeviceElements.isVolumeAdjustmentRestricted);
            set => ajcBase.CallJNI(DeviceElements.restrictVolumeAdjustment, value);
        }

        /// <summary>
        /// System brightness
        /// </summary>
        public int brightness
        {
            get => ajcBase.CallJNI<int>(DeviceElements.getBrightness);
            set => ajcBase.CallJNI(DeviceElements.setBrightness, value);
        }

        /// <summary>
        /// Is the brightness adjustment restricted
        /// </summary>
        public bool brightnessAdjustmentRestricted
        {
            get => ajcBase.CallJNI<bool>(DeviceElements.isBrightnessAdjustmentRestricted);
            set => ajcBase.CallJNI(DeviceElements.restrictBrightnessAdjustment, value);
        }

        public void EnableIPDAutoAdjustment(bool enable)
        {
            DevicePlugin.Instance.SetIPDEnable(enable);
        }

        public bool GetIPDEnable()
        {
            return DevicePlugin.Instance.GetIPDEnable();
        }

        public void SetIPDValue(float value)
        {
            DevicePlugin.Instance.SetIPDValue(value);
        }

        public float GetIPDValue()
        {
            return DevicePlugin.Instance.GetIPDVale();
        }
    }
}
#endif