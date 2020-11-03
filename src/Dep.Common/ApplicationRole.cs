/*
 * ********************************************************************************************
 * Copyright © 2006 - 2020 Wang Yucai. All rights reserved.
 * Licensed under the MS-PL License See LICENSE in the project root for license information.
 *
 *
 * Author:             Wang Yucai
 * Git Repository Url: https://github.com/netowls-studio/dep
 * Created Time:       2020/11/2 14:11:42
 * Code:               ApplicationRole.cs
 * ********************************************************************************************
 */

namespace NetowlsStudio.Dep
{
    /// <summary> 定义了应用程序角色枚举类型。 </summary>
    public enum ApplicationRole
    {
        /// <summary> 部署为 DEP 服务器。 </summary>
        Server = 128,

        /// <summary> 部署为 DEP 中转点。 </summary>
        Transition = 64,

        /// <summary> 部署为 DEP 代理。 </summary>
        Agent = 32,

        /// <summary> 仅为本地磁盘监听程序。 </summary>
        Watcher = 16
    }
}