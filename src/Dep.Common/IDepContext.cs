/*
 * ********************************************************************************************
 * Copyright © 2006 - 2020 Wang Yucai. All rights reserved.
 * Licensed under the MS-PL License See LICENSE in the project root for license information.
 *
 *
 * Author:             Wang Yucai
 * Git Repository Url: https://github.com/netowls-studio/dep
 * Created Time:       2020/10/16 8:51:52
 * Code:               IDepContext.cs
 * ********************************************************************************************
 */

namespace NetowlsStudio.Dep
{
    /// <summary> 定义了 DEP 上下文信息接口。 </summary>
    public interface IDepContext
    {
        /// <summary>
        /// DEP 运行时环境信息。
        /// <para> 实现了 <see cref="IRunningEnvironment" /> 类型接口的对象实例。 </para>
        /// </summary>
        /// <value> 设置或获取 <see cref="IRunningEnvironment" /> 类型的对象实例，用于表示 DEP 运行时环境信息。 </value>
        /// <seealso cref="IRunningEnvironment" />
        IRunningEnvironment RunningEnvironment { get; set; }
    }
}