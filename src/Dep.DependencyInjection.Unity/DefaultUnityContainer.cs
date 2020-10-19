/*
 * ********************************************************************************************
 * Copyright © 2006 - 2020 Wang Yucai. All rights reserved.
 * Licensed under the MS-PL License See LICENSE in the project root for license information.
 *
 *
 * Author:             Wang Yucai
 * Git Repository Url: https://github.com/netowls-studio/dep
 * Created Time:       2020/10/19 13:26:25
 * Code:               DefaultUnityContainer.cs
 * ********************************************************************************************
 */

using System;
using Unity;

namespace NetowlsStudio.Dep.Unity
{
    /// <summary> 提供了默认的 Unity IoC 容器。 </summary>
    /// <seealso cref="IUnityContainer" />
    public static class DefaultUnityContainer
    {
        /// <summary> Unity IoC 容器。 </summary>
        /// <seealso cref="IUnityContainer" />
        /// <seealso cref="Lazy{T}" />
        public static readonly Lazy<IUnityContainer> Container = new Lazy<IUnityContainer>(() => sr_container, true);

        private static readonly IUnityContainer sr_container = new UnityContainer();
    }
}