#if USE_ANDROID_DEVICE_CORE
using YVR.AndroidDevice.Core;

namespace YVR.Enterprise.Device
{
    public class AppElements : IAJCElements
    {
        public string className => "com.yvr.tobsettings.ToBServiceHelper";
        public const string init = "init";
        public const string getInstance = "getInstance";

        // Kiosk Mode part: https://www.pfdm.cn/yvrdoc/biz/docs/2.13.KioskMode.html
        public const string setStartupApp = "setStartupApp";
        public const string getStartupApp = "getStartupApp";
        public const string setAppCloseAbility = "setAppCloseAbility";
        public const string getAppCloseAbility = "getAppCloseAbility";
        public const string setConfigurationPermission = "setConfigurationPermission";
        public const string getConfigurationPermission = "getConfigurationPermission";
    }
}
#endif