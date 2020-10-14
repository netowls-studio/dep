![DEP](../assets/Icons/Dep-128.png)

# 代码规范 Code Standard

- **项目结构约定 Project Structure**

  - **基础设施 Common Infrastructure**

    | 项目名称                                 | 说明                                                |
    | ---------------------------------------- | --------------------------------------------------- |
    | Dep.Common                               | 公共接口、类型、扩展方法等。                        |
    | Dep.Core                                 | 公共核心接口基本实现。                              |
    | Dep.Core.DependencyInjection             | 基于 .NET Core 服务依赖注入实现。                   |
    | Dep.Core.DependencyInjection.Unity       | 用于保持兼容性的基于 Microsoft Unity 依赖注入实现。 |
    | Dep.Runtime.Logging.Abstractions         | 运行时日志抽象日志接口。                            |
    | Dep.Runtime.Logging.Providers.NLog       | 基于 NLog 的运行时日志实现。                        |
    | Dep.Runtime.Logging.Providers.DI         | 运行时日志服务（所有）依赖注入。                    |
    | Dep.Runtime.Logging.Providers.DI.Unity   | 运行时日志服务（所有）依赖注入（Microsoft Unity）。 |
    | Dep.Runtime.Serialization.Abstractions   | 运行时序列化抽象接口。                              |
    | Dep.Runtime.Serialization.Defaults       | .NET 内置的序列化（**Binary & XML**）实现。         |
    | Dep.Runtime.Serialization.NewtonsoftJson | 基于 **Newtonsoft.Json** 的序列化实现。             |
    | Dep.Runtime.Serialization.DI             | 运行时序列化（所有）依赖注入。                      |
    | Dep.Runtime.Serialization.DI.Unity       | 运行时序列化（所有）依赖注入（Microsoft Unity）。   |
    | Dep.Infrastructures.DI                   | 基础设施服务（所有）依赖注入。                      |
    | Dep.Infrastructures.DI.Unity             | 基础设施服务（所有）依赖注入（Microsoft Unity）。   |

  - **服务器 Server**

    | 项目名称                   | 说明                    |
    | -------------------------- | ----------------------- |
    | Dep.Messaging.Abstractions | 通信消息抽象。          |
    | Dep.Messaging.RabbitMQ     | RabbitMQ 通信消息抽象。 |
    | Dep.Messaging.Http         | RESTful 通信消息抽象。  |
    |                            |                         |

    