using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace SignalR
{
    /// <summary>
    /// 全局信息类
    /// </summary>
    public class GlobalInfo
    {
        /// <summary>
        /// 消息广播处理类对象实例
        /// </summary>
        public static SignalR.MessageHandler MessageHandler { get { return SignalR.MessageHandler.Instance; } }
    }
}