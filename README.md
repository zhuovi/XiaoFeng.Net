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
$ dotnet add package XiaoFeng.Net --version 3.1.5
```

Package Manager

```
PM> Install-Package XiaoFeng.Net --Version 3.1.5
```

PackageReference

```
<PackageReference Include="XiaoFeng.Net" Version="3.1.5" />
```
Paket CLI

```
> paket add XiaoFeng.Net --version 3.1.5
```

Script & Interactive

```
> #r "nuget: XiaoFeng.Net, 3.1.5"
```

Cake

```
// Install XiaoFeng.Net as a Cake Addin
#addin nuget:?package=XiaoFeng.Net&version=3.1.5

// Install XiaoFeng.Net as a Cake Tool
#tool nuget:?package=XiaoFeng.Net&version=3.1.5
```
# 更新日志

## 2023-10-08   v3.1.5

1.修复SocketClient连接DNS时的bug;

## 2023-09-26   v 3.1.4

1.优化SocketClient中NetworkDelay最小值及最大值的判断;

2.优化SocketClient中连接host为IP的bug;

3.优化XiaoFeng.Net.WebSocketClient请求头;

4.优化网络客户端;


## 2023-08-30   v 3.1.3

1.优化网络延时时服务端接收websocket客户端时偶尔拒绝连接的bug

2.SocketServer,SocketClient增加NetworkDelay网络延时属性;

3.优化SocketServer中的AcceptTcpClient方法;

## 2023-08-29   v 3.1.2

1.优化SocketClient,在websocket客户端未解包的Bug;

2.优化SocketClient第一次连接只调用OnMessage事件未调用OnMessageByte事件的Bug;

3.SocketClient增加LastMessageTime最后通讯时间,ConnectedTime连接时间;

4.优化识别客户端是WebSocket还是Socket;

5.SocketClient连接方法增加返回类型;

## 2023-08-22   v 3.1.1

1.修复postman在ssl下,一直发送消息服务端不能收到的问题;

## 2023-08-22   v 3.1.0

1.增加WebSocketClient中属性WebSocketRequest为客户端请求信息;

2.WebSocketClient增加启动传参数据WebSocketRequestOptions;

3.优化Socket网络库注释;

4.修复SocketServer每次收到消息都发送一次新连接回调的bug;


## 2023-08-03   v 3.0.0

1.重新写Socket库,SocketServer,WebSocketServer,SocketClient,WebSocketClient;

---

# XiaoFeng 类库包含库
| 命名空间 | 所属类库 | 开源状态 | 说明 | 包含功能 |
| :----| :---- | :---- | :----: | :---- |
| XiaoFeng.Prototype | XiaoFeng.Core | :white_check_mark: | 扩展库 | ToCase 类型转换<br/>ToTimestamp,ToTimestamps 时间转时间戳<br/>GetBasePath 获取文件绝对路径,支持Linux,Windows<br/>GetFileName 获取文件名称<br/>GetMatch,GetMatches,GetMatchs,IsMatch,ReplacePatten,RemovePattern 正则表达式操作<br/> |
| XiaoFeng.Net | XiaoFeng.Net | :white_check_mark: | 网络库 | XiaoFeng网络库，封装了Socket客户端，服务端（Socket,WebSocket），根据当前库可轻松实现订阅，发布等功能。|
| XiaoFeng.Http | XiaoFeng.Core | :white_check_mark: | 模拟请求库 | 模拟网络请求 |
| XiaoFeng.Data | XiaoFeng.Core | :white_check_mark: | 数据库操作库 | 支持SQLSERVER,MYSQL,ORACLE,达梦,SQLITE,ACCESS,OLEDB,ODBC等数十种数据库 |
| XiaoFeng.Cache | XiaoFeng.Core | :white_check_mark: | 缓存库 |  内存缓存,Redis,MemcachedCache,MemoryCache,FileCache缓存 |
| XiaoFeng.Config | XiaoFeng.Core | :white_check_mark: | 配置文件库 | 通过创建模型自动生成配置文件，可为xml,json,ini文件格式 |
| XiaoFeng.Cryptography | XiaoFeng.Core | :white_check_mark: | 加密算法库 | AES,DES,RSA,MD5,DES3,SHA,HMAC,RC4加密算法 |
| XiaoFeng.Excel | XiaoFeng.Excel | :white_check_mark: | Excel操作库 | Excel操作，创建excel,编辑excel,读取excel内容，边框，字体，样式等功能  |
| XiaoFeng.Ftp | XiaoFeng.Ftp | :white_check_mark: | FTP请求库 | FTP客户端 |
| XiaoFeng.IO | XiaoFeng.Core | :white_check_mark: | 文件操作库 | 文件读写操作 |
| XiaoFeng.Json | XiaoFeng.Core | :white_check_mark: | Json序列化，反序列化库 | Json序列化，反序列化库 |
| XiaoFeng.Xml | XiaoFeng.Core | :white_check_mark: | Xml序列化，反序列化库 | Xml序列化，反序列化库 |
| XiaoFeng.Log | XiaoFeng.Core | :white_check_mark: | 日志库 | 写日志文件,数据库 |
| XiaoFeng.Memcached | XiaoFeng.Memcached | :white_check_mark: | Memcached缓存库 | Memcached中间件,支持.NET框架、.NET内核和.NET标准库,一种非常方便操作的客户端工具。实现了Set,Add,Replace,PrePend,Append,Cas,Get,Gets,Gat,Gats,Delete,Touch,Stats,Stats Items,Stats Slabs,Stats Sizes,Flush_All,Increment,Decrement,线程池功能。|
| XiaoFeng.Redis | XiaoFeng.Redis | :white_check_mark: | Redis缓存库 | Redis中间件,支持.NET框架、.NET内核和.NET标准库,一种非常方便操作的客户端工具。实现了Hash,Key,String,ZSet,Stream,Log,List,订阅发布,线程池功能; |
| XiaoFeng.Threading | XiaoFeng.Core | :white_check_mark: | 线程库 | 线程任务,线程队列 |
| XiaoFeng.Mvc | XiaoFeng.Mvc | :x: | 低代码WEB开发框架 | .net core 基础类，快速开发CMS框架，真正的低代码平台，自带角色权限，WebAPI平台，后台管理，可托管到服务运行命令为:应用.exe install 服务名 服务说明,命令还有 delete 删除 start 启动  stop 停止。 |
| XiaoFeng.Proxy | XiaoFeng.Proxy | :white_check_mark: | 代理库 | 开发中 |
| XiaoFeng.TDengine | XiaoFeng.TDengine | :white_check_mark: | TDengine 客户端 | 开发中 |
| XiaoFeng.GB28181 | XiaoFeng.GB28181 | :white_check_mark: | 视频监控库，SIP类库，GB28181协议 | 开发中 |
| XiaoFeng.Onvif | XiaoFeng.Onvif | :white_check_mark: | 视频监控库Onvif协议 | XiaoFeng.Onvif 基于.NET平台使用C#封装Onvif常用接口、设备、媒体、云台等功能， 拒绝WCF服务引用动态代理生成wsdl类文件 ， 使用原生XML扩展标记语言封装参数，所有的数据流向都可控。 |


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