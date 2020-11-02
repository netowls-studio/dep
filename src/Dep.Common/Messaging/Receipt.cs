/*
 * ********************************************************************************************
 * Copyright © 2006 - 2020 Wang Yucai. All rights reserved.
 * Licensed under the MS-PL License See LICENSE in the project root for license information.
 *
 *
 * Author:             Wang Yucai
 * Git Repository Url: https://github.com/netowls-studio/dep
 * Created Time:       2020/11/2 10:16:27
 * Code:               Receipt.cs
 * ********************************************************************************************
 */

namespace NetowlsStudio.Dep.Messaging
{
    /// <summary> 定义了回执消息枚举类型。 </summary>
    public enum Receipt : int
    {
        /// <summary> 完成。 </summary>
        Ok = 200,

        /// <summary> 失败。 </summary>
        Failed = 300,

        /// <summary> 超时。 </summary>
        Timeout = 400
    }
}