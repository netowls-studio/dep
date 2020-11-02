![DEP](../../assets/Icons/Dep-128.png)

# 基本消息结构说明 Basic

- **消息格式 Message Body Format**

  统一使用 **JSON** 格式。

- **基本消息报文格式 Basic Format**

  ```json
  {
    "header": {
      "message-type": "StateSynchronized",
      "message-typeid": 1,
      "publish-time": "2020-10-30 12:15:54",
      "group-id": "system"
    },
    "body": {}
  }
  
  ```

  - **字段说明 Field Description**

    | 字段名 Field Name         | 数据类型 Data Type     | 说明 Description                                 | 参考值 Reference                                             | 可否为空 Nullable | 默认值 Default Value                                         |
    | ------------------------- | ---------------------- | ------------------------------------------------ | ------------------------------------------------------------ | ----------------- | ------------------------------------------------------------ |
    | **header**                | **Object**             | 消息头信息。此字段包含了消息的摘要信息。         | -                                                            | **No**            | -                                                            |
    | header/**message-type**   | **String/Enumeration** | 消息类型枚举值名称。                             | **Distribution - *1***：数据分发消息；<br /> **Maintenance - *2***：系统内部维护消息；<br /> **Retry - *3***：重试消息；<br /> **Receipt - *4***：回执消息；<br /> **Reissue - *5***：补发请求消息；<br /> **StateSynchronized - *6***：群集状态同步消息 | **No**            | -                                                            |
    | header/**message-typeid** | **Int32**              | 消息类型枚举值对应的 32 位整型值。               | *(参见 header/**message-type**)*                             | **No**            | -                                                            |
    | header/**publish-time**   | **DateTime/String**    | 消息发布时间。                                   | *格式统一为：**yyyy-MM-dd HH:mm:ss***                        | **No**            | DEP 当前系统时间。                                           |
    | header/**group-id**       | **String**             | 消息分组标识。每个分组标识，都有不同的消息通道。 |                                                              | **No**            | 对于 **Maintenance 和 StateSynchronized** 类型的消息，此处总为 **system** |
    | **body**                  | **Any**                | 任意类型的消息数据数据内容。                     |                                                              | **Yes**           |                                                              |

​    

- **具体的消息定义 Details**
  - **状态同步类消息 StateSynchronized**
    - **[DEP 群集](./Cluster-StateSynchronized.md)**
    - **[DEP 数据维护](./Data-Maintenance.md)**
  - **[DEP 数据分发消息](./Distribution-Retry.md)**
  - **[补发申请](./Reissue.md)**



----



![DEP](../../assets/Icons/Dep-64.png)



