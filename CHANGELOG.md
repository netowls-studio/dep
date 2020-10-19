# Changelog

All notable changes to this project will be documented in this file. See [standard-version](https://github.com/conventional-changelog/standard-version) for commit guidelines.

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
