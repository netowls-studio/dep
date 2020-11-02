/*
 * ********************************************************************************************
 * Copyright © 2006 - 2020 Wang Yucai. All rights reserved.
 * Licensed under the MS-PL License See LICENSE in the project root for license information.
 *
 *
 * Author:             Wang Yucai
 * Git Repository Url: https://github.com/netowls-studio/dep
 * Created Time:       2020/11/2 12:13:15
 * Code:               HeaderBuilder.cs
 * ********************************************************************************************
 */

using System;

namespace NetowlsStudio.Dep.Messaging
{
    /// <summary> 提供了构建消息头信息相关的基本方法。 </summary>
    /// <typeparam name="THeader"> 实现了 <see cref="IHeader" /> 接口的类型。 </typeparam>
    /// <seealso cref="IHeader" />
    /// <seealso cref="IHeaderBuilder{THeader}" />
    public abstract class HeaderBuilder<THeader> : IHeaderBuilder<THeader>
        where THeader : class, IHeader
    {
        /// <summary> 用于初始化一个 <see cref="HeaderBuilder{THeader}" /> 类型的对象实例。 </summary>
        protected HeaderBuilder()
        {
        }

        /// <summary> 消息分组标识。 </summary>
        /// <value> 设置或获取一个字符串，用于表示消息分组标识。 </value>
        protected virtual string GroupId { get; set; }

        /// <summary> 消息类型。 </summary>
        /// <value> 设置或获取一个 <see cref="MessageType" /> 类型的值，用于表示消息类型。 </value>
        /// <seealso cref="MessageType" />
        protected virtual MessageType MessageType { get; set; }

        /// <summary> 消息发布时间。 </summary>
        /// <value> 设置或获取一个值，用于表示消息发布时间。 </value>
        protected virtual DateTime PublishTime { get; set; }

        /// <summary> 构建 <typeparamref name="THeader" /> 类型的对象实例。 </summary>
        /// <returns> <typeparamref name="THeader" /> 类型的对象实例。 </returns>
        THeader IObjectBuilder<THeader>.Build() => Build();

        /// <summary> 构建 <typeparamref name="THeader" /> 类型的对象实例。 </summary>
        /// <returns> <typeparamref name="THeader" /> 类型的对象实例。 </returns>
        public abstract THeader Build();

        /// <summary> 设置分组标识。 </summary>
        /// <param name="groupId"> 分组标识。 </param>
        /// <returns> 实现了 <see cref="IHeaderBuilder{THeader}" /> 类型接口的对象实例。 </returns>
        /// <exception cref="ArgumentNullException"> </exception>
        IHeaderBuilder<THeader> IHeaderBuilder<THeader>.WithGroupId(string groupId) => WithGroupId(groupId);

        /// <summary> 设置分组标识。 </summary>
        /// <param name="groupId"> 分组标识。 </param>
        /// <returns> 实现了 <see cref="IHeaderBuilder{THeader}" /> 类型接口的对象实例。 </returns>
        /// <exception cref="ArgumentNullException"> </exception>
        public virtual HeaderBuilder<THeader> WithGroupId(string groupId)
        {
            if (string.IsNullOrWhiteSpace(groupId))
            {
                throw new ArgumentNullException(nameof(groupId), string.Format(DepException.MessageTemplate, "GroupId 不可以为空"));
            }

            GroupId = groupId;

            return this;
        }

        /// <summary> 设置消息发布时间。 </summary>
        /// <param name="publishTime"> 消息发布时间。如果等于 <c> null </c>，则默认赋值为 <see cref="P:System.DateTime.Now" />。 </param>
        /// <returns> 实现了 <see cref="IHeaderBuilder{THeader}" /> 类型接口的对象实例。 </returns>
        IHeaderBuilder<THeader> IHeaderBuilder<THeader>.WithPublishTime(DateTime? publishTime) => WithPublishTime(publishTime);

        /// <summary> 设置消息发布时间。 </summary>
        /// <param name="publishTime"> 消息发布时间。如果等于 <c> null </c>，则默认赋值为 <see cref="P:System.DateTime.Now" />。 </param>
        /// <returns> 实现了 <see cref="IHeaderBuilder{THeader}" /> 类型接口的对象实例。 </returns>
        public virtual HeaderBuilder<THeader> WithPublishTime(DateTime? publishTime = null)
        {
            PublishTime = publishTime.HasValue ? publishTime.Value : DateTime.Now;
            return this;
        }

        /// <summary> 设置消息类型。 </summary>
        /// <param name="messageType">
        /// 消息类型。
        /// <para> <see cref="MessageType" /> 类型的值。 </para>
        /// </param>
        /// <returns> 实现了 <see cref="IHeaderBuilder{THeader}" /> 类型接口的对象实例。 </returns>
        /// <seealso cref="MessageType" />
        IHeaderBuilder<THeader> IHeaderBuilder<THeader>.WithType(MessageType messageType) => WithType(messageType);

        /// <summary> 设置消息类型。 </summary>
        /// <param name="messageType">
        /// 消息类型。
        /// <para> <see cref="MessageType" /> 类型的值。 </para>
        /// </param>
        /// <returns> 实现了 <see cref="IHeaderBuilder{THeader}" /> 类型接口的对象实例。 </returns>
        /// <seealso cref="MessageType" />
        public virtual HeaderBuilder<THeader> WithType(MessageType messageType = MessageType.Default)
        {
            if (messageType == MessageType.Default)
                messageType = MessageType.Distribution;
            MessageType = messageType;
            return this;
        }
    }
}