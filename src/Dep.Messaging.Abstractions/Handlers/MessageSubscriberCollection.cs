/*
 * ********************************************************************************************
 * Copyright © 2006 - 2020 Wang Yucai. All rights reserved.
 * Licensed under the MS-PL License See LICENSE in the project root for license information.
 *
 *
 * Author:             Wang Yucai
 * Git Repository Url: https://github.com/netowls-studio/dep
 * Created Time:       2020/11/3 12:46:49
 * Code:               MessageSubscriberCollection.cs
 * ********************************************************************************************
 */

using System.Collections.Generic;

namespace NetowlsStudio.Dep.Messaging.Handlers
{
    /// <summary>
    /// <see cref="IMessageSubscriber" /> 类型的对象实例集合。
    /// <para> 密闭的，不可以从此类型派生。 </para>
    /// </summary>
    /// <seealso cref="IMessageSubscriber" />
    /// <seealso cref="List{T}" />
    /// <remarks> 密闭的，不可以从此类型派生。 </remarks>
    public sealed class MessageSubscriberCollection : List<IMessageSubscriber>
    {
        /// <summary> 用于初始化一个 <see cref="MessageSubscriberCollection" /> 类型的对象实例。 </summary>
        public MessageSubscriberCollection()
        {
        }

        /// <summary> 用于初始化一个 <see cref="MessageSubscriberCollection" /> 类型的对象实例。 </summary>
        /// <param name="collection"> 用于初始化的 <see cref="IMessageSubscriber" /> 类型的对象实例集合。 </param>
        public MessageSubscriberCollection(IEnumerable<IMessageSubscriber> collection) : base(collection)
        {
        }
    }
}