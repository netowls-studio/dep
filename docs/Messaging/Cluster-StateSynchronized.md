![DEP](../../assets/Icons/Dep-128.png)

# **DEP 群集状态同步消息**

***Cluster StateSynchronized***

```json
{
  "header": {
    "message-type": "StateSynchronized",
    "message-typeid": 1,
    "publish-time": "2020-10-30 12:15:54",
    "group-id": "System"
  },
  "body": {
    "cluster-provider": "Zookeeper",
    "memberships": [
      {
        "host-ip": "",
        "api-port": 10000,
        "role": "Server | Transition | Agent | Watcher"
      }
    ]
  }
}

```



| 字段名 Field Name             | 数据类型 Data Type     | 说明 Description                                             | 参考值 Reference                                             | 可否为空 Nullable | 默认值 Default Value                                         |
| ----------------------------- | ---------------------- | ------------------------------------------------------------ | ------------------------------------------------------------ | ----------------- | ------------------------------------------------------------ |
| **header**                    | **Object**             | 消息头信息。此字段包含了消息的摘要信息。                     | -                                                            | **No**            | -                                                            |
| header/**message-type**       | **String/Enumeration** | 消息类型枚举值名称。                                         | **Distribution - *1***：数据分发消息；<br /> **Maintenance - *2***：系统内部维护消息；<br /> **Retry - *3***：重试消息；<br /> **Receipt - *4***：回执消息；<br /> **Reissue - *5***：补发请求消息；<br /> **StateSynchronized - *6***：群集状态同步消息 | **No**            | 总是 **StateSynchronized**                                   |
| header/**message-typeid**     | **Int32**              | 消息类型枚举值对应的 32 位整型值。                           | *(参见 header/**message-type**)*                             | **No**            | -                                                            |
| header/**publish-time**       | **DateTime/String**    | 消息发布时间。                                               | *格式统一为：**yyyy-MM-dd HH:mm:ss***                        | **No**            | DEP 当前系统时间。                                           |
| header/**group-id**           | **String**             | 消息分组标识。每个分组标识，都有不同的消息通道。             |                                                              | **No**            | 对于 **Maintenance 和 StateSynchronized** 类型的消息，此处总为 **system** |
| **body**                      | **Object**             | 群集状态同步信息。                                           |                                                              | **No**            |                                                              |
| body/**cluster-provider**     | **String**             | 群集管理程序名称。                                           | **Zookeeper**：基于 Apache Zookeeper 的群集；<br /> **Consul**：基于 Consul 的群集 | **Yes**           | 默认为 “**Zookeeper**”。                                     |
| body/**memberships**          | **Object Array**       | 群集成员信息注册表。                                         |                                                              | **Yes**           |                                                              |
| body/memberships/**host-ip**  | **String**             | 成员的 IP 地址或者主机名称。                                 |                                                              | **No**            |                                                              |
| body/memberships/**api-port** | **Int32**              | 对外暴露的基于 “**ASP.NET Core WebApi**” 的 RESTful 接口端口号。 |                                                              | **Yes**           | 默认为 **10000**。                                           |
| body/memberships/**role**     | **String/Enumeration** | 群集成员角色。                                               | **Server**：DEP 服务器；<br /> **Transition**：DEP 中转点；<br /> **Agent**：数据订阅代理；<br /> **Watcher**：数据文件扫描器 | **No**            | -                                                            |



----

![DEP](../../assets/Icons/Dep-64.png)

