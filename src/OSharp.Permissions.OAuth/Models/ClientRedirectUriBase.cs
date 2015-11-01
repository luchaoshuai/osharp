﻿// -----------------------------------------------------------------------
//  <copyright file="ClientRedirectUriBase.cs" company="OSharp开源团队">
//      Copyright (c) 2014-2015 OSharp. All rights reserved.
//  </copyright>
//  <site>http://www.osharp.org</site>
//  <last-editor>郭明锋</last-editor>
//  <last-date>2015-10-31 16:59</last-date>
// -----------------------------------------------------------------------

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using OSharp.Core.Data;


namespace OSharp.Core.Security.Models
{
    /// <summary>
    /// 客户端重定向地址信息基类
    /// </summary>
    /// <typeparam name="TKey">主键类型</typeparam>
    /// <typeparam name="TClient">客户端信息类型</typeparam>
    /// <typeparam name="TClientKey">客户端主键类型</typeparam>
    public abstract class ClientRedirectUriBase<TKey, TClient, TClientKey> : EntityBase<TKey>, IClientRedirectUri<TKey>
        where TClient : IClient<TClientKey>
    {
        /// <summary>
        /// 获取或设置 重定向地址
        /// </summary>
        public string Url { get; set; }

        /// <summary>
        /// 获取或设置 所属客户端信息
        /// </summary>
        public virtual TClient Client { get; set; }
    }
}