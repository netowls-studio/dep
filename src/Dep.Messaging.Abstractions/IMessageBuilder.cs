/*
 * ********************************************************************************************
 * Copyright © 2006 - 2020 Wang Yucai. All rights reserved.
 * Licensed under the MS-PL License See LICENSE in the project root for license information.
 *
 *
 * Author:             Wang Yucai
 * Git Repository Url: https://github.com/netowls-studio/dep
 * Created Time:       2020/10/27 13:44:14
 * Code:               IMessageBuilder.cs
 * ********************************************************************************************
 */

namespace NetowlsStudio.Dep.Messaging
{
    /// <summary> 定义了构建消息的接口。 </summary>
    /// <typeparam name="TData"> 消息数据类型。 </typeparam>
    public interface IMessageBuilder<TData>
    {
        /// <summary> 构建 <typeparamref name="TMessage" /> 类型的对象实例。 </summary>
        /// <typeparam name="TMessage"> 实现了 <see cref="IMessage{TData}" /> 类型接口的类型。 </typeparam>
        /// <returns> 实现了 <see cref="IMessage{TData}" /> 类型接口的对象实例。 </returns>
        /// <seealso cref="IMessage{TData}" />
        TMessage Build<TMessage>() where TMessage : class, IMessage<TData>;

        /// <summary> 设置消息数据。 </summary>
        /// <param name="data"> <typeparamref name="TData" /> 类型的消息数据。 </param>
        /// <returns> 实现了 <see cref="IMessageBuilder{TData}" /> 类型接口的对象实例。 </returns>
        /// <seealso cref="IMessageBuilder{TData}" />
        IMessageBuilder<TData> WithData(TData data);
    }
}