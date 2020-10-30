![DEP](../../assets/Icons/Dep-128.png)

# **数据维护状态同步消息**

```json
{
  "header": {
    "message-type": "Maintenance",
    "message-typeid": 1,
    "publish-time": "2020-10-30 12:15:54",
    "group-id": "System"
  },
  "body": {
    "changed-data-state": [
      {
        "collection-name": "",
        "changed-entities": [
          {
            "action": "CreateNew | Update | Delete | Remove",
            "data": {}
          }
        ]
      }
    ],
    "exec-member": {
      "host-ip": "",
      "api-port": 10000
    }
  }
}
```

| 字段名 Field Name                                   | 数据类型 Data Type     | 说明 Description                                             | 参考值 Reference                                             | 可否为空 Nullable | 默认值 Default Value                                         |
| --------------------------------------------------- | ---------------------- | ------------------------------------------------------------ | ------------------------------------------------------------ | ----------------- | ------------------------------------------------------------ |
| **header**                                          | **Object**             | 消息头信息。此字段包含了消息的摘要信息。                     | -                                                            | **No**            | -                                                            |
| header/**message-type**                             | **String/Enumeration** | 消息类型枚举值名称。                                         | **Distribution - *1***：数据分发消息；<br /> **Maintenance - *2***：系统内部维护消息；<br /> **Retry - *3***：重试消息；<br /> **Receipt - *4***：回执消息；<br /> **Reissue - *5***：补发请求消息；<br /> **StateSynchronized - *6***：群集状态同步消息 | **No**            | 总是 **Maintenance**                                         |
| header/**message-typeid**                           | **Int32**              | 消息类型枚举值对应的 32 位整型值。                           | *(参见 header/**message-type**)*                             | **No**            | -                                                            |
| header/**publish-time**                             | **DateTime/String**    | 消息发布时间。                                               | *格式统一为：**yyyy-MM-dd HH:mm:ss***                        | **No**            | DEP 当前系统时间。                                           |
| header/**group-id**                                 | **String**             | 消息分组标识。每个分组标识，都有不同的消息通道。             |                                                              | **No**            | 对于 **Maintenance 和 StateSynchronized** 类型的消息，此处总为 **system** |
| **body**                                            | **Object**             | 群集状态同步信息。                                           |                                                              | **No**            |                                                              |
| body/**changed-data-state**                         | **Object Array**       | 发生变更的数据状态集合。                                     |                                                              | **Yes**           |                                                              |
| body/changed-data-state/**collection-name**         | **String**             | 发生变更的数据集名称或表名称。                               |                                                              | **No**            |                                                              |
| body/changed-data-state/**changed-entities**        | **Object Array**       | 发生变更的数据实体集合。                                     |                                                              | **Yes**           |                                                              |
| body/changed-data-state/changed-entities/**action** | **String/Enumeration** | 当前的数据实体发生变更的动作。                               | **CreateNew**：新建，相当于 Insert；<br /> **Update**：修改更新；<br /> **Delete**：物理删除；<br /> **Remove**：逻辑删除。 | **Yes**           | 默认为 **CreateNew**。                                       |
| body/changed-data-state/changed-entities/**data**   | **Any**                | 变更的数据。                                                 |                                                              |                   |                                                              |
| body/**exec-member**                                | **Object**             | 执行此动作的成员信息。                                       |                                                              | **No**            |                                                              |
| body/exec-member/**host-ip**                        | **String**             | 成员的 IP 地址或者主机名称。                                 |                                                              | **No**            |                                                              |
| body/exec-member/**api-port**                       | **Int32**              | 对外暴露的基于 “**ASP.NET Core WebApi**” 的 RESTful 接口端口号。 |                                                              | **Yes**           | 默认为 **10000**。                                           |