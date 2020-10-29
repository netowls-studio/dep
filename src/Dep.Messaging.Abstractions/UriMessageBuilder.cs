/*
 * ********************************************************************************************
 * Copyright © 2006 - 2020 Wang Yucai. All rights reserved.
 * Licensed under the MS-PL License See LICENSE in the project root for license information.
 *
 *
 * Author:             Wang Yucai
 * Git Repository Url: https://github.com/netowls-studio/dep
 * Created Time:       2020/10/29 10:13:24
 * Code:               UriMessageBuilder.cs
 * ********************************************************************************************
 */

namespace NetowlsStudio.Dep.Messaging
{
    /// <summary>
    /// 提供了构建 <see cref="UriMessage" /> 类型消息相关的方法。
    /// <para> 密闭的，不可以从此类型派生。 </para>
    /// </summary>
    /// <seealso cref="MessageBuilder{TData}" />
    /// <seealso cref="UriMessage" />
    /// <remarks> 密闭的，不可以从此类型派生。 </remarks>
    public sealed class UriMessageBuilder : MessageBuilder<string>
    {
        /// <summary> 用于初始化一个 <see cref="UriMessageBuilder" /> 类型的对象实例。 </summary>
        public UriMessageBuilder()
        {
        }

        /// <summary> 构建消息。 </summary>
        /// <returns> <see cref="UriMessage" /> 类型的对象实例。 </returns>
        /// <seealso cref="UriMessage" />
        public new UriMessage Build() => new UriMessage(MessageData);

        /// <summary> 设置消息数据。 </summary>
        /// <param name="messageData"> <see cref="string" /> 类型的消息数据。 </param>
        /// <returns> 实现了 <see cref="IMessageBuilder{TData}" /> 类型接口的对象实例。 </returns>
        /// <seealso cref="IMessageBuilder{TData}" />
        public override IMessageBuilder<string> WithMessageData(string messageData) => WithUri(messageData);

        /// <summary> 设置 URI 地址。 </summary>
        /// <param name="uri"> URI 地址。 </param>
        /// <returns> <see cref="UriMessage" /> 类型的对象实例。 </returns>
        public UriMessageBuilder WithUri(string uri)
        {
            MessageData = uri;
            return this;
        }
    }
}