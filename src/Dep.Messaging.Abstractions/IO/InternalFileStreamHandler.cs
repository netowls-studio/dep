/*
 * ********************************************************************************************
 * Copyright © 2006 - 2020 Wang Yucai. All rights reserved.
 * Licensed under the MS-PL License See LICENSE in the project root for license information.
 *
 *
 * Author:             Wang Yucai
 * Git Repository Url: https://github.com/netowls-studio/dep
 * Created Time:       2020/10/30 10:57:41
 * Code:               InternalFileStreamHandler.cs
 * ********************************************************************************************
 */

using System;
using System.IO;

namespace NetowlsStudio.Dep.Messaging.IO
{
    /// <summary> 提供了操作文件流相关的方法（内部的）。 </summary>
    internal class InternalFileStreamHandler
    {
        /// <summary> 用于初始化一个 <see cref="InternalFileStreamHandler" /> 类型的对象实例。 </summary>
        internal InternalFileStreamHandler()
        {
        }

        /// <summary> 打开文件并获取只读的文件流。 </summary>
        /// <param name="file">
        /// 需要打开的文件。
        /// <para> <see cref="FileInfo" /> 类型的对象实例。 </para>
        /// </param>
        /// <returns> <see cref="FileStream" /> 类型的对象实例。 </returns>
        /// <seealso cref="FileInfo" />
        /// <seealso cref="FileStream" />
        /// <exception cref="ArgumentNullException"> </exception>
        /// <exception cref="FileNotFoundException"> </exception>
        /// <exception cref="UnauthorizedAccessException"> </exception>
        /// <exception cref="DirectoryNotFoundException"> </exception>
        /// <exception cref="IOException"> </exception>
        internal FileStream OpenAndRead(FileInfo file)
        {
            if (file == null)
                throw new ArgumentNullException(nameof(file), string.Format(DepException.MessageTemplate, "未提供有效的文件信息"));
            if (!file.Exists)
                throw new FileNotFoundException(string.Format(DepException.MessageTemplate, $"目标文件 “{file.FullName}” 不存在"), file.FullName);
            return file.OpenRead();
        }
    }
}