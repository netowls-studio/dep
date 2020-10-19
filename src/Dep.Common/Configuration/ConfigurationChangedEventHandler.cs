/*
 * ********************************************************************************************
 * Copyright © 2006 - 2020 Wang Yucai. All rights reserved.
 * Licensed under the MS-PL License See LICENSE in the project root for license information.
 * 
 * 
 * Author:             Wang Yucai
 * Git Repository Url: https://github.com/netowls-studio/dep
 * Created Time:       2020/10/19 11:31:03
 * Code:               ConfigurationChangedEventHandler.cs
 * ********************************************************************************************
 */

namespace NetowlsStudio.Dep.Configuration
{
    /// <summary> 提供了配置变更事件相关的委托。 </summary>
    /// <param name="sender"> 触发此事件的对象实例。 </param>
    /// <param name="e">
    /// 事件参数。
    /// <para> <see cref="ConfigurationChangedEventArgs" /> 类型的对象实例。 </para>
    /// </param>
    /// <seealso cref="ConfigurationChangedEventArgs" />
    public delegate void ConfigurationChangedEventHandler(object sender, ConfigurationChangedEventArgs e);
}
