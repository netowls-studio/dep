/*
 * ********************************************************************************************
 * Copyright © 2006 - 2020 Wang Yucai. All rights reserved.
 * Licensed under the MS-PL License See LICENSE in the project root for license information.
 *
 *
 * Author:             Wang Yucai
 * Git Repository Url: https://github.com/netowls-studio/dep
 * Created Time:       2020/10/15 13:30:35
 * Code:               RunningEnvironment.cs
 * ********************************************************************************************
 */

using System;

namespace NetowlsStudio.Dep
{
    /// <summary>
    /// 提供了访问 DEP 运行环境信息相关的方法。
    /// <para> 密闭的，不可以从此类型派生。 </para>
    /// </summary>
    /// <seealso cref="IRunningEnvironment" />
    /// <remarks> 密闭的，不可以从此类型派生。 </remarks>
    public sealed class RunningEnvironment : IRunningEnvironment
    {
        /// <summary> 默认的环境名称。 </summary>
        public const string DefaultEnvironmentName = "Development";

        /// <summary> 内测环境。 </summary>
        /// <seealso cref="IRunningEnvironment" />
        public static readonly IRunningEnvironment Alpha = new RunningEnvironment("Alpha");

        /// <summary> 公测环境。 </summary>
        /// <seealso cref="IRunningEnvironment" />
        public static readonly IRunningEnvironment Beta = new RunningEnvironment("Beta");

        /// <summary> 开发环境。 </summary>
        /// <seealso cref="IRunningEnvironment" />
        public static readonly IRunningEnvironment Development = new RunningEnvironment();

        /// <summary> 生产环境。 </summary>
        /// <seealso cref="IRunningEnvironment" />
        public static readonly IRunningEnvironment Production = new RunningEnvironment("Production");

        private string m_environmentName = DefaultEnvironmentName;

        /// <summary> 用于初始化一个 <see cref="RunningEnvironment" /> 类型的对象实例。 </summary>
        public RunningEnvironment() : this(DefaultEnvironmentName)
        {
        }

        /// <summary> 用于初始化一个 <see cref="RunningEnvironment" /> 类型的对象实例。 </summary>
        /// <param name="envName"> 运行环境名称。 </param>
        /// <exception cref="ArgumentNullException"> </exception>
        public RunningEnvironment(string envName)
        {
            if (string.IsNullOrWhiteSpace(envName))
                throw new ArgumentNullException(nameof(envName), string.Format(DepException.MessageTemplate, $"无效的运行环境名称变量 @{nameof(envName)}"));
            m_environmentName = envName;
        }

        /// <summary> 运行环境名称。 </summary>
        /// <value> 获取一个字符串，用于表示运行环境名称。 </value>
        string IRunningEnvironment.EnvironmentName
        {
            get { return m_environmentName; }
        }
    }
}