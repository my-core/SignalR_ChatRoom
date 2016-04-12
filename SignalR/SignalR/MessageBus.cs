using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace SignalR
{
    /// <summary>
    /// 消息总线类MessageBus
    /// </summary>
    public class MessageBus
    {
        /// <summary>
        /// 发送消息
        /// </summary>
        /// <param name="message"></param>
        public static void SendMessage(Message message)
        {
            GlobalInfo.MessageHandler.SendMessage(message);
        }
    }
}