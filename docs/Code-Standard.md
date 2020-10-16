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
    | Scripting/CakeBuild                      | CakeBuild 构建脚本定义。                            |
    | Scripting/BuildEnvironmentSetup.ps1      | 构建环境初始化脚本。                                |

  - **服务器 Server**
  
    | 项目名称                                            | 说明                                                         |
    | --------------------------------------------------- | ------------------------------------------------------------ |
    | Dep.Messaging.Abstractions                          | 通信消息抽象。                                               |
    | Dep.Messaging.RabbitMQ                              | RabbitMQ 通信消息实现。                                      |
    | Dep.Messaging.Http                                  | RESTful 通信消息实现。                                       |
    | Dep.AspNetCore.SwaggerDocumentation                 | DEP ASP.NET Core 接口说明文档配置。                          |
    | Dep.Server.Membership                               | DEP 服务成员信息。                                           |
    | Dep.Server.Membership.Persistence.Abstractions      | DEP 服务成员信息数据持久化抽象。                             |
    | Dep.Server.Membership.Persistence.Locale            | DEP 服务成员信息本地持久化实现（基于 **[LiteDB](https://www.nuget.org/packages/LiteDB/)**）。 |
    | Dep.Server.Membership.Configuration                 | DEP 服务配置。                                               |
    | Dep.Server.Membership.Cluster.Abstractions          | DEP 服务成员群集实现抽象。                                   |
    | Dep.Server.Membership.Cluster.ConsulClusterUtils    | DEP 服务成员群集实现（基于 Consul ***稍候***）。             |
    | Dep.Server.Membership.Cluster.ZookeeperClusterUtils | DEP 服务成员群集实现（基于 Zookeeper ***稍候***）。          |
    | Dep.Server.InternalState.Core                       | DEP 服务内部状态。                                           |
    | Dep.Server.InternalState.Persistence.Abstractions   | DEP 服务内部状态数据持久化抽象。                             |
    | Dep.Server.InternalState.Persistence.Locale         | DEP 服务内部状态数据持久化本地实现。                         |
    | Dep.Server.DevOps.Core                              | DEP 服务运维、配置等信息。                                   |
    | Dep.Server.DevOps.Persistence.Abstractions          | DEP 服务运维、配置等信息数据持久化抽象。                     |
    | Dep.Server.DevOps.Persistence.Locale                | DEP 服务运维、配置等信息数据持久化本地实现。                 |
    | Dep.Server.Plugins.Core                             | DEP 服务插件核心。                                           |
    | Dep.Server.Plugins.Interfaces                       | DEP 服务插件抽象接口。                                       |
    | Dep.Server.Plugins.FileStorage.Locale               | 本地文件存储插件。                                           |
    | Dep.Server.Plugins.FileStorage.AliyunOSS            | 阿里云 OSS 对象存储插件。                                    |
    | Dep.Server.Plugins.FileStorage.AWS                  | AWS 对象存储插件。                                           |
    | Dep.Server.Plugins.FileStorage.MinIO                | MinIO 对象存储插件。                                         |
    | Dep.Server.Plugins.FileStorage.Binary.MongoDB       | 基于 MongoDB 的二进制存储方案。                              |
    | Dep.Server.DependencyInjection                      | DEP 服务注册。                                               |
    | **Dep.Server.Host.AspNetCore**                      | DEP 服务托管主机（基于 **ASP.NET Core**）。                  |
    | Scripting/CakeBuild/Server.cake                     | DEP 服务构建脚本。                                           |
    | Scripting/BuildServer.ps1                           | DEP 服务构建引导脚本。                                       |
    | UI/dep-server                                       | DEP 服务管理控制台 UI 项目。                                 |
    
  - **本地文件系统扫描器 Watcher**
  
    | 项目名称                             | 说明                                                  |
    | ------------------------------------ | ----------------------------------------------------- |
    | Dep.Heartbeat.Abstractions           | 心跳抽象。                                            |
    | Dep.Heartbeats.Http                  | 基于 HTTP 接口的心跳实现。                            |
    | Dep.Heartbeats.ConsulClusterUtils    | 基于 Consul 的心跳实现。                              |
    | Dep.Heartbeats.ZookeeperClusterUtils | 基于 Apache Zookeeper 的心跳实现。                    |
    | **Dep.Watcher.AspNetCore**           | DEP 文件系统扫描器托管主机（基于 **ASP.NET Core**）。 |
    | Scripting/CakeBuild/Watcher.cake     | DEP 文件系统扫描器构建脚本。                          |
    | Scripting/BuildWatcher.ps1           | DEP 文件系统扫描器构建引导脚本。                      |
    | UI/dep-watcher                       | DEP 文件系统扫描器配置控制台 UI。                     |
  
  - **本地接收代理 Agent**
  
    | 项目名称                       | 说明                                                |
    | ------------------------------ | --------------------------------------------------- |
    | Dep.Agent.Plugins.Core         | DEP 本地接收代理插件信息。                          |
    | Dep.Agent.Plugins.Interfaces   | DEP 本地接收代理插件接口。                          |
    | Dep.Agent.Plugins.Default      | DEP 本地接收代理默认插件。                          |
    | Dep.Agent.Plugins.Forward      | DEP 本地接收代理转发插件。                          |
    | **Dep.Agent.AspNetCore**       | DEP 本地接收代理托管主机（基于 **ASP.NET Core**）。 |
    | Scripting/CakeBuild/Agent.cake | DEP 本地接收代理构建脚本。                          |
    | Scripting/BuildAgent.ps1       | DEP 本地接收代理构建引导脚本。                      |
    | UI/dep-agent                   | DEP 本地接收代理配置控制台 UI。                     |
  
- **RESTful 接口约定 API Standard**

  | URL 模板或地址                                              | 说明                                            |
  | ----------------------------------------------------------- | ----------------------------------------------- |
  | api/dep-svr/v1/*                                            | DEP 服务器接口 URL Root 规则。                  |
  | api/dep-**{identity: *watcher or agent*}**/v1/is-available  | DEP 本地文件扫描器或本地接收代理是否存活。      |
  | api/dep-**{identity: *watcher or agent*}**/v1/identity-mode | 获取 DEP 本地文件扫描器或本地接收代理身份类型。 |

- **Consul 或者 Apache Zookeeper 路径约定 Path Standard**

  | 路径                                                | 说明                                      |
  | --------------------------------------------------- | ----------------------------------------- |
  | /dotnetcore-dep/v1                                  | DEP Root 路径。                           |
  | **{root-path}**/server                              | DEP 服务 Root 路径。                      |
  | **{root-path}**/server/cluster-members/#{hash-sign} | DEP 服务群集节点。                        |
  | **{root-path}**/server/devops/#{hash-sign}          | DEP 运维相关信息节点。                    |
  | **{root-path}**/client-registry/#{hash-sign}        | DEP 客户端（**Watcher & Agent**）注册表。 |
  
- **通信渠道 Communicate Mode**

  - **RabbitMQ**

    | 类型        | 模板                                                    | 说明                                                         |
    | ----------- | ------------------------------------------------------- | ------------------------------------------------------------ |
    | Exchange    | dep-exchange.topic.journal                              | DEP 服务器内部行为交换机。                                   |
    | Routing-Key | dep-journal.#{**mode: normal/receipt/dead-letter/cmd**} | DEP 服务器内部行为路由标识。**Normal**: 正常的消息；**Receipt**: 回执消息；**Dead-Letter**: 死信消息；**CMD (Command)**: 维护性命令消息。 |
    | Queue       | dep-queue.normal                                        | 正常消息队列。                                               |
    | Queue       | dep-queue.receipt                                       | 回执消息队列。                                               |
    | Queue       | dep-queue.dead-letter                                   | 私信消息队列。                                               |
    | Queue       | dep-queue.cmd                                           | 维护命令消息队列。                                           |

    



------

![DEP](../assets/Icons/Dep-64.png)
