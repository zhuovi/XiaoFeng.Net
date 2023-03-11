# XiaoFeng.Net

![fayelf](https://user-images.githubusercontent.com/16105174/197918392-29d40971-a8a2-4be4-ac17-323f1d0bed82.png)

![GitHub top language](https://img.shields.io/github/languages/top/zhuovi/xiaofeng.net?logo=github)
![GitHub License](https://img.shields.io/github/license/zhuovi/xiaofeng.net?logo=github)
![Nuget Downloads](https://img.shields.io/nuget/dt/xiaofeng.net?logo=nuget)
![Nuget](https://img.shields.io/nuget/v/xiaofeng.net?logo=nuget)
![Nuget (with prereleases)](https://img.shields.io/nuget/vpre/xiaofeng.net?label=dev%20nuget&logo=nuget)

Nuget：XiaoFeng.Net

| QQ群号 | QQ群 | 公众号 |
| :----:| :----: | :----: |
| 748408911  | ![QQ 群](https://user-images.githubusercontent.com/16105174/198058269-0ea5928c-a2fc-4049-86da-cca2249229ae.png) | ![畅聊了个科技](https://user-images.githubusercontent.com/16105174/198059698-adbf29c3-60c2-4c76-b894-21793b40cf34.jpg) |

源码： https://github.com/zhuovi/XiaoFeng.Net

教程： https://www.yuque.com/fayelf/xiaofeng


XiaoFeng网络库，封装了Socket客户端，服务端，根据当前库可轻松实现订阅，发布等功能。

## XiaoFeng.Net

XiaoFeng.Net generator with [XiaoFeng.Net](https://github.com/zhuovi/XiaoFeng.Net).

## Install

.NET CLI

```
$ dotnet add package XiaoFeng.Net --version 2.0.5
```

Package Manager

```
PM> Install-Package XiaoFeng.Net --Version 2.0.5
```

PackageReference

```
<PackageReference Include="XiaoFeng.Net" Version="2.0.5" />
```
Paket CLI

```
> paket add XiaoFeng.Net --version 2.0.5
```

Script & Interactive

```
> #r "nuget: XiaoFeng.Net, 2.0.5"
```

Cake

```
// Install XiaoFeng.Net as a Cake Addin
#addin nuget:?package=XiaoFeng.Net&version=2.0.5

// Install XiaoFeng.Net as a Cake Tool
#tool nuget:?package=XiaoFeng.Net&version=2.0.5
```

# XiaoFeng.Net Socket操作

## 服务端实例

```csharp
//新建一个服务端,同时支持websocket,socket客户端连接
var server = new NetServer<ServerSession>(8088)
{
    //是否启用ping
    IsPing = true,
    //是否启用新行
    IsNewLine = true,
    //传输编码
    Encoding = System.Text.Encoding.UTF8,
    //认证 认证不过则直接断开
    SocketAuth = s =>
    {
        //判断 客户端是否符合认证,不符合则直接返回false即可
        return true;
    }
};
server.OnStart += (s, e) =>
{
    //服务端启动事件
    Console.WriteLine($"启动!-{DateTime.Now:yyyy-MM-dd HH:mm:ss.fffffff}");
};
server.OnNewConnection += (s, e) =>
{
    //客户端新连接事件
    Console.WriteLine($"新连接-{DateTime.Now:yyyy-MM-dd HH:mm:ss.fffffff}");
    //给当前客户端设置一个频道名  为后边按频道名发送作准备
    //一个客户端可以订阅多个频道
    //websocket可以从头里面获取标识
    //如果非websocket 可以从消息里设置频道消息
    if (s.Headers.IndexOf("Channel:a") > 0)
        s.AddChannel("a");
    else
        s.AddChannel("b");
};
server.OnDisconnected += (s, e) =>
{
    //客户端断开连接事件
    Console.WriteLine($"断开连接!-{DateTime.Now:yyyy-MM-dd HH:mm:ss.fffffff}");
};
server.OnMessage += (s, m, e) =>
{
    //接收消息事件
    if (m.IndexOf("Channel:a") > 0)
    {
        s.AddChannel("a");
        return;
    }
    else if (m.IndexOf("Channel:b") > 0)
    {
        s.AddChannel("b");
        return;
    }
    Console.WriteLine($"消息-{m}-{DateTime.Now:yyyy-MM-dd HH:mm:ss.fffffff}");
    //把当前消息发送到频道名为a的所有客户端
    server.Send("a", Encoding.UTF8.GetBytes("消息"));
    //回复当前客户端消息
    s.Send("消息");
    //发送消息给所有客户端
    server.Send("消息");
};
server.OnMessageByte += (session, message, e) =>
{
    //接收消息事件
    session.Send("回复客户端消息");
};
server.OnError += (s, e) =>
{
    //服务端出错事件
    Console.WriteLine($"出错-{e.Message}-{DateTime.Now:yyyy-MM-dd HH:mm:ss.fffffff}");
};
server.OnClientError += (session, e) =>
{
    //客户端出错事件
};
server.OnError += (session, e) =>
{
    //服务端出错事件
};
server.OnStop += (socket, e) =>
{
    //服务端停止事件
};
server.Start();
//添加黑名单
server.AddIpBlack("10.10.10.10");
//移除黑名单
server.RemoveIpBlack("10.10.10.10");
//清空黑名单
server.ClearIpBlack();
//断开所有客户端
server.ClearQueue();
//在线客户端列表 复制出来的
var clients = server.GetData();
//在线客户端列表 原列表
var clients1 = server.ConnectionSocketList;
```

## 客户端实例

```csharp
var client = new XiaoFeng.Net.NetClient<XiaoFeng.Net.ClientSession>("127.0.0.1", 8888);
client.OnStart += (socket, e) =>
{
    //启动消息
};
client.OnClose += (socket,e)=>
{
    //关闭消息
};
client.OnDisconnected += (session,e)=>{
    //断开连接消息
};
client.OnError += (socket,e)=>
{
    //出错消息
};
client.OnMessageByte += (session,message,e)=>
{
//接收信息
};
//启动客户端
client.Start();

client.Send("发送消息");

client.Subscribe("订阅频道");
client.UnSubscribe("取消订阅频道");
```

# 作者介绍

* 网址 : http://www.fayelf.com
* QQ : 7092734
* EMail : jacky@fayelf.com