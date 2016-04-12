<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Notice.aspx.cs" Inherits="SignalR.Notice" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <meta http-equiv="Content-Type" content="text/html; charset=utf-8" />
    <title></title>
    <script src="Scripts/jquery-1.6.4.min.js"></script>
    <script src="Scripts/jquery.signalR-2.2.0.min.js"></script>
    <%--以下引用是必须的（该目录是不存在的，但是SignalR运行必须的虚拟目录）--%>
    <script src="/SignalR/hubs"></script>
    <script>
        $(function () {
            //生成客户端集线器代理(注意：这里的messageHub与集线器MessageHub的HubName属性要一致)
            var msgHub = $.connection.messageHub;
            //添加客户端hub方法以供服务端调用
            msgHub.client.showMessage = function (msgObj) {
                //(向列表中添加信息)。msgObj是一个json对象
                $('#msg-list').append('<li>' + msgObj.content + '</li>');
            }
            //日志输出，以备调试使用
            $.connection.hub.logging = true;
            //开启hub连接
            $.connection.hub.start();
        });
    </script>
</head>
<body>
    <form id="form1" runat="server">
    <div>
    <ul id="msg-list">
        
    </ul>
    </div>
    </form>
</body>
</html>
