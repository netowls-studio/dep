/*
 * ********************************************************************************************
 * Copyright © 2006 - 2020 Wang Yucai. All rights reserved.
 * Licensed under the MS-PL License See LICENSE in the project root for license information.
 *
 *
 * Author:             Wang Yucai
 * Git Repository Url: https://github.com/netowls-studio/dep
 * Created Time:       2020/10/26 11:55:47
 * Code:               MessageType.cs
 * ********************************************************************************************
 */

namespace NetowlsStudio.Dep.Messaging
{
    /// <summary> 定义了消息类型枚举。 </summary>
    public enum MessageType
    {
        /// <summary> 正常的消息。此类消息主要面向数据发布、数据订阅等。 </summary>
        Normal = 1,

        /// <summary> 用于同步服务器、监听器、代理间的状态同步信息。 </summary>
        StateSynchronization = 2,

        /// <summary> 死信消息。此类消息主要用户补发订阅失败的数据等。 </summary>
        Deadletter = 3,

        /// <summary> 中转的消息。此类消息用于比较复杂的网络环境。在不同网络、服务器中中转搬运数据。 </summary>
        Transition = 4,

        /// <summary> 回执消息。 </summary>
        Receipt = 5
    }
}