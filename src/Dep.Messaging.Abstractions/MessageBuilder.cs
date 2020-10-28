/*
 * ********************************************************************************************
 * Copyright © 2006 - 2020 Wang Yucai. All rights reserved.
 * Licensed under the MS-PL License See LICENSE in the project root for license information.
 *
 *
 * Author:             Wang Yucai
 * Git Repository Url: https://github.com/netowls-studio/dep
 * Created Time:       2020/10/28 15:28:48
 * Code:               MessageBuilder.cs
 * ********************************************************************************************
 */

namespace NetowlsStudio.Dep.Messaging
{
    /// <summary> 提供了构建消息相关的方法。 </summary>
    /// <seealso cref="IMessage" />
    /// <seealso cref="IMessageBuilder" />
    public class MessageBuilder : IMessageBuilder
    {
        /// <summary> 用于初始化一个 <see cref="MessageBuilder" /> 类型的对象实例。 </summary>
        public MessageBuilder()
        {
        }

        /// <summary> 构建消息。 </summary>
        /// <returns> 实现了 <see cref="IMessage" /> 类型接口的对象实例。 </returns>
        /// <seealso cref="IMessage" />
        IMessage IMessageBuilder.Build()
        {
            return Build();
        }

        /// <summary> 构建消息。 </summary>
        /// <returns> 实现了 <see cref="IMessage" /> 类型接口的对象实例。 </returns>
        /// <seealso cref="IMessage" />
        /// <seealso cref="Message" />
        public virtual IMessage Build() => new Message();
    }

    /// <summary> 提供了构建包含数据的消息相关的方法。 </summary>
    /// <typeparam name="TData"> 消息数据类型。 </typeparam>
    /// <seealso cref="IMessage{TData}" />
    /// <seealso cref="IMessageBuilder{TData}" />
    public class MessageBuilder<TData> : IMessageBuilder<TData>
    {
        /// <summary> 用于初始化一个 <see cref="MessageBuilder{TData}" /> 类型的对象实例。 </summary>
        public MessageBuilder()
        {
        }

        /// <summary> 消息数据。 </summary>
        /// <value> 设置或获取 <typeparamref name="TData" /> 类型的对象实例或值，用于表示消息数据。 </value>
        protected virtual TData MessageData { get; set; }

        /// <summary> 构建消息。 </summary>
        /// <returns> 实现了 <see cref="IMessage{TData}" /> 类型接口的对象实例。 </returns>
        /// <seealso cref="IMessage{TData}" />
        IMessage<TData> IMessageBuilder<TData>.Build() => Build();

        /// <summary> 构建消息。 </summary>
        /// <returns> 实现了 <see cref="IMessage{TData}" /> 类型接口的对象实例。 </returns>
        /// <seealso cref="IMessage{TData}" />
        /// <seealso cref="Message{TData}" />
        public virtual IMessage<TData> Build() => new Message<TData>(MessageData);

        /// <summary> 构建消息。 </summary>
        /// <returns> 实现了 <see cref="IMessage" /> 类型接口的对象实例。 </returns>
        /// <seealso cref="IMessage" />
        IMessage IMessageBuilder.Build() => Build();

        /// <summary> 设置消息数据。 </summary>
        /// <param name="messageData"> <typeparamref name="TData" /> 类型的消息数据。 </param>
        /// <returns> 实现了 <see cref="IMessageBuilder{TData}" /> 类型接口的对象实例。 </returns>
        /// <seealso cref="IMessageBuilder{TData}" />
        IMessageBuilder<TData> IMessageBuilder<TData>.WithMessageData(TData messageData) => WithMessageData(messageData);

        /// <summary> 设置消息数据。 </summary>
        /// <param name="messageData"> <typeparamref name="TData" /> 类型的消息数据。 </param>
        /// <returns> 实现了 <see cref="IMessageBuilder{TData}" /> 类型接口的对象实例。 </returns>
        /// <seealso cref="IMessageBuilder{TData}" />
        public virtual IMessageBuilder<TData> WithMessageData(TData messageData)
        {
            MessageData = messageData;
            return this;
        }
    }
}