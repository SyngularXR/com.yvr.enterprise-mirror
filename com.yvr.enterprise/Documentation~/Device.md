# Device Information and Control

> [!note]
> 
> Refer to our open‐source project [Device Sample](https://github.com/PlayForDreamDevelopers/DeviceSample-Unity) for more details.

All device-related information and controls can be implemented via [DeviceMgr]. The following interfaces are supported. Items marked with `*` are writable (settable):

| Information                                            | Description                      |
| ------------------------------------------------------ | -------------------------------- |
| [btMac](xref:YVR.Enterprise.Device.DeviceMgr.btMac)    | Bluetooth MAC address            |
| [wifiMac](xref:YVR.Enterprise.Device.DeviceMgr.wifiMac)| Wi‑Fi MAC address                |
| [deviceModel](xref:YVR.Enterprise.Device.DeviceMgr.deviceModel) | Device model           |
| [deviceSn](xref:YVR.Enterprise.Device.DeviceMgr.deviceSn)       | Device serial number     |
| [osVersion](xref:YVR.Enterprise.Device.DeviceMgr.osVersion)     | Operating system version |
| [volume *](xref:YVR.Enterprise.Device.DeviceMgr.volume)         | Current volume           |
| [maxVolume](xref:YVR.Enterprise.Device.DeviceMgr.maxVolume)       | Maximum volume           |
| [volumeAdjustmentRestricted *](xref:YVR.Enterprise.Device.DeviceMgr.volumeAdjustmentRestricted) | Volume adjustment restriction status |
| [brightness *](xref:YVR.Enterprise.Device.DeviceMgr.brightness)   | Current brightness       |
| [brightnessAdjustmentRestricted *](xref:YVR.Enterprise.Device.DeviceMgr.brightnessAdjustmentRestricted) | Brightness adjustment restriction status |

