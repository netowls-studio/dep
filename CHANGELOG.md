# Changelog

All notable changes to this project will be documented in this file. See [standard-version](https://github.com/conventional-changelog/standard-version) for commit guidelines.

## [1.0.0-alpha.17](https://github.com/netowls-studio/dep/compare/v1.0.0-alpha.16...v1.0.0-alpha.17) (2020-11-03)


### ⚠ BREAKING CHANGES

* 重构消息订阅模块的所有接口。
* IMessagePublisher 重命名，并调整命名空间。

### Tools

* 修改了 NuGet 包版本号。 ([0384d79](https://github.com/netowls-studio/dep/commit/0384d79bb6b06c6ec69bf0710087d59e14ea3436))


### Documentations

* 修改了代码规范说明文档。 ([0c80aa1](https://github.com/netowls-studio/dep/commit/0c80aa1dbdf8d8e1d14a477b3cd8c4b4e54c1883))


### Refactor

* 重构了消息发布接口和抽象类。 ([842fa54](https://github.com/netowls-studio/dep/commit/842fa54964ea77e2539138cee016f35c61a8ffce))
* 重构消息订阅模块的所有接口。 ([6a783ac](https://github.com/netowls-studio/dep/commit/6a783ac2b1888230fcdacc814377c415694e2d4b))
* 重命名 IMessagePublisher 为 IDistributor ([59181a2](https://github.com/netowls-studio/dep/commit/59181a2d0eb7107e845de4d16ad4433f83d90b24))


### New features

* 为 IDispatcher 接口增加了 LogWriter 属性。 ([7a87381](https://github.com/netowls-studio/dep/commit/7a873812fa6ef38d179f808cc349ad3e8ae82bf7))
* 新增 DEP 成员信息接口。 ([43faf21](https://github.com/netowls-studio/dep/commit/43faf211d1e3e20a96a6f9aa4671cd8d3fce6c92))
* 新增成员信息集合。 ([4417505](https://github.com/netowls-studio/dep/commit/441750568b932a6e55d70fcdf7eb95d3f3a4f6e0))
* 新增订阅分组特性。 ([d5df327](https://github.com/netowls-studio/dep/commit/d5df327fc04fbca9641b16b0a096c2b5592dfbbd))
* 新增发布消息接口。 ([c90c518](https://github.com/netowls-studio/dep/commit/c90c51835919c8dfa53fe90fa4f514e762e7a5ed))
* 新增群集管理程序常量类型。 ([57be7ab](https://github.com/netowls-studio/dep/commit/57be7ab604f49e973fbbc4d116ebbcc834578df6))
* 新增消息调度分发程序基类。 ([b00503f](https://github.com/netowls-studio/dep/commit/b00503fbbbb138bb8a490eef915c2029115a49e2))
* 新增消息订阅程序基类。 ([25a36f9](https://github.com/netowls-studio/dep/commit/25a36f976d3029c8aa73bffc5eb3be5787d949d2))
* 新增消息订阅程序集合类。 ([f99cf52](https://github.com/netowls-studio/dep/commit/f99cf52df06f6f7d38af19d210c93e0512298b0b))
* 新增消息订阅接口。 ([253484a](https://github.com/netowls-studio/dep/commit/253484ab8ec1c0f61d81276df41bfc065fd8239e))
* 新增消息发布程序基类。 ([b761cfb](https://github.com/netowls-studio/dep/commit/b761cfb7c7a85428b8fb33ffd2aa137dc71b623e))
* 新增消息分发接口。 ([84e1d16](https://github.com/netowls-studio/dep/commit/84e1d164a67e47c0b9adec6277e14dd159ac83aa))
* 新增应用角色枚举类型。 ([50f15b7](https://github.com/netowls-studio/dep/commit/50f15b7768925582af596f2e85a6d717644d32d0))

## [1.0.0-alpha.16](https://github.com/netowls-studio/dep/compare/v1.0.0-alpha.15...v1.0.0-alpha.16) (2020-11-02)


### ⚠ BREAKING CHANGES

* 删除了 IMessageBody 接口定义。

### Documentations

* 说明文档重命名。 ([b64f2a3](https://github.com/netowls-studio/dep/commit/b64f2a370812555c02d2310f64dafdd9fd57e714))
* 完善了数据分发消息说明文档。 ([eea0024](https://github.com/netowls-studio/dep/commit/eea0024b48cfbe9c3b0130bc5741d6a143aff80c))
* 新增补发申请消息说明文档。 ([a468edb](https://github.com/netowls-studio/dep/commit/a468edb25cb8f597bde77916060ea593afabb5bb))
* 新增补发原因编码说明文档。 ([00fa058](https://github.com/netowls-studio/dep/commit/00fa058ad8681728ff497236799f6065e23248ac))
* 新增补发原因代码说明文档。 ([44d436d](https://github.com/netowls-studio/dep/commit/44d436daceb3fc70a740ab3f453d34e0a4b1445f))


### Refactor

* 删除了不合理的接口定义。 ([aa3c8a4](https://github.com/netowls-studio/dep/commit/aa3c8a4d24595abe572e3e9497a3a6eabfb0a599))
* **IMessageBody:** 重构了消息内容接口定义。 ([a539ea2](https://github.com/netowls-studio/dep/commit/a539ea2fbffdafae8268e0dfd8a74d96f8234fb6))


### New features

* 新增回执枚举类型。 ([c7fef1e](https://github.com/netowls-studio/dep/commit/c7fef1e9e0d745d11f345b68a6a9cff39ad52dce))
* 新增消息构建接口。 ([86eeee3](https://github.com/netowls-studio/dep/commit/86eeee312f54f192c98ac50fe8b4dc348e60156e))
* 新增消息构建器抽象程序。 ([128d010](https://github.com/netowls-studio/dep/commit/128d01034b62be58ddea02edc19c86c210018b4c))
* 新增消息接口。 ([1cb5ed1](https://github.com/netowls-studio/dep/commit/1cb5ed1b33ce68c8efd56fbc04943147d3b2e3c8))
* 新增消息类型枚举。 ([5cc1402](https://github.com/netowls-studio/dep/commit/5cc140271ac4fec8666a3781124ee86b87d44c94))
* 新增消息内容接口。 ([fc95d92](https://github.com/netowls-studio/dep/commit/fc95d92061b70a06adbdb0118d48ff78b4ffb1c1))
* 新增消息头构建程序。 ([f02f3fa](https://github.com/netowls-studio/dep/commit/f02f3fa654f7617246ccc04daca2c95fb9665d76))
* 新增消息头基类。 ([18d4294](https://github.com/netowls-studio/dep/commit/18d429475a32b2a7c80a958887f7b2fcd45e5c62))
* 新增消息头接口。 ([c16c8a1](https://github.com/netowls-studio/dep/commit/c16c8a18ca6654b34695b163f7ad03ebe532e278))
* 新增消息信息基类。 ([eff321a](https://github.com/netowls-studio/dep/commit/eff321a4daec7ba292298f50a54183d73a007f74))

## [1.0.0-alpha.15](https://github.com/netowls-studio/dep/compare/v1.0.0-alpha.14...v1.0.0-alpha.15) (2020-10-30)


### ⚠ BREAKING CHANGES

* 重构消息抽象模块。

### Refactor

* 重构消息模块。 ([ffb2e58](https://github.com/netowls-studio/dep/commit/ffb2e58bd11cda6c99559668f0b814bf7bde12a9))


### New features

* 新增基础消息结构定义。 ([fa71ac8](https://github.com/netowls-studio/dep/commit/fa71ac8974cb48aefb513d65922f99c328f92623))


### Documentations

* 新增群集状态同步消息描述文档。 ([f56acec](https://github.com/netowls-studio/dep/commit/f56acec39971bdb5986f384925dcec014d7efbb4))
* 新增数据分发消息说明文档。 ([0456c7f](https://github.com/netowls-studio/dep/commit/0456c7f3e272cdd6a01aff50c854b558a8d1d1ca))
* 新增维护性同步消息说明文档。 ([b49a1bb](https://github.com/netowls-studio/dep/commit/b49a1bb829b1115672675680d11bea45e9b0e0e3))
* 增加消息结构说明文档。 ([093a1b4](https://github.com/netowls-studio/dep/commit/093a1b496fac28c37bffc7be7602240852098119))

## [1.0.0-alpha.14](https://github.com/netowls-studio/dep/compare/v1.0.0-alpha.13...v1.0.0-alpha.14) (2020-10-30)


### Refactor

* 重构了 IStreamingMessageBuilder 接口。 ([cbc15c7](https://github.com/netowls-studio/dep/commit/cbc15c7a980c30ee39d15fdd1fc0ef6ba36201d8))


### New features

* 为 FileStreamSplitter 增加新的构造函数。 ([d37f6b4](https://github.com/netowls-studio/dep/commit/d37f6b4b2ad20dc1bd5b8e5d13c710cc7cbbe47f))
* 新增 IO 流相关消息。 ([2fde18f](https://github.com/netowls-studio/dep/commit/2fde18f51980d2da53b262c5beaaae148ce23043))
* 新增 IO 流消息构建接口。 ([09a61e5](https://github.com/netowls-studio/dep/commit/09a61e5ffda5ac09130304417e03079504c4dde7))
* 新增操作文件流的内部方法。 ([dbbc215](https://github.com/netowls-studio/dep/commit/dbbc215908c008e75ee2f02923bfd788c8231f12))
* 新增构建 IO 流相关消息的基类。 ([1c75db9](https://github.com/netowls-studio/dep/commit/1c75db9c00be94ff257ec1430289705348f96342))
* 新增文件流分割程序。 ([133e6ad](https://github.com/netowls-studio/dep/commit/133e6ad1fc1f285d1aad8caa2f83258a780243f0))
* 新增文件消息构建程序。 ([a6fb719](https://github.com/netowls-studio/dep/commit/a6fb7195b388145cb7891d213987476a4bc2e5ea))
* 新增文件型消息。 ([b60e716](https://github.com/netowls-studio/dep/commit/b60e71664438a2edf6bf5f64a481a90731f8e3fb))
* 重写了 FileMessageBuilder.WithSplitter 方法。 ([5d7f204](https://github.com/netowls-studio/dep/commit/5d7f2044e837263de13dfdeb6d839327a5b1a907))


### Tools

* 修改了 .NET 构建版本号。 ([d95036c](https://github.com/netowls-studio/dep/commit/d95036c3c1001b74eb05fa873d99492e10f2eb13))

## [1.0.0-alpha.13](https://github.com/netowls-studio/dep/compare/v1.0.0-alpha.12...v1.0.0-alpha.13) (2020-10-29)


### ⚠ BREAKING CHANGES

* 对流消息相关代码进行重构。

### Refactor

* 对流消息相关代码进行重构。 ([033cc29](https://github.com/netowls-studio/dep/commit/033cc29d4a2f73db024fad44f6870a63f2929db6))


### New features

* 新增 IO 流拆分接口。 ([15bb485](https://github.com/netowls-studio/dep/commit/15bb4851d8b5134f3bb96f8ce3d45b96a0425469))
* 新增 IO 流分包基础类。 ([715fe4d](https://github.com/netowls-studio/dep/commit/715fe4db30f1b6788778bf5a03b1fa971c8b2485))
* 新增流消息摘要信息。 ([6d5536f](https://github.com/netowls-studio/dep/commit/6d5536f205266daf8af641071719d6e5fdf820e7))
* 新增数据包信息。 ([7feb921](https://github.com/netowls-studio/dep/commit/7feb921457e0690445ccbded42e4166bf3e4aedb))
* 新增文件流摘要信息。 ([c33397a](https://github.com/netowls-studio/dep/commit/c33397a5c0d311ee77ce36f06650ddb2fddd5519))

## [1.0.0-alpha.12](https://github.com/netowls-studio/dep/compare/v1.0.0-alpha.11...v1.0.0-alpha.12) (2020-10-29)


### Documentations

* 修改了架构设计图。 ([b40373e](https://github.com/netowls-studio/dep/commit/b40373e78ec8d119c6ea17758d7ebc44335f1ede))


### Bugs fixed

* 取消了 ReferenceTypeMessage 中对于泛型 T 的 new() 约束。 ([25c4c35](https://github.com/netowls-studio/dep/commit/25c4c3587fd59600b9a21497d1ea92bb9795a869))


### Refactor

* 对流分片程序进行了重构。 ([90981e7](https://github.com/netowls-studio/dep/commit/90981e7c503f773590e5339caaa024442accdd07))


### New features

* 调整解决方案的结构。 ([34cc89c](https://github.com/netowls-studio/dep/commit/34cc89c1cf269739dd70f3d2ec1bb2737ce912b6))
* 为 IStreamSlicer 接口增加了异步方法。 ([29d3087](https://github.com/netowls-studio/dep/commit/29d3087559cea5eaf3d071abfa5c73e6720deb17))
* 为流分割基础程序 StreamSlicer 增加服务注入名称特性。 ([e6d61b3](https://github.com/netowls-studio/dep/commit/e6d61b39d0be20d0cb9c28fc761e3ef05a71aa30))
* 新增 URI 消息构建器。 ([aec20e9](https://github.com/netowls-studio/dep/commit/aec20e9857c1e153c9855affebcfa398e6d9ac54))
* 新增包含了 URI 地址的消息。 ([cb6c610](https://github.com/netowls-studio/dep/commit/cb6c61010e491923926fb518aaf335d8c763de49))
* 新增流分割基类。 ([eddb682](https://github.com/netowls-studio/dep/commit/eddb6824f2e2e8f7f6c9f7e4f8c75241eac51c2a))
* 新增流分割接口。 ([13158af](https://github.com/netowls-studio/dep/commit/13158af942bbd087c669b8eb58a708051ac993a3))
* 新增流分片数据信息。 ([b790415](https://github.com/netowls-studio/dep/commit/b790415194a08bc8c18f24d4dbef53b128dee247))
* 新增文件流分割程序。 ([551c086](https://github.com/netowls-studio/dep/commit/551c0865faa1030b8433d3df225e9cae7b2053b2))
* 新增文件流分片信息。 ([8d28798](https://github.com/netowls-studio/dep/commit/8d287987b77d060941256bbfc69e9b132bad0e49))
* 新增消息构建器基类。 ([27afba3](https://github.com/netowls-studio/dep/commit/27afba3e8ac2b6f778d003bfa51d2ce151d596e8))
* 新增消息构建器接口。 ([23ec64b](https://github.com/netowls-studio/dep/commit/23ec64b3dd16a3923d04d25e6f864b8e02b996e3))
* 新增消息基类。 ([9ce9aa3](https://github.com/netowls-studio/dep/commit/9ce9aa3f5623e841c2b9246655d67a29a74ad349))
* 新增引用类型（类）的消息。 ([3064e80](https://github.com/netowls-studio/dep/commit/3064e805917906f779695a3b499f056a8bc44848))
* 新增值类型消息基类。 ([348e4ff](https://github.com/netowls-studio/dep/commit/348e4ff630dba3de44dcbc4d9f7fe69572ca237e))

## [1.0.0-alpha.11](https://github.com/netowls-studio/dep/compare/v1.0.0-alpha.10...v1.0.0-alpha.11) (2020-10-27)


### New features

* 新增消息信息接口。 ([e3789ba](https://github.com/netowls-studio/dep/commit/e3789ba2b55dab224241ad86058df9eb602397a0))


### CI & CD

* 新增服务器项目持续集成脚本。 ([c879afb](https://github.com/netowls-studio/dep/commit/c879afb7d3542d5d16edd03f1e74a9e0768683cd))


### Tools

* 修改了 MSBuild 配置文件版本号。 ([8093ea2](https://github.com/netowls-studio/dep/commit/8093ea2763368b80f43027bdeea16dea9a7923d4))

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
