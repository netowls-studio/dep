/*
 * ********************************************************************************************
 * Copyright © 2006 - 2020 Wang Yucai. All rights reserved.
 * Licensed under the MS-PL License See LICENSE in the project root for license information.
 *
 *
 * Author:             Wang Yucai
 * Git Repository Url: https://github.com/netowls-studio/dep
 * Created Time:       2020/11/2 10:10:53
 * Code:               MessageType.cs
 * ********************************************************************************************
 */

namespace NetowlsStudio.Dep.Messaging
{
    /// <summary> 定义了消息类型枚举。 </summary>
    public enum MessageType : int
    {
        /// <summary> 数据分发消息。 </summary>
        Distribution = 1,

        /// <summary> 维护性消息。 </summary>
        Maintenance = 2,

        /// <summary> 重试消息。 </summary>
        Retry = 3,

        /// <summary> 回执消息。 </summary>
        Receipt = 4,

        /// <summary> 补发申请。 </summary>
        Reissue = 5,

        /// <summary> 群集状态同步消息。 </summary>
        StateSynchronized = 6,

        /// <summary> 默认的消息。等同于 <see cref="MessageType.Distribution" />。 </summary>
        /// <seealso cref="MessageType.Distribution" />
        Default = 65535
    }
}