# 应用控制

> [!note]
>
> 可参考我们的开源项目 [设备示例](https://github.com/PlayForDreamDevelopers/DeviceSample-Unity) 获取更多信息

可以通过 [AppMgr](xref:YVR.Enterprise.Device.AppMgr) 实现对设备内的应用可操作性进行配置，接口中带 `*` 的表示该数据是可写入的（可设置）：

| 信息                                                         | 说明                                                         |
| ------------------------------------------------------------ | ------------------------------------------------------------ |
| [startupApp *](xref:YVR.Enterprise.Device.AppMgr.startupApp) | 默认启动的应用                                               |
| [startupAppClosable *](xref:YVR.Enterprise.Device.AppMgr.startupAppClosable) | 标识默认启动应用是否允许被关闭，`false` 意味着不可关闭。 <br />对于 XR 应用，`false` 意味着按应用内按 Home（旋钮按键）将无效； <br />对于 2D 应用，`false` 意味着拖拽栏侧的关闭按钮隐藏； <br />仅当处于 Kiosk 模式并且Startup应用不为空时，函数生效，默认值为 `true`。 |
| [configurationPermission *](xref:YVR.Enterprise.Device.AppMgr.configurationPermission) | 系统是否允许进一步配置，`false` 意味着不允许。 <br/> 对于 XR 应用，`false` 时无法通过双击 home 打开快捷设置 + home 按键无效；<br/> 对于 2D 应用，意味着无法打开 Home View 和 Settings； <br/>仅当处于 Kiosk 模式并且Startup应用不为空时，函数生效，默认值为 `true`。 |
