![DEP](../../assets/Icons/Dep-128.png)

# 补发消息

```json
{
  "header": {
    "message-type": "Reissue", // 消息类型。
    "message-typeid": 1,
    "publish-time": "2020-10-30 12:15:54", // 发布时间。
    "group-id": "Your Group Id", // 分组标识。
    "subscriber-id": "", // 订阅者唯一标识。
    "reissue-token": "", // 分发消息中的补发申请令牌。
    "reason-code": "", // 请求补发原因编码（内置的，请参考《补发申请原因》）。
    "reason-description": "", // 请求补发原因描述。
    "path": [ // 补发消息申请路径。等同于分发消息中的回执路径。
      {
        "http": {
          "uri": ""
        },
        "is-destination": false,
        "is-transition": true,
        "message-queue": {
          "rabbit-mq": {
            "server-id": "",
            "exchange-name": "",
            "routing-key": ""
          }
        }
      }
    ]
  },
  "body": {
    "source-message-id": "" // 原始消息标识。
  }
}

```



- **参考文献**
  - *[分发或重试消息](./Distribution-Retry.md)*
  - **点击下载**：*《[补发原因代码](../Assets/Reissue-Reason-Codes.xlsx)》*





----

![DEP](../../assets/Icons/Dep-64.png)