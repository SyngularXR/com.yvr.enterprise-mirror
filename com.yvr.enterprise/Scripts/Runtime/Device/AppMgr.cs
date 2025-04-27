using UnityEngine;
using YVR.AndroidDevice.Core;

#if USE_ANDROID_DEVICE_CORE

namespace YVR.Enterprise.Device
{
    /// <summary>
    /// Configure the self-startup and closable of the application
    /// </summary>
    public class AppMgr : AJCMgrSingleton<AppMgr, AJCMocker, AppElements>
    {
        protected override void OnInit()
        {
            base.OnInit();
            AndroidJavaObject playerActivity = AndroidUtils.unityPlayerActivity;
            ajcBase.CallJNIStatic(AppElements.init, playerActivity);
            var helperInstance = ajcBase.CallJNIStatic<AndroidJavaObject>(AppElements.getInstance);

            // The instance is the real android object for further use, so we create a new ajcBase with it.
            ajcBase = new AJCInvoker(helperInstance);
        }

        /// <summary>
        /// If the application exists, it will be automatically started at startup
        /// </summary>
        public string startupApp
        {
            get => GetStartupApp();
            set => SetStartupApp(value, !string.IsNullOrWhiteSpace(value));
        }

        /// <summary>
        /// It represents whether the default startup application is allowed to be shut down. (Valid only when the default application is configured)
        /// For XR applications, false means that pressing the in-app Home (knob key) will be invalid;
        /// For 2D applications, false means that the close button on the drag bar side is hidden;
        /// The function takes effect only when it is in Kiosk mode, and the default value is true.
        /// </summary>
        public bool startupAppClosable
        {
            get => GetAppCloseAbility();
            set => SetAppCloseAbility(value);
        }

        /// <summary>
        /// Whether the system allows further configuration, false means not.
        /// For XR applications, when false, Quick Settings cannot be opened by double-clicking home button and the home button is disabled.
        /// For 2D applications, it means that Home View and Settings cannot be opened;
        /// The function takes effect only when in Kiosk mode, and the default value is true.
        /// The function takes effect only when the Startup application is not empty, and the default value is true.
        /// </summary>
        public bool configurationPermission
        {
            get => GetConfigurationPermission();
            set => SetConfigurationPermission(value);
        }

        private void SetStartupApp(string packageName, bool active)
        {
            ajcBase.CallJNI(AppElements.setStartupApp, packageName, active);
        }

        private string GetStartupApp()
        {
            var app = ajcBase.CallJNI<string>(AppElements.getStartupApp);
            return app;
        }

        private bool GetAppCloseAbility()
        {
            var closable = ajcBase.CallJNI<bool>(AppElements.getAppCloseAbility);
            return closable;
        }

        private void SetAppCloseAbility(bool closable)
        {
            ajcBase.CallJNI(AppElements.setAppCloseAbility, closable);
        }

        private bool GetConfigurationPermission()
        {
            var configurable = ajcBase.CallJNI<bool>(AppElements.getConfigurationPermission);
            return configurable;
        }

        private void SetConfigurationPermission(bool configurable)
        {
            ajcBase.CallJNI(AppElements.setConfigurationPermission, configurable);
        }
    }
}
#endif