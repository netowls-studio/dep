/*
 * ********************************************************************************************
 * Copyright © 2006 - 2020 Wang Yucai. All rights reserved.
 * Licensed under the MS-PL License See LICENSE in the project root for license information.
 *
 *
 * Author:             Wang Yucai
 * Git Repository Url: https://github.com/netowls-studio/dep
 * Created Time:       2020/10/16 10:33:30
 * Code:               BasicCredentialsOptionsBuilder.cs
 * ********************************************************************************************
 */

namespace NetowlsStudio.Dep.Configuration
{
    /// <summary> 提供了构建 <see cref="BasicCredentialsOptions" /> 类型的对象实例相关的方法。 </summary>
    /// <seealso cref="IObjectBuilder{T}" />
    /// <seealso cref="BasicCredentialsOptions" />
    public class BasicCredentialsOptionsBuilder : IObjectBuilder<BasicCredentialsOptions>
    {
        /// <summary> 口令。 </summary>
        /// <value> 设置或获取一个字符串，用于表示口令。 </value>
        protected virtual string Password { get; set; }

        /// <summary> 用户名。 </summary>
        /// <value> 设置或获取一个字符串，用于表示用户名。 </value>
        protected virtual string UserName { get; set; }

        /// <summary> 构建 <see cref="BasicCredentialsOptions" /> 类型的对象实例。 </summary>
        /// <returns> <see cref="BasicCredentialsOptions" /> 类型的对象实例。 </returns>
        /// <seealso cref="BasicCredentialsOptions" />
        public virtual BasicCredentialsOptions Build()
        {
            return new BasicCredentialsOptions(UserName, Password);
        }

        /// <summary> 设置口令。 </summary>
        /// <param name="password"> 口令。 </param>
        /// <returns> <see cref="BasicCredentialsOptionsBuilder" /> 类型的对象实例。 </returns>
        public virtual BasicCredentialsOptionsBuilder WithPassword(string password)
        {
            Password = password;
            return this;
        }

        /// <summary> 设置用户名。 </summary>
        /// <param name="userName"> 用户名。 </param>
        /// <returns> <see cref="BasicCredentialsOptionsBuilder" /> 类型的对象实例。 </returns>
        public virtual BasicCredentialsOptionsBuilder WithUserName(string userName)
        {
            UserName = userName;
            return this;
        }
    }
}