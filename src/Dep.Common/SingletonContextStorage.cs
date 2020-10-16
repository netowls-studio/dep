/*
 * ********************************************************************************************
 * Copyright © 2006 - 2020 Wang Yucai. All rights reserved.
 * Licensed under the MS-PL License See LICENSE in the project root for license information.
 *
 *
 * Author:             Wang Yucai
 * Git Repository Url: https://github.com/netowls-studio/dep
 * Created Time:       2020/10/16 9:01:50
 * Code:               SingletonContextStorage.cs
 * ********************************************************************************************
 */

namespace NetowlsStudio.Dep
{
    /// <summary> 提供了用于保存单例的 DEP 上下文信息相关的方法。 </summary>
    public static class SingletonContextStorage
    {
        private static readonly object sr_synchronizationLockObj = new object();

        /// <summary> 默认的 DEP 上下文。 </summary>
        /// <value>
        /// 设置或获取 <see cref="IDepContext" /> 类型的对象实例，用于表示默认的 DEP 上下文。
        /// <para> 实现了 <see cref="IDepContext" /> 类型接口的对象实例。 </para>
        /// </value>
        /// <seealso cref="IDepContext" />
        internal static IDepContext DefaultContext { get; set; }

        /// <summary> 重新保存当前的 DEP 上下文信息。 </summary>
        /// <param name="context"> DEP 上下文。 </param>
        /// <seealso cref="IDepContext" />
        public static void Save(IDepContext context)
        {
            if (DefaultContext is null)
            {
                lock (sr_synchronizationLockObj)
                {
                    if (DefaultContext is null)
                        DefaultContext = context;
                }
            }
        }
    }
}