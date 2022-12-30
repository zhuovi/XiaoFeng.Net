# XiaoFeng.Net

![fayelf](https://user-images.githubusercontent.com/16105174/197918392-29d40971-a8a2-4be4-ac17-323f1d0bed82.png)

![GitHub top language](https://img.shields.io/github/languages/top/zhuovi/xiaofeng.net?logo=github)
![GitHub License](https://img.shields.io/github/license/zhuovi/xiaofeng.net?logo=github)
![Nuget Downloads](https://img.shields.io/nuget/dt/xiaofeng.net?logo=nuget)
![Nuget](https://img.shields.io/nuget/v/xiaofeng.net?logo=nuget)
![Nuget (with prereleases)](https://img.shields.io/nuget/vpre/xiaofeng.net?label=dev%20nuget&logo=nuget)

Nuget：XiaoFeng.Net

QQ群号：748408911 

QQ群二维码： 

![QQ 群](https://user-images.githubusercontent.com/16105174/198058269-0ea5928c-a2fc-4049-86da-cca2249229ae.png)

公众号： 

![畅聊了个科技](https://user-images.githubusercontent.com/16105174/198059698-adbf29c3-60c2-4c76-b894-21793b40cf34.jpg)

源码： https://github.com/zhuovi/XiaoFeng.Net

教程： https://www.yuque.com/fayelf/xiaofeng


XiaoFeng网络库，封装了Socket客户端，服务端，根据当前库可轻松实现订阅，发布等功能。


# XiaoFeng.Net Socket操作

## 服务端实例

```csharp
//新建一个服务端,同时支持websocket,socket客户端连接
var SocketServer = new XiaoFeng.Net.NetServer<XiaoFeng.Net.ServerSession>(8888)
{
    //是否启用ping
    IsPing = true,
    //是否启用新行
    IsNewLine = true,
    //传输编码
    Encoding = System.Text.Encoding.UTF8
};
SocketServer.SocketAuth = session =>
{
    //判断 客户端是否符合认证,不符合则直接返回false即可
    return true;
};
SocketServer.OnClientError += (session,e)=>
{
    //客户端出错事件
};
SocketServer.OnDisconnected += (session,e)=>
{
    //断开连接事件
};
SocketServer.OnError += (session, e) =>
{
    //服务端出错事件
};
SocketServer.OnNewConnection += (session, e) =>
{
    //有新的连接事件
};
SocketServer.OnMessageByte += (session,message,e)=>
{
    //接收消息事件

    session.Send("回复客户端消息");
};
SocketServer.OnStart += (socket,e)=>
{
    //服务端启动事件
};
SocketServer.OnStop += (socket,e)=>
{
    //服务端停止事件
};
//启动监听
SocketServer.Start();
//发送消息给所有客户端
SocketServer.Send("发送消息");
//添加黑名单
SocketServer.AddIpBlack("124.2.2.2");
```

## 客户端实例

```csharp
var SocketClient = new XiaoFeng.Net.NetClient<XiaoFeng.Net.ClientSession>("127.0.0.1", 8888);
SocketClient.OnStart += (socket, e) =>
{
    //启动消息
};
SocketClient.OnClose += (socket,e)=>
{
    //关闭消息
};
SocketClient.OnDisconnected += (session,e)=>{
    //断开连接消息
};
SocketClient.OnError += (socket,e)=>
{
    //出错消息
};

SocketClient.OnMessageByte += (session,message,e)=>
{
//接收信息
};

//启动客户端
SocketClient.Start();

SocketClient.Send("发送消息");
SocketClient.Subscribe("订阅频道");

SocketClient.UnSubscribe("取消订阅频道");
```

# 作者介绍

* 网址 : http://www.fayelf.com
* QQ : 7092734
* EMail : jacky@fayelf.com