/*
 * ********************************************************************************************
 * Copyright © 2006 - 2020 Wang Yucai. All rights reserved.
 * Licensed under the MS-PL License See LICENSE in the project root for license information.
 *
 *
 * Author:             Wang Yucai
 * Git Repository Url: https://github.com/netowls-studio/dep
 * Created Time:       2020/11/2 14:20:41
 * Code:               IMember.cs
 * ********************************************************************************************
 */

namespace NetowlsStudio.Dep.Server
{
    /// <summary> 定义了 DEP 应用程序信息的接口。 </summary>
    public interface IMember
    {
        /// <summary> 成员对外网关端口号。 </summary>
        /// <value> 设置或获取一个值，用于表示成员对外网关端口号。 </value>
        int GatewayPort { get; set; }

        /// <summary> 成员唯一标识。 </summary>
        /// <value> 设置或获取一个字符串，用于表示成员唯一标识。 </value>
        string Id { get; set; }

        /// <summary> 成员主机 IP 地址。 </summary>
        /// <value> 获取一个字符串，用于表示成员主机 IP 地址。 </value>
        string IPAddress { get; set; }

        /// <summary> 成员应用角色。 </summary>
        /// <value> 设置或获取一个 <see cref="ApplicationRole" /> 类型的值，用于表示成员应用角色。 </value>
        /// <seealso cref="ApplicationRole" />
        ApplicationRole Role { get; set; }
    }
}