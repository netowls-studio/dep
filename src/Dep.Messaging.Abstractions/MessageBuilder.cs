/*
 * ********************************************************************************************
 * Copyright © 2006 - 2020 Wang Yucai. All rights reserved.
 * Licensed under the MS-PL License See LICENSE in the project root for license information.
 *
 *
 * Author:             Wang Yucai
 * Git Repository Url: https://github.com/netowls-studio/dep
 * Created Time:       2020/11/2 13:44:50
 * Code:               MessageBuilder.cs
 * ********************************************************************************************
 */

namespace NetowlsStudio.Dep.Messaging
{
    /// <summary> 提供了构建消息信息相关的基本方法。 </summary>
    /// <typeparam name="TMessage"> 实现了 <see cref="IMessage" /> 接口的类型。 </typeparam>
    /// <seealso cref="IMessage" />
    /// <seealso cref="IMessage{TBody}" />
    /// <seealso cref="IMessageBuilder{TMessage}" />
    public abstract class MessageBuilder<TMessage> : IMessageBuilder<TMessage>
        where TMessage : class, IMessage
    {
        /// <summary> 用于初始化一个 <see cref="MessageBuilder{TMessage}" /> 类型的对象实例。 </summary>
        protected MessageBuilder()
        {
        }

        /// <summary> 消息体。 </summary>
        /// <value> 设置或获取 <see cref="object" /> 类型的对象实例，用于表示消息体。 </value>
        protected virtual object CommonBody { get; set; }

        /// <summary> 消息头摘要信息。 </summary>
        /// <value> 设置或获取 <see cref="IHeader" /> 类型的对象实例，用于表示消息头摘要信息。 </value>
        /// <seealso cref="IHeader" />
        protected virtual IHeader Header { get; set; }

        /// <summary> 构建消息。 </summary>
        /// <typeparam name="TBody"> 消息体类型。 </typeparam>
        /// <returns> 实现了 <see cref="IMessage{TBody}" /> 类型接口的对象实例。 </returns>
        IMessage<TBody> IMessageBuilder<TMessage>.Build<TBody>() => Build<TBody>();

        /// <summary> 构建消息。 </summary>
        /// <typeparam name="TBody"> 消息体类型。 </typeparam>
        /// <returns> 实现了 <see cref="IMessage{TBody}" /> 类型接口的对象实例。 </returns>
        public abstract IMessage<TBody> Build<TBody>();

        /// <summary> 构建 <see cref="IMessage" /> 类型的对象实例。 </summary>
        /// <returns> <see cref="IMessage" /> 类型的对象实例。 </returns>
        TMessage IObjectBuilder<TMessage>.Build() => Build();

        /// <summary> 构建 <see cref="IMessage" /> 类型的对象实例。 </summary>
        /// <returns> <see cref="IMessage" /> 类型的对象实例。 </returns>
        public abstract TMessage Build();

        /// <summary> 设置消息体。 </summary>
        /// <param name="body"> 消息体。 </param>
        /// <returns> 实现了 <see cref="IMessageBuilder{TMessage}" /> 类型接口的对象实例。 </returns>
        public virtual IMessageBuilder<TMessage> WithBody(object body)
        {
            CommonBody = body;
            return this;
        }

        /// <summary> 设置消息体。 </summary>
        /// <typeparam name="TBody"> 消息体类型。 </typeparam>
        /// <param name="body"> 消息体。 </param>
        /// <returns> 实现了 <see cref="IMessageBuilder{TMessage}" /> 类型接口的对象实例。 </returns>
        public virtual IMessageBuilder<TMessage> WithBody<TBody>(TBody body) => WithBody(body);

        /// <summary> 设置消息头摘要信息。 </summary>
        /// <typeparam name="THeader"> 实现了 <see cref="IHeader" /> 接口的类型。 </typeparam>
        /// <param name="header"> <typeparamref name="THeader" /> 类型的对象实例。 </param>
        /// <returns> 实现了 <see cref="IMessageBuilder{TMessage}" /> 类型接口的对象实例。 </returns>
        /// <seealso cref="IHeader" />
        IMessageBuilder<TMessage> IMessageBuilder<TMessage>.WithHeader<THeader>(THeader header) => WithHeader(header);

        /// <summary> 设置消息头摘要信息。 </summary>
        /// <typeparam name="THeader"> 实现了 <see cref="IHeader" /> 接口的类型。 </typeparam>
        /// <param name="header"> <typeparamref name="THeader" /> 类型的对象实例。 </param>
        /// <returns> 实现了 <see cref="IMessageBuilder{TMessage}" /> 类型接口的对象实例。 </returns>
        /// <seealso cref="IHeader" />
        public virtual MessageBuilder<TMessage> WithHeader<THeader>(THeader header)
            where THeader : class, IHeader
        {
            Header = header;

            return this;
        }

        /// <summary> 设置消息头摘要信息。 </summary>
        /// <typeparam name="THeader"> 实现了 <see cref="IHeader" /> 接口的类型。 </typeparam>
        /// <param name="builder"> 实现了 <see cref="IHeaderBuilder{THeader}" /> 类型接口的对象实例。 </param>
        /// <returns> 实现了 <see cref="IMessageBuilder{TMessage}" /> 类型接口的对象实例。 </returns>
        /// <seealso cref="IHeader" />
        /// <seealso cref="IHeaderBuilder{THeader}" />
        IMessageBuilder<TMessage> IMessageBuilder<TMessage>.WithHeader<THeader>(IHeaderBuilder<THeader> builder) => WithHeader(builder.Build());

        /// <summary> 设置消息头摘要信息。 </summary>
        /// <typeparam name="THeader"> 实现了 <see cref="IHeader" /> 接口的类型。 </typeparam>
        /// <param name="builder"> 实现了 <see cref="IHeaderBuilder{THeader}" /> 类型接口的对象实例。 </param>
        /// <returns> 实现了 <see cref="IMessageBuilder{TMessage}" /> 类型接口的对象实例。 </returns>
        /// <seealso cref="IHeader" />
        /// <seealso cref="IHeaderBuilder{THeader}" />
        public virtual MessageBuilder<TMessage> WithHeader<THeader>(IHeaderBuilder<THeader> builder)
            where THeader : class, IHeader => WithHeader(builder.Build());
    }
}