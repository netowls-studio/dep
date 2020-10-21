/*
 * ********************************************************************************************
 * Copyright © 2006 - 2020 Wang Yucai. All rights reserved.
 * Licensed under the MS-PL License See LICENSE in the project root for license information.
 *
 *
 * Author:             Wang Yucai
 * Git Repository Url: https://github.com/netowls-studio/dep
 * Created Time:       2020/10/21 12:20:49
 * Code:               InjectionNameAttribute.cs
 * ********************************************************************************************
 */

using System;

namespace NetowlsStudio.Dep.DependencyInjection.Annotations
{
    /// <summary>
    /// 提供了标识注入服务名称相关的方法。
    /// <para> 密闭的，不可以从此类型派生。 </para>
    /// </summary>
    /// <seealso cref="Attribute" />
    /// <seealso cref="AttributeUsageAttribute" />
    /// <seealso cref="AttributeTargets" />
    /// <seealso cref="AttributeTargets.Class" />
    /// <remarks> 密闭的，不可以从此类型派生。 </remarks>
    [AttributeUsage(AttributeTargets.Class, AllowMultiple = false, Inherited = false)]
    public sealed class InjectionNameAttribute : Attribute
    {
        /// <summary> 用于初始化一个 <see cref="InjectionNameAttribute" /> 类型的对象实例。 </summary>
        /// <param name="serviceName"> 注册的服务名称。 </param>
        public InjectionNameAttribute(string serviceName)
        {
            ServiceName = serviceName;
        }

        /// <summary> 服务名称。 </summary>
        /// <value> 获取一个字符串，用于表示服务名称。 </value>
        public string ServiceName { get; }
    }
}