/*
 * ********************************************************************************************
 * Copyright © 2006 - 2020 Wang Yucai. All rights reserved.
 * Licensed under the MS-PL License See LICENSE in the project root for license information.
 *
 *
 * Author:             Wang Yucai
 * Git Repository Url: https://github.com/netowls-studio/dep
 * Created Time:       2020/10/27 13:49:05
 * Code:               MessageBuilder.cs
 * ********************************************************************************************
 */

namespace NetowlsStudio.Dep.Messaging
{
    /// <summary> 提供了构建消息相关的基本方法。 </summary>
    /// <typeparam name="TData"> 消息数据类型。 </typeparam>
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

        /// <summary> 构建 <typeparamref name="TMessage" /> 类型的对象实例。 </summary>
        /// <typeparam name="TMessage"> 实现了 <see cref="IMessage{TData}" /> 类型接口的类型。 </typeparam>
        /// <returns> 实现了 <see cref="IMessage{TData}" /> 类型接口的对象实例。 </returns>
        /// <seealso cref="IMessage{TData}" />
        TMessage IMessageBuilder<TData>.Build<TMessage>()
        {
            return (TMessage)Build();
        }

        /// <summary> 构建实现了 <see cref="IMessage{TData}" /> 类型接口的对象实例。 </summary>
        /// <returns> 实现了 <see cref="IMessage{TData}" /> 类型接口的对象实例。 </returns>
        /// <seealso cref="IMessage{TData}" />
        /// <seealso cref="Message{TData}" />
        public virtual IMessage<TData> Build()
        {
            return new Message<TData>(MessageData);
        }

        /// <summary> 设置消息数据。 </summary>
        /// <param name="data"> <typeparamref name="TData" /> 类型的消息数据。 </param>
        /// <returns> 实现了 <see cref="IMessageBuilder{TData}" /> 类型接口的对象实例。 </returns>
        /// <seealso cref="IMessageBuilder{TData}" />
        public virtual IMessageBuilder<TData> WithData(TData data)
        {
            MessageData = data;
            return this;
        }
    }
}