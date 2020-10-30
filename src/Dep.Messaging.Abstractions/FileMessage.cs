/*
 * ********************************************************************************************
 * Copyright © 2006 - 2020 Wang Yucai. All rights reserved.
 * Licensed under the MS-PL License See LICENSE in the project root for license information.
 * 
 * 
 * Author:             Wang Yucai
 * Git Repository Url: https://github.com/netowls-studio/dep
 * Created Time:       2020/10/30 10:36:05
 * Code:               FileMessage.cs
 * ********************************************************************************************
 */

using NetowlsStudio.Dep.Messaging.IO;

namespace NetowlsStudio.Dep.Messaging
{
    /// <summary>
    /// 提供了文件型消息相关的方法。
    /// <para> 密闭的，不可以从此类型派生。 </para>
    /// </summary>
    /// <seealso cref="StreamingMessage" />
    /// <remarks> 密闭的，不可以从此类型派生。 </remarks>
    public sealed class FileMessage : StreamingMessage
    {
        /// <summary> 用于初始化一个 <see cref="FileMessage" /> 类型的对象实例。 </summary>
        public FileMessage()
        {
        }

        /// <summary> 文件流摘要信息。 </summary>
        /// <value> 获取 <see cref="FileStreamSummary" /> 类型的对象实例，用于表示文件流流摘要信息。 </value>
        /// <seealso cref="FileStreamSummary" />
        new public FileStreamSummary StreamInfo=> base.StreamInfo as FileStreamSummary;
    }
}
