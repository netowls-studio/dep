/*
 * ********************************************************************************************
 * Copyright © 2006 - 2020 Wang Yucai. All rights reserved.
 * Licensed under the MS-PL License See LICENSE in the project root for license information.
 *
 *
 * Author:             Wang Yucai
 * Git Repository Url: https://github.com/netowls-studio/dep
 * Created Time:       2020/11/2 13:28:56
 * Code:               IMessageBuilder.cs
 * ********************************************************************************************
 */

namespace NetowlsStudio.Dep.Messaging
{
    /// <summary> 定义了构建消息信息的接口。 </summary>
    /// <typeparam name="TMessage"> 实现了 <see cref="IMessage" /> 接口的类型。 </typeparam>
    /// <seealso cref="IObjectBuilder{T}" />
    /// <seealso cref="IMessage" />
    public interface IMessageBuilder<TMessage> : IObjectBuilder<TMessage>
        where TMessage : class, IMessage
    {
        /// <summary> 构建消息。 </summary>
        /// <typeparam name="TBody"> 消息体类型。 </typeparam>
        /// <returns> 实现了 <see cref="IMessage{TBody}" /> 类型接口的对象实例。 </returns>
        IMessage<TBody> Build<TBody>();

        /// <summary> 设置消息体。 </summary>
        /// <param name="body"> 消息体。 </param>
        /// <returns> 实现了 <see cref="IMessageBuilder{TMessage}" /> 类型接口的对象实例。 </returns>
        IMessageBuilder<TMessage> WithBody(object body);

        /// <summary> 设置消息体。 </summary>
        /// <typeparam name="TBody"> 消息体类型。 </typeparam>
        /// <param name="body"> 消息体。 </param>
        /// <returns> 实现了 <see cref="IMessageBuilder{TMessage}" /> 类型接口的对象实例。 </returns>
        IMessageBuilder<TMessage> WithBody<TBody>(TBody body);

        /// <summary> 设置消息头摘要信息。 </summary>
        /// <typeparam name="THeader"> 实现了 <see cref="IHeader" /> 接口的类型。 </typeparam>
        /// <param name="header"> <typeparamref name="THeader" /> 类型的对象实例。 </param>
        /// <returns> 实现了 <see cref="IMessageBuilder{TMessage}" /> 类型接口的对象实例。 </returns>
        /// <seealso cref="IHeader" />
        IMessageBuilder<TMessage> WithHeader<THeader>(THeader header) where THeader : class, IHeader;

        /// <summary> 设置消息头摘要信息。 </summary>
        /// <typeparam name="THeader"> 实现了 <see cref="IHeader" /> 接口的类型。 </typeparam>
        /// <param name="builder"> 实现了 <see cref="IHeaderBuilder{THeader}" /> 类型接口的对象实例。 </param>
        /// <returns> 实现了 <see cref="IMessageBuilder{TMessage}" /> 类型接口的对象实例。 </returns>
        /// <seealso cref="IHeader" />
        /// <seealso cref="IHeaderBuilder{THeader}" />
        IMessageBuilder<TMessage> WithHeader<THeader>(IHeaderBuilder<THeader> builder) where THeader : class, IHeader;
    }
}