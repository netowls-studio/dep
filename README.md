![DEP](./assets/Icons/Dep-128.png)

# “[DEP][Github-Repo]” - Data Exchange

***"[DEP][Github-Repo]"** is an open source data exchange platform, or it should be called data exchange middleware. It is used to exchange dataset, files and etc. produced by different systems.*



- **介绍 - Introduction**

  - **概述 - Summary**

    **[DEP][Github-Repo]** 主要用于在不同系统、甚至是不同企业中交换数据、报文等。功能和 [ETL](https://blog.csdn.net/jianzhang11/article/details/104240047/) 类似，但是 **[DEP][Github-Repo]** 仅负责数据的**“异地”**搬运，同时利用 **[RabbitMQ][RabbitMQ]** 等技术手段实现容错、补发等功能。

  - **开发环境 - Development Environment**

    | 开发环境                                       | 版本                                                         | 备注 |
    | ---------------------------------------------- | ------------------------------------------------------------ | ---- |
    | Microsoft Windows 10 Professional Edition      | **1909 - 18363.1082**                                        |      |
    | Microsoft Visual Studio 2019 Community Edition | **[16.7.6](https://docs.microsoft.com/zh-cn/visualstudio/releases/2019/release-notes#16.7.6)** |      |
    | Microsoft SQL Server 2019 Developer Edition    |                                                              |      |
    | Microsoft .NET                                 | **[Microsoft .NET SDK 3.1.x](https://dotnet.microsoft.com/download/dotnet-core/3.1)** |      |
    | RabbitMQ                                       | **3.8.5**                                                    |      |
    | Java JDK                                       | 14.0.2                                                       |      |
    | Zookeeper                                      |                                                              |      |
    | Consul                                         |                                                              |      |

  - **部署环境 - Deployment Environment**

    | 环境                          | 最低版本要求                                                 | 其他                      |
    | ----------------------------- | ------------------------------------------------------------ | ------------------------- |
    | Microsoft Windows Server      |                                                              | ***支持 .NET Core 即可*** |
    | Linux                         | **[Linux 安装要求](https://docs.microsoft.com/zh-cn/dotnet/core/install/linux)** | ***推荐且优先实现***      |
    | Docker                        |                                                              | ***推荐且优先实现***      |
    | Microsoft .NET SDK or Runtime |                                                              | ***非必要***              |

- **架构设计 - Architecture**

  <img src="./docs/DEP 架构设计.png" alt="架构设计" style="zoom:30%;" />

- **文档 - Documentation**

  | 文档目录 Table Of Content                           |
  | --------------------------------------------------- |
  | [代码变更日志 - Change Log](./CHANGELOG.md)         |
  | [构建状态 - Build State](./docs/Build-Status.md)    |
  | [代码约定 - Code Standard](./docs/Code-Standard.md) |

- **协议 - License**

  ```
  Microsoft Public License (MS-PL)
  
  This license governs use of the accompanying software. If you use the software, you accept this license. If you do not accept the license, do not use the software.
  
  1. Definitions
  The terms "reproduce," "reproduction," "derivative works," and "distribution" have the
  same meaning here as under U.S. copyright law.
  A "contribution" is the original software, or any additions or changes to the software.
  A "contributor" is any person that distributes its contribution under this license.
  "Licensed patents" are a contributor's patent claims that read directly on its contribution.
  2. Grant of Rights
  (A) Copyright Grant- Subject to the terms of this license, including the license conditions and limitations in section 3, each contributor grants you a non-exclusive, worldwide, royalty-free copyright license to reproduce its contribution, prepare derivative works of its contribution, and distribute its contribution or any derivative works that you create.
  (B) Patent Grant- Subject to the terms of this license, including the license conditions and limitations in section 3, each contributor grants you a non-exclusive, worldwide, royalty-free license under its licensed patents to make, have made, use, sell, offer for sale, import, and/or otherwise dispose of its contribution in the software or derivative works of the contribution in the software.
  3. Conditions and Limitations
  (A) No Trademark License- This license does not grant you rights to use any contributors' name, logo, or trademarks.
  (B) If you bring a patent claim against any contributor over patents that you claim are infringed by the software, your patent license from such contributor to the software ends automatically.
  (C) If you distribute any portion of the software, you must retain all copyright, patent, trademark, and attribution notices that are present in the software.
  (D) If you distribute any portion of the software in source code form, you may do so only under this license by including a complete copy of this license with your distribution. If you distribute any portion of the software in compiled or object code form, you may only do so under a license that complies with this license.
  (E) The software is licensed "as-is." You bear the risk of using it. The contributors give no express warranties, guarantees or conditions. You may have additional consumer rights under your local laws which this license cannot change. To the extent permitted under your local laws, the contributors exclude the implied warranties of merchantability, fitness for a particular purpose and non-infringement.
  ```



----

![DEP](./assets/Icons/Dep-64.png)



**Copyright © 2006 - 2020 Wang Yucai. All rights reserved.**

**[LICENSE](./LICENSE.md)**







[Github-Repo]: https://github.com/netowls-studio/dep	"Dep in Github"
[RabbitMQ]: https://www.rabbitmq.com/

