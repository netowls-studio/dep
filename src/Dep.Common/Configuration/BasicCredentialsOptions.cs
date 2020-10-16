/*
 * ********************************************************************************************
 * Copyright © 2006 - 2020 Wang Yucai. All rights reserved.
 * Licensed under the MS-PL License See LICENSE in the project root for license information.
 *
 *
 * Author:             Wang Yucai
 * Git Repository Url: https://github.com/netowls-studio/dep
 * Created Time:       2020/10/16 10:29:22
 * Code:               BasicCredentialsOptions.cs
 * ********************************************************************************************
 */

namespace NetowlsStudio.Dep.Configuration
{
    /// <summary> 提供了用户名、口令基础身份认证凭据相关的配置信息。 </summary>
    /// <seealso cref="IDepOptions" />
    public class BasicCredentialsOptions : IDepOptions
    {
        /// <summary> 用于初始化一个 <see cref="BasicCredentialsOptions" /> 类型的对象实例。 </summary>
        public BasicCredentialsOptions()
        {
        }

        /// <summary> 用于初始化一个 <see cref="BasicCredentialsOptions" /> 类型的对象实例。 </summary>
        /// <param name="userName"> 用户名。 </param>
        /// <param name="password"> 口令。 </param>
        public BasicCredentialsOptions(string userName, string password)
        {
            UserName = userName;
            Password = password;
        }

        /// <summary> 口令。 </summary>
        /// <value> 设置或获取一个字符串，用于表示口令。 </value>
        public virtual string Password { get; set; }

        /// <summary> 用户名。 </summary>
        /// <value> 设置或获取一个字符串，用于表示用户名。 </value>
        public virtual string UserName { get; set; }
    }
}