/*
 * ********************************************************************************************
 * Copyright © 2006 - 2020 Wang Yucai. All rights reserved.
 * Licensed under the MS-PL License See LICENSE in the project root for license information.
 *
 *
 * Author:             Wang Yucai
 * Git Repository Url: https://github.com/netowls-studio/dep
 * Created Time:       2020/10/16 10:38:20
 * Code:               IObjectBuilder.cs
 * ********************************************************************************************
 */

namespace NetowlsStudio.Dep
{
    /// <summary> 定义了构建器模式接口。 </summary>
    /// <typeparam name="T"> 引用类型。 </typeparam>
    public interface IObjectBuilder<T>
        where T : class
    {
        /// <summary> 构建 <typeparamref name="T" /> 类型的对象实例。 </summary>
        /// <returns> <typeparamref name="T" /> 类型的对象实例。 </returns>
        T Build();
    }
}