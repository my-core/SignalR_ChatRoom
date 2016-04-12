using Microsoft.AspNet.SignalR;
using Microsoft.AspNet.SignalR.Hubs;
using Microsoft.AspNet.SignalR.Messaging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace SignalR
{
    /// <summary>
    /// Message消息广播处理类
    /// </summary>
    public class MessageHandler
    {
        private readonly static Lazy<MessageHandler> _instance =
            new Lazy<MessageHandler>(() =>
               new MessageHandler(GlobalHost.ConnectionManager.GetHubContext<MessageHub>().Clients));

        private MessageHandler(IHubConnectionContext<dynamic> clients)
        {
            Clients = clients;
        }
        /// <summary>
        /// 消息广播处理类对象实例
        /// </summary>
        public static MessageHandler Instance { get { return _instance.Value; } }
        /// <summary>
        /// 集线器连接上下文 客户端集
        /// </summary>
        public IHubConnectionContext<dynamic> Clients { get; set; }

        /// <summary>
        /// 向所有客户端发送消息
        /// </summary>
        /// <param name="msg"></param>
        public void SendMessage(Message msg)
        {
            //这里的showMessage方法是动态解析的，必须与客户端方法一致，方可调用成功
            Clients.All.showMessage(msg);
        }
    }
}