﻿/*
 * ********************************************************************************************
 * Copyright © 2006 - 2020 Wang Yucai. All rights reserved.
 * Licensed under the MS-PL License See LICENSE in the project root for license information.
 *
 *
 * Author:             Wang Yucai
 * Git Repository Url: https://github.com/netowls-studio/dep
 * Created Time:       2020/10/15 13:28:47
 * Code:               IRunningEnvironment.cs
 * ********************************************************************************************
 */

namespace NetowlsStudio.Dep
{
    /// <summary> 定义了 DEP 运行环境信息的接口。 </summary>
    public interface IRunningEnvironment
    {
        /// <summary> 运行环境名称。 </summary>
        /// <value> 获取一个字符串，用于表示运行环境名称。 </value>
        string EnvironmentName { get; }
    }
}