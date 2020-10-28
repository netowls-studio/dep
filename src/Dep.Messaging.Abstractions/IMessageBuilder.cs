/*
 * ********************************************************************************************
 * Copyright © 2006 - 2020 Wang Yucai. All rights reserved.
 * Licensed under the MS-PL License See LICENSE in the project root for license information.
 *
 *
 * Author:             Wang Yucai
 * Git Repository Url: https://github.com/netowls-studio/dep
 * Created Time:       2020/10/28 15:19:22
 * Code:               IMessageBuilder.cs
 * ********************************************************************************************
 */

namespace NetowlsStudio.Dep.Messaging
{
    /// <summary> 定义了构建消息的接口。 </summary>
    /// <seealso cref="IMessage" />
    public interface IMessageBuilder
    {
        /// <summary> 构建消息。 </summary>
        /// <returns> 实现了 <see cref="IMessage" /> 类型接口的对象实例。 </returns>
        /// <seealso cref="IMessage" />
        IMessage Build();
    }

    /// <summary> 定义了构建包含数据的消息的接口。 </summary>
    /// <typeparam name="TData"> 消息数据的类型。 </typeparam>
    /// <seealso cref="IMessageBuilder" />
    public interface IMessageBuilder<TData> : IMessageBuilder
    {
        /// <summary> 构建消息。 </summary>
        /// <returns> 实现了 <see cref="IMessage{TData}" /> 类型接口的对象实例。 </returns>
        /// <seealso cref="IMessage{TData}" />
        new IMessage<TData> Build();

        /// <summary> 设置消息数据。 </summary>
        /// <param name="messageData"> <typeparamref name="TData" /> 类型的消息数据。 </param>
        /// <returns> 实现了 <see cref="IMessageBuilder{TData}" /> 类型接口的对象实例。 </returns>
        /// <seealso cref="IMessageBuilder{TData}" />
        IMessageBuilder<TData> WithMessageData(TData messageData);
    }
}