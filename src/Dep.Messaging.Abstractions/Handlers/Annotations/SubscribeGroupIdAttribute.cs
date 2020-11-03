using System;

namespace NetowlsStudio.Dep.Messaging.Handlers.Annotations
{
    /// <summary>
    /// 提供了标识订阅组信息相关的方法。
    /// <para> 密闭的，不可以从此类型派生。 </para>
    /// </summary>
    /// <seealso cref="Attribute" />
    /// <seealso cref="AttributeUsageAttribute" />
    /// <seealso cref="AttributeTargets.Class" />
    /// <remarks> 密闭的，不可以从此类型派生。 </remarks>
    [AttributeUsage(AttributeTargets.Class, AllowMultiple = true, Inherited = true)]
    public sealed class SubscribeGroupIdAttribute : Attribute
    {
        private bool m_enabled;

        /// <summary> 用于初始化一个 <see cref="SubscribeGroupIdAttribute" /> 类型的对象实例。 </summary>
        /// <param name="groupId"> 需要订阅的组标识。 </param>
        public SubscribeGroupIdAttribute(string groupId)
        {
            GroupId = groupId;
            m_enabled = true;
        }

        /// <summary> 是否启用此订阅分组。 </summary>
        /// <value> 设置或获取一个值，用于表示是否启用此订阅分组。 </value>
        public bool Enabled
        {
            get { return m_enabled && !string.IsNullOrWhiteSpace(GroupId); }
            set { m_enabled = value; }
        }

        /// <summary> 需要订阅的组标识。 </summary>
        /// <value> 获取一个字符串，用于表示需要订阅的组标识。 </value>
        public string GroupId { get; }
    }
}