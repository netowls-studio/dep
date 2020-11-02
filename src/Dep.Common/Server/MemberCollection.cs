/*
 * ********************************************************************************************
 * Copyright © 2006 - 2020 Wang Yucai. All rights reserved.
 * Licensed under the MS-PL License See LICENSE in the project root for license information.
 *
 *
 * Author:             Wang Yucai
 * Git Repository Url: https://github.com/netowls-studio/dep
 * Created Time:       2020/11/2 14:27:22
 * Code:               MemberCollection.cs
 * ********************************************************************************************
 */

using System.Collections.Generic;

namespace NetowlsStudio.Dep.Server
{
    /// <summary>
    /// 提供了 <see cref="IMember" /> 类型的对象实例集合。
    /// <para> 密闭的，不可以从此类型派生。 </para>
    /// </summary>
    /// <seealso cref="IMember" />
    /// <seealso cref="IList{T}" />
    /// <seealso cref="List{T}" />
    /// <remarks> 密闭的，不可以从此类型派生。 </remarks>
    public sealed class MemberCollection : List<IMember>
    {
        /// <summary> 用于初始化一个 <see cref="MemberCollection" /> 类型的对象实例。 </summary>
        public MemberCollection() : base()
        {
        }

        /// <summary> 用于初始化一个 <see cref="MemberCollection" /> 类型的对象实例。 </summary>
        /// <param name="collection"> 用于初始化的 <see cref="IMember" /> 类型的对象实例集合。 </param>
        public MemberCollection(IEnumerable<IMember> collection) : base(collection)
        {
        }
    }
}