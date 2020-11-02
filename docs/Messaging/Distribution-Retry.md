![DEP](../../assets/Icons/Dep-128.png)

# **数据分发或重试消息**

```json
{
  "header": {
    "message-type": "Distribution", // 消息类型，总是 Distribution
    "message-typeid": 1, // 消息类型枚举 ID 值。
    "publish-time": "2020-10-30 12:15:54", // 发布时间。
    "group-id": "Your Message Group", // 消息分组。
    "message-id": "", // 消息唯一标识。
    "subscriber-id": "", // 订阅者唯一标识。
    "reissue-request-token": "", // 补发申请令牌。
    "reissue-request-token-expires": 1, // 补发申请令牌超时毫秒数。如果为 -1，则认为永不过期。
    "size": 1, // 消息报文大小。
    "receipt-required": true, // 是否需要回执。
    "signature": "", // 消息签名。
    "encoding": "UTF-8", // 消息内容编码。
    "is-split": true, // 消息是否被拆分。
    "packages-number": 2, // 消息被拆分的包数。
    "package-index": 1, // 分包索引，用于按顺序合包。当没有被拆包时，则固定为 1。
    "package-combine-id": "", // 包合并唯一标识。
    "serializer": "JsonSerializer", // 消息序列化器。
    "retried-times": 0, // 消息被重试的次数。默认为 0。
    "allow-maximum-retry-times": 5, // 允许最大重试次数。系统默认最大值为 10。
    "paths": { // 数据分发、订阅路径。
      "distribute-path": [ // 分发路径。
        {
          "http": { // HTTP:80 通道。此通道主要用于复杂的网络环境、跨网段、仅开放 80 或有限端口时使用。
            "uri": "" // 数据分发 URI 地址。
          },
          "is-destination": false, // 是否为目标节点。
          "is-transition": true, // 是否为中转节点。
          "message-queue": { // 消息队列通道。
            "rabbit-mq": { // RabbitMQ 方式。
              "server-id": "", // RabbitMQ 服务唯一标识。
              "exchange-name": "", // RabbitMQ 交换机名称。
              "routing-key": "" // RabbitMQ 路由标识。
            }
          }
        }
      ],
      "receipt-path": [ // 回执路径。
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
    }
  },
  "body": "BASE-64 编码的消息" // 消息内容。采用 BASE-64 编码的字符串。
}

```





----

![DEP](../../assets/Icons/Dep-64.png)

