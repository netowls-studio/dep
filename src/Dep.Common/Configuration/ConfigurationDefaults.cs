/*
 * ********************************************************************************************
 * Copyright © 2006 - 2020 Wang Yucai. All rights reserved.
 * Licensed under the MS-PL License See LICENSE in the project root for license information.
 *
 *
 * Author:             Wang Yucai
 * Git Repository Url: https://github.com/netowls-studio/dep
 * Created Time:       2020/10/19 12:16:59
 * Code:               ConfigurationDefaults.cs
 * ********************************************************************************************
 */

using System;
using System.IO;

namespace NetowlsStudio.Dep.Configuration
{
    /// <summary> 提供了配置相关的默认值。 </summary>
    public static class ConfigurationDefaults
    {
        /// <summary> 配置文件存放文件夹名称。 </summary>
        public const string StorageFolderName = "app_data";

        /// <summary>
        /// 配置文件存放路径。
        /// <para> <see cref="DirectoryInfo" /> 类型的对象实例。 </para>
        /// </summary>
        /// <seealso cref="DirectoryInfo" />
        public static readonly DirectoryInfo StoragePath = new DirectoryInfo(Path.Combine(AppDomain.CurrentDomain.BaseDirectory, StorageFolderName));
    }
}