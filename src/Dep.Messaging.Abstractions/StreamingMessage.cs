/*
 * ********************************************************************************************
 * Copyright © 2006 - 2020 Wang Yucai. All rights reserved.
 * Licensed under the MS-PL License See LICENSE in the project root for license information.
 *
 *
 * Author:             Wang Yucai
 * Git Repository Url: https://github.com/netowls-studio/dep
 * Created Time:       2020/10/30 10:01:57
 * Code:               StreamMessage.cs
 * ********************************************************************************************
 */

using NetowlsStudio.Dep.Messaging.IO;
using Newtonsoft.Json;
using System;
using System.Xml.Serialization;

namespace NetowlsStudio.Dep.Messaging
{
    /// <summary> 提供了 IO 流相关的消息。 </summary>
    /// <seealso cref="Message{TData}" />
    /// <seealso cref="StreamSummary" />
    [Serializable]
    public class StreamingMessage : Message<StreamSummary>
    {
        /// <summary> 用于初始化一个 <see cref="StreamingMessage" /> 类型的对象实例。 </summary>
        public StreamingMessage()
        {
        }

        /// <summary> IO 流摘要信息。 </summary>
        /// <value> 获取 <see cref="StreamSummary" /> 类型的对象实例，用于表示 IO 流摘要信息。 </value>
        /// <seealso cref="StreamSummary" />
        [JsonIgnore, XmlIgnore]
        public virtual StreamSummary StreamInfo => MessageData;
    }
}