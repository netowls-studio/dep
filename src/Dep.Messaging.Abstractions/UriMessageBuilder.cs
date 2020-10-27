/*
 * ********************************************************************************************
 * Copyright © 2006 - 2020 Wang Yucai. All rights reserved.
 * Licensed under the MS-PL License See LICENSE in the project root for license information.
 *
 *
 * Author:             Wang Yucai
 * Git Repository Url: https://github.com/netowls-studio/dep
 * Created Time:       2020/10/27 14:02:28
 * Code:               UriMessageBuilder.cs
 * ********************************************************************************************
 */

using System;

namespace NetowlsStudio.Dep.Messaging
{
    /// <summary> 提供了构建 <see cref="UriMessage" /> 类型的对象实例相关的方法。 </summary>
    /// <seealso cref="Uri" />
    /// <seealso cref="MessageBuilder{TData}" />
    /// <seealso cref="UriMessage" />
    public class UriMessageBuilder : MessageBuilder<Uri>
    {
        /// <summary> 用于初始化一个 <see cref="UriMessageBuilder" /> 类型的对象实例。 </summary>
        public UriMessageBuilder()
        {
        }

        /// <summary> 构建实现了 <see cref="IMessage{TData}" /> 类型接口的对象实例。 </summary>
        /// <returns> 实现了 <see cref="IMessage{TData}" /> 类型接口的对象实例。 </returns>
        /// <seealso cref="IMessage{TData}" />
        /// <seealso cref="Message{TData}" />
        public override IMessage<Uri> Build() => new UriMessage(MessageData);

        /// <summary> 设置 URI 地址。 </summary>
        /// <param name="uri"> <see cref="Uri" /> 类型的对象实例。 </param>
        /// <returns> 实现了 <see cref="IMessageBuilder{TData}" /> 类型接口的对象实例。 </returns>
        /// <seealso cref="IMessageBuilder{TData}" />
        /// <seealso cref="Uri" />
        /// <seealso cref="UriMessageBuilder" />
        public virtual IMessageBuilder<Uri> WithUri(Uri uri) => WithData(uri);

        /// <summary> 设置 URI 地址。 </summary>
        /// <param name="uri"> URI 地址。 </param>
        /// <returns> 实现了 <see cref="IMessageBuilder{TData}" /> 类型接口的对象实例。 </returns>
        /// <seealso cref="IMessageBuilder{TData}" />
        /// <seealso cref="UriMessageBuilder" />
        public virtual IMessageBuilder<Uri> WithUri(string uri) => WithUri(new Uri(uri));
    }
}