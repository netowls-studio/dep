/*
 * ********************************************************************************************
 * Copyright © 2006 - 2020 Wang Yucai. All rights reserved.
 * Licensed under the MS-PL License See LICENSE in the project root for license information.
 *
 *
 * Author:             Wang Yucai
 * Git Repository Url: https://github.com/netowls-studio/dep
 * Created Time:       2020/10/19 9:42:45
 * Code:               IConfigurationBroker.cs
 * ********************************************************************************************
 */

namespace NetowlsStudio.Dep.Configuration
{
    /// <summary> 定义了访问 DEP 配置信息的方法。 </summary>
    /// <typeparam name="TOptions"> 实现了 <see cref="IDepOptions" /> 接口的类型。 </typeparam>
    /// <seealso cref="IDepOptions" />
    public interface IConfigurationBroker<TOptions>
        where TOptions : class, IDepOptions
    {
        /// <summary> 获取配置信息。 </summary>
        /// <returns> 实现了 <see cref="IDepOptions" /> 类型接口的对象实例。 </returns>
        TOptions Get();
    }
}