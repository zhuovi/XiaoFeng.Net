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
    /// <summary>
    /// 网络客户端接口
    /// </summary>
    public interface INetClient : ISocket
    {
        /// <summary>
        /// 订阅频道
        /// </summary>
        /// <param name="channel">频道</param>
        void Subscribe(string channel);
        /// <summary>
        /// 订阅频道
        /// </summary>
        /// <param name="channels">频道</param>
        void Subscribe(IEnumerable<string> channels);
        /// <summary>
        /// 取消订阅频道
        /// </summary>
        /// <param name="channel">频道</param>
        void UnSubscribe(string channel);
        /// <summary>
        /// 取消订阅频道
        /// </summary>
        /// <param name="channels">频道</param>
        void UnSubscribe(IEnumerable<string> channels);
    }
}