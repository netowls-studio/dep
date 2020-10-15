/*
 * ********************************************************************************************
 * Copyright © 2006 - 2020 Wang Yucai. All rights reserved.
 * Licensed under the MS-PL License See LICENSE in the project root for license information.
 *
 *
 * Author:             Wang Yucai
 * Git Repository Url: https://github.com/netowls-studio/dep
 * Created Time:       2020/10/15 13:07:18
 * Code:               DepContext.cs
 * ********************************************************************************************
 */

namespace NetowlsStudio.Dep
{
    /// <summary> 提供了访问 DEP 上下文信息相关的方法。 </summary>
    /// <seealso cref="IDepContext" />
    public class DepContext : IDepContext
    {
        /// <summary> 默认的环境名称。 </summary>
        public const string DefaultEnvironmentName = "Development";

        /// <summary>
        /// 当前的 DEP 上下文。
        /// <para> 实现了 <see cref="IDepContext" /> 类型接口的对象实例。 </para>
        /// </summary>
        /// <seealso cref="IDepContext" />
        /// <seealso cref="DepContext" />
        public static readonly IDepContext CurrentContext = CurrentCtx;

        /// <summary>
        /// 当前的 DEP 上下文。
        /// <para> <see cref="DepContext" /> 类型的对象实例。 </para>
        /// </summary>
        /// <seealso cref="DepContext" />
        internal static readonly DepContext CurrentCtx = new DepContext();

        private string m_environmentName = "Development";

        /// <summary> 用于初始化一个 <see cref="DepContext" /> 类型的对象实例。 </summary>
        private DepContext()
        {
        }

        /// <summary> 当前的运行环境名称。 </summary>
        /// <value> 获取一个字符串，用于表示当前的运行环境名称。 </value>
        public virtual string EnvironmentName
        {
            get { return m_environmentName; }
        }

        /// <summary> 设置当前的运行环境名称。 </summary>
        /// <param name="envName"> 环境名称。 </param>
        /// <seealso cref="DefaultEnvironmentName" />
        internal void SetEnvironmentName(string envName = DefaultEnvironmentName) => m_environmentName = envName;
    }
}