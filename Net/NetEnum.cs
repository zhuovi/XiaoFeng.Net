﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
/****************************************************************
*  Copyright © (2017) www.fayelf.com All Rights Reserved.       *
*  Author : jacky                                               *
*  QQ : 7092734                                                 *
*  Email : jacky@fayelf.com                                     *
*  Site : www.fayelf.com                                        *
*  Create Time : 2017-10-31 14:18:38                            *
*  Version : v 1.0.0                                            *
*  CLR Version : 4.0.30319.42000                                *
*****************************************************************/
namespace XiaoFeng.Net
{
    #region WebSocket类型
    /// <summary>
    /// WebSocket类型
    /// </summary>
    public enum WebSocketType
    {
        /// <summary>
        /// 无
        /// </summary>
        Null = 0,
        /// <summary>
        /// WS类型
        /// </summary>
        WS = 1,
        /// <summary>
        /// WSS类型
        /// </summary>
        WSS = 2
    }
    #endregion

    #region Socket 数据类型
    /// <summary>
    /// Socket 数据类型
    /// </summary>
    public enum SocketDataType
    {
        /// <summary>
        /// 字符串类型
        /// </summary>
        String = 0,
        /// <summary>
        /// 16进制类型 一般用于串口传输
        /// </summary>
        HexString = 1
    }
    #endregion

    #region Socket类型
    /// <summary>
    /// Socket类型
    /// </summary>
    public enum SocketTypes
    {
        /// <summary>
        /// Socket
        /// </summary>
        Socket = 0,
        /// WebSocket
        WebSocket = 1
    }
    #endregion

    #region Socket状态
    /// <summary>
    /// Socket状态
    /// </summary>
    public enum SocketState
    {
        /// <summary>
        /// 空闲
        /// </summary>
        Idle = 0,
        /// <summary>
        /// 运行中
        /// </summary>
        Runing = 1,
        /// <summary>
        /// 停止
        /// </summary>
        Stop = 2
    }
    #endregion
}