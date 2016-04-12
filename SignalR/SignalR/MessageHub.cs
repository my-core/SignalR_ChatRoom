using Microsoft.AspNet.SignalR;
using Microsoft.AspNet.SignalR.Hubs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace SignalR
{
    /// <summary>
    /// Message集线器类
    /// </summary>
    [HubName("messageHub")]
    public class MessageHub : Hub
    {
        /// <summary>
        /// 消息广播处理类对象
        /// </summary>
        private readonly MessageHandler _messageHandler;

        /// <summary>
        /// 默认构造函数
        /// </summary>
        public MessageHub() 
            : this(MessageHandler.Instance) { }

        /// <summary>
        /// 构造函数
        /// </summary>
        /// <param name="messageHandler"></param>
        public MessageHub(MessageHandler messageHandler)
        {
            _messageHandler = messageHandler;
        }

        /// <summary>
        /// 供客户端调用的方法
        /// </summary>
        /// <param name="message"></param>
        public void SendMessage(Message message)
        {
            Clients.All.showMessage(message);
        }
    }
}