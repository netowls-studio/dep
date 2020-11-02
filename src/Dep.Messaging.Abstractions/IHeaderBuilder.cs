/*
 * ********************************************************************************************
 * Copyright © 2006 - 2020 Wang Yucai. All rights reserved.
 * Licensed under the MS-PL License See LICENSE in the project root for license information.
 *
 *
 * Author:             Wang Yucai
 * Git Repository Url: https://github.com/netowls-studio/dep
 * Created Time:       2020/11/2 12:05:55
 * Code:               IHeaderBuilder.cs
 * ********************************************************************************************
 */

using System;

namespace NetowlsStudio.Dep.Messaging
{
    /// <summary> 定义了构建消息头信息的接口。 </summary>
    /// <typeparam name="THeader"> 实现了 <see cref="IHeader" /> 接口的类型。 </typeparam>
    /// <seealso cref="IHeader" />
    /// <seealso cref="IObjectBuilder{T}" />
    public interface IHeaderBuilder<THeader> : IObjectBuilder<THeader>
        where THeader : class, IHeader
    {
        /// <summary> 设置分组标识。 </summary>
        /// <param name="groupId"> 分组标识。 </param>
        /// <returns> 实现了 <see cref="IHeaderBuilder{THeader}" /> 类型接口的对象实例。 </returns>
        IHeaderBuilder<THeader> WithGroupId(string groupId);

        /// <summary> 设置消息发布时间。 </summary>
        /// <param name="publishTime"> 消息发布时间。如果等于 <c> null </c>，则默认赋值为 <see cref="DateTime.Now" />。 </param>
        /// <returns> 实现了 <see cref="IHeaderBuilder{THeader}" /> 类型接口的对象实例。 </returns>
        IHeaderBuilder<THeader> WithPublishTime(DateTime? publishTime = null);

        /// <summary> 设置消息类型。 </summary>
        /// <param name="messageType">
        /// 消息类型。
        /// <para> <see cref="MessageType" /> 类型的值。 </para>
        /// </param>
        /// <returns> 实现了 <see cref="IHeaderBuilder{THeader}" /> 类型接口的对象实例。 </returns>
        /// <seealso cref="MessageType" />
        IHeaderBuilder<THeader> WithType(MessageType messageType = MessageType.Default);
    }
}