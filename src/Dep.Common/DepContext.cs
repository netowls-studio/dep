/*
 * ********************************************************************************************
 * Copyright © 2006 - 2020 Wang Yucai. All rights reserved.
 * Licensed under the MS-PL License See LICENSE in the project root for license information.
 *
 *
 * Author:             Wang Yucai
 * Git Repository Url: https://github.com/netowls-studio/dep
 * Created Time:       2020/10/16 8:54:58
 * Code:               DepContext.cs
 * ********************************************************************************************
 */

namespace NetowlsStudio.Dep
{
    /// <summary> 提供了访问 DEP 上下文信息相关的方法。 </summary>
    /// <seealso cref="IDepContext" />
    public class DepContext : IDepContext
    {
        private IRunningEnvironment m_runningEnv;

        /// <summary> 用于初始化一个 <see cref="DepContext" /> 类型的对象实例。 </summary>
        /// <param name="envName"> 运行环境名称。 </param>
        /// <seealso cref="IRunningEnvironment" />
        /// <seealso cref="RunningEnvironment" />
        public DepContext(string envName = RunningEnvironment.DefaultEnvironmentName) : this(new RunningEnvironment(envName))
        {
        }

        /// <summary> 用于初始化一个 <see cref="DepContext" /> 类型的对象实例。 </summary>
        /// <param name="env"> 运行时环境。 </param>
        public DepContext(IRunningEnvironment env)
        {
            m_runningEnv = env;
        }

        /// <summary> 默认的 DEP 上下文。 </summary>
        /// <value> 获取 <see cref="IDepContext" /> 类型的对象实例，用于表示默认的 DEP 上下文。 </value>
        /// <seealso cref="IDepContext" />
        public static IDepContext DefaultContext => SingletonContextStorage.DefaultContext;

        /// <summary>
        /// DEP 运行时环境信息。
        /// <para> 实现了 <see cref="IRunningEnvironment" /> 类型接口的对象实例。 </para>
        /// </summary>
        /// <value> 设置或获取 <see cref="IRunningEnvironment" /> 类型的对象实例，用于表示 DEP 运行时环境信息。 </value>
        /// <seealso cref="IRunningEnvironment" />
        IRunningEnvironment IDepContext.RunningEnvironment
        {
            get { return m_runningEnv; }
            set { m_runningEnv = value; }
        }
    }
}