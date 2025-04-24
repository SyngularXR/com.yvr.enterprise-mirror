# Application Control

> [!note]
> 
> Refer to our open‐source project [Device Sample](https://github.com/PlayForDreamDevelopers/DeviceSample-Unity) for more details.

The operability of applications within the device can be configured through [AppMgr](xref:YVR.Enterprise.Device.AppMgr). The data marked with '*' in the interface indicates that it is writable (settable) :

| Information                                                  | Description                                                 |
| ------------------------------------------------------------ | ----------------------------------------------------------- |
| [startupApp *](xref:YVR.Enterprise.Device.AppMgr.startupApp) | Retrieves the default startup application|
| [startupAppClosable *](xref:YVR.Enterprise.Device.AppMgr.startupAppClosable) | Indicates whether the default startup app can be closed (default: allowed).  For XR apps, false means the Home button (knob press) will be disabled.  For 2D apps, false hides the close button on the drag bar.  Only takes effect in Kiosk Mode. Default value is true. |
| [configurationPermission *](xref:YVR.Enterprise.Device.AppMgr.configurationPermission) | Indicates whether the system allows further configuration. false means not allowed.  For XR apps, false disables quick settings access via double-pressing Home and makes Home button ineffective.  For 2D apps, prevents opening Home View and Settings.  Only takes effect in Kiosk Mode (default: true).  Only takes effect when Startup app is not empty (default: true). |
