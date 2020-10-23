/*
 * ********************************************************************************************
 * Copyright © 2006 - 2020 Wang Yucai. All rights reserved.
 * Licensed under the MS-PL License See LICENSE in the project root for license information.
 *
 *
 * Author:             Wang Yucai
 * Git Repository Url: https://github.com/netowls-studio/dep
 * Created Time:       2020/10/21 12:34:29
 * Code:               IServiceDiscovery.cs
 * ********************************************************************************************
 */

namespace NetowlsStudio.Dep.DependencyInjection
{
    /// <summary> 定义了发现依赖注入服务的接口。 </summary>
    public interface IServiceDiscovery
    {
        /// <summary> 查找指定名称的服务。 </summary>
        /// <typeparam name="TService"> 服务类型。 </typeparam>
        /// <param name="name"> 服务注册名称。 </param>
        /// <returns> <typeparamref name="TService" /> 类型的对象实例。 </returns>
        TService Discover<TService>(string name);
    }
}
