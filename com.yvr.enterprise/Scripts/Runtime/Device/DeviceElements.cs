using YVR.AndroidDevice.Core;

namespace YVR.Enterprise.Device
{
    public class DeviceElements : IAJCElements
    {
        public string className => "com.yvr.tobsettings.ToBServiceHelper";
        public const string init = "init";
        public const string getInstance = "getInstance";
        public const string getBTMac = "getBtMac";
        public const string getWifiMac = "getWifiMac";
        public const string getDeviceModel = "getDeviceModel";
        public const string getDeviceSn = "getDeviceSn";
        public const string getOSVersion = "getSoftwareVersion";

        public const string getVolume = "getSystemAudioVolume";
        public const string getMaxVolume = "getSystemMaxAudioVolume";
        public const string setVolume = "setSystemAudioVolume";

        public const string restrictVolumeAdjustment = "restrictVolumeAdjustment";
        public const string isVolumeAdjustmentRestricted = "isVolumeAdjustmentRestricted";

        public const string getBrightness = "getBrightness";
        public const string setBrightness = "setBrightness";
        public const string restrictBrightnessAdjustment = "restrictBrightnessAdjustment";
        public const string isBrightnessAdjustmentRestricted = "isBrightnessAdjustmentRestricted";

        public const string changeThirdHomeState = "changeThirdHomeState";
    }
}