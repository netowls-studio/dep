/*
 * ********************************************************************************************
 * Copyright © 2006 - 2020 Wang Yucai. All rights reserved.
 * Licensed under the MS-PL License See LICENSE in the project root for license information.
 *
 *
 * Author:             Wang Yucai
 * Git Repository Url: https://github.com/netowls-studio/dep
 * Created Time:       2020/10/22 11:38:13
 * Code:               JsonSerializerDefaultSettings.cs
 * ********************************************************************************************
 */

using Newtonsoft.Json;
using Newtonsoft.Json.Serialization;
using System.Globalization;

namespace NetowlsStudio.Dep.Runtime.Serializations.Providers
{
    /// <summary> 提供了 JSON 序列化相关的默认配置（静态的）。 </summary>
    public static class JsonSerializerDefaultSettings
    {
        /// <summary>
        /// 默认的 JSON 序列化设置。
        /// <para> <see cref="JsonSerializerSettings" /> 类型的对象实例。 </para>
        /// </summary>
        /// <seealso cref="JsonSerializerSettings" />
        public static readonly JsonSerializerSettings Settings = new JsonSerializerSettings()
        {
            CheckAdditionalContent = false,
            ConstructorHandling = ConstructorHandling.AllowNonPublicDefaultConstructor,
            ContractResolver = new CamelCasePropertyNamesContractResolver(),
            Culture = CultureInfo.CurrentCulture,
            DateFormatHandling = DateFormatHandling.MicrosoftDateFormat,
            DateFormatString = "yyyy-MM-dd HH:mm",
            DateParseHandling = DateParseHandling.DateTime,
            DateTimeZoneHandling = DateTimeZoneHandling.Utc,
            DefaultValueHandling = DefaultValueHandling.Include,
            Error = (sender, e) => throw e.ErrorContext.Error,
            FloatFormatHandling = FloatFormatHandling.Symbol,
            FloatParseHandling = FloatParseHandling.Decimal,
            Formatting = Formatting.Indented,
            MaxDepth = 0x400,
            MetadataPropertyHandling = MetadataPropertyHandling.Ignore,
            MissingMemberHandling = MissingMemberHandling.Ignore,
            NullValueHandling = NullValueHandling.Include,
            ObjectCreationHandling = ObjectCreationHandling.Auto,
            PreserveReferencesHandling = PreserveReferencesHandling.None,
            ReferenceLoopHandling = ReferenceLoopHandling.Error,
            StringEscapeHandling = StringEscapeHandling.EscapeHtml,
            TypeNameAssemblyFormatHandling = TypeNameAssemblyFormatHandling.Simple,
            TypeNameHandling = TypeNameHandling.None
        };

        /// <summary> <see cref="JsonSerializerDefaultSettings" /> 类型的静态构造方法。 </summary>
        static JsonSerializerDefaultSettings()
        {
        }
    }
}