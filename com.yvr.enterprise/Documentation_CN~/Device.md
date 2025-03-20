# 设备信息与控制

> [!note]
>
> 可参考我们的开源项目 [设备示例](https://github.com/PlayForDreamDevelopers/DeviceSample-Unity) 获取更多信息

所有设备相关的信息和控制都可以通过 [DeviceMgr](xref:YVR.Enterprise.Device.DeviceMgr) 实现，支持的接口有，其中带 `*` 的表示该数据是可写入的（可设置）：

| 信息                                                                                                     | 说明             |
| -------------------------------------------------------------------------------------------------------- | ---------------- |
| [btMac](xref:YVR.Enterprise.Device.DeviceMgr.btMac)                                                      | 蓝牙 MAC 地址    |
| [wifiMac](xref:YVR.Enterprise.Device.DeviceMgr.wifiMac)                                                  | Wi-Fi MAC 地址   |
| [deviceModel](xref:YVR.Enterprise.Device.DeviceMgr.deviceModel)                                          | 设备型号         |
| [deviceSn](xref:YVR.Enterprise.Device.DeviceMgr.deviceSn)                                                | 设备序列号       |
| [osVersion](xref:YVR.Enterprise.Device.DeviceMgr.osVersion)                                              | 操作系统版本     |
| [volume \*](xref:YVR.Enterprise.Device.DeviceMgr.volume)                                                 | 当前音量         |
| [maxVolume](xref:YVR.Enterprise.Device.DeviceMgr.maxVolume)                                              | 最大音量         |
| [volumeAdjustmentRestricted \*](xref:YVR.Enterprise.Device.DeviceMgr.volumeAdjustmentRestricted)         | 音量调节是否受限 |
| [brightness \*](xref:YVR.Enterprise.Device.DeviceMgr.brightness)                                         | 当前亮度         |
| [brightnessAdjustmentRestricted \*](xref:YVR.Enterprise.Device.DeviceMgr.brightnessAdjustmentRestricted) | 亮度调节是否受限 |
