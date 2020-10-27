# Changelog

All notable changes to this project will be documented in this file. See [standard-version](https://github.com/conventional-changelog/standard-version) for commit guidelines.

## [1.0.0-alpha.10](https://github.com/netowls-studio/dep/compare/v1.0.0-alpha.9...v1.0.0-alpha.10) (2020-10-27)


### Documentations

* 修改了代码规范文档。 ([348c849](https://github.com/netowls-studio/dep/commit/348c849b047f952649ced4b23668057063974142))


### New features

* 开始进行服务器编码。 ([b2f2c40](https://github.com/netowls-studio/dep/commit/b2f2c4085fdd198f2cff4f9d672f71cea7bb140e))
* 为 XmlFormatMessagingSchema.xsd 增加了必要的定义。 ([18559bb](https://github.com/netowls-studio/dep/commit/18559bb7ec474734bd91078d5e43c770e7ce3d24))
* 新增 Uri 消息。 ([188ce01](https://github.com/netowls-studio/dep/commit/188ce01aafcfed486db5167b8b09ccef7f203420))
* 新增 XML 格式消息架构。 ([84b802b](https://github.com/netowls-studio/dep/commit/84b802b94c77266101e0b900e979a3ea31808e4a))
* 新增 XML 格式消息架构文档。 ([54aead2](https://github.com/netowls-studio/dep/commit/54aead2fd653d124fe327ff671b8be966307bd43))
* 新增消息构建器接口。 ([2b87437](https://github.com/netowls-studio/dep/commit/2b874377abbbd7e5fd3c71b4d535de8d558380fa))
* 新增消息基本信息接口。 ([ade864a](https://github.com/netowls-studio/dep/commit/ade864aeb0f47a0acd74973d530b7876f3f1e6ab))
* 新增消息类型枚举。 ([d690316](https://github.com/netowls-studio/dep/commit/d690316a11e5da04e339e508dc49b12b9569a0dc))
* 修改了消息类型枚举。 ([8bcfe34](https://github.com/netowls-studio/dep/commit/8bcfe34d0d8f6a867e84e22c93bf88040f26cedb))

## [1.0.0-alpha.9](https://github.com/netowls-studio/dep/compare/v1.0.0-alpha.8...v1.0.0-alpha.9) (2020-10-26)


### Bugs fixed

* 删除了无用的注释信息 ([5520a41](https://github.com/netowls-studio/dep/commit/5520a41947b577000447281f144407029e18f946))
* 新增 MSBuild.NuGet.props 项目属性文件。 ([1f024cf](https://github.com/netowls-studio/dep/commit/1f024cf2535df274b90e3d8ac72daa4d49a424e7))
* 修复了 IServiceDiscovery 接口中多余的命名空间引用。 ([966b2ce](https://github.com/netowls-studio/dep/commit/966b2ce956a5227c57e9a2f12799d4e0dfd2efbb))


### New features

* 新增 Github Actions 配置。 ([c0827bd](https://github.com/netowls-studio/dep/commit/c0827bd92ed41ae4252133abdd04559a81c66930))
* 新增 NuGet 配置文件。 ([2caac25](https://github.com/netowls-studio/dep/commit/2caac2509d3c37af09d8eeb9e30ff7aa63392dc6))
* 修改了 CI 构建策略。 ([4936888](https://github.com/netowls-studio/dep/commit/4936888ea715dff844629d1005a086925b06c1f2))
* 修改了 NuGet 还原配置。 ([81721e9](https://github.com/netowls-studio/dep/commit/81721e92fcd92bdf348aa18d042e21ba2822b1f1))
* 修改了项目 URL 地址配置。 ([e87d9ae](https://github.com/netowls-studio/dep/commit/e87d9ae1bf7206f5f16ec5c6dfdc8783b4b5e4d3))


### Tools

* 新增 NuGet 命令行工具。 ([caed029](https://github.com/netowls-studio/dep/commit/caed029572cd30965c37f83a460d3a7d009287d6))
* 新增 PowerShell 构建流程。 ([e8cf185](https://github.com/netowls-studio/dep/commit/e8cf185a9eacb4cd25fa5cf364b079a3da36a5ee))


### CI & CD

* 调整 NuGet 构建包路径。 ([13b422b](https://github.com/netowls-studio/dep/commit/13b422ba58de87aa1ad4cdccd9ce0f9022274e09))
* 调整 Push 脚本。 ([9d1fb6e](https://github.com/netowls-studio/dep/commit/9d1fb6e7c7071c87f21da5a8473d2d030b2fd20b))
* 调整 Windows 构建脚本，修改了 NuGet 命令行工具下载命令。 ([cf7d5f8](https://github.com/netowls-studio/dep/commit/cf7d5f828efde00f5763a87d83a5ee44cae3bbdb))
* 调整了 APIKey 配置。 ([f0e1e44](https://github.com/netowls-studio/dep/commit/f0e1e445285fb5292207e7e4a91e99688883a292))
* 调整批量推送脚本。 ([75031c4](https://github.com/netowls-studio/dep/commit/75031c4f29243a29c8c7449acc0a0a0f69d7ea44))
* 新增 NuGet 推包流程。 ([da93046](https://github.com/netowls-studio/dep/commit/da930461f464ef334f8dc1c72bc5b845c0a6244f))
* 修改了 .NET 版本号为 netstandard2.0。 ([8605e2e](https://github.com/netowls-studio/dep/commit/8605e2ea6f65df5c385455b8ee7fa29f6ec0ea1f))
* 修改了 CI 打包配置文件中的路径错误。 ([b40bb50](https://github.com/netowls-studio/dep/commit/b40bb5071df7e3c6da262d5141f606c88bffb58b))
* 修改了 Github Actions 构建时的 Framework 版本。 ([31e2ed0](https://github.com/netowls-studio/dep/commit/31e2ed0ddbca8a82adb87dfee5eb28c7a10704d7))
* 修改了 Github Actions 配置。 ([f2a0c43](https://github.com/netowls-studio/dep/commit/f2a0c43156120bb2ad4c939f35f590e429d85730))
* 修改了 Github Actions 配置。 ([971d6a3](https://github.com/netowls-studio/dep/commit/971d6a3946a335c21cf52a4fbd322e2a13ec5933))
* 修改了 Github Actions 配置文件。 ([7dc337d](https://github.com/netowls-studio/dep/commit/7dc337dc9714bfb02c6096074b47685b898d6e1e))
* 修改了 Github Actions 配置文件。 ([b36a8d2](https://github.com/netowls-studio/dep/commit/b36a8d21539da938b669ddef0e353f8e26ce6c1d))
* 修改了 Github Actions CI 配置。 ([dbc2580](https://github.com/netowls-studio/dep/commit/dbc2580aa8bacd8bb24c52f0cbfef478189a8184))
* 修改了 Linux 构建的名称。 ([61f1946](https://github.com/netowls-studio/dep/commit/61f194685858984531dddebad804f2e6b513bb63))
* 修改了 NuGet 打包规则。 ([5207701](https://github.com/netowls-studio/dep/commit/5207701259f2b7814d2868d35995dcd722b8b9ca))
* 修改了 NuGet 推送流程。 ([84c3c20](https://github.com/netowls-studio/dep/commit/84c3c20ab55fc543ec62729af948928d5e0111cf))
* 修改了 NuGet 推送路径。 ([a0fefc5](https://github.com/netowls-studio/dep/commit/a0fefc5bd589d6661c6f7b9f2c0e5c3fe77fa205))
* 修改了 Windows 版本。 ([702a43c](https://github.com/netowls-studio/dep/commit/702a43ce96aa8422ced7d57281228dc9f33cd4ff))
* 修改了 Windows 版本。 ([daf06e6](https://github.com/netowls-studio/dep/commit/daf06e6dfb1c3c29adebe5d5a48f78e75dd7bc0c))
* 增加 CD 脚本，尝试推送。 ([e814195](https://github.com/netowls-studio/dep/commit/e814195abe92378b443e43616b0dc7770e9139d9))
* 增加了适用于 Windows 的 Github Actions 构建流程。 ([df44501](https://github.com/netowls-studio/dep/commit/df44501edac2ef5c9562aa1e2b88885a3309ee46))


### Documentations

* 新增构建状态说明文档。 ([ca4afe1](https://github.com/netowls-studio/dep/commit/ca4afe1251a7985b539ec609a430236d5ae18c2a))
* 修改了构建状态说明文档。 ([beb598f](https://github.com/netowls-studio/dep/commit/beb598fac82d971dcfba29cf5e395c4908672480))
* 修改了项目自述文件。 ([3c20222](https://github.com/netowls-studio/dep/commit/3c20222a7aa8193290b0505b9e529d4376b10464))

## [1.0.0-alpha.8](https://github.com/netowls-studio/dep/compare/v1.0.0-alpha.7...v1.0.0-alpha.8) (2020-10-22)


### New features

* 完成了基础设施代码开发工作。 ([0e7e97c](https://github.com/netowls-studio/dep/commit/0e7e97cb1804f7b4eb4329542581f7d30c06d5c6)), closes [#3](https://github.com/netowls-studio/dep/issues/3)
* 新增序列化服务依赖注入类库。 ([c2cafac](https://github.com/netowls-studio/dep/commit/c2cafac29210b3adba74b92b9575e856c7a26601))

## [1.0.0-alpha.7](https://github.com/netowls-studio/dep/compare/v1.0.0-alpha.6...v1.0.0-alpha.7) (2020-10-22)


### ⚠ BREAKING CHANGES

* 将 InjectionNameAttribute 移动到 Dep.Common.csproj 项目中。

### Documentations

* 修改了文档 docs/Code-Standard.md。 ([739f68b](https://github.com/netowls-studio/dep/commit/739f68b93fd2e33db38bfbdfd84de1c8999508fa))


### Refactor

* 将 InjectionNameAttribute 移动到 Dep.Common.csproj 项目中。 ([87fadac](https://github.com/netowls-studio/dep/commit/87fadac332d8dacabb21be70dffcba74aa149f6f))


### New features

* 新增 Newtonsoft.Json 默认序列化设置 JsonSerializerDefaultSettings。 ([6351ed0](https://github.com/netowls-studio/dep/commit/6351ed015beb1dcadd2da54107ecd15b25d02896))
* 新增 XML 序列化程序 XmlSerializer。 ([94e4e5c](https://github.com/netowls-studio/dep/commit/94e4e5cee1a3448e77f86d615fdc3127eebb6deb))
* 新增二进制序列化程序。 ([c98a2d4](https://github.com/netowls-studio/dep/commit/c98a2d476027b6083a1b38a2f95b47ef86238334))
* 新增服务依赖注入发现接口 IServiceDiscovery。 ([f514ad6](https://github.com/netowls-studio/dep/commit/f514ad6ab0cdf1af5a08ab6f7c912d7018ab1d94))
* 新增基于 Newtonsoft.Json 的序列化服务 JsonSerializer。 ([7ceb999](https://github.com/netowls-studio/dep/commit/7ceb9992695b70984686e013374886d422025b93))
* 新增可序列化对象基类 SerializableObject。 ([85e9e17](https://github.com/netowls-studio/dep/commit/85e9e176fae4446d951cd0cfe00f3a2007d30423))
* 新增序列化服务基类。 ([647bfdf](https://github.com/netowls-studio/dep/commit/647bfdf76e21c897b0a4fcef6666d3c30324b365))
* 新增序列化接口 ISerializer。 ([6771773](https://github.com/netowls-studio/dep/commit/6771773a7c073c055150259fafc74fb40b6391e4))
* 修改了 XmlSerializer.InternalSerialize 的 XML 注释，消除了 Visual Studio 警告。 ([4788f99](https://github.com/netowls-studio/dep/commit/4788f99e62db2fad2365bb74b806c9785f1c3829))
* 增加 DisplayNameAttribute 特性描述。 ([6aca563](https://github.com/netowls-studio/dep/commit/6aca563bd83d963b36757c248b967fda3ab197dd))

## [1.0.0-alpha.6](https://github.com/netowls-studio/dep/compare/v1.0.0-alpha.5...v1.0.0-alpha.6) (2020-10-21)


### ⚠ BREAKING CHANGES

* feat: 修改了 Dep.Runtime.Logging.DI.csproj 项目的程序集名称。

### New features

* 新增初始化 NLog 日志服务的接口 INLogConfigurationSetup。 ([ad0eff3](https://github.com/netowls-studio/dep/commit/ad0eff3f24ef9cff1c34cf660602554698b5a7f8))
* 新增基于 NLog 记录运行时日志的相关方法。 ([6423593](https://github.com/netowls-studio/dep/commit/6423593116d315dc693054c837eed2ec16b3007a))
* 新增基于 Unity 的日志服务依赖注入项目。 ([7729300](https://github.com/netowls-studio/dep/commit/7729300f7ebf5de471501b8983a00a7733c0ff63))
* 新增日志服务依赖注入程序。 ([145772a](https://github.com/netowls-studio/dep/commit/145772a80006ae4e4f3f5babed19dd6c4b9c092d))
* 新增一组 NLog 配置文件。 ([0221d3b](https://github.com/netowls-studio/dep/commit/0221d3b1198da91ba0132b775f3e1f11a7c859f9))
* 修改了 ConfigurationDefaults.StorageFolderName 常量值。 ([706bb6b](https://github.com/netowls-studio/dep/commit/706bb6be1074b2e1f5a09c6748e7ba445bd6176f))
* 修改了 Dep.Runtime.Logging.DI.csproj 项目的程序集名称。 ([79ac22a](https://github.com/netowls-studio/dep/commit/79ac22ab31df12b130d4fd3aedcc559c6895b8de))

## [1.0.0-alpha.5](https://github.com/netowls-studio/dep/compare/v1.0.0-alpha.4...v1.0.0-alpha.5) (2020-10-20)


### New features

* 新增 LogWriter 集合。 ([33f3f79](https://github.com/netowls-studio/dep/commit/33f3f790f2564bd473ff8c546d722d3a27748ab0))
* 新增基于 .NET 诊断器记录运行时日志的方法 TraceListenerWriter。 ([8e0fc4a](https://github.com/netowls-studio/dep/commit/8e0fc4ab712b5ab2cd3adff99b8d9f580a4b6510))
* 新增基于 EnterpriseLibrary 企业库的访问配置信息的方法。 ([7528b17](https://github.com/netowls-studio/dep/commit/7528b17f10f56707248d5b44cdc7cddddf76aa0b))
* 新增记录运行时日志的接口 ILogWriter。 ([372e646](https://github.com/netowls-studio/dep/commit/372e646667e5652d31a0b276d6e9f2b725058540))
* 新增记录运行时日志的入口方法 LogWriter。 ([6c9396d](https://github.com/netowls-studio/dep/commit/6c9396de8c89705911e5a301c0d23bb36e79471d))
* 新增配置服务依赖注入扩展方法 UnityContainerExtensions.Configuration ([23ba0e2](https://github.com/netowls-studio/dep/commit/23ba0e21bd74e262b48b2306ecb6e844bce795b2))
* 新增日志项类型枚举 LogEntryTypes。 ([5b758de](https://github.com/netowls-studio/dep/commit/5b758defe42c9a33a62c80f1814bba0f133b4b9c))

## [1.0.0-alpha.4](https://github.com/netowls-studio/dep/compare/v1.0.0-alpha.3...v1.0.0-alpha.4) (2020-10-19)


### New features

* 调整了 AddDepServices 方法，增加了 IDepContext 服务注册。 ([a09b0da](https://github.com/netowls-studio/dep/commit/a09b0da372c8cb51afb9683273ac48719e98dfb5))
* 新增 DEP 提供的默认 Unity IoC 容器。 ([fdb2465](https://github.com/netowls-studio/dep/commit/fdb2465e92eca579419200326768d7f710120010))
* 新增基于 Microsoft Unity 的依赖注入扩展方法。 ([e48cdd3](https://github.com/netowls-studio/dep/commit/e48cdd3dd63313f9cb02843c2cf0e3d540e534b4))
* 新增配置默认值类。 ([af2b1be](https://github.com/netowls-studio/dep/commit/af2b1beac93deb203d31e64425dea3c06fea6a30))

## [1.0.0-alpha.3](https://github.com/netowls-studio/dep/compare/v1.0.0-alpha.2...v1.0.0-alpha.3) (2020-10-19)


### Documentations

* 新增 NuGet 包依赖说明文档。 ([0a4ee4e](https://github.com/netowls-studio/dep/commit/0a4ee4e0d4c29dc74e9cbc2f0dcd4163fae299f3))
* 修改了 NuGet 包依赖说明文档格式。 ([7a01942](https://github.com/netowls-studio/dep/commit/7a019429855caaa914aaecf58373be2efaa814b1))
* 修改了代码规范文档 Code-Standard.md ([36656f6](https://github.com/netowls-studio/dep/commit/36656f6ab7459670ac404837a6e6525a81616d44))


### New features

* 为 RabbitMQOptions 类型添加了 Path 常量，便于访问配置路径。 ([c46d058](https://github.com/netowls-studio/dep/commit/c46d058636634cf226b5a7ad07f5ebe6a1957a5f))
* 为接口 IConfigurationBroker 新增捕获配置变更的事件。 ([b118823](https://github.com/netowls-studio/dep/commit/b118823eb4ed0726a0b13754b7030051778527cb))
* 新增 Microsoft .NET Core 依赖注入扩展。 ([dddbb5d](https://github.com/netowls-studio/dep/commit/dddbb5d5636c0d3b25e25ac1db05a0016028479a))
* 新增 RabbitMQ 配置访问程序 RabbitMQConfigurationBroker。 ([3ad5128](https://github.com/netowls-studio/dep/commit/3ad5128bf62bd9e07ce8194ab93e761c8e49878c))
* 新增 RabbitMQ 配置服务依赖注入扩展方法。 ([689b1eb](https://github.com/netowls-studio/dep/commit/689b1eb834ccde393d97402e111dbb83293c44ff))
* 新增访问配置信息的接口 IConfigurationBroker。 ([5fe1796](https://github.com/netowls-studio/dep/commit/5fe1796fbc05fc8bccc863bc5fc68618ffcd26f8))

## [1.0.0-alpha.2](https://github.com/netowls-studio/dep/compare/v1.0.0-alpha.1...v1.0.0-alpha.2) (2020-10-16)


### Refactor

* 调整 DEP 上下文接口 IDepContext。 ([c17ab3b](https://github.com/netowls-studio/dep/commit/c17ab3b256649e07b122266570fe7720d8fb84f8))


### Documentations

* 修改了代码规范文档。 ([f172ccf](https://github.com/netowls-studio/dep/commit/f172ccfc694dbb7dc99387260fb38d20baffd9a8))
* 修改了代码规范文档。 ([a11305f](https://github.com/netowls-studio/dep/commit/a11305f8c4eb88e6f681ed8f8a3132bbc190fb6f))


### New features

* 调整了 RabbitMQServerOptionsBuilder 类型的 WithCredentialsBuilder 方法参数。 ([eadc194](https://github.com/netowls-studio/dep/commit/eadc1947fc377240d20d78340a1c84dbbb8ae4da))
* 新增 DEP 配置项标记接口。 ([45c0600](https://github.com/netowls-studio/dep/commit/45c0600a582f414d84e343d5de34143d59221481))
* 新增 RabbitMQ 配置 RabbitMQOptions。 ([410b701](https://github.com/netowls-studio/dep/commit/410b70122da8445a97c4be39cdd16d100ec638d3))
* 新增 RabbitMQ 通信配置 RabbitMQServerOptions。 ([797c1e4](https://github.com/netowls-studio/dep/commit/797c1e44d51ae3fe6d01ee0f6f1376069eed9add))
* 新增构建器模式接口 IObjectBuilder。 ([649c337](https://github.com/netowls-studio/dep/commit/649c337f1a893f7c6b9046b9f96e90aa998bad0f))
* 新增基础身份认证凭据配置类 BasicCredentialsOptions。 ([ae23e6a](https://github.com/netowls-studio/dep/commit/ae23e6a3fb2437900cf7d75eb7540f6cc672fc67))

## 1.0.0-alpha.1 (2020-10-15)


### ⚠ BREAKING CHANGES

* 重构 IDepContext 上下文接口。

### Tools

* 修改了 npm 配置。 ([4f59756](https://github.com/netowls-studio/dep/commit/4f597564b8fd090dd634418262d9445c70a4621c))


### Documentations

* 新增代码约定文档。 ([6828c6a](https://github.com/netowls-studio/dep/commit/6828c6a36a238bba6e2714a30824ca04269925c3))
* 修复了文档格式。 ([b86a72b](https://github.com/netowls-studio/dep/commit/b86a72b32d41d156d8c4d0efa6fdfcdbb84241de))
* 修复了文档格式错乱问题。 ([b4ceadf](https://github.com/netowls-studio/dep/commit/b4ceadfce063f697e59f82b01d9bd694abddb99f))
* 修改了代码规范文档。 ([2d6e5aa](https://github.com/netowls-studio/dep/commit/2d6e5aa645a107feaa39508204e0e05a90550a5f))
* 修改了项目自述文件，添加了架构设计图纸。 ([412bae7](https://github.com/netowls-studio/dep/commit/412bae7ed3ffe594f46e7823b1dd02f5d12dc383))


### New features

* 初始化项目。 ([5194e5a](https://github.com/netowls-studio/dep/commit/5194e5ae200cd50b721ffd7b479e1ca50e4fb1c7))
* 新增 DEP 上下文信息接口 IDepContext。 ([a0fea03](https://github.com/netowls-studio/dep/commit/a0fea03fda8c9189738bde57f8ab34a57c9490d3))
* 新增 Dep.Common.csproj 项目。 ([57cbd6e](https://github.com/netowls-studio/dep/commit/57cbd6e56c9210afa04db320ab60dd2d13090dbf))
* 新增运行时环境接口 IRunningEnvironment。 ([f99ea9b](https://github.com/netowls-studio/dep/commit/f99ea9b03a4608465768778cb6bf504a6e122501))
* 修改了 Dep.Common.csproj 项目 TargetFrameworks 设置。 ([0d39fbe](https://github.com/netowls-studio/dep/commit/0d39fbeaefdef5db9b72c24ce1bbe76cc44104d5))
* 修改了 DepException 注释信息，消除了 Visual Studio 的构建警告。 ([2af1276](https://github.com/netowls-studio/dep/commit/2af12764f8148db79bfba624bbf8e7d0d7edc357))
